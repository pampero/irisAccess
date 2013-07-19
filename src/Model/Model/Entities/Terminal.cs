using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Terminal : AbstractUpdatableClass
    {
        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [NotMapped]
        public string AddressDescription
        {
            get
            {
                return this.Address != null ? Address.Description : null;
            }
        }

        [ForeignKey("Area")]
        public int AreaID { get; set; }
        public Area Area { get; set; }

        [NotMapped]
        public string AreaDescription
        {
            get
            {
                return this.Area != null ? Area.Description : null;
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
                return this.Door != null ? Door.Description : null;
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
