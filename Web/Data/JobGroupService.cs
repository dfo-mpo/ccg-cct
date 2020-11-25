using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Collections;

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
                JobGroup jb1 = o1 as JobGroup;
                JobGroup jb2 = o2 as JobGroup;
                if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en")
                { return String.Compare(jb1.NameEng, jb2.NameEng); }
                else { return String.Compare(jb1.NameFre, jb2.NameFre); }
            }
        }

        public async Task<JobGroup[]> GetJobGroups()
        {
            CompareByName comparebyname = new CompareByName();
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<JobGroup[]>("/api/jobgroups");
            Array.Sort(list, comparebyname);
            return list;
        }

        public async Task<JobGroup> GetJobGroupById(int Id)
        {
            string url = "/api/jobgroups/" + Id;
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroup>(url);
        }

        //api/jobgroups/{id}/levels
        public async Task<JobGroupPosition[]> GetJobGroupPositionsById(int Id)
        {
            string url = "/api/jobgroups/" + Id + "/levels";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobGroupPosition[]>(url);
        }

        //api/jobgroups/{id}/levels/{level}/positions
        public async Task<JobPosition[]> GetJobGroupPositionsByLevel(int Id, int level)
        {
            string url = "/api/jobgroups/" + Id + "/levels/" + level + "/positions";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPosition[]>(url);
        }

    }
}
