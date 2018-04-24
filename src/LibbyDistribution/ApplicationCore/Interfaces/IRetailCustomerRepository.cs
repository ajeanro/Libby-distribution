using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IRetailCustomerRepository
    {
        List<RetailCustomer> RetailCustomerList();
        RetailCustomer GetById(int Id);
        void Add(RetailCustomer NewRetailCustomer);
        void Update(RetailCustomer EditedRetailCustomer);
        void Delete(RetailCustomer RetailCustomerToDelete);
    }
}
