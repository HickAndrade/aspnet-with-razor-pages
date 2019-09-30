using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using theRealMVC.Models;

namespace theRealMVC.Repositories
{
    public interface ICelaRepository
    {
        void Criar(Cela cela);
        IList<Cela> Listar();
        void Atualizar(Cela cela);
        void Deletar(int id);

        Cela findById(int id);
        void Save();
        IList<Cela> findBy(Expression<Func<Cela,bool>> retorno);
    }
}
