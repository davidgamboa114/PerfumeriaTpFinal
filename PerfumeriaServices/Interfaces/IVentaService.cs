using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IVentaService : IGenericService<Venta>
    {
        public Task<List<Venta>?> GetAllAsync(string? filtro);
        public Task<List<Venta>?> GetAllDeletedAsync(string? filtro);

    }
}
