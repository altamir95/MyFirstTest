using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTest.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public int ITN { get; set; }
        public string CustomerName { get; set; }
        public string AType { get; set; }
        
        public string CreationData { get; set; }
        public string UpdateDate { get; set; }
    }
}
