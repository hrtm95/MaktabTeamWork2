using MaktabTeamWork2.DataBase;
using MaktabTeamWork2.Models;
using MaktabTeamWork2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Services
{
    public class SalaryService : ISalaryService
    {
        AppDB appDB = new AppDB();

        public double GetSumTotalTaxPaid()
        {
            var getTax = (from a in appDB.salaries
                         select a.tax).Sum();
            return getTax;                           
        }

        public double GetTotalSalaryById(int id)
        {
            var totalIdSalary = (from a in appDB.salaries
                                 where a.EmployeeId == id
                                 select a.Amont + a.oderBenefit - a.tax);
            return totalIdSalary.Sum();
        }

        public List<Payslip> PayslipByIdForOneMonth(int id, int year, int month)
        {
            var payslip = (from a in appDB.employes
                           join b in appDB.salaries on a.id equals b.EmployeeId
                           where a.id == id.ToString() 
                           select new Payslip() {Id = b.EmployeeId , Amount = b.Amont ,Tax = b.tax })
        }
    }
}
