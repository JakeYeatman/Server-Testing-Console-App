using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RDSWebAPI.Models;

namespace ServerTesterApplication.ExternalAPIConnections
{
    public class CazanaValuation
    {
        private const string _KEY = "5ab3cc97a8d11a00017332a7852539f8365d470ca14b116b5cdc57a3";

        public static async void GetCarValuation(string numberPlate)
        {
            using (var client = new HttpClient())
            {
                string url = String.Empty;
                CarValution model = new CarValution();
                model.RegPlate = numberPlate;
                url = String.Format(@"https://api.cazana.com/vehicle/{0}/valuation?key={1}", numberPlate, _KEY);
                model.MileageEstimate = true;
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string res = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(res);                        
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }

            }
        }
    }
}
