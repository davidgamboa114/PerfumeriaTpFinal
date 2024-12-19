using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IClienteService : IGenericService<pCliente>
    {
        public Task<List<pCliente>?> GetAllAsync(string? filtro);
        public Task<List<pCliente>?> GetAllDeletedAsync(string? filtro);

    }
}
