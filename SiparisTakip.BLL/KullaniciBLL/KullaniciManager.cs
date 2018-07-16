using SiparisTakip.Interfaces.KullaniciIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Abstract.KullaniciA;

namespace SiparisTakip.BLL.KullaniciBLL
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _IKullaniciDal;//

        public KullaniciManager(IKullaniciDal IKullaniciDal)
        {
            _IKullaniciDal = IKullaniciDal;
        }

        public Kullanici Getir(int id)
        {
            var data = _IKullaniciDal.Getir(id);
            return data;
        }

        public int Guncelle(Kullanici nesne)
        {
            var data = _IKullaniciDal.Guncelle(nesne);
            return data;
        }

        public int Kaydet(Kullanici nesne)
        {
            var data = _IKullaniciDal.Kaydet(nesne);
            return data;
        }

        public List<Kullanici> ListeGetir()
        {
            return _IKullaniciDal.ListeGetir();

        }

        public Kullanici Sil(Kullanici nesne)
        {
            var data = _IKullaniciDal.Sil(nesne);
            return data;
        }

        public List<Kullanici> EkstraMetod()
        {
            throw new NotImplementedException();
        }
    }
}
