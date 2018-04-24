using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IWholesaleCustomerRepository
    {
        List<WholesaleCustomer> WholesaleCustomerList();
        WholesaleCustomer GetById(int Id);
        void Add(WholesaleCustomer NewWholesaleCustomer);
        void Update(WholesaleCustomer EditedWholesaleCustomer);
        void Delete(WholesaleCustomer WholesaleCustomerToDelete);
    }
}
