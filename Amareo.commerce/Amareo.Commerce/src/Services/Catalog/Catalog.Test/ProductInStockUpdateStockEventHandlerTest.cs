using Catalog.Domain;
using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using Catalog.Test.Config;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static Common.Enums;

namespace Catalog.Test
{
    [TestClass]
    public class ProductInStockUpdateStockEventHandlerTest
    {
        private ILogger<ProductInStockUpdateStockEventHandler> GetLogger
        {
            get { return new Mock<ILogger<ProductInStockUpdateStockEventHandler>>().Object; }
        }

        [TestMethod]
        public void TryToSubstractStockWhenProductHasStock()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 1;
            var productId = 1;

            context.Stock.Add(new ProductInStock
            {
                ProductId = productId,
                ProductInStockId = productInStockId,
                Stock = 1
            } );

            context.SaveChanges();

            var handler = new ProductInStockUpdateStockEventHandler(context,GetLogger);
            handler.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() { 
                    new ProductInStockUpdateItem
                    {
                        ProductId=productId,
                        Stock =1,
                        Action = ProductInStockAction.Substract
                    }
                },

            }, new CancellationToken()).Wait();
        }

        [TestMethod]
        [ExpectedException(typeof(ProductInStockUpdateStockCommandException))]
        public void TryToSubstractStockWhenProductHasntStock()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 2;
            var productId = 2;

            context.Stock.Add(new ProductInStock
            {
                ProductId = productId,
                ProductInStockId = productInStockId,
                Stock = 1
            });

            context.SaveChanges();

            var handler = new ProductInStockUpdateStockEventHandler(context, GetLogger);
            try
            {
                handler.Handle(new ProductInStockUpdateStockCommand
                {
                    Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem
                    {
                        ProductId=productId,
                        Stock =2,
                        Action = ProductInStockAction.Substract
                    }
                },

                }, new CancellationToken()).Wait();
            }
            catch (AggregateException ae)
            {
                var exception = ae.GetBaseException();
                if(exception is ProductInStockUpdateStockCommandException)
                {
                    throw new ProductInStockUpdateStockCommandException(exception?.InnerException?.Message
                        );
                }
            }
        }

        [TestMethod]
        public void TryToAddStockWhenProductExists()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productId = 3;

            

            var handler = new ProductInStockUpdateStockEventHandler(context, GetLogger);
            handler.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem
                    {
                        ProductId=productId,
                        Stock =3,
                        Action = ProductInStockAction.Add
                    }
                },

            }, new CancellationToken()).Wait();

            var stockInDb = context.Stock.Single(x => x.ProductId == productId).Stock;
            Assert.AreEqual(stockInDb, 3);
        }

        [TestMethod]
        public void TryToAddStockWhenProductNotExists()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productId = 4;



            var handler = new ProductInStockUpdateStockEventHandler(context, GetLogger);
            handler.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem
                    {
                        ProductId=productId,
                        Stock =2,
                        Action = ProductInStockAction.Add
                    }
                },

            }, new CancellationToken()).Wait();

            var stockInDb = context.Stock.Single(x => x.ProductId == productId).Stock;
            Assert.AreEqual(stockInDb, 2);
        }
    }
}
