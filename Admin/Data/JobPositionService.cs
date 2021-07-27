using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using Business.Dtos.JobGroups;
using System.Collections;
using System;

namespace Admin.Data
{
    public class JobPositionService : IDataService
    {
        public class CompareByName : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobGroupDto jb1 = o1 as JobGroupDto;
                JobGroupDto jb2 = o2 as JobGroupDto;
                if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en")
                { return string.Compare(jb1.NameEng, jb2.NameEng); }
                else { return string.Compare(jb1.NameFre, jb2.NameFre); }
            }
        }
        public class CompareByLevelCode : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobGroupPositionDto jb1 = o1 as JobGroupPositionDto;
                JobGroupPositionDto jb2 = o2 as JobGroupPositionDto;
                return string.Compare(jb1.LevelCode, jb2.LevelCode);
            }
        }
        private readonly IHttpClientFactory _clientFactory;

        public JobPositionService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JobPositionDto[]> GetAllJobPositions()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>("/api/jobpositions");
        }

        public async Task<JobGroupDto> GetJobGroupById(int Id)
        {
            string url = $"/api/jobgroups/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupDto>(url);
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

        public async Task<JobCompetencyRatingDto[]> GetJobCompetencyRatingsByTypeId(int Id, int compentencytypeId)
        {
            string url = $"/api/jobpositions/{Id}/{compentencytypeId}/competencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyRatingDto[]>(url);
        }

        public async Task<JobLocationRegionDto[]> GetJobLocationRegionsById(int Id)
        {
            string url = $"/api/jobpositions/{Id}/joblocationregions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobLocationRegionDto[]>(url);
        }

        public async Task<JobCertificateDto[]> GetJobCertificatesById(int Id)
        {
            string url = $"/api/jobpositions/{Id}/certificates";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto[]>(url);
        }

        public async Task<JobGroupDto[]> GetJobGroups()
        {
            CompareByName comparebyname = new CompareByName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupDto[]>("/api/jobgroups");
            Array.Sort(list, comparebyname);
            return list;
        }

        public async Task<JobGroupPositionDto[]> GetJobGroupPositionLevelsById(int Id)
        {
            string url = $"/api/jobgroups/{Id}/grouplevels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
        }

        public async Task<JobCompetencyDto[]> GetAllJobCompetencyTypes()
        {
            string url = $"/api/jobcompetencies/types";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
        }
        public async Task<JobPositionDto[]> GetJobGroupPositionsByLevel(int Id, string level)
        {
            string url = $"/api/jobgroups/{Id}/levels/{level}/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>(url);
        }

        public async Task<JobPositionDto[]> GetJobGroupPositionsBySubGroupLevel(int Id, string subgroupcode, string level)
        {
            string url = $"/api/jobgroups/{Id}/{subgroupcode}/{level}/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>(url);
        }

        public async Task UpdateJobPosition(object Parameters)
        {
            string url = $"/api/jobpositions/updatejobposition?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }

        public async Task DeleteJobPosition(object Parameters)
        {
            string url = $"/api/jobpositions/deletejobposition?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }

        public async Task UpdateSimilarPositions(object Parameters)
        {
            string url = $"/api/similar/updatesimilarjobpositions?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }

        public async Task PostSimilarPositions(object Parameters)
        {
            string url = $"/api/similar/addsimilarjobpositions?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }

        public async Task<int[]> GetAllSimilarSearchIds()
        {
            string url = $"/api/similar/ids";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int[]>(url);
        }
    }
}