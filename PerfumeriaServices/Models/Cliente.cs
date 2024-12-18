using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfumeriaServices.Models;

public class Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    [EmailAddress]
    public string Correo { get; set; }

    public string Telefono { get; set; }
    public bool IsDeleted { get; set; }

}
