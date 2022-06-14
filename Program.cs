using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayTranning
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Employees emp1 = new Employees();
            Employees emp = new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f);
            // emp.Display();
            Console.WriteLine(emp);
            Date date1 = new Date();
            date1.Day = 13;
            date1.Month = " june";
            date1.Year = 2022;

            //Console.WriteLine($" Date id {date1.Day}/{date1.Month}/{date1.Year}");

            //Date date2 = new Date { Day = 14, Month = "July", Year = 2022 };
            //Console.WriteLine($" Date id {date1.Day}/{date1.Month}/{date1.Year}");
            List<int>intlist=new List<int>() { 1,2,3,4,5};
            foreach(int item in intlist)
            {
                Console.WriteLine(item);
            }
            List<string> strlist = new List<string>();
            foreach(string item in strlist)
            {
                Console.WriteLine(item);
            }
            List<Employees> list = new List<Employees>()
            {
                new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f),
                new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f),
                new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f),
                new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f),
                new Employees(202, "shubhali", Gender.Female, Department.Comp, 32000.00f),
            };
            foreach (Employees item in list)
            {
                Console.WriteLine(item);
            }
            List<Date> list2 = new List<Date>()
            {
                new Date { Day = 14, Month = "Jun", Year = 2022 },
                new Date { Day = 15, Month = "July", Year = 2022 },
                new Date { Day = 16, Month = "Jun", Year = 2022 },
            };
            foreach (Date item in list2)
            {
                Console.WriteLine($" Date id {date1.Day}/{date1.Month}/{date1.Year}");
            }

            Console.ReadLine();
        }
    }
}
