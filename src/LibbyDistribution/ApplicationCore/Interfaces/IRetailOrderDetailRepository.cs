using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IRetailOrderDetailRepository
    {
        List<RetailOrderDetail> RetailOrderDetailList();
        RetailOrderDetail GetById(int Id);
        void Add(RetailOrderDetail NewRetailOrderDetail);
        void Update(RetailOrderDetail EditedRetailOrderDetail);
        void Delete(RetailOrderDetail RetailOrderDetailToDelete);
    }
}
