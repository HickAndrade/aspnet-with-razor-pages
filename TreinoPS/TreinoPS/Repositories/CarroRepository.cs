using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TreinoPS.Models;
using TreinoPS.Persistences;

namespace TreinoPS.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private CarContext _context;

        public CarroRepository(CarContext context)
        {
            _context = context;
        }

        public void Atualizar(Carro carro)
        {
            _context.Carros.Update(carro);
        }

        public void Criar(Carro carro)
        {
            _context.Carros.Add(carro);
        }

        public void Deletar(int id)
        {
            var carro = _context.Carros.Find(id);
            _context.Carros.Remove(carro);
        }

        public IList<Carro> findBy(Expression<Func<Carro, bool>> filtro)
        {
            return _context.Carros.Where(filtro).ToList();
        }

        public Carro findById(int id)
        {
            return _context.Carros.Find(id);
        }

        public IList<Carro> listar()
        {
            return _context.Carros.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
