namespace Lab01
{
    public class Employee
    {
        #region Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BornDate { get; set; }

        public Date HireDate { get; set; }
        #endregion

        /*#region Constructor
        public Employee(string firstName, string lastName, Date bornDate, Date hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BornDate = bornDate;
            HireDate = hireDate;
        }
        #endregion*/

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1}\n\tBorn date: {2}\n\tHire date: {3}", 
                                 FirstName, LastName, BornDate, HireDate);
        }
        #endregion
    }
}
