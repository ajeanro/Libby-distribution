using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IDriverRepository
    {
        List<Driver> DriverList();
        Driver GetById(int Id);
        void Add(Driver NewDriver);
        void Update(Driver EditedDriver);
        void Delete(Driver DriverToDelete);
    }
}
