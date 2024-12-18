using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeriaServices.Interfaces
{
    public interface IUsuarioService : IGenericService<pUsuario>
    {
        public Task<List<pUsuario>?> GetAllAsync(string? filtro);
        public Task<List<pUsuario>?> GetAllDeletedAsync(string? filtro);

    }
}
