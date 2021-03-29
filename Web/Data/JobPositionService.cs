using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;

namespace Web.Data
{
    public class JobPositionService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobPositionService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }
        public async Task<JobPositionDto[]> GetJobPositionByIdValues(string Parameters)
        {
            string url = $"/api/jobpositions/IdValues?{Parameters}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>(url);
        }

        public async Task<JobCompetencyRatingDto[]> GetJobCompetencyRatings(int Id)
        {
            string url = $"/api/jobpositions/{Id}/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRatingDto[]>(url);
        }

        public async Task<JobCompetencyRatingDto[]> GetJobCompetencyRatingsByTypeId(int Id, int compentencytypeId)
        {
            string url = $"/api/jobpositions/{Id}/{compentencytypeId}/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRatingDto[]>(url);
        }

        public async Task<JobCertificateDto[]> GetJobCertificatesById(int Id)
        {
            string url = $"/api/jobpositions/{Id}/certificates";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto[]>(url);
        }

        public async Task<JobCompetencyDto[]> GetAllJobCompetencyTypes()
        {
            string url = $"/api/jobcompetencies/types";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
        }
        public async Task<JobCompetencyDto[]> GetJobCompetenciesByTypeId(int? TypeId)
        {
            if (TypeId.HasValue)
            {
                string url = $"/api/jobcompetencies/{TypeId}/jobcompetencies";
                using var httpClient = _clientFactory.CreateClient("api");
                return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
            }
            else return new JobCompetencyDto[] { };
        }


    }
}
