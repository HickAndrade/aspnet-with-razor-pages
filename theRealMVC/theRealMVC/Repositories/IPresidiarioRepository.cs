using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using theRealMVC.Models;

namespace theRealMVC.Repositories
{
    public interface IPresidiarioRepository
    {
        void Criar(Presidiario presidiario);
   
        void Atualizar(Presidiario presidiario);

        void Deletar(int id);
        Presidiario findById(int id);

        IList<Presidiario> Listar();
        IList<Presidiario> FindBy(Expression<Func<Presidiario,bool>>retorno);
    }
}
