﻿using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PerfumeriaServices.Services
{
    public class ProductoService : GenericService<Producto>, IProductoService
    {
        public async Task<List<Producto>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Producto>>(content, options); ;
        }

        public async Task<List<Producto>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            // Deserializamos los itinerarios
            var itineraries = JsonSerializer.Deserialize<List<Producto>>(content, options);

            // Filtramos los itinerarios eliminados (IsDeleted = true)
            return itineraries?.Where(i => i.IsDeleted).ToList();
        }
    }
}