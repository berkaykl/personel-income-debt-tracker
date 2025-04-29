using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Wage
    {
        public int WageId { get; set; }
        public string WageName { get; set; }
        public string WageDescription { get; set; }
        public string WageAmount { get; set; }
        public DateTime WageCreatedDate { get; set; }
    }
}
