using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Models
{
    public class Salary
    {

       public string Id { get; set; }

        public double Amont { get; set; }

        public double tax { get; set; }

        public double oderBenefit { get; set; }

        public string EmployeeId { get; set; }

        public int year { get; set; }

        public int month { get; set; }
    }
}
