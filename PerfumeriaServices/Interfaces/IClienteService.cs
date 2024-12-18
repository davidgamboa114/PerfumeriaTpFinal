using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    internal interface IClienteService : IGenericService<Cliente>
    {
        public Task<List<Cliente>?> GetAllAsync(string? filtro);
        public Task<List<Cliente>?> GetAllDeletedAsync(string? filtro);

    }
}
