using SiparisTakip.Dal.Abstract.StokA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFStokRepository : GenericRepository<SiparisTakipEntity, Stok>, IStokDal
    {       
        
    }
}
