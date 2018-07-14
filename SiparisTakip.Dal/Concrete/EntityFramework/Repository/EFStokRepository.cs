using SiparisTakip.Dal.Abstract.StokA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFStokRepository : IStokDal
    {
        public Stok Getir(int id)
        {
            throw new NotImplementedException();
        }

        public Stok Guncelle(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public Stok Kaydet(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public List<Stok> ListeGetir()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
