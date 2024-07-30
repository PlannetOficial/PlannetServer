using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlannetServer.Core.Aggregates;

namespace PlannetServer.Core.Repositories
{
    public interface IOrdersRepository
    {
        Task<Order> GetAsync(Guid id);
        Task<IEnumerable<Order>> BrowseAsync();        
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
    }
}
