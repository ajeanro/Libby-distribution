using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IWholesaleOrderDetailRepository
    {
        List<WholesaleOrderDetail> WholesaleOrderDetailList();
        WholesaleOrderDetail GetById(int Id);
        void Add(WholesaleOrderDetail NewWholesaleOrderDetail);
        void Update(WholesaleOrderDetail EditedWholesaleOrderDetail);
        void Delete(WholesaleOrderDetail WholesaleOrderDetailToDelete);
    }
}
