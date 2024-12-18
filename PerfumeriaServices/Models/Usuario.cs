
using PerfumeriaServices.Enums;

namespace PerfumeriaServices.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public TipoUsuarioEnum TipoUsuario { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}

