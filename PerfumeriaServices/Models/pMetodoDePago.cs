using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfumeriaServices.Models;

public class pMetodoDePago
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public string Nombre { get; set; }
    public bool IsDeleted { get; set; }

}

