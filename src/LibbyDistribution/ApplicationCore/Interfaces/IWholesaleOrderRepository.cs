using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IWholesaleOrderRepository
    {
        List<WholesaleOrder> WholesaleOrderList();
        WholesaleOrder GetById(int Id);
        void Add(WholesaleOrder NewWholesaleOrder);
        void Update(WholesaleOrder EditedWholesaleOrder);
        void Delete(WholesaleOrder WholesaleOrderToDelete);
        IEnumerable<WholesaleOrder> GetByWholesaleCustomer(WholesaleCustomer wholesaleCustomer);
        IEnumerable<WholesaleOrder> GetBySalesAgent(SalesAgent salesAgent);
    }
}
