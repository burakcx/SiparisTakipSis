using SiparisTakip.Entity.Models;
using System.Collections.Generic;

namespace SiparisTakip.Dal.Abstract.Product
{
    public interface IProductDal
    {
        Products Kaydet(Products nesne);

        List<Products> Listele();

        Products Getir(int id);

        int Guncelle(Products nesne);

        bool Sil(int id);

        bool Sil(Products nesne);


    }
}
