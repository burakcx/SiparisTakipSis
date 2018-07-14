using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces.FaturaIG
{
    public interface IFaturaService:IGenericService<Fatura>
    {
        int OrnekFaturaMetod();

    }
}
