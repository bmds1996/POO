using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var employess = new List<Employee>();

            //SalariedEmployee
            var emp1 = new SalariedEmployee(1010, "Celia", "Cruz", 1300000);
            employess.Add(emp1);
            var emp2 = new SalariedEmployee(1122, "Hector", "Lavoe", 2800000);
            employess.Add(emp2);
            //SalariedEmployee

            //CommissionedEmployee
            var emp3 = new CommissionedEmployee(3030, "Natalia", "Paris", 250000000, 0.023);
            employess.Add(emp3);
            var emp4 = new CommissionedEmployee(4444, "Esperanza", "Gomez", 340000000, 0.027);
            employess.Add(emp4);
            //CommissionedEmployee

            //HourlyEmployee
            var emp5 = new HourlyEmployee(2323, "Fredy", "Mercury", 300, 13500);
            employess.Add(emp5);
            var emp6 = new HourlyEmployee(5656, "Liv", "Taylor", 245, 45000);
            employess.Add(emp6);
            //HourlyEmployee

            //CommissionedBaseEmployee
            var emp7 = new CommissionedBaseEmployee(7676, "Tatiana", "De los rios", 6700000, 0.045, 2300000);
            employess.Add(emp7);
            var emp8 = new CommissionedBaseEmployee(5656, "Any", "Herrera", 5600000, 0.012, 6700000);
            employess.Add(emp8);
            //CommissionedBaseEmployee

            decimal paySheet = 0;

            foreach (var employee in employess)
            {
                Console.WriteLine(employee);
                paySheet += employee.CalculateSalary();
            }
             
            Console.WriteLine("                                     ================");
            Console.WriteLine("Pay sheet.......:                 {0,18:C2}", paySheet);
            Console.ReadKey();
        }
    }
}
