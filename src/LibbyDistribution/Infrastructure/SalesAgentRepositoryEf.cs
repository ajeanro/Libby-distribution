using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class SalesAgentRepositoryEf : ISalesAgentRepository
    {
        private readonly CustomerContext _DbContext;

        public SalesAgentRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(SalesAgent NewSalesAgent)
        {
            
        }

        public void Delete(SalesAgent SalesAgentToDelete)
        {
            
        }

        public SalesAgent GetById(int Id)
        {
            return _DbContext.SalesAgents
                .Include(s => s.AgentRetailCustomers)
                .ThenInclude(s => s.MyRetailOrders)
                .ThenInclude(s => s.RetailOrderDetails)
                .Include(s => s.AgentWholesaleCustomers)
                .ThenInclude(s => s.MyWholesaleOrders)
                .ThenInclude(s => s.WholesaleOrderDetails)
                .SingleOrDefault(s => s.Id == Id);
        }

        public List<SalesAgent> SalesAgentList()
        {
            return _DbContext.SalesAgents.ToList();
        }

        public void Update(SalesAgent EditedSalesAgent)
        {
            
        }
    }
}
