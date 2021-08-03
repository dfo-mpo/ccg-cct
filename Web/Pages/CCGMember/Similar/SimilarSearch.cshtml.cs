using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;
using Business.Dtos.JobPositions;
using Business.Dtos.JobCompetencies;
using System.Collections.Generic;
using Business.Dtos.Similar;

namespace Web.Pages.CCGMember.Similar
{
    public class SimilarSearchModel : PageModel
    {
        private readonly ILogger<SimilarSearchModel> _logger;
        private readonly JobPositionService _jobpositionService;
        private readonly SimilarService _similarService;
        [BindProperty]
        public JobPositionDto Position { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        public JobCertificateDto[] PositionCertificates { get; set; }
        [BindProperty]
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        [BindProperty]
        public List<string> CertificateIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> SameLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> HigherLevelCompetencyIds { get; set; } = new List<string>();
        [BindProperty]
        public List<string> RequiredCompetencyIds { get; set; } = new List<string>();
        [BindProperty(SupportsGet = true)]
        public string Certificates { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SameLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string HigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string SubGroupCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SameOrHigherLevels { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string RequiredCompetencies { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPageSimilar { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string PreviousPage { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public Boolean PageEdit { get; set; } = false;
        [BindProperty(SupportsGet = true)]
        public string PageSubmit { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedCompetencies { get; set; } = string.Empty;
        [BindProperty]
        public List<int> AddedCompetencyValues { get; set; } = new List<int>();
        public List<int> SimilarSearchIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PercentMatch { get; set; }
        [BindProperty]
        public string RouteParameter { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PercentSelected { get; set; } = string.Empty;
       
        [BindProperty(SupportsGet = true)]
        public string PreviousPageDetails { get; set; } = string.Empty;
        public SimilarSearchDto SimilarJobIds100 { get; set; }
        public SimilarSearchDto SimilarJobIds90 { get; set; }
        public SimilarSearchDto SimilarJobIds80 { get; set; }
        public SimilarSearchDto SimilarJobIds70 { get; set; }
        public JobPositionDto[] HundredPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] NinetyPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] EightyPercentPositions { get; set; } = new JobPositionDto[] { };
        public JobPositionDto[] SeventyPercentPositions { get; set; } = new JobPositionDto[] { };

        public SimilarSearchModel(ILogger<SimilarSearchModel> logger, SimilarService similarService, JobPositionService jobcompetencyService)
        {
            _logger = logger;
            _jobpositionService = jobcompetencyService;
            _similarService = similarService;
        }
        public async Task OnGetAsync(int positionid)
        {
            _logger.LogInformation($"CCG Member Similar Search page visited at {DateTime.UtcNow.ToLongTimeString()}");
            SimilarSearchIds = await _similarService.GetAllSimilarSearchIds();
            if (SimilarSearchIds.Contains(positionid))
            {
                if (!SameLevels.Equals(string.Empty))
            {
                var ids = SameLevels.Split("&sameLevelCompetencyId=");
                foreach (var id in ids)
                {
                    SameLevelCompetencyIds.Add(id);
                }
            }
            if (!HigherLevels.Equals(string.Empty))
            {
                var ids = HigherLevels.Split("&higherLevelCompetencyId=");
                foreach (var id in ids)
                {
                    HigherLevelCompetencyIds.Add(id);
                }
            }
            if (!SameOrHigherLevels.Equals(string.Empty))
            {
                var ids = SameOrHigherLevels.Split("&sameOrHigherLevelCompetencyId=");
                foreach (var id in ids)
                {
                    HigherLevelCompetencyIds.Add(id);
                    SameLevelCompetencyIds.Add(id);
                }
            }
            if (!Certificates.Equals(string.Empty))
            {
                var ids = Certificates.Split("&certificateId=");
                foreach (var id in ids)
                {
                    CertificateIds.Add(id);
                }
            }
            if (!RequiredCompetencies.Equals(string.Empty))
            {
                var ids = RequiredCompetencies.Split("&requiredCompetencyId=");
                foreach (var id in ids)
                {
                    RequiredCompetencyIds.Add(id);
                }
            }
            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);
                    }

                }
            }
            Position = await _jobpositionService.GetJobPositionById(positionid);
            PositionCertificates = await _jobpositionService.GetJobCertificatesById(positionid);
            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes)
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }

            foreach (var c in CertificateIds)
            {
                Certificates += "&certificateId=" + c;
            }
            foreach (var c in RequiredCompetencyIds)
            {
                RequiredCompetencies += "&requiredCompetencyId=" + c;
            }
            foreach (var c in SameLevelCompetencyIds)
            {

                if (!HigherLevelCompetencyIds.Contains(c))
                {
                    SameLevels += "&sameLevelCompetencyId=" + c;
                }
                else
                {
                    SameOrHigherLevels += "&sameOrHigherLevelCompetencyId=" + c;
                }
            }
            foreach (var c in HigherLevelCompetencyIds)
            {
                if (!SameLevelCompetencyIds.Contains(c))
                {
                    HigherLevels += "&higherLevelCompetencyId=" + c;
                }
            }
                if (!string.IsNullOrEmpty(PercentMatch)) {
                    Position = await _similarService.GetJobPositionById(PositionId);
                    if (PercentMatch == "&percentMatch=100")
                    {
                        SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds90 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                        SimilarJobIds80 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                        SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                    }
                    else if (PercentMatch == "&percentMatch=90")
                    {
                        SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds80 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                        SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                    }
                    else if (PercentMatch == "&percentMatch=80")
                    {
                        SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds80 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                    }
                    else
                    {
                        SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds80 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                        SimilarJobIds70 = await _similarService.GetAllSeventyPercentSimilarPositionsByPositionId(positionid);

                    }

                    RouteParameter = String.Format($"jobPositionId={positionid}{RequiredCompetencies}{SameLevels}{HigherLevels}{SameOrHigherLevels}{AddedCompetencies}{Certificates}{PercentMatch}");
                    HundredPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds100?.SimilarPositionIds}");
                    NinetyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds90?.SimilarPositionIds}");
                    EightyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds80?.SimilarPositionIds}");
                    SeventyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds70?.SimilarPositionIds}");

                }
                else
                {
                    SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                    SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                    SimilarJobIds80 = await _similarService.GetAllEightyPercentSimilarPositionsByPositionId(positionid);
                    SimilarJobIds70 = await _similarService.GetAllSeventyPercentSimilarPositionsByPositionId(positionid);
                if(SimilarJobIds100.SimilarPositionIds == "" && SimilarJobIds90.SimilarPositionIds == "" && SimilarJobIds80.SimilarPositionIds == "" && SimilarJobIds70.SimilarPositionIds == "")
                    {
                        PageSubmit = "Error";
                    }
                }
            }
            else
            {
                PageSubmit = "Error";
            }
            
        }
        public async Task OnPost(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
            SameLevels = string.Empty;
            HigherLevels = string.Empty;
            SameOrHigherLevels = string.Empty;
            RequiredCompetencies = string.Empty;
            Certificates = string.Empty;

            foreach (var c in CertificateIds)
            {
                Certificates += "&certificateId=" + c;
            }
            foreach (var c in RequiredCompetencyIds)
            {
                RequiredCompetencies += "&requiredCompetencyId=" + c;
            }
            foreach (var c in SameLevelCompetencyIds)
            {

                if (!HigherLevelCompetencyIds.Contains(c))
                {
                    SameLevels += "&sameLevelCompetencyId=" + c;
                }
                else
                {
                    SameOrHigherLevels += "&sameOrHigherLevelCompetencyId=" + c;
                }
            }
            foreach (var c in HigherLevelCompetencyIds)
            {
                if (!SameLevelCompetencyIds.Contains(c))
                {
                    HigherLevels += "&higherLevelCompetencyId=" + c;
                }
            }
        }
        public void OnPostCompetency(string competencyid)
        {
            PageEdit = true;
            AddedCompetencies += "&addedCompetencyId=" + competencyid;

            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);

                    }

                }
            }

        }
        public void OnPostClear()
        {
            PageEdit = true;
            AddedCompetencies = string.Empty;
        }
        public void OnPostDelete(int competencyid)
        {
            PageEdit = true;
            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);
                    }
                }
            }
            AddedCompetencyValues.Remove(competencyid);
            AddedCompetencies = string.Empty;
            foreach (var id in AddedCompetencyValues)
            {
                AddedCompetencies += "&addedCompetencyId=" + id.ToString();
            }
        }
        public async Task OnPostEdit(int positionid)
        {
            Position = await _jobpositionService.GetJobPositionById(positionid);
            SameLevels = string.Empty;
            HigherLevels = string.Empty;
            SameOrHigherLevels = string.Empty;
            RequiredCompetencies = string.Empty;
            Certificates = string.Empty;

            foreach (var c in CertificateIds)
            {
                Certificates += "&certificateId=" + c;
            }
            foreach (var c in RequiredCompetencyIds)
            {
                RequiredCompetencies += "&requiredCompetencyId=" + c;
            }
            foreach (var c in SameLevelCompetencyIds)
            {
                if (!HigherLevelCompetencyIds.Contains(c))
                {
                    SameLevels += "&sameLevelCompetencyId=" + c;
                }
                else
                {
                    SameOrHigherLevels += "&sameOrHigherLevelCompetencyId=" + c;
                }
            }
            foreach (var c in HigherLevelCompetencyIds)
            {
                if (!SameLevelCompetencyIds.Contains(c))
                {
                    HigherLevels += "&higherLevelCompetencyId=" + c;
                }
            }
            // PageSubmit = true;
            PageEdit = true;
            Position = await _jobpositionService.GetJobPositionById(positionid);
            var CompetencyTypes = await _jobpositionService.GetAllJobCompetencyTypes();
            foreach (var competencytype in CompetencyTypes)
            {
                var competencies = await _jobpositionService.GetJobCompetencyRatingsByTypeId(positionid, competencytype.Id);
                if (!competencies.Equals(null))
                {
                    PositionCompetencyRatings.Add(competencies);
                }
            }
            foreach (var added in AddedCompetencies.Split("&addedCompetencyId="))
            {
                if (!string.IsNullOrEmpty(added))
                {
                    int number;
                    bool success = Int32.TryParse(added, out number);
                    if (success)
                    {
                        AddedCompetencyValues.Add(number);

                    }

                }
            }

        }

        public async Task OnPostSubmit(int positionid)
        {
            _logger.LogInformation($"CCG Member Similar positions list page visited at {DateTime.UtcNow.ToLongTimeString()}");
            SameLevels = string.Empty;
            HigherLevels = string.Empty;
            SameOrHigherLevels = string.Empty;
            RequiredCompetencies = string.Empty;
            Certificates = string.Empty;
            PageSubmit = "true";
            PreviousPageDetails = "SimilarSearch";
            PercentSelected = "true";
            Position = await _similarService.GetJobPositionById(PositionId);
            foreach (var c in CertificateIds)
            {
                Certificates += "&certificateId=" + c;
            }
            foreach (var c in RequiredCompetencyIds)
            {
                RequiredCompetencies += "&requiredCompetencyId=" + c;
            }
            foreach (var c in SameLevelCompetencyIds)
            {

                if (!HigherLevelCompetencyIds.Contains(c))
                {
                    SameLevels += "&sameLevelCompetencyId=" + c;
                }
                else
                {
                    SameOrHigherLevels += "&sameOrHigherLevelCompetencyId=" + c;
                }
            }
            foreach (var c in HigherLevelCompetencyIds)
            {
                if (!SameLevelCompetencyIds.Contains(c))
                {
                    HigherLevels += "&higherLevelCompetencyId=" + c;
                }
            }
            if (PercentMatch == "&percentMatch=100")
            {
                SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds90 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                SimilarJobIds80 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
            }
            else if (PercentMatch == "&percentMatch=90")
            {
                SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds80 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
                SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
            }
            else if (PercentMatch == "&percentMatch=80")
            {
                SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds80 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds70 = new SimilarSearchDto() { SimilarPositionIds = string.Empty };
            }
            else
            {
                SimilarJobIds100 = await _similarService.GetAllHundredPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds90 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds80 = await _similarService.GetAllNinetyPercentSimilarPositionsByPositionId(positionid);
                SimilarJobIds70 = await _similarService.GetAllSeventyPercentSimilarPositionsByPositionId(positionid);

            }

            RouteParameter = String.Format($"jobPositionId={positionid}{RequiredCompetencies}{SameLevels}{HigherLevels}{SameOrHigherLevels}{AddedCompetencies}{Certificates}{PercentMatch}");
            HundredPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds100?.SimilarPositionIds}");
            NinetyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds90?.SimilarPositionIds}");
            EightyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds80?.SimilarPositionIds}");
            SeventyPercentPositions = await _similarService.GetAllSimilarJobPositionsByPositionId($"{RouteParameter}&{SimilarJobIds70?.SimilarPositionIds}");
        }
    }

}

