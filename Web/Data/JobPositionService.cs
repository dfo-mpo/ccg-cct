using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class JobPositionService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobPositionService(IHttpClientFactory clientFactory)
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

        public async Task<JobCompetencyRating[]> GetJobCompetencyRatingsByTypeId(int id, int compentencytypeid)
        {
            string url = "/api/jobpositions/" + id + "/" + compentencytypeid + "/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRating[]>(url);

        }

        public async Task<JobCertificate[]> GetJobCertificatesById(int id)
        {
            string url = "/api/jobpositions/" + id + "/certificates";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificate[]>(url);
        }
    
    }
}
