﻿

namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum Estado
    {
        Aprobado,
        Reprobado
    }
    public class Nota
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public int Calificacion { get; set; }
        [Required]
        public string Materia { get; set; }
        [Required]
        public Estado estado { get; set; }
    }
}