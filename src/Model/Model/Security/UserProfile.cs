using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class UserProfile : AbstractUpdatableClass
    {
        [StringLength(20)]
        public string FileId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        [StringLength(120)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Identification { get; set; }

        public bool IsMale { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}
