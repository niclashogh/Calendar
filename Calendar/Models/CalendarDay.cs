namespace Calendar.Models
{
    public class CalendarDay
    {
        #region Variables & Properties
        public CalendarEvent CalendarEvent { get; private set; }
        public byte Day { get; set; }
        #endregion

        #region Constructor
        public CalendarDay(CalendarEvent calendarEvent)
        {
            this.CalendarEvent = calendarEvent;
        }
        #endregion
    }
}
