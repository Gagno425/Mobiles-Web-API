using Microsoft.EntityFrameworkCore;
using Mobile.Domain;
using Mobile.Domain.Models;
using Mobile.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Services.Implementations
{
    public class MobileService : IMobileService
    {
        private readonly ApplicationDbContext _context;

        public MobileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddMobile(Phone mobile)
        {
            _context.Mobiles.Add(mobile);
            _context.SaveChanges();
        }

        public Phone GetMobileById(int Id)
        {
            return GetMobiles().SingleOrDefault(m => m.Id == Id);
        }

        public IQueryable<Phone> GetMobiles()
        {
            return _context.Mobiles
                            .Include(m => m.Manufacturer);
        }

        public void RemoveMobileById(int Id)
        {
            _context.Mobiles.Remove(_context.Mobiles.SingleOrDefault(m => m.Id == Id));
            _context.SaveChanges();
        }

        public void UpdateMobile(Phone mobile)
        {
            _context.Mobiles.Update(mobile);
            _context.SaveChanges();
        }
    }
}
