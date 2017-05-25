namespace Lab01
{
    public class Date
    {
        #region Attributtes
        private int year;
        private int month;
        private int day;
        #endregion

        #region Properties
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = CheckMonth(value);
            }
        }

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = CheckDay(value);
            }
        }
        #endregion

        #region Constructor
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0,4:0000}/{1,2:00}/{2,2:00}", Year, Month, Day);
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
            return 1;
        }

        private int CheckDay(int day)
        {
            var daysPerMonths = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            if (day >= 1 && day <= daysPerMonths[Month])
            {
                return day;
            }

            if (day == 29 && month == 2 && IsLeapYear(Year))
            {
                return day;
            }

            return 1;

        }

        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
