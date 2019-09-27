using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluation.Models
{
    public enum TypeGender{ Male,Female,Other }


    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public  TypeGender Gender { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public int Date { get; set; }
        [Required]
        public virtual ICollection<Nota> Notas { get; set; }

    }
}