using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface ISalesAgentRepository
    {
        List<SalesAgent> SalesAgentList();
        SalesAgent GetById(int Id);
        void Add(SalesAgent NewSalesAgent);
        void Update(SalesAgent EditedSalesAgent);
        void Delete(SalesAgent SalesAgentToDelete);
    }
}
