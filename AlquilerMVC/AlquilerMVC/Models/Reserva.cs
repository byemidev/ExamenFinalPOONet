using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerMVC.Models
{
    public class Reserva
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string IdMatricula { get; set; }
        [Required]
        public string Ubicacion { get; set; }
        [Required]
        public DateOnly FechaEtrada { get; set; }
        [Required]
        public DateOnly FechaSalida { get; set; }
        [Required]
        public TimeOnly Inicio { get; set; }

        public TimeOnly Fin { get; set; }
    }
}
