using MaktabTeamWork2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Services
{
    public interface IEmployeeService
    {
        List<EmployeeNameViewModel> GetEmployeeName();
        List<EmployeeNameViewModel> GetMenEmpName();
    }
}
