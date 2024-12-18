using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Models;
using System.Text.Json;

namespace PerfumeriaServices.Services
{
    public class AreaDeVentaService : GenericService<pAreaDeVenta>, IAreaDeVentaService
    {
        public async Task<List<pAreaDeVenta>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pAreaDeVenta>>(content, options); ;
        }

        public async Task<List<pAreaDeVenta>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            // Deserializamos los itinerarios
            var itineraries = JsonSerializer.Deserialize<List<pAreaDeVenta>>(content, options);

            // Filtramos los itinerarios eliminados (IsDeleted = true)
            return itineraries?.Where(i => i.IsDeleted).ToList();
        }
    }
}
