﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
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
                { return string.Compare(jb1.Code, jb2.Code); }
                else { return string.Compare(jb1.Code, jb2.Code); }
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

        public class CompareByPositionLevelCode : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobPositionDto jb1 = o1 as JobPositionDto;
                JobPositionDto jb2 = o2 as JobPositionDto;
                return string.Compare(jb1.LevelCode, jb2.LevelCode);
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

        public async Task<JobGroupDto[]> GetJobGroupsByHLCategoryId(int Id)
        {
            CompareByName comparebyname = new CompareByName();
            string url = $"/api/jobgroups/hlcategory/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupDto[]>(url);
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
            CompareByPositionLevelCode comparebylevelcode = new CompareByPositionLevelCode();
            string url = $"/api/jobgroups/{Id}/levels/{level}/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebylevelcode);
            return list;
        }

        public async Task<JobPositionDto[]> GetJobGroupPositionsBySubGroupLevel(int Id, string subgroupcode, string level)
        {
            CompareByPositionLevelCode comparebylevelcode = new CompareByPositionLevelCode();
            string url = $"/api/jobgroups/{Id}/{subgroupcode}/{level}/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebylevelcode);
            return list;
        }

        public async Task<JobPositionDto[]> GetJobPositionsByGroupId(int Id)
        {
            CompareByPositionLevelCode comparebylevelcode = new CompareByPositionLevelCode();
            string url = $"/api/jobgroups/{Id}/jobpositions";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebylevelcode);
            return list;
        }

        public async Task<JobPositionDto[]> GetJobPositionsByHLCategoryGroupId(int Id, int HLId)
        {
            CompareByPositionLevelCode comparebylevelcode = new CompareByPositionLevelCode();
            string url = $"/api/jobpositions/{Id}/{HLId}";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobPositionDto[]>(url);
            Array.Sort(list, comparebylevelcode);
            return list;
        }

        public async Task<JobGroupPositionDto[]> GetSubGroupLevelsByGroupId(int Id)
        {
            CompareByLevelCode comparebylevelcode = new CompareByLevelCode();
            string url = $"/api/jobgroups/{Id}/subgrouplevels";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
            Array.Sort(list, comparebylevelcode);
            return list;

        }

    }
}
