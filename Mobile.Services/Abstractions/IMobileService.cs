using Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Services.Abstractions
{
    public interface IMobileService
    {
        IQueryable<Phone> GetMobiles();

        Phone GetMobileById(int Id);

        void UpdateMobile(Phone mobile);

        void RemoveMobileById(int Id);

        void AddMobile(Phone mobile);
    }
}
