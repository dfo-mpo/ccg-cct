using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobGroups;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Business.Dtos.JobPositions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DataModel.CustomValidation;

namespace Admin.Pages.Positions
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;
        private readonly JobCertificateService _jobCertificateService;

        public CreateModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService, JobCertificateService jobCertificateService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
            _jobCertificateService = jobCertificateService;
        }

        [BindProperty]
        public JobPosition JobPosition { get; set; }
        public List<JobCertificateDto> AddedCertificates = new List<JobCertificateDto>() { };
        public JobCompetencyDto[] JobCompetenciesKnowledge { get; set; }
        public JobCompetencyDto[] JobCompetenciesTechnical { get; set; }
        public JobCompetencyDto[] JobCompetenciesBehavioural { get; set; }
        public JobCompetencyDto[] JobCompetenciesExecutive { get; set; }
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        public List<JobCompetencyRatingDto> AddedKnowledgeCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedTechnicalCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedBehaviouralCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedExecutiveCompetencies = new List<JobCompetencyRatingDto>() { };
        [BindProperty]
        public JobCertificateDto[] JobCertificateDescriptions { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int JobGroupId { get; set; } = 2;
        [BindProperty(SupportsGet = true)]
        public string TitleEng { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string TitleFre { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string DescriptionEng { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string DescriptionFre { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedCertificateIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedKnowledgeCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedTechnicalCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedBehaviouralCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedExecutiveCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string RegionIds { get; set; } = string.Empty;
        [BindProperty]
        public JobGroupDto[] JobGroups { get; set; }
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobCertificateDto[] JobCertificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JobHLCategory { get; set; }
        [BindProperty]
        [CheckOneRegionSelected]
        public List<string> SelectedRegionIds { get; set; } = new List<string> { };
        [BindProperty(SupportsGet = true)]
        public int JobGroupLevelId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SubJobGroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelValue { get; set; }

        // Normally, the three private properties shouldn't be accessible, but it was necessary in order to use the partial view

        public CctDbContext GetContext()
        {
            return _context;
        }

        public JobCompetencyService GetJobCompetencyService()
        {
            return _jobCompetencyService;
        }

        public JobCertificateService GetJobCertificateService()
        {
            return _jobCertificateService;
        }

        public async Task OnGetAsync()
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            CurrentSelectedJobGroup = JobGroups[0];
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroups[0].Id);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;

        }
        public async Task OnPostGroup()
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }

        }
        public async Task OnPostCertificate()
        {

            var certificate = Request.Form["certificate"];
            var certificatedescId = Request.Form["CertificateDescriptionId"];
            AddedCertificateIds += certificate[0] + "&" + certificatedescId[0] + "-";
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
        }
        public async Task OnPostCompetency(string competencytypename)
        {         
            var Id = Request.Form[$"{competencytypename}Competency"];
            var level = Request.Form[$"{competencytypename}Level"];
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            if (competencytypename == "knowledge")
            {
                AddedKnowledgeCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "technical")
            {
                AddedTechnicalCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "behavioural")
            {
                AddedBehaviouralCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "executive")
            {
                AddedExecutiveCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
        }

        public async Task OnPostDeleteCertificate(int certificateid)
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];            
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    if (cidInt != certificateid)
                    {
                        var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                        var certificateDescDto = await _jobCertificateService.GetJobCertificateDescriptionById(int.Parse(cid.Split("&")[1]));
                        certificateDto.CertificateDescId = certificateDescDto.Id;
                        if (certificateDescDto.Active == 1)
                        {
                            certificateDto.DescEng = certificateDescDto.DescEng;
                            certificateDto.DescFre = certificateDescDto.DescFre;
                        }
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
            AddedCertificateIds = string.Empty;
            foreach (var certificate in AddedCertificates)
            {
                AddedCertificateIds += certificate.Id + "&" + certificate.CertificateDescId + "-";
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }

        }
        public async Task OnPostDelete(int competencyid)
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            if (competency != null)
                            {
                                AddedKnowledgeCompetencies.Add(competency);
                            }
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            if (competency != null)
                            {
                                AddedBehaviouralCompetencies.Add(competency);
                            }
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            if (competency != null)
                            {
                                AddedTechnicalCompetencies.Add(competency);
                            }
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            if (competency != null)
                            {
                                AddedExecutiveCompetencies.Add(competency);
                            }
                        }
                    }
                }
            }
            AddedKnowledgeCompetencyIds = string.Empty;
            AddedTechnicalCompetencyIds = string.Empty;
            AddedBehaviouralCompetencyIds = string.Empty;
            AddedExecutiveCompetencyIds = string.Empty;
            foreach (var competency in AddedKnowledgeCompetencies)
            {
                AddedKnowledgeCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedTechnicalCompetencies)
            {
                AddedTechnicalCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedBehaviouralCompetencies)
            {
                AddedBehaviouralCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedExecutiveCompetencies)
            {
                AddedExecutiveCompetencyIds += competency.CompetencyId + "&" + (competency.RatingValue + 5) + "-";
            }
        }
        public async Task<IActionResult> OnPostCreateAsync()
        {
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            var acceptedRegionIds = _context.JobLocationRegions.Select(x => x.Id).ToList();
            foreach (var id in SelectedRegionIds.Distinct())
            {
                if (int.TryParse(id, out int intId))
                {
                    if (acceptedRegionIds.Contains(intId))
                    {
                        RegionIds += id + "-";
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }

            bool validModel = false;

            if (ModelState.IsValid || ModelState.ErrorCount == 1)   // the ModelState seems to always have at least one error, but it's something
                                                                    // that should not matter
            {
                validModel = true;
            }

            if (!validModel)    // the model can't be validated right at the beginning of this function, otherwise the DTO
                                // won't be in the proper state, since its properties won't have been set, yet
            {
                return Page();
            }

            var parameters = string.Format($"&titleEng={TitleEng}&titleFre={TitleFre}&descriptionEng={DescriptionEng}&descriptionFre={DescriptionFre}");
            var jobPositionId = await _jobCompetencyService.PostJobPositionGetId(parameters);

            var jobGroupPosition = new JobGroupPosition()
            {
                JobGroupId = JobGroupId,
                JobPositionId = jobPositionId,
                SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
            };
             _jobCompetencyService.PostJobGroupPosition(jobGroupPosition);
            foreach(var competency in AddedKnowledgeCompetencies)
            {
                var jobrolepositioncompetency = new JobRolePositionCompetencyRating() { 
                    JobPositionId = jobPositionId,              
                    CompetencyId = competency.CompetencyId,
                    CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                    CompetencyTypeId = 1,
                    CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                    SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                    JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                    JobGroupId = JobGroupId
                };
               _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
            }
                foreach (var competency in AddedTechnicalCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,
                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 2,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
                foreach (var competency in AddedBehaviouralCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,
                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 3,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
                foreach (var competency in AddedExecutiveCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,
                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 4,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
                foreach(var id in SelectedRegionIds)
                {
                    var jobrolepositionlocation = new JobRolePositionLocation()
                    {
                        JobLocationRegionId = int.Parse(id),
                        JobGroupId = JobGroupId,
                        JobPositionId = jobPositionId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1])                      
                    };
                    _jobCompetencyService.PostJobRolePositionLocation(jobrolepositionlocation);
                }

                var acceptedHLCategoryIds = _context.JobHLCategories.Select(x => x.Id).ToList();
                if (int.TryParse(JobHLCategory, out int jobHLId))
                {
                    if (!acceptedHLCategoryIds.Contains(jobHLId))
                    {
                        JobHLCategory = "1";
                    }
                }
                var jobrolepositionhlcategory = new JobRolePositionHLCategory()
                {
                    JobGroupId = JobGroupId,
                    JobPositionId = jobPositionId,
                    SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                    JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                    JobHLCategoryId = int.Parse(JobHLCategory)
                };
                _jobCompetencyService.PostJobRolePositionHLCategory(jobrolepositionhlcategory);
                foreach(var certificate in AddedCertificates)
                {
                    var jobrolepositioncertificate = new JobRolePositionCertificate()
                    {
                        JobPositionId = jobPositionId,
                        JobGroupId = JobGroupId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        CertificateDescriptionId = certificate.CertificateDescId,
                        CertificateId = certificate.Id,
                    };
                    _jobCompetencyService.PostJobRolePositionCertificate(jobrolepositioncertificate);

                }
            Thread.Sleep(10000);
            return RedirectToPage("Details", new { positionid = jobPositionId });
        }

    }
}