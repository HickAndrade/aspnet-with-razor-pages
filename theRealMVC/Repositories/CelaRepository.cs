using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using theRealMVC.Models;
using theRealMVC.Persistences;

namespace theRealMVC.Repositories
{
    public class CelaRepository : ICelaRepository
    {

        private banguContext _context;

        public CelaRepository(banguContext context)
        {
            _context = context;
        }
       
        public void Atualizar(Cela cela)
        {
            _context.Celas.Update(cela);
        }

        public void Criar(Cela cela)
        {
            _context.Celas.Add(cela);
        }

        public void Deletar(int id)
        {
            var cela = _context.Celas.Find(id);
            _context.Celas.Remove(cela);
        }

        public IList<Cela> findBy(Expression<Func<Cela, bool>> retorno)
        {
            return _context.Celas.Where(retorno).ToList();
         }

        public Cela findById(int id)
        {
            return _context.Celas.Find(id);
        }

        public IList<Cela> Listar()
        {
            return _context.Celas.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
