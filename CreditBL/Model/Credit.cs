using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CreditBL.Model
{
    public class Credit
    {
        [Key]
        public int Credit_id { get; set; }
      

        public decimal Amount { get; set; }
        public decimal Amount_to_be_paid { get; set; }
        public DateTime Date_of_issue { get; set; }
        public DateTime Date_of_repayment { get; set; }
        public int? Type_id { get; set; }
        public virtual Type_of_credit Type_Of_Credit { get; set; }

        public int? Employee_id { get; set; }
        public virtual Employee Employee { get; set; }

        public int? Status_id { get; set; }
        public virtual Status Status { get; set; }

        public int? Client_id { get; set; }
        public virtual Client Client { get;set; }

        //public override string ToString()
        //{
        //    return ; 
        //}
    }
}
