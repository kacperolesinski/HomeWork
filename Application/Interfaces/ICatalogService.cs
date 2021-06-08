﻿using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ICatalogService
    {
        IEnumerable<Catalog> GetAllCatalogs();
    }
}
