namespace Lab02
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }
        #endregion

        #region Contructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FistName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Methods
        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, FistName, LastName);
        }
        #endregion
    }
}
