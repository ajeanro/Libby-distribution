using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IRetailOrderRepository
    {
        List<RetailOrder> RetailOrderList();
        RetailOrder GetById(int Id);
        void Add(RetailOrder NewRetailOrder);
        void Update(RetailOrder EditedRetailOrder);
        void Delete(RetailOrder RetailOrderToDelete);
        IEnumerable<RetailOrder> GetByRetailCustomer(RetailCustomer retailCustomer);
        IEnumerable<RetailOrder> GetByDriver(Driver driver);
        IEnumerable<RetailOrder> GetBySalesAgent(SalesAgent salesAgent);
    }
}
