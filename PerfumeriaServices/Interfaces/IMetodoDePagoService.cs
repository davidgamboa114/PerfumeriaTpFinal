using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    internal interface IMetodoDePagoService : IGenericService<pMetodoDePago>
    {
        public Task<List<pMetodoDePago>?> GetAllAsync(string? filtro);
        public Task<List<pMetodoDePago>?> GetAllDeletedAsync(string? filtro);

    }
}
