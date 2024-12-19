
using System.Net.Http.Json;
using System.Text.Json;
using PerfumeriaServices.Class;
using PerfumeriaServices.Interfaces;

namespace PerfumeriaServices.Services
{
    public class GenericService<P> : IGenericService<P> where P : class
    {
        protected readonly HttpClient client;
        protected readonly JsonSerializerOptions options;
        protected readonly string _endpoint;

        public GenericService()
        {
            this.client = new HttpClient();
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var remoto = Properties.Resources.Remoto;

            var urlApi = Properties.Resources.UrlApi;
            if (remoto == "false")
            {
                urlApi = Properties.Resources.UrlApiLocal;
            }
            this._endpoint = urlApi + ApiEndpoints.GetEndpoint(typeof(P).Name);
        }

        public async Task<List<P>?> GetAllAsync()
        {
            var response = await client.GetAsync(_endpoint);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new ApplicationException($"Error: {response.StatusCode}, {errorContent}");
            }
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<P>>(content, options);
        }

        public async Task<List<P>?> GetAllDeletedAsync()
        {
            var response = await client.GetAsync($"{_endpoint}/Deleted");
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new ApplicationException($"Error: {response.StatusCode}, {errorContent}");
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<P>>(content, options);
        }

        public async Task<P?> GetByIdAsync(int id)
        {
            var response = await client.GetAsync($"{_endpoint}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new ApplicationException($"Error: {response.StatusCode}, {errorContent}");
            }

            var content = await response.Content.ReadAsStreamAsync();
            return JsonSerializer.Deserialize<P>(content, options);
        }

        public async Task<P?> AddAsync(P? entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var response = await client.PostAsJsonAsync(_endpoint, entity);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new ApplicationException($"Error: {response.StatusCode}, {errorContent}");
            }

            var content = await response.Content.ReadAsStreamAsync();
            return JsonSerializer.Deserialize<P>(content, options);
        }

        public async Task UpdateAsync(P? entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var idValue = entity.GetType().GetProperty("Id")?.GetValue(entity);
            if (idValue == null) throw new ArgumentException("Entity does not have an Id property.");

            var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");
            }
        }

        public async Task DeleteAsync(int Id)
        {
            var response = await client.DeleteAsync($"{_endpoint}/{Id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");
            }
        }
    }
}
