using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IUsuarioService : IGenericService<Usuario>
    {
        public Task<List<Usuario>?> GetAllAsync(string? filtro);
        public Task<List<Usuario>?> GetAllDeletedAsync(string? filtro);

    }
}
