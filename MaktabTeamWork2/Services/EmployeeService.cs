using MaktabTeamWork2.DataBase;
using MaktabTeamWork2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.Services
{
    public class EmployeeService : IEmployeeService
    {
        AppDB appDB = new AppDB();

        public List<EmployeeNameViewModel> GetEmployeeName()
        {
            var personalNameLastname = from a in appDB.employes
                                       select new EmployeeNameViewModel()
                                       { Id = a.id, Name = a.FName, LastName = a.LName } ;
            return personalNameLastname.ToList();
        }

        public List<EmployeeNameViewModel> GetMenEmpName()
        {
            var getMenEmpName = from a in appDB.employes
                                where a.gender == "man"
                                orderby a.id ascending
                                select new EmployeeNameViewModel() { Id = a.id, Name = a.FName, LastName = a.LName };
            return getMenEmpName.ToList();
        }
    }
}
