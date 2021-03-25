using Microsoft.AspNetCore.Components;
using Business.Dtos.JobPositions;
using System.Net.Http;
using System.Threading.Tasks;

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

    }
}
