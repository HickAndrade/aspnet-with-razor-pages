using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using theRealMVC.Models;
using theRealMVC.Persistences;

namespace theRealMVC.Repositories
{
    public class PresidiarioRepository : IPresidiarioRepository
    {
        private banguContext _context;


        public PresidiarioRepository(banguContext context)
        {
            _context = context;
        }

        public void Atualizar(Presidiario presidiario)
        {
            _context.Presidiarios.Update(presidiario);
        }

        public void Criar(Presidiario presidiario)
        {
            _context.Presidiarios.Add(presidiario);
        }

        public void Deletar(int id)
        {
            var presidiario = _context.Presidiarios.Find(id);
            _context.Presidiarios.Remove(presidiario);
        }

        public IList<Presidiario> FindBy(Expression<Func<Presidiario, bool>> retorno)
        {

            return _context.Presidiarios.Where(retorno).ToList();
        }


        public Presidiario findById(int id)
        {
            return _context.Presidiarios.Find(id);

        }

        public IList<Presidiario> Listar()
        {
            return _context.Presidiarios.ToList();
        }

        public void Salvar() {
             _context.SaveChanges();
        }
    }
}
