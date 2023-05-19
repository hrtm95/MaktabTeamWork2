using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Models.ViewModels
{
    public class Payslip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int NationalCode { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; }
        public double OtherBenefit { get; set;}

    }
}
