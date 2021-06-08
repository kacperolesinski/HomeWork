using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catalogRepository;
        public CatalogService(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }
        public IEnumerable<Catalog> GetAllCatalogs()
        {
            return _catalogRepository.GetAll();
        }
    }
}
