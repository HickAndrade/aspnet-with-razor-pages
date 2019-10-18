using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TreinoPS.Models;

namespace TreinoPS.Repositories
{
    interface IClienteRepository
    {
        void Criar(Cliente cliente);
        IList<Cliente> Listar();
        void Atualizar(Cliente cliente);

        void Deletar(int id);
        Cliente findById(int id);

        void Salvar();
        IList<Cliente> findBy(Expression<Func<Cliente,bool>>filtro);

    }
}
