using MaktabTeamWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2.DataBase
{
    internal class AppDB
    {
        List<Employe> employes = new List<Employe>()
        {
            new Employe() {id = "2", FName = "ali", LName = "alipour", Email = "" +
                "1@gmail", gender = "man", mobile = "0900000", nationalCode = "12345"},

              new Employe() {id = "3", FName = "mohammad", LName = "alizadeh", Email = "" +
                "2@gmail", gender = "man", mobile = "090000110", nationalCode = "6789"}
        };



        List<Salary> salaries = new List<Salary>()
        {
            new Salary() {Id = "20", EmployeeId = "2", Amont = 230, tax = 10, year = Convert.ToDateTime("2021"),
            month = Convert.ToDateTime("2"), oderBenefit = 20},

            new Salary() {Id = "20", EmployeeId = "2", Amont = 290, tax = 11, year = Convert.ToDateTime("2021"),
            month = Convert.ToDateTime("3"), oderBenefit = 21},

            new Salary() {Id = "30", EmployeeId = "3", Amont = 200, tax = 10, year = Convert.ToDateTime("2021"),
            month = Convert.ToDateTime("5"), oderBenefit = 25},

            new Salary() {Id = "30", EmployeeId = "3", Amont = 270, tax = 10, year = Convert.ToDateTime("2021"),
            month = Convert.ToDateTime("8"), oderBenefit = 25},

        };
    }
}
