using SiparisTakip.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class GenericRepository<CContext, T> : IRepositoryDal<T> where CContext : DbContext, new() where T : class
    {
        private CContext _context = new CContext();

        public CContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public T Getir(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Guncelle(T nesne)
        {            
            _context.Entry(nesne).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public int Kaydet(T nesne)
        {
            var result = _context.Set<T>().Add(nesne);
            return _context.SaveChanges();
        }

        public List<T> ListeGetir()
        {
            return _context.Set<T>().ToList();
        }

        public T Sil(T nesne)
        {
            return _context.Set<T>().Remove(nesne);
             
        }
    }
}
