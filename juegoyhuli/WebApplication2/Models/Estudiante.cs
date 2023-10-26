using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Estudiante
    {
        [Key]
        public int IdStudent { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public bool sexo { get; set; }
        public int IdUniversity { get; set; }
    }
}