
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
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<P>>(content, options); ;
        }
        public async Task<List<P>?> GetAllDeletedAsync()
        {
            var response = await client.GetAsync($"{_endpoint}/Deleted");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            return JsonSerializer.Deserialize<List<P>>(content, options);
        }

        public async Task<P?> GetByIdAsync(int id)
        {
            var response = await client.GetAsync($"{_endpoint}/{id}");
            var content = await response.Content.ReadAsStreamAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<P>(content, options);
        }

        public async Task<P?> AddAsync(P? entity)
        {
            var response = await client.PostAsJsonAsync(_endpoint, entity);
            var content = await response.Content.ReadAsStreamAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<P>(content, options);
        }

        public async Task UpdateAsync(P? entity)
        {
            var idValue = entity.GetType().GetProperty("Id").GetValue(entity);
            var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response?.ToString());
            }
        }

        public async Task DeleteAsync(int Id)
        {
            var response = await client.DeleteAsync($"{_endpoint}/{Id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response.ToString());
            }
        }

    }

}
