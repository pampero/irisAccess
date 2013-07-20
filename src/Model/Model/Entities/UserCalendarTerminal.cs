using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class UserCalendarTerminal : AbstractUpdatableClass
    {
        [NotMapped]
        public string UserProfileDescription
        {
            get
            {
                return UserProfile.FullName;
            }
        }

        [ForeignKey("UserProfile")]
        public int UserProfileID { get; set; }
        public UserProfile UserProfile { get; set; }

        [NotMapped]
        public string CalendarDescription
        {
            get
            {
                return Calendar.Description;
            }
        }

        [ForeignKey("Calendar")]
        public int CalendarID { get; set; }
        public Calendar Calendar { get; set; }

        [NotMapped]
        public string TerminalDescription
        {
            get
            {
                return Terminal.IP;
            }
        }

        [ForeignKey("Terminal")]
        public int TerminalID { get; set; }
        public Terminal Terminal { get; set; }
    }
}
