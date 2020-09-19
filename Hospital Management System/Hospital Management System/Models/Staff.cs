using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string Docter_Name { get; set; }
        public string Docter_Number { get; set; }
        public string Scpeciality { get; set; }
        public string Education { get; set; }
        public int Docter_Fee { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}