namespace Calendar.Models
{
    #region Month Enum
    public enum Months
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }
    #endregion

    public class CalendarMonth
    {
        #region Variables & Properties
        public CalendarWeek[] Weeks { get; private set; }
        public Months Month { get; set; }
        #endregion

        #region Constructor
        public CalendarMonth(CalendarWeek[] weeks)
        {
            this.Weeks = weeks;
        }
        #endregion
    }
}
