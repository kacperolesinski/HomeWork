using System.Collections.Generic;

namespace Domain.Entities
{
    public class Catalog
    {
        public List<CD> CDs { get; set; }
        public Catalog()
        {
            CDs = new List<CD>();
        }
    }
}
