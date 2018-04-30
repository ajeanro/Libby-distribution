using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class EquipmentIssueRepositoryEf : IEquipmentIssueRepository
    {
        private readonly CustomerContext _DbContext;

        public EquipmentIssueRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(EquipmentIssue NewEquipmentIssue)
        {
            
        }

        public void Delete(EquipmentIssue EquipmentIssueToDelete)
        {
           
        }

        public List<EquipmentIssue> EquipmentIssueList()
        {
            return _DbContext.EquipmentIssues.ToList();
        }

        public EquipmentIssue GetById(int Id)
        {
            return _DbContext.EquipmentIssues.SingleOrDefault(e => e.Id == Id);
        }

        public void Update(EquipmentIssue EditedEquipmentIssue)
        {
            
        }
    }
}
