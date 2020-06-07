using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTest.Models
{
    public class Founder
    {
        public int FounderId { get; set; }
        public string FounderITN { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationData { get; set; }
        public DateTime UpdateDate { get; set; }
        //_______________________________________
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
    }
}
