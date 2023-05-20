using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Models
{
    public class Employe
    {

        public int id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string nationalCode { get; set; }

        public string mobile { get; set; }

        public string gender { get; set; }

        public string Email { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeAddress2 { get; set; }

        public string Address2 { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
