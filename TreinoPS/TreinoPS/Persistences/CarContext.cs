using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoPS.Models;

namespace TreinoPS.Persistences
{
    public class CarContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public CarContext(DbContextOptions op) : base(op)
        {

        }

    }
}
