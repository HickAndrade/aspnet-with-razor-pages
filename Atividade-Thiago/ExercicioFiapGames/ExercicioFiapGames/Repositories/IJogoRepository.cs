using ExercicioFiapGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExercicioFiapGames.Repositories
{
    public interface IJogoRepository
    {
        void Criar(Jogo jogo);
           IList<Jogo> Listar();

        void Atualizar(Jogo jogo);

        void Deletar(int id);

        void Salvar();
        Jogo procurarPorId(int id);
        IList<Jogo> ListarPor(Expression<Func<Jogo, bool>> funcao);
    }
}
