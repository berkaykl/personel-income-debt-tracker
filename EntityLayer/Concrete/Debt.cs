using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Debt
    {
        public int DebtId { get; set; }
        public string DebtName { get; set; }
        public string DebtDescription { get; set; }
        public string DebtAmount { get; set; }
        public DateTime DebtCreatedDate { get; set; }
    }
}
