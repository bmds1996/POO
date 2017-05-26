using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public int HoursWorked { get; set; }

        public decimal HourValue { get; set; }
        #endregion

        #region Constructor
        public HourlyEmployee(int id, string firstName, string lastName,
          int hoursWorked, decimal hourValue) :
          base(id, firstName, lastName)
        {
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }
        #endregion

        #region Methods
        public override decimal CalculateSalary()
        {
            return HoursWorked * HourValue;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                    Worked hours: {1,18:N2}
                    Hour value..: {2,18:C2}
                    Salary......: {3,18:C2}",
                    base.ToString(), HoursWorked, HourValue, CalculateSalary());
        } 
        #endregion
    }
}
