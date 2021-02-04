using Microsoft.AspNetCore.Components;
using Business.Dtos.JobPositions;
using Business.Dtos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;

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
