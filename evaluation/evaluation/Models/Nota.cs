using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluation.Models
{
    public enum TypeSubject { Matematica, Biologia, Quimica }
    public enum TypeState { Aprobado, Reprobado  }

    public class Nota
    {
        [Key]
        public TypeSubject Subject { get; set; }
        [Required]
        public int Grades { get; set; }
        [Required]
        public TypeState State { get; set; }
        [Required]
        public Student Student { get; set; }


    }
}