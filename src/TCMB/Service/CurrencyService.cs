using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using TCMB.Dao;
using TCMB.Entities;

namespace TCMB.Service
{
    public class CurrencyService : ICurrencyService
    {
        public CurrencyRepository currencyRepository;
        public CurrencyService()
        {
            currencyRepository = new CurrencyRepository();
        }

        public List<Currency> GetCurrencies()
        {
            List<Currency> currencies = currencyRepository.GetCurrencies();
            currencies.RemoveAll(t => t.CurrencyCode != "USD" && t.CurrencyCode != "EUR" && t.CurrencyCode != "GBP");
            return currencies;
        }
    }
}
