using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCurrencyConversion.Models
{
    public class ConvertCurrency
    {
        //ISO 4217
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal CurrencyFromValue { get; set; }
        
    }

    public class ISO4217CurrencyCode
    {
        public string Codes { get; set; }
    }
}