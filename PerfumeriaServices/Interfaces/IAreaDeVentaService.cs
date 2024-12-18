using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IAreaDeVentaService : IGenericService<AreaDeVenta>
    {
        public Task<List<AreaDeVenta>?> GetAllAsync(string? filtro);
        public Task<List<AreaDeVenta>?> GetAllDeletedAsync(string? filtro);

    }
}
