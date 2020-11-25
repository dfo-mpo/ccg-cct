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
        public async Task<JobPosition> GetJobPosition(int Id)
        {
            string url = "/api/jobpositions/" + Id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPosition>(url);
        }

        public async Task<JobCompetencyRating[]> GetJobCompetencyRatings(int Id)
        {
            string url = "/api/jobpositions/" + Id + "/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRating[]>(url);

        }

        public async Task<JobCompetencyRating[]> GetJobCompetencyRatingsByTypeId(int Id, int compentencytypeId)
        {
            string url = "/api/jobpositions/" + Id + "/" + compentencytypeId + "/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRating[]>(url);
        }

        public async Task<JobCertificate[]> GetJobCertificatesById(int Id)
        {
            string url = "/api/jobpositions/" + Id + "/certificates";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificate[]>(url);
        }
    
    }
}
