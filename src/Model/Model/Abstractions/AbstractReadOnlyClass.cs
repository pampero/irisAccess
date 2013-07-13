using Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public abstract class AbstractReadOnlyClass : ICreateFields
    {
        private bool _isDeleted;
       
        [Key]
        public int ID
        {
            get; set;
        }

        public DateTime Created
        {
            get; set;
        }

        public string CreatedBy
        {
            get; set;
        }

        public bool IsDeleted
        {
            get { return _isDeleted; } 
        }
    }
}
