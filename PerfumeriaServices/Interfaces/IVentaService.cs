using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IVentaService : IGenericService<pVenta>
    {
        public Task<List<pVenta>?> GetAllAsync(string? filtro);
        public Task<List<pVenta>?> GetAllDeletedAsync(string? filtro);

    }
}
