using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data 
{
    public class JobCategoryService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobCategoryService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JobCategory[]> GetJobCategories()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCategory[]>("/api/jobcategories");
        }

        public async Task<JobCategory> GetJobCategoryById(int id)
        {
            string url = "/api/jobcategories/"+id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCategory>(url);
        }

    }
}
