using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract
{
    public interface IRepositoryDal<T>
    {

        T Getir(int id);

        List<T> ListeGetir();

        int Kaydet(T nesne);

        bool Guncelle(T nesne);

        T Sil(T nesne);
    }
}

