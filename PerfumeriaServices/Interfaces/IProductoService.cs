using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IProductoService : IGenericService<Producto>
    {
        public Task<List<Producto>?> GetAllAsync(string? filtro);
        public Task<List<Producto>?> GetAllDeletedAsync(string? filtro);

    }
}
