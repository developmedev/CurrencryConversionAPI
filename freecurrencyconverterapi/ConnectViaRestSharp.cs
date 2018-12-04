using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace freecurrencyconverterapi
{
     public class ConnectViaRestSharp
    {
        public static decimal Rate;
        public ConnectViaRestSharp()
        {

        }

        public decimal GetRate(string from,string to)
        {
            try
            {
                string currencyConvert = from + "_" + to;
                var client = new RestClient(@"https://free.currencyconverterapi.com/api/v6/convert?q="+currencyConvert+"&compact=y");
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);
                JObject jObject = JObject.Parse(response.Content);
                JObject value = (JObject)jObject[currencyConvert];
                var val = (decimal)value["val"];
                Rate = val;
                return Rate;
            }
            catch (Exception e)
            {
                return Rate;
            }
        }
        public decimal ConvertDollarToRand(string from, string to,decimal amount)
        {
            return Math.Round(amount * GetRate(from,to), 2);
        }
    }
}
