using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theRealMVC.Models;

namespace theRealMVC.Persistences
{
    public class banguContext : DbContext
    {

        public DbSet<Presidiario> Presidiarios { get; set; }
        public DbSet<Cela> Celas { get; set; }



        public banguContext(DbContextOptions op): base(op)
        {

        }
    }
}
