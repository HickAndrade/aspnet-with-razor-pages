using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExercicioFiapGames.Models;
using ExercicioFiapGames.Persistences;

namespace ExercicioFiapGames.Repositories
{
    public class JogoRepository : IJogoRepository
    {

        private GamesContext _context;


        public JogoRepository(GamesContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
          
        }

        public void Criar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public void Deletar(int id)
        {
            var jogo =_context.Jogos.Find(id);
            _context.Jogos.Remove(jogo);
        }

        public IList<Jogo> Listar()
        {
            return _context.Jogos.ToList();
        }

        public IList<Jogo> ListarPor(Expression<Func<Jogo, bool>> funcao)
        {
            return _context.Jogos.Where(funcao).ToList();
        }

        public Jogo procurarPorId(int id)
        {
            return _context.Jogos.Find(id);

        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
