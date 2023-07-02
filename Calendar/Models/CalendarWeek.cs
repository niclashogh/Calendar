namespace Calendar.Models
{
    public class CalendarWeek
    {
        #region Variables & Properties
        public CalendarDay[] Days { get; private set; }
        public byte Week { get; set; }
        #endregion

        #region Constructor
        public CalendarWeek(CalendarDay[] days)
        {
            this.Days = days;
        }
        #endregion
    }
}
