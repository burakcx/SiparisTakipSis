using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface IGenericService<T>
    {
        T Getir(int id);

        List<T> ListeGetir();

        int Kaydet(T nesne);

        int Guncelle(T nesne);

        T Sil(T nesne);

    }
}
