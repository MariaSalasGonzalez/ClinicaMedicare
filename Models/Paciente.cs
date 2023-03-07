using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMedicare.Models{
    public class Paciente{
        [DisplayName("Id")]
        [Required(ErrorMessage = "El id es requerido")]
        public int id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [DisplayName("Edad")]
        [Required(ErrorMessage = "La edad es  requerida")]
        [Range(typeof(Int32), "0", "90", ErrorMessage = "La edad debe ser entre 0 y 90 años.")]
        public int Edad { get; set; }

        [DisplayName("Enfermedad")]
        [Required(ErrorMessage = "La enfermedad es requerida")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage = "  El {0} Solo permite letras.")]
        [StringLength(50, ErrorMessage = " El {0} de contenener entre {2} y {1}  caracteres.", MinimumLength = 2)]
        public string Enfermedad { get; set; }
    }
}