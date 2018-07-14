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


        public List<Stok> EkstraMetod()
        {
            throw new NotImplementedException();
        }

        public Stok Getir(int id)
        {
            throw new NotImplementedException();
        }

       

        public int Guncelle(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public int Kaydet(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public List<Stok> ListeGetir()
        {
            throw new NotImplementedException();
        }

        public Stok Sil(Stok nesne)
        {
            throw new NotImplementedException();
        }
    }
}
