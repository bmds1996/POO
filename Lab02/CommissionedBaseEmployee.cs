using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class CommissionedBaseEmployee : CommissionedEmployee
    {
        public decimal SalaryBase{ get; set; }

        public CommissionedBaseEmployee(int id, string firstName, string lastName, decimal sales, double commissionPercentage, decimal salaryBase) : 
            base(id, firstName, lastName, sales, commissionPercentage)
        {
            SalaryBase = salaryBase;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + SalaryBase;
        }

        public override string ToString()
        {
            return string.Format(@"{0} {1} {2}
                    % Commision.: {3,18:P2}
                    Sales.......: {4,18:C2}
                    Base........: {5,18:C2}
                    Salary......: {6,18:C2}",
                    Id, FistName, LastName, CommissionPercentage, Sales, SalaryBase, CalculateSalary());
        }
    }
}
