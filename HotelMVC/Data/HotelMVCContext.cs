using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelMVC.Models;

namespace HotelMVC.Data
{
    public class HotelMVCContext : DbContext
    {
        public HotelMVCContext (DbContextOptions<HotelMVCContext> options)
            : base(options)
        {
        }

        public DbSet<HotelMVC.Models.Hotel> Hotel { get; set; }
    }
}
