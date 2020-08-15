using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_1.Models
{
    public class DashboardDBContext:DbContext
    {
        public DashboardDBContext(DbContextOptions<DashboardDBContext> options):base(options)
        {

        }

        public DbSet<Beacon> Beacons { get; set; }
        public DbSet<Gateway> Gateways { get; set; }
    }
}
