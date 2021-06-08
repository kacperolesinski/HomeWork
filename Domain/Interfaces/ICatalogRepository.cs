using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICatalogRepository
    {
        IEnumerable<Catalog> GetAll();
    }
}
