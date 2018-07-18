using SiparisTakip.Interfaces.StokIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Abstract.StokA;

namespace SiparisTakip.BLL.StokBLL
{
    public class StokManager : IStokService
    {
        IStokDal _IStokDal;

        public StokManager(IStokDal IStokDal)
        {
            _IStokDal = IStokDal;
        }

        public Stok Getir(int id)
        {
            var data = _IStokDal.Getir(id);
            return data;
        }

        public bool Guncelle(Stok nesne)
        {
            var data = _IStokDal.Guncelle(nesne);
            return data;
        }

        public int Kaydet(Stok nesne)
        {
            var data = _IStokDal.Kaydet(nesne);
            return data;
        }

        public List<Stok> ListeGetir()
        {
            return _IStokDal.ListeGetir();

        }

        public Stok Sil(Stok nesne)
        {
            var data = _IStokDal.Sil(nesne);
            return data;
        }

        public List<Stok> EkstraMetod()
        {
            throw new NotImplementedException();
        }
    }
}
