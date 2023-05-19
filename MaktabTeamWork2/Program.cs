using MaktabTeamWork2.Models.ViewModels;
using MaktabTeamWork2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTeamWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SalaryService salaryService = new SalaryService();

            //Console.WriteLine("plese enter employ id:");
            //int employid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter year:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter maont:");
            //int maont = Convert.ToInt32(Console.ReadLine());


            
            //List<Payslip> pasys = salaryService.PayslipByIdForOneMonth(employid, year, maont);


            var listem = new EmployeeService();
            var newList = listem.GetEmployeeName1();



            foreach (var item in newList)
            {
                Console.WriteLine("Id: " + item.id + "\t name: " + item.FName);
            }


            //foreach (var Pay in pasys)
            //{
            //    Console.WriteLine("Id: " + Pay.Id + "\t amount: " + Pay.Amount);
            //}

            //double sumtotaltax = salaryService.GetSumTotalTaxPaid();
            //Console.WriteLine(sumtotaltax);


            Console.ReadKey();
        }
    }
}
