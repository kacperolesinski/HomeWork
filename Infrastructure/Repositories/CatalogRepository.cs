using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private static IEnumerable<Catalog> _catalogs = new List<Catalog>()
        {
            new Catalog()
            {
                CDs = new List<CD>()
                {
                    new CD(){
                        Title = "Empire Burlesque",
                        Artist = "Bob Dylan",
                        Country = "USA",
                        Company = "Columbia",
                        Price = 10.90m,
                        Year = 1985
                    },
                    new CD(){Title = "Hide your heart",
                        Artist = "Bonnie Tyler",
                        Country = "UK",
                        Company = "CBS Records",
                        Price = 9.90m,
                        Year = 1988},
                }
            }
        };

        public IEnumerable<Catalog> GetAll() => _catalogs;
    }
}
