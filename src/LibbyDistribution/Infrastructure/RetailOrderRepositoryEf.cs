using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class RetailOrderRepositoryEf : IRetailOrderRepository
    {
        private readonly CustomerContext _DbContext;

        public RetailOrderRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(RetailOrder NewRetailOrder)
        {
            
        }

        public void Delete(RetailOrder RetailOrderToDelete)
        {
            
        }

        public IEnumerable<RetailOrder> GetByDriver(Driver driver)
        {
            return _DbContext.RetailOrders.Where(r => r.DriverId == driver.Id);
        }

        public RetailOrder GetById(int Id)
        {
            return _DbContext.RetailOrders
                .Include(r => r.RetailOrderDetails)
                .Include(r => r.Driver)
                .Include(r => r.RetailCustomer)
                .ThenInclude(r => r.SalesAgent)
                .SingleOrDefault(r => r.Id == Id);
        }

        public IEnumerable<RetailOrder> GetByRetailCustomer(RetailCustomer retailCustomer)
        {
            return _DbContext.RetailOrders.Where(r => r.RetailCustomerId == retailCustomer.Id);
        }

        public IEnumerable<RetailOrder> GetBySalesAgent(SalesAgent salesAgent)
        {
            return _DbContext.RetailOrders.Where(r => r.SalesAgentId == salesAgent.Id);
        }

        public List<RetailOrder> RetailOrderList()
        {
            return _DbContext.RetailOrders.ToList();
        }

        public void Update(RetailOrder EditedRetailOrder)
        {
            
        }
    }
}
