using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class CommissionedEmployee : Employee
    {

        #region Properties
        public decimal Sales { get; set; }

        public double CommissionPercentage { get; set; }
        #endregion

        #region Constructor
        public CommissionedEmployee(int id, string firstName, string lastName,
             decimal sales, double commissionPercentage) :
             base(id, firstName, lastName)
        {
            Sales = sales;
            CommissionPercentage = commissionPercentage;
        }
        #endregion

        #region Methods
        public override decimal CalculateSalary()
        {
            return Sales * (decimal)CommissionPercentage;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                    % Commision: {1,18:P2}
                    Sales.......: {2,18:C2}
                    Salary......: {3,18:C2}",
                    base.ToString(), CommissionPercentage, Sales, CalculateSalary());
        } 
        #endregion
    }
}
