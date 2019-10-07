using ExercicioFiapGames.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioFiapGames.Persistences

{
    public class GamesContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }


        public GamesContext(DbContextOptions op): base(op)
        {

        }


    }
}
