using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Models;
using System.Text.Json;

namespace PerfumeriaServices.Services
{
    public class AreaDeVentaService : GenericService<AreaDeVenta>, IAreaDeVentaService
    {
        public async Task<List<AreaDeVenta>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<AreaDeVenta>>(content, options); ;
        }

        public async Task<List<AreaDeVenta>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            // Deserializamos los itinerarios
            var itineraries = JsonSerializer.Deserialize<List<AreaDeVenta>>(content, options);

            // Filtramos los itinerarios eliminados (IsDeleted = true)
            return itineraries?.Where(i => i.IsDeleted).ToList();
        }
    }
}
