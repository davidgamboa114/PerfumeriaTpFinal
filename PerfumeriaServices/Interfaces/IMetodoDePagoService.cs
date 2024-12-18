using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    internal interface IMetodoDePagoService : IGenericService<MetodoDePago>
    {
        public Task<List<MetodoDePago>?> GetAllAsync(string? filtro);
        public Task<List<MetodoDePago>?> GetAllDeletedAsync(string? filtro);

    }
}
