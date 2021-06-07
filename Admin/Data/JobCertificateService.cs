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
    }
}
