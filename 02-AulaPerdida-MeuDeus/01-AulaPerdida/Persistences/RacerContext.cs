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
        public DbSet<Medalha> Medalhas { get; set; }
        public DbSet<Corrida> Corridas { get; set; }
        public DbSet <Atleta> Atletas { get; set; }
        public DbSet<Trajeto> Trajeto { get; set; }
        public DbSet<CorridaAtleta> CorridaAtletas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CorridaAtleta>().HasKey(c => new { c.AtletaId, c.CorridaId});

            modelBuilder.Entity<CorridaAtleta>().
                HasOne(c => c.Corrida).
                WithMany(c => c.CorridaAtletas)
                .HasForeignKey(c => c.CorridaId);

            modelBuilder.Entity<CorridaAtleta>().
                HasOne(c => c.Atleta).
                WithMany(c => c.CorridaAtletas).
                HasForeignKey(c => c.AtletaId);
               


            base.OnModelCreating(modelBuilder);
        }

        public RacerContext(DbContextOptions op): base(op)
        {

        }

}
}
