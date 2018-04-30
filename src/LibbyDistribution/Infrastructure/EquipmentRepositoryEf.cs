using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class EquipmentRepositoryEf : IEquipmentRepository
    {
        private readonly CustomerContext _DbContext;

        public EquipmentRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Equipment NewEquipment)
        {
            
        }

        public void Delete(Equipment EquipmentToDelete)
        {
            
        }

        public List<Equipment> EquipmentList()
        {
            return _DbContext.Equipments.ToList();
        }

        public Equipment GetById(int Id)
        {
            return _DbContext.Equipments
                .Include(e => e.EquipmentIssues)
                .FirstOrDefault(e => e.Id == Id);
        }

        public void Update(Equipment EditedEquipment)
        {
            
        }
    }
}
