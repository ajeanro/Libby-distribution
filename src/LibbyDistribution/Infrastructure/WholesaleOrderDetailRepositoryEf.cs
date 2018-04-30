using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class WholesaleOrderDetailRepositoryEf : IWholesaleOrderDetailRepository
    {
        private readonly CustomerContext _DbContext;

        public WholesaleOrderDetailRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(WholesaleOrderDetail NewWholesaleOrderDetail)
        {
            
        }

        public void Delete(WholesaleOrderDetail WholesaleOrderDetailToDelete)
        {
            
        }

        public WholesaleOrderDetail GetById(int Id)
        {
            return _DbContext.WholesaleOrderDetails.SingleOrDefault(w => w.Id == Id);
        }

        public void Update(WholesaleOrderDetail EditedWholesaleOrderDetail)
        {
            
        }

        public List<WholesaleOrderDetail> WholesaleOrderDetailList()
        {
            return _DbContext.WholesaleOrderDetails.ToList();
        }
    }
}
