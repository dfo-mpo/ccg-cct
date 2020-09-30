using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class ClassificationService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ClassificationService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Classification[]> GetClassifications()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Classification[]>("/api/classification");
        }
    }
}
