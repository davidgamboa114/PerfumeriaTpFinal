using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfumeriaServices.Models;

public class pProducto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Precio { get; set; }

    [ForeignKey("AreaDeVenta")]
    public long AreaVentaId { get; set; }
    public pAreaDeVenta AreaDeVenta { get; set; }
    public bool IsDeleted { get; set; }

}
