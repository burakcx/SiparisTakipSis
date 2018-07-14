using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.KullaniciA
{
    public interface IKullaniciDal
    {
        Kullanici Getir(int id);

        List<Kullanici> ListeGetir();

        int Kaydet(Kullanici nesne);

        int Guncelle(Kullanici nesne);

        Kullanici Sil(Kullanici nesne);
    }
}
