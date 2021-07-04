using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCMB.Entities;

namespace TCMB.Service
{
    interface ICurrencyService
    {
        List<Currency> GetCurrencies();
    }
}
