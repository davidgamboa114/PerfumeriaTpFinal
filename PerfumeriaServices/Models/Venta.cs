using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfumeriaServices.Models;


public class Venta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public DateTime Fecha { get; set; } = DateTime.UtcNow;

    [ForeignKey("Cliente")]
    public long ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    [ForeignKey("Producto")]
    public long ProductoId { get; set; }
    public Producto Producto { get; set; }

    [Required]
    public int Cantidad { get; set; }

    [ForeignKey("MetodoDePago")]
    public long MetodoPagoId { get; set; }
    public MetodoDePago MetodoDePago { get; set; }
    public bool IsDeleted { get; set; }

}
