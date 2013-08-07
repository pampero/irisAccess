using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Door : DefaultEntity
    {
        public string AreaDescription
        {
            get
            {
                return this.Area != null ? this.Area.Description : null;
            }
        }

        public string AddressDescription
        {
            get
            {
                return this.Area != null && this.Area.Address != null ? this.Area.Address.Description : null;
            }
        }

        [ForeignKey("AreaID")]
        public Area Area { get; set; }
        public int AreaID { get; set; }
    }
}
