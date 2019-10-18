using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TreinoPS.Models;
using TreinoPS.Persistences;

namespace TreinoPS.Repositories
{
    public interface ICarroRepository
    {
        void Criar(Carro carro);
        IList<Carro> listar();
        void Atualizar(Carro carro);

        void Deletar(int id);

        Carro findById(int id);

        void Salvar();

        IList<Carro> findBy(Expression<Func<Carro,bool>> filtro);

    }
}
