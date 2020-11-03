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
            string url = "/api/jobgroups/" + id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroup>(url);
        }
        //api/jobgroups/{id}/levels
        public async Task<JobGroupLevel[]> GetJobGroupLevelsById(int id)
        {
            string url = "/api/jobgroups/" + id + "/levels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupLevel[]>(url);
        }
        //api/jobgroups/{id}/levels/{level}/positions
        public async Task<JobGroupPosition[]> GetJobGroupPositionsByLevel(int id, int level)
        {
            string url = "/api/jobgroups/" + id + "/levels/" + level + "/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPosition[]>(url);
        }

        //api/jobgroups/{id}/levels/{level}/positions/{positionid}/competencies/{competencyid}/rating

    }
}
