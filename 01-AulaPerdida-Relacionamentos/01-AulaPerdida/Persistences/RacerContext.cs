using _01_AulaPerdida.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AulaPerdida.Persistences
{
    public class RacerContext : DbContext
{

        public DbSet<Corrida> Corridas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        

            base.OnModelCreating(modelBuilder);
        }


        public RacerContext(DbContextOptions op): base(op)
        {

        }

}
}
