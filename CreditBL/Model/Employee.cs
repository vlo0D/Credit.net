using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CreditBL.Model
{
    public class Employee
    {
        [Key]
        public int Employee_id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Credit> Credits { get; set; }


        //public override string ToString()
        //{
        //    return FirstName+" "+LastName;

        //}
    }
}
