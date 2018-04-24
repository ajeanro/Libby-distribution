using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IEquipmentRepository
    {
        List<Equipment> EquipmentList();
        Equipment GetById(int Id);
        void Add(Equipment NewEquipment);
        void Update(Equipment EditedEquipment);
        void Delete(Equipment EquipmentToDelete);
    }
}
