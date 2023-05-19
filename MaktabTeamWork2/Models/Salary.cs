using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Models
{
    public class Salary
    {

        string Id { get; set; }

        double Amont { get; set; }

        double tax { get; set; }

        double oderBenefit { get; set; }

        string EmployeeId { get; set; }

        TimeSpan year { get; set; }

        TimeSpan month { get; set; }
    }
}
