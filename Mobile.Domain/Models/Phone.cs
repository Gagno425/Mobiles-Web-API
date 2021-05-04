using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Domain.Models
{
    public class Phone
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public decimal Price { get; set; }
    }
}
