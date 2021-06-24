using System;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobPositions;
using System.Net.Http;
using System.Threading.Tasks;
using Business.Dtos.Similar;
using System.Collections;

namespace Web.Data
{
    public class SimilarService : IDataService
    {

        private readonly IHttpClientFactory _clientFactory;

        public SimilarService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public class CompareByGroupCode : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobPositionDto jb1 = o1 as JobPositionDto;
                JobPositionDto jb2 = o2 as JobPositionDto;
                return string.Compare(jb1.JobGroupCode, jb2.JobGroupCode);
            }
        }

        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }

        public async Task<JobPositionDto[]> GetAllSimilarJobPositionsByPositionId(string Parameters)
        {
            CompareByGroupCode comparebygroupcode = new CompareByGroupCode();
            string url = $"/api/similar/positions?{Parameters}";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebygroupcode);
            return list;
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
