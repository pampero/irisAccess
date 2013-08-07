using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Area : DefaultEntity
    {
        public string AddressDescription
        {
            get
            {
                return this.Address != null ? this.Address.Description : null;
            }
        }

        [ForeignKey("AddressID")]
        public Address Address { get; set; }
        public int AddressID { get; set; }
    }
}
