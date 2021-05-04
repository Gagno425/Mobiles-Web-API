using Mobile.Domain;
using Mobile.Domain.Models;
using Mobile.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Services.Implementations
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly ApplicationDbContext _context;

        public ManufacturerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Manufacturer GetManufacturerById(int Id)
        {
            return _context.Manufacturers.SingleOrDefault(m => m.Id == Id);
        }

        public IQueryable<Manufacturer> GetManufacturers()
        {
            return _context.Manufacturers;
        }
    }
}
