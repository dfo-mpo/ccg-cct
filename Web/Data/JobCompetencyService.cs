using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using System.Collections;
using System;

namespace Web.Data
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
        public async Task<JobCompetencyDto[]> GetJobCompetenciesByTypeId(int? TypeId)
        {
            if (TypeId.HasValue)
            {
                string url = $"/api/jobcompetencies/{TypeId}/jobcompetencies";
                using var httpClient = _clientFactory.CreateClient("api");
                return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
            }
            else return new JobCompetencyDto[]{ };
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

        public async Task<JobCompetencyDto[]> GetAllJobCompetencies()
        {
            CompareByName comparebyname = new CompareByName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobCompetencyDto[]>("/api/jobcompetencies");
            Array.Sort(list, comparebyname);
            return list;
        }
        public async Task<JobCompetencyTypeDto[]> GetJobCompetencyTypeById(int TypeId)
        {
            string url = $"/api/jobcompetencies/types/{TypeId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyTypeDto[]>(url);
        }
    }
}
