using SiparisTakip.Dal.Abstract.FaturaA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFFaturaRepository : IFaturaDal
    {
        SiparisTakipEntity ctx = new SiparisTakipEntity();

        public Fatura Getir(int id)
        {
           return ctx.Fatura.Where(x => x.FaturaID == id).FirstOrDefault();
        }

        public int Guncelle(Fatura nesne)
        {
            ctx.Fatura.Attach(nesne);
            return ctx.SaveChanges();
        }

        public int Kaydet(Fatura nesne)
        {
            ctx.Fatura.Add(nesne);
            return ctx.SaveChanges();
        }

        public List<Fatura> ListeGetir()
        {
           return ctx.Fatura.ToList();
        }

        public Fatura Sil(Fatura nesne)
        {
           return ctx.Fatura.Remove(nesne);
        }
    }
}
