using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCMB.Entities
{
    public class Currency
    {
        private int _unit;
        private String _currencyCode;
        private String _isim;
        private String _currencyName;
        private decimal _forexBuying;
        private decimal _forexSelling;
        private decimal _banknoteBuying;
        private decimal _banknoteSelling;
        private decimal _crossRateUSD;
        private decimal _crossRateOther;


        public int Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public String CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        public string Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }

        public string CurrencyName
        {
            get { return _currencyName; }
            set { _currencyName = value; }
        }

        public decimal ForexBuying
        {
            get { return _forexBuying; }
            set { _forexBuying = value; }
        }

        public decimal ForexSelling
        {
            get { return _forexSelling; }
            set { _forexSelling = value; }
        }

        public decimal BanknoteBuying
        {
            get { return _banknoteBuying; }
            set { _banknoteBuying = value; }
        }

        public decimal BanknoteSelling
        {
            get { return _banknoteSelling; }
            set { _banknoteSelling = value; }
        }

        public decimal CrossRateUSD
        {
            get { return _crossRateUSD; }
            set { _crossRateUSD = value; }
        }

        public decimal CrossRateOther
        {
            get { return _crossRateOther; }
            set { _crossRateOther = value; }
        }
    }
}
