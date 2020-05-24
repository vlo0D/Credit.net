using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace CreditBL.Model
{
    public class Client
    {
        [Key]
        public int Client_id { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public string Passport_id { get; set; }

        public virtual ICollection<Credit> Credits { get; set; }
        //public override string ToString()
        //{
        //    return First_Name+" "+Last_Name;
        //}
    }
}
