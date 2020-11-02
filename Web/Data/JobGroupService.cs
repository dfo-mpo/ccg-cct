using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data 
{
    public class JobGroupService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobGroupService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JobGroup[]> GetJobGroups()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroup[]>("/api/jobgroups");
        }

        public async Task<JobGroup> GetJobGroupById(int id)
        {
            string url = "/api/jobgroups/"+id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroup>(url);
        }

    }
}
