using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Terminal : AbstractUpdatableClass
    {
        [NotMapped]
        public string AddressDescription
        {
            get
            {
                return this.Door != null && this.Door.Area != null && this.Door.Area.Address != null ? this.Door.Area.Address.Description : null;
            }
        }

        [NotMapped]
        public string AreaDescription
        {
            get
            {
                return this.Door != null && this.Door.Area != null ? this.Door.Area.Description : null;
            }
        }

        [ForeignKey("Door")]
        public int DoorID { get; set; }
        public Door Door { get; set; }

        [NotMapped]
        public string DoorDescription
        {
            get
            {
                return this.Door != null ? this.Door.Description : null;
            }
        }

        [ForeignKey("HardwareModel")]
        public int HardwareModelID { get; set; }
        public HardwareModel HardwareModel { get; set; }

        [NotMapped]
        public string HardwareModelDescription
        {
            get
            {
                return this.HardwareModel != null ? HardwareModel.Description : null;
            }
        }

        [StringLength(30)]
        public string IP { get; set; }
    }
}
