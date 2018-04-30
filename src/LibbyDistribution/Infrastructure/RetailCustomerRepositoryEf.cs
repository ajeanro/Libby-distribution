using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class RetailCustomerRepositoryEf : IRetailCustomerRepository
    {
        private readonly CustomerContext _DbContext;

        public RetailCustomerRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(RetailCustomer NewRetailCustomer)
        {
            
        }

        public void Delete(RetailCustomer RetailCustomerToDelete)
        {
            
        }

        public RetailCustomer GetById(int Id)
        {
            return _DbContext.RetailCustomers
                .Include(r => r.Equipment)
                .Include(r => r.Driver)
                .Include(r => r.SalesAgent)
                .Include(r => r.MyRetailOrders)
                .ThenInclude(r => r.RetailOrderDetails)
                .SingleOrDefault(r => r.Id == Id);
        }

        public List<RetailCustomer> RetailCustomerList()
        {
            return _DbContext.RetailCustomers.ToList();
        }

        public void Update(RetailCustomer EditedRetailCustomer)
        {
            
        }
    }
}
