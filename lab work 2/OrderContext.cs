using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.Entity;

namespace lab2
{
    public class OrdersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Services> Services { get; set; }
    }
}
