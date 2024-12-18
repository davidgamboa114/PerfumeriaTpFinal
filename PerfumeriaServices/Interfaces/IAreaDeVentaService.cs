using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IAreaDeVentaService : IGenericService<pAreaDeVenta>
    {
        public Task<List<pAreaDeVenta>?> GetAllAsync(string? filtro);
        public Task<List<pAreaDeVenta>?> GetAllDeletedAsync(string? filtro);

    }
}
