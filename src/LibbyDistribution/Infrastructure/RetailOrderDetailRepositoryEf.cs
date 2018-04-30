using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class RetailOrderDetailRepositoryEf : IRetailOrderDetailRepository
    {
        private readonly CustomerContext _DbContext;

        public RetailOrderDetailRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(RetailOrderDetail NewRetailOrderDetail)
        {
            
        }

        public void Delete(RetailOrderDetail RetailOrderDetailToDelete)
        {
            
        }

        public RetailOrderDetail GetById(int Id)
        {
            return _DbContext.RetailOrderDetails.SingleOrDefault(r => r.Id == Id);
        }

        public List<RetailOrderDetail> RetailOrderDetailList()
        {
            return _DbContext.RetailOrderDetails.ToList();
        }

        public void Update(RetailOrderDetail EditedRetailOrderDetail)
        {
            
        }
    }
}
