using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTest.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerITN { get; set; }
        public string CustomerName { get; set; }
        public string EntityType  { get; set; }

        public DateTime CreationData { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
