﻿using Microsoft.EntityFrameworkCore;
using Order.Persistence.Database;
using Order.Service.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Order.Service.Queries
{

    public interface IOrderQueryService
    {
        Task<DataCollection<OrderDto>> GetAllAsync(int page, int take, IEnumerable<int> orders = null);
        Task<OrderDto> GetAsync(int id);
    }

    public class OrderQueryService: IOrderQueryService
    {
        private readonly ApplicationDbContext _context;

        public OrderQueryService (ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<DataCollection<OrderDto>> GetAllAsync(int page, int take, IEnumerable<int> orders = null)
        {
            var collection = await _context.Orders
                             .Include(x => x.Items)
                             .OrderByDescending(x => x.OrderId)
                             .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<OrderDto>>();
        }

        public async Task<OrderDto> GetAsync(int id)
        {
            return (await _context.Orders.Include(x => x.Items).SingleAsync(x => x.OrderId == id)).MapTo<OrderDto>();
        }
    }
}
