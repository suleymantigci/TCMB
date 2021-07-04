using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using System.Xml.Linq;
using TCMB.Entities;

namespace TCMB.Dao
{
    public class CurrencyRepository
    {
        public List<Currency> GetCurrencies()
        {
            List<Currency> currencies = new List<Currency>();
            var url = "https://www.tcmb.gov.tr/kurlar/today.xml";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xdoc = XDocument.Parse(response.Content.ReadAsStringAsync().Result);
                    currencies = xdoc.Descendants("Currency").Select(x =>
                    {
                        decimal zero = Decimal.Zero;
                        return new Currency()
                        {
                            Unit = (int) x.Element("Unit"),
                            CurrencyCode = (string) x.Attribute("CurrencyCode"),
                            Isim = (String) x.Element("Isim"),
                            CurrencyName = (String) x.Element("CurrencyName"),
                            ForexBuying = Decimal.TryParse((string) x.Element("ForexBuying"), out zero) ? (decimal)x.Element("ForexBuying") : zero,
                            ForexSelling = Decimal.TryParse((string) x.Element("ForexSelling"), out zero) ? (decimal)x.Element("ForexSelling") : zero,
                            BanknoteBuying = Decimal.TryParse((string) x.Element("BanknoteBuying"), out zero) ? (decimal)x.Element("BanknoteBuying") : zero,
                            BanknoteSelling = Decimal.TryParse((string) x.Element("BanknoteSelling"), out zero) ? (decimal)x.Element("BanknoteSelling") : zero,
                            CrossRateUSD = Decimal.TryParse((string) x.Element("CrossRateUSD"), out zero) ? (decimal)x.Element("CrossRateUSD") : zero,
                            CrossRateOther = Decimal.TryParse((string) x.Element("CrossRateOther"), out zero) ? (decimal)x.Element("CrossRateOther") : zero
                        };
                    }).ToList();
                }

            }
            return currencies;
        }
    }
}
