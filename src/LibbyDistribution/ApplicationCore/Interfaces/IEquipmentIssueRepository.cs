using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IEquipmentIssueRepository
    {
        List<EquipmentIssue> EquipmentIssueList();
        EquipmentIssue GetById(int Id);
        void Add(EquipmentIssue NewEquipmentIssue);
        void Update(EquipmentIssue EditedEquipmentIssue);
        void Delete(EquipmentIssue EquipmentIssueToDelete);
    }
}
