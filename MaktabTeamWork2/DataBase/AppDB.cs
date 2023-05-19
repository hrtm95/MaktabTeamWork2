using MaktabTeamWork2.Models;
using MaktabTeamWork2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.DataBase
{
    public class AppDB
    {
        public List<Employe> employes = new List<Employe>()
        {
            new Employe() {id = "2", FName = "ali", LName = "alipour", Email = "" +
                "1@gmail", gender = "man", mobile = "0900000", nationalCode = "12345"},

              new Employe() {id = "3", FName = "mohammad", LName = "alizadeh", Email = "" +
                "2@gmail", gender = "man", mobile = "090000110", nationalCode = "6789"}
        };



        public List<Salary> salaries = new List<Salary>()
               {
            new Salary() {Id = "20", EmployeeId = 2, Amont = 230, tax = 10, year = 2023,
            month = 2, oderBenefit = 20},

            new Salary() {Id = "21", EmployeeId = 2, Amont = 290, tax = 11, year = 2023,
            month = 3, oderBenefit = 21},

            new Salary() {Id = "22", EmployeeId = 3, Amont = 200, tax = 10, year = 2023,
            month = 5, oderBenefit = 25},

            new Salary() {Id = "23", EmployeeId = 3, Amont = 270, tax = 10, year = 2023,
            month = 8, oderBenefit = 25},

               };

        public List<Payslip> payslip = new List<Payslip>();
    }
}
