﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Business.Dtos.Shared;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;

namespace Web.Data
{
    public class CompareService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CompareService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JobPositionDto> GetJobPositionById(int Id)
        {
            string url = $"/api/jobpositions/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobPositionDto>(url);
        }

        public async Task<JobLocationRegionDto[]> GetMatchingJobLocationRegionsByPositionId(int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/matching/joblocationregions/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobLocationRegionDto[]>(url);
        }

        public async Task<SharedJobLocationRegionDto[]> GetDifferingJobLocationRegionsByPositionId(int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/differing/joblocationregions/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SharedJobLocationRegionDto[]>(url);
        }

        public async Task<SharedJobCompetencyRating[]> GetMatchingCompetenciesByTypeId(int TypeId, int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/matching/competencies/{TypeId}/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SharedJobCompetencyRating[]>(url);
        }

        public async Task<SharedJobCompetencyRating[]> GetDifferingCompetenciesByTypeId(int TypeId, int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/differing/competencies/{TypeId}/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SharedJobCompetencyRating[]>(url);
        }

        public async Task<JobCertificateDto[]> GetMatchingCertificatesByPositionId(int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/matching/certificates/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCertificateDto[]>(url);
        }

        public async Task<SharedJobCertificateDto[]> GetDifferingCertificatesByPositionId(int PositionId, int ObjectiveId)
        {
            string url = $"/api/compare/differing/certificates/{PositionId}/{ObjectiveId}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<SharedJobCertificateDto[]>(url);
        }

        public async Task<JobCompetencyDto[]> GetAllJobCompetencyTypes()
        {
            string url = $"/api/jobcompetencies/types";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<JobCompetencyDto[]>(url);
        }

    }
}
