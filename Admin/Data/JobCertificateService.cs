using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.JobCompetencies;
using System.Collections;
using System;
using Business.Dtos.JobGroups;

namespace Admin.Data
{
    public class JobCertificateService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public JobCertificateService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
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
        public async Task<JobCertificateDto> GetJobCertificateDescriptionById(int Id)
        {
            string url = $"/api/jobcertificates/descriptions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto>(url);
        }
        public async Task<int> PostJobCertificate(string NameEng, string NameFre, string DescEng, string DescFre)
        {
            string url = $"/api/jobcertificates/addjobcertificate/{NameEng}/{NameFre}/{DescEng}/{DescFre}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int>(url);
        }
        public async Task UpdateJobCertificate(object Parameters)
        {
            string url = $"/api/jobcertificates/updatejobcertificate?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task DeleteJobCertificate(object Parameters)
        {
            string url = $"/api/jobcertificates/deletejobcertificate?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task<int> PostJobCertificateDescription(string DescEng, string DescFre)
        {
            string url = $"/api/jobcertificates/addjobcertificatedescription/{DescEng}/{DescFre}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<int>(url);
        }
        public async Task UpdateJobCertificateDescription(object Parameters)
        {
            string url = $"/api/jobcertificates/updatejobcertificatedescription?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
        }
        public async Task<JobCertificateDto[]> GetAllJobCertificateDescriptions()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto[]>("/api/jobcertificates/descriptions");
        }

    }
}
