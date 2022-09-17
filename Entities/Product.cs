using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name{ get; set; }
        public double Price { get; set; }
        public int StockUnit { get; set; }
        public string  Description { get; set; }
        public int CategoryId { get; set; }
    }
}
