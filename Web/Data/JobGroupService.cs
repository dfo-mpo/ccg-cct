using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Collections;
using Business.Dtos.JobGroups;
using Business.Dtos.JobPositions;

namespace Web.Data 
{
    public class JobGroupService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobGroupService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public class CompareByName : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobGroupDto jb1 = o1 as JobGroupDto;
                JobGroupDto jb2 = o2 as JobGroupDto;
                if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en")
                { return String.Compare(jb1.NameEng, jb2.NameEng); }
                else { return String.Compare(jb1.NameFre, jb2.NameFre); }
            }
        }

        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }

        public async Task<JobGroupDto[]> GetJobGroups()
        {
            CompareByName comparebyname = new CompareByName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupDto[]>("/api/jobgroups");
            Array.Sort(list, comparebyname);
            return list;
        }

        public async Task<JobGroupDto> GetJobGroupById(int Id)
        {
            string url = $"/api/jobgroups/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupDto>(url);
        }

        public async Task<JobGroupPositionDto[]> GetJobGroupPositionsById(int Id)
        {
            string url = $"/api/jobgroups/{Id}/levels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
        }

        public async Task<JobPositionDto[]> GetJobGroupPositionsByLevel(int Id, string level)
        {
            string url = $"/api/jobgroups/{Id}/levels/{level}/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto[]>(url);
        }

    }
}
