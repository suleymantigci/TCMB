using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCMB.Entities;
using TCMB.Service;

namespace TCMB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Currency> currencyService = new CurrencyService().GetCurrencies();
            return View(currencyService);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
