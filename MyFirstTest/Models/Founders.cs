using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTest.Models
{
    public class Founders
    {
        public int FoundersId { get; set; }
        public int ITN { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreationData { get; set; }
        public string UpdateDate { get; set; }
        //ссылка на клиента.
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
    }
}
