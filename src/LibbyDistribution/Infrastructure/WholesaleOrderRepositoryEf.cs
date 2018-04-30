using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class WholesaleOrderRepositoryEf : IWholesaleOrderRepository
    {
        private readonly CustomerContext _DbContext;

        public WholesaleOrderRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(WholesaleOrder NewWholesaleOrder)
        {
            
        }

        public void Delete(WholesaleOrder WholesaleOrderToDelete)
        {
            
        }

        public WholesaleOrder GetById(int Id)
        {
            return _DbContext.WholesaleOrders
                .Include(w => w.WholesaleOrderDetails)
                .Include(w => w.WholesaleCustomer)
                .ThenInclude(w => w.SalesAgent)
                .SingleOrDefault(w => w.Id == Id);
        }

        public IEnumerable<WholesaleOrder> GetBySalesAgent(SalesAgent salesAgent)
        {
            return _DbContext.WholesaleOrders.Where(w => w.SalesAgentId == salesAgent.Id);
        }

        public IEnumerable<WholesaleOrder> GetByWholesaleCustomer(WholesaleCustomer wholesaleCustomer)
        {
            return _DbContext.WholesaleOrders.Where(w => w.WholesaleCustomerId == wholesaleCustomer.Id);
        }

        public void Update(WholesaleOrder EditedWholesaleOrder)
        {
            
        }

        public List<WholesaleOrder> WholesaleOrderList()
        {
            return _DbContext.WholesaleOrders.ToList();
        }
    }
}
