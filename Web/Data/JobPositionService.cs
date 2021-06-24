using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using System.Collections;

namespace Web.Data
{
    public class JobPositionService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobPositionService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public class CompareByGroupCode : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobPositionDto jb1 = o1 as JobPositionDto;
                JobPositionDto jb2 = o2 as JobPositionDto;
                if (jb1.JobGroupId == jb2.JobGroupId)
                {
                    return string.Compare(jb1.LevelCode, jb2.LevelCode);
                }
                return string.Compare(jb1.JobGroupCode, jb2.JobGroupCode);
            }
        }

        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }

        public async Task<JobPositionDto[]> GetJobPositionByIdValues(string Parameters)
        {
            CompareByGroupCode comparebygroupcode = new CompareByGroupCode();
            string url = $"/api/jobpositions/IdValues?{Parameters}";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebygroupcode);
            return list;
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
    }
}
