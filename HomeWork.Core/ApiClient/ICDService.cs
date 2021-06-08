using HomeWork.Core.Models;
using System.Collections.Generic;

namespace HomeWork.Core.ApiClient
{
    public interface ICDService
    {
        IEnumerable<CD> GetCDs();
    }
}
