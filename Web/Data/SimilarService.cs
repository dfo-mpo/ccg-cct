using Microsoft.AspNetCore.Components;
using Business.Dtos.JobPositions;
using System.Net.Http;
using System.Threading.Tasks;
using Business.Dtos.Similar;

namespace Web.Data
{
    public class SimilarService : IDataService
    {

        private readonly IHttpClientFactory _clientFactory;

        public SimilarService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }
        public async Task<JobPositionDto[]> GetAllSimilarJobPositionsByPositionId(string Parameters)
        {
            string url = $"/api/similar/positions?{Parameters}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>(url);
        }
        public async Task<SimilarSearchDto> GetAllHundredPercentSimilarPositionsByPositionId(int Id)
        {
            string url = $"/api/similar/hundredpercentsimilarjobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SimilarSearchDto>(url);
        }
        public async Task<SimilarSearchDto> GetAllNinetyPercentSimilarPositionsByPositionId(int Id)
        {
            string url = $"/api/similar/ninetypercentsimilarjobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SimilarSearchDto>(url);
        }
        public async Task<SimilarSearchDto> GetAllEightyPercentSimilarPositionsByPositionId(int Id)
        {
            string url = $"/api/similar/eightypercentsimilarjobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SimilarSearchDto>(url);
        }
        public async Task<SimilarSearchDto> GetAllSeventyPercentSimilarPositionsByPositionId(int Id)
        {
            string url = $"/api/similar/seventypercentsimilarjobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SimilarSearchDto>(url);
        }
    }
}
