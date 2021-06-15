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
        public async Task PostJobCertificate(object Parameters)
        {
            string url = $"/api/jobcertificates/addjobcertificate?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
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
        public async Task PostJobCertificateDescription(object Parameters)
        {
            string url = $"/api/jobcertificates/addjobcertificatedescription?";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync<HttpResponseMessage>(url, Parameters);
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
            return await httpClient.GetJsonAsync<JobCertificateDto[]>("/api/jobcertificates/certificatedescriptions");
        }

    }
}
