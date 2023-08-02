using System.ComponentModel.DataAnnotations;

namespace GoUcneProject.Client.Utilidades
{
    public class UsuarioLogin
    {
        [Required(ErrorMessage = "El correo requerido es obligatorio.")]
        public string Correo { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña requerida es obligatoria.")]
        public string Password { get; set; } = null!;
    }
}
