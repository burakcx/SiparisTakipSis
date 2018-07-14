using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.StokA
{
    public interface IStokDal
    {
        Stok Getir(int id);

        List<Stok> ListeGetir();

        Stok Kaydet(Stok nesne);

        Stok Guncelle(Stok nesne);

        bool Sil(int id);

    }
}
