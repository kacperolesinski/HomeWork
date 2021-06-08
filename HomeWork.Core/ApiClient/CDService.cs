using HomeWork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork.Core.ApiClient
{
    public class CDService : ICDService
    {
        public static HttpClient ApiClient { get; set; }
        public CDService()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Clear();
        }

        public IEnumerable<CD> GetCDs()
        {
            return GetCDsAsync().Result;
        }

        public async Task<IEnumerable<CD>> GetCDsAsync()
        {
            using (HttpResponseMessage response = ApiClient.GetAsync("https://localhost:44328/api/Catalog").Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    IEnumerable<CD> result = XDocument.Parse(content).Descendants("CD").Select(o =>
                                             new CD()
                                             {
                                                 Title = o.Element("Title").Value.ToString(),
                                                 Artist = o.Element("Artist").Value.ToString(),
                                                 Country = o.Element("Country").Value.ToString(),
                                                 Company = o.Element("Company").Value.ToString(),
                                                 Price = (decimal)o.Element("Price"),
                                                 Year = (int)o.Element("Year")
                                             });
                    return result;
                }
                else
                    throw new Exception($"{response.StatusCode} ({response.ReasonPhrase})");
            }
        }
    }
}
