using SiparisTakip.Dal.Abstract.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFProductRepository : IProductDal
    {
        public Products Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Products nesne)
        {
            throw new NotImplementedException();
        }

        public Products Kaydet(Products nesne)
        {
            throw new NotImplementedException();
        }

        public List<Products> Listele()
        {
            throw new NotImplementedException();
        }

        public bool Sil(Products nesne)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
