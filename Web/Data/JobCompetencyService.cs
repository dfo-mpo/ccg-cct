using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class JobCompetencyService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobCompetencyService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<JobPosition> GetJobPosition(int id)
        {
            string url = "/api/jobpositions/" + id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPosition>(url);

        }

        public async Task<JobCompetencyRating[]> GetJobCompetencyRatings(int id)
        {
            string url = "/api/jobpositions/" + id + "/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRating[]>(url);

        }
    
    }
}
