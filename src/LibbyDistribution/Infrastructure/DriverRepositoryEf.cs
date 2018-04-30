using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class DriverRepositoryEf : IDriverRepository
    {
        private readonly CustomerContext _DbContext;

        public DriverRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Driver NewDriver)
        {
            _DbContext.Add(NewDriver);

            _DbContext.SaveChanges();
        }

        public void Delete(Driver DriverToDelete)
        {
           
        }

        public List<Driver> DriverList()
        {
            return _DbContext.Drivers.ToList();
        }

        public Driver GetById(int Id)
        {
            return _DbContext.Drivers
                .Include(d => d.DriverRetailCustomers)
                .ThenInclude(d => d.MyRetailOrders)
                .ThenInclude(d => d.RetailOrderDetails)
                .FirstOrDefault(d => d.Id == Id);
        }

        public void Update(Driver EditedDriver)
        {
            
        }
    }
}
