
namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum Gender
    {
        Masculino,
        Femenino
    }
    public class Estudiante
    {
        [Key]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        public int Birthdate { get; set; }

    }
}