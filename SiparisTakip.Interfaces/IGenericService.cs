using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface IGenericService<T> where T : class
    {       

        T Getir(int id);

        List<T> ListeGetir();

        int Kaydet(T nesne);

        bool Guncelle(T nesne);

        T Sil(T nesne);
    }
}
