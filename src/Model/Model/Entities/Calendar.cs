using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Calendar : AbstractUpdatableClass
    {
        [NotMapped]
        public string Description
        {
            get
            {
                var s = DaysText;
                if (StartTime != null && EndTime != null)
                {
                    s += (s.Length == 0 ? " " : "") + "de " + StartTimeText + "hs a " + EndTimeText + "hs";
                }
                if (StartDate != null && EndDate != null)
                {
                    s += (s.Length == 0 ? " " : "") + " desde " + StartDateText + " hasta " + EndDateText;
                }

                return s;
            }
        }

        public DateTime? StartTime { get; set; }

        [NotMapped]
        public string StartTimeText
        {
            get
            {
                return StartTime == null ? null : StartTime.Value.ToShortTimeString();
            }
        }

        public DateTime? EndTime { get; set; }

        [NotMapped]
        public string EndTimeText
        {
            get
            {
                return EndTime == null ? null : EndTime.Value.ToShortTimeString();
            }
        }

        public DateTime? StartDate { get; set; }

        [NotMapped]
        public string StartDateText
        {
            get
            {
                return StartDate == null ? null : StartDate.Value.ToShortDateString();
            }
        }

        public DateTime? EndDate { get; set; }

        [NotMapped]
        public string EndDateText
        {
            get
            {
                return EndDate == null ? null : EndDate.Value.ToShortDateString();
            }
        }

        public bool? OnMonday { get; set; }

        public bool? OnTuesday { get; set; }

        public bool? OnWednesday { get; set; }

        public bool? OnThursday { get; set; }

        public bool? OnFriday { get; set; }

        public bool? OnSaturday { get; set; }

        public bool? OnSunday { get; set; }

        [NotMapped]
        public string DaysText
        {
            get
            {
                var s = "";
                s += OnMonday == true ? "Lun-" : "";
                s += OnTuesday == true ? "Mar-" : "";
                s += OnWednesday == true ? "Mie-" : "";
                s += OnThursday == true ? "Jue-" : "";
                s += OnFriday == true ? "Vie-" : "";
                s += OnSaturday == true ? "Sab-" : "";
                s += OnSunday == true ? "Dom-" : "";

                return s.Length == 0 ? null : s.Substring(0, s.Length - 1);
            }
        }
    }
}
