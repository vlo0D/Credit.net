using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBL.Model
{
    public class FakeCredit
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount_to_be_paid { get; set; }
        public DateTime Date_of_issue { get; set; }
        public DateTime Date_of_repayment { get; set; }
    }
}
