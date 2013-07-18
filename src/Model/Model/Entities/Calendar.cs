using System;

namespace Model
{
    public class Calendar : AbstractUpdatableClass
    {
        public int? StartTime { get; set; }

        public int? EndTime { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? OnMonday { get; set; }

        public bool? OnTuesday { get; set; }

        public bool? OnWednesday { get; set; }

        public bool? OnThursday { get; set; }

        public bool? OnFriday { get; set; }

        public bool? OnSaturday { get; set; }

        public bool? OnSunday { get; set; }
    }
}
