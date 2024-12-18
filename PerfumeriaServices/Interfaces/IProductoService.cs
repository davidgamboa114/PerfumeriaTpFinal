using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IProductoService : IGenericService<pProducto>
    {
        public Task<List<pProducto>?> GetAllAsync(string? filtro);
        public Task<List<pProducto>?> GetAllDeletedAsync(string? filtro);

    }
}
