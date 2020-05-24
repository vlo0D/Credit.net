using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CreditBL.Model
{
    public class Type_of_credit
    {
        [Key]
        public int Type_id { get; set; }

        public string Name_of_type { get; set; }
        public decimal Rate { get; set; }
        public int Days { get; set; }
       
        public virtual ICollection <Credit> Credits { get; set; }


        //public override string ToString()
        //{   
        //    return Name_of_type;
        //}
    }
}
