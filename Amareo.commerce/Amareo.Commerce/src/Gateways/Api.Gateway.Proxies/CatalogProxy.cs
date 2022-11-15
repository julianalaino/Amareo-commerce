using Api.Gateway.Models;
using Api.Gateway.Models.Catalog.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Gateway.Proxies
{
    public interface ICatalogProxy
    {
        Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> ids = null);
        Task<ProductDto> GetAsync(int id);

    }
 
    public  class CatalogProxy : ICatalogProxy
    {
        private readonly ApiUrls _apiUrls;
        private readonly HttpClient _httpClient;

        public CatalogProxy(IOptions<ApiUrls> apiUrls, HttpClient httpClient, IHttpContextAccessor context)
        {
            httpClient.AddBearerToken(context);
            _httpClient = httpClient;
            _apiUrls = apiUrls.Value;
        }

        public async Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> clients = null)
        {
            var ids = string.Join(',', clients ?? new List<int>());
            var request = await _httpClient.GetAsync($"{_apiUrls.CatalogUrl}v1/products?page={page}&take={take}&ids={ids}");

            request.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<DataCollection<ProductDto>>(
                await request.Content.ReadAsStringAsync(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }               
                
                );

        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var request = await _httpClient.GetAsync($"{_apiUrls.CatalogUrl}v1/stocks?id={id}");

            request.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<ProductDto>(
                await request.Content.ReadAsStringAsync(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
        
    }
}
