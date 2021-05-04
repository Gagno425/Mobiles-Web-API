using Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Services.Abstractions
{
    public interface IManufacturerService
    {
        IQueryable<Manufacturer> GetManufacturers();

        Manufacturer GetManufacturerById(int Id);
    }
}
