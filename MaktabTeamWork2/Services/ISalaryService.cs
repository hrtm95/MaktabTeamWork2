using MaktabTeamWork2.Models;
using MaktabTeamWork2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Services
{
    public interface ISalaryService
    {
        double GetTotalSalaryById(int id);
        double GetSumTotalTaxPaid();
        List<Payslip> PayslipByIdForOneMonth(int id, int year, int month);
    }
}
