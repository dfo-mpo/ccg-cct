﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using System.Collections;
using System;
using Business.Dtos.JobGroups;
using DataModel;

namespace Admin.Data
{
    public class JobCompetencyService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobCompetencyService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public class CompareByName : IComparer
        {
            int IComparer.Compare(object o1, object o2)
            {
                JobCompetencyDto jb1 = o1 as JobCompetencyDto;
                JobCompetencyDto jb2 = o2 as JobCompetencyDto;
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
        public class CompareByGroupName : IComparer
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
        public async Task<JobGroupDto[]> GetJobGroups()
        {
            CompareByGroupName comparebyname = new CompareByGroupName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupDto[]>("/api/jobgroups");
            Array.Sort(list, comparebyname);
            return list;
        }
        public async Task<JobCertificateDto[]> GetJobCertificates()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobCertificateDto[]>("/api/jobcertificates");
            return list;
        }
        public async Task<JobCertificateDto> GetJobCertificateById(int Id)
        {

            string url = $"/api/jobcertificates/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto>(url);

        }

        public async Task<JobGroupDto> GetJobGroupById(int Id)
        {
            string url = $"/api/jobgroups/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupDto>(url);
        }
        public async Task<JobCompetencyDto[]> GetJobCompetenciesByTypeId(int? TypeId)
        {

            string url = $"/api/jobcompetencies/{TypeId}/jobcompetencies";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
        }

        public async Task<JobCompetencyDto> GetJobCompetencyById(int? Id)
        {
            if (Id.HasValue)
            {
                string url = $"/api/jobcompetencies/{Id}";
                using var httpClient = _clientFactory.CreateClient("api");
                return await httpClient.GetJsonAsync<JobCompetencyDto>(url);
            }
            else return new JobCompetencyDto { };
        }
        public async Task<JobCompetencyRatingDto> GetJobCompetencyLevelByIdLevelId(int? Id, int? LevelId)
        {
            if (Id.HasValue)
            {
                string url = $"/api/jobcompetencies/{Id}/{LevelId}";
                using var httpClient = _clientFactory.CreateClient("api");
                return await httpClient.GetJsonAsync<JobCompetencyRatingDto>(url);
            }
            else return new JobCompetencyRatingDto { };
        }
        public async Task<JobCompetencyRatingDto> GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(int? Id, int? Value)
        {
            if (Value.HasValue)
            {
                string url = $"/api/jobcompetencies/{Id}/{Value}/description";
                using var httpClient = _clientFactory.CreateClient("api");
                return await httpClient.GetJsonAsync<JobCompetencyRatingDto>(url);
            }
            else return new JobCompetencyRatingDto { };
        }
        public async Task<JobCompetencyDto[]> GetAllJobCompetencies()
        {
            CompareByName comparebyname = new CompareByName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobCompetencyDto[]>("/api/jobcompetencies");
            Array.Sort(list, comparebyname);
            return list;
        }
        public async Task<JobCertificateDto[]> GetAllJobCertificateDescriptions()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto[]>("/api/jobcertificates/descriptions");
        }
        public async Task<JobCompetencyTypeDto> GetJobCompetencyTypeById(int TypeId)
        {
            string url = $"/api/jobcompetencies/types/{TypeId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyTypeDto>(url);
        }
        public async Task<int> PostJobCompetency(string Parameters)
        {
            string url = $"/api/jobcompetencies/addjobcompetency?{Parameters}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int>(url);
        }
        public async Task PostJobRolePositionCompetency(object Parameters)
        {
            string url = $"/api/jobpositions/addjobrolepositioncompetency?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task PostJobRolePositionLocation(object Parameters)
        {
            string url = $"/api/jobpositions/addjobrolepositionlocation?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task PostJobRolePositionCertificate(object Parameters)
        {
            string url = $"/api/jobpositions/addjobrolepositioncertificate?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task PostJobRolePositionHLCategory(object Parameters)
        {
            string url = $"/api/jobpositions/addjobrolepositionhlcategory?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task PostJobGroupPosition(object Parameters)
        {
            string url = $"/api/jobgroups/addjobgroupposition?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task PostJobPosition(object Parameters)
        {
            string url = $"/api/jobpositions/addjobposition?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);

        }
        public async Task<JobGroupPositionDto[]> GetJobGroupPositionsById(int Id)
        {
            string url = $"/api/jobgroups/{Id}/levels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
        }
        public async Task<int> PostJobPositionGetId(string TitleEng, string TitleFre)
        {
            string url = $"/api/jobpositions/postjobpositionreturnid/{TitleEng}/{TitleFre}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int>(url);
        }
        public async Task<JobGroupPositionDto[]> GetSubGroupLevelsByGroupId(int Id)
        {
            CompareByLevelCode comparebyname = new CompareByLevelCode();
            string url = $"/api/jobgroups/{Id}/subgrouplevels";
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
            Array.Sort(list, comparebyname);
            return list;

        }
        public async Task<int> GetJobPositionIdByTitle(string Title)
        {
            string url = $"/api/jobpositions/getjobpositionid/{Title}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int>(url);
        }
        public async Task UpdateJobCompetency(object Parameters)
        {
            string url = $"/api/jobcompetencies/updatejobcompetency?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task DeleteJobCompetency(object Parameters)
        {
            string url = $"/api/jobcompetencies/deletejobcompetency?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task<JobGroupPositionDto[]> GetJobGroupPositionLevelsById(int Id)
        {
            string url = $"/api/jobgroups/{Id}/grouplevels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPositionDto[]>(url);
        }
    }
}

