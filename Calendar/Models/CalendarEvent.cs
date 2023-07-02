using System;
using System.Windows.Media;

namespace Calendar.Models
{
    public class CalendarEvent
    {
        #region Variables & Properties
        public string Name { get; private set; }
        public string Location { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public Colors Color { get; private set; }
        #endregion

        #region Constructor
        public CalendarEvent(string name, string location, DateTime startTime, DateTime endTime, Colors color)
        {
            this.Name = name;
            this.Location = location;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Color = color;
        }
        #endregion
    }
}
