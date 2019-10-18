using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TreinoPS.Models;
using TreinoPS.Persistences;

namespace TreinoPS.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private CarContext _context;
        public ClienteRepository(CarContext context)
        {
            _context = context;
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public void Criar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Deletar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            _context.Clientes.Remove(cliente);
        }

        public IList<Cliente> findBy(Expression<Func<Cliente, bool>> filtro)
        {
            return _context.Clientes.Where(filtro).ToList();
        }

        public Cliente findById(int id)
        {
            var cliente = _context.Clientes.Find(id);
            return cliente;
        }

        public IList<Cliente> Listar()
        {

            return _context.Clientes.ToList();

        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
