//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using TourismServices.Interfaces;
//using TourismServices.Models;

//namespace TourismServices.Services
//{
//    public class ItineraryService : GenericService<pfItinerary>, IItineraryService
//    {
//        public async Task<List<pfItinerary>?> GetAllAsync(string? filtro)
//        {
//            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
//            var content = await response.Content.ReadAsStringAsync();
//            if (!response.IsSuccessStatusCode)
//            {
//                throw new ApplicationException(content?.ToString());
//            }
//            return JsonSerializer.Deserialize<List<pfItinerary>>(content, options); ;
//        }

//        public async Task<List<pfItinerary>?> GetAllDeletedAsync(string? filtro)
//        {
//            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
//            var content = await response.Content.ReadAsStringAsync();

//            if (!response.IsSuccessStatusCode)
//            {
//                throw new ApplicationException(content?.ToString());
//            }

//            // Deserializamos los itinerarios
//            var itineraries = JsonSerializer.Deserialize<List<pfItinerary>>(content, options);

//            // Filtramos los itinerarios eliminados (IsDeleted = true)
//            return itineraries?.Where(i => i.IsDeleted).ToList();
//        }

//    }
//}
