using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class WholesaleCustomerRepositoryEf : IWholesaleCustomerRepository
    {
        private readonly CustomerContext _DbContext;

        public WholesaleCustomerRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(WholesaleCustomer NewWholesaleCustomer)
        {
            
        }

        public void Delete(WholesaleCustomer WholesaleCustomerToDelete)
        {
            
        }

        public WholesaleCustomer GetById(int Id)
        {
            return _DbContext.WholesaleCustomers
                .Include(w => w.MyWholesaleOrders)
                .ThenInclude(w => w.WholesaleOrderDetails)
                .Include(w => w.RetailCustomers)
                .ThenInclude(w => w.MyRetailOrders)
                .ThenInclude(w => w.RetailOrderDetails)
                .Include(w => w.SalesAgent)
                .SingleOrDefault(w => w.Id == Id);
        }

        public void Update(WholesaleCustomer EditedWholesaleCustomer)
        {
            
        }

        public List<WholesaleCustomer> WholesaleCustomerList()
        {
            return _DbContext.WholesaleCustomers.ToList();
        }
    }
}
