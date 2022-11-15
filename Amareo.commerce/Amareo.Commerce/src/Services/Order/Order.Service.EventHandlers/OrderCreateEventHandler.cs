﻿using MediatR;
using Microsoft.Extensions.Logging;
using Order.Domain;
using Order.Persistence.Database;
using Order.Service.EventHandlers.Commands;
using Order.Service.Proxies.Catalog;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Order.Service.EventHandlers
{
    public class OrderCreateEventHandler : INotificationHandler<OrderCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<OrderCreateEventHandler> _logger;
        private readonly ICatalogProxy _catalogProxy;

        public OrderCreateEventHandler(ApplicationDbContext context, ILogger<OrderCreateEventHandler> logger, ICatalogProxy catalogProxy)
        {
            _context = context;
            _logger = logger;
            _catalogProxy = catalogProxy;
        }
        public async Task Handle(OrderCreateCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- New Order creation started");
            var entry = new Domain.Order();

            using (var trx = await _context.Database.BeginTransactionAsync())
            {
                //01. Prepare detail
                _logger.LogInformation(" --- Preparing detail");
                PrepareDetail(entry, notification);

                //02.Prepare header
                _logger.LogInformation(" --- Preparing header");
                PrepareHeader(entry, notification);

                //03. Create order
                _logger.LogInformation(" --- Creating order");
                await _context.AddAsync(entry);
                await _context.SaveChangesAsync();

                //04. Update Stocks
                try {
                    await _catalogProxy.UpdateStockAsync(new ProductInStockUpdateStockCommand
                    {
                        Items = notification.Items.Select(x => new ProductInStockUpdateItem
                        {
                            Action = ProductInStockAction.Substract,
                            ProductId = x.ProductId,
                            Stock = x.Quantity
                        })
                    });
                    _logger.LogInformation($"--- Order {entry.OrderId} was created");
                }
                catch(Exception e)
                {
                    _logger.LogInformation($"--- Order couldn't be created");
                    throw new Exception();
                }
             



                //04. Update Stocks
                _logger.LogInformation("--- Updating stock");

                // Lógica para actualizar el Stock
                await trx.CommitAsync();
            }
        }

        private void PrepareDetail(Domain.Order entry, OrderCreateCommand notification) { 
                
                entry.Items = notification.Items.Select(x => new OrderDetail
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    UnitPrice = x.Price,
                    Total = x.Price * x.Quantity
                }).ToList();
        }

        private void PrepareHeader(Domain.Order entry, OrderCreateCommand notification)
        {

            entry.Status = Common.Enums.OrderStatus.Pending;
            entry.PaymentType = notification.PaymentType;
            entry.ClientId = notification.ClientId;
            entry.CreatedAt = DateTime.UtcNow;

            //sum
            entry.Total = entry.Items.Sum(x => x.Total);
        }
    }
}
