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
        private readonly JobPositionService _jobPositionService;

        public CreateModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService, JobCertificateService jobCertificateService, JobPositionService jobPositionService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
            _jobCertificateService = jobCertificateService;
            _jobPositionService = jobPositionService;
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

        [BindProperty]
        public JobPositionDto CurrentJobPosition { get; set; } // used by the "save a copy" feature
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobCertificateDto[] JobCertificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JobHLCategory { get; set; }
        [BindProperty]
        public List<string> SelectedRegionIds { get; set; } = new List<string> { };
        [BindProperty(SupportsGet = true)]
        public int JobGroupLevelId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SubJobGroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelValue { get; set; }

        // Normally, the four private properties shouldn't be accessible, but it was necessary in order to use the partial view

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

        public JobPositionService GetJobPositionService()
        {
            return _jobPositionService;
        }

        private async Task ValidateModel()
        {
            var errEng = await CheckUniquePositionName(JobPosition);
            if (errEng != null)
            {
                ModelState.AddModelError("JobPosition.TitleEng", errEng);
            }
            var errFre = await CheckUniquePositionName(JobPosition, false);
            if (errFre != null)
            {
                ModelState.AddModelError("JobPosition.TitleFre", errFre);
            }

            bool oneRegionSelected = !string.IsNullOrWhiteSpace(RegionIds);

            bool atLeastOneComp = (
                (!string.IsNullOrWhiteSpace(AddedKnowledgeCompetencyIds)) ||
                (!string.IsNullOrWhiteSpace(AddedTechnicalCompetencyIds)) ||
                (!string.IsNullOrWhiteSpace(AddedBehaviouralCompetencyIds)) ||
                (!string.IsNullOrWhiteSpace(AddedExecutiveCompetencyIds))
                );

            if (!atLeastOneComp)
            {
                ModelState.AddModelError("AddedBehaviouralCompetencyIds", "Make sure that at least one competency has been added");
            }

            if (!oneRegionSelected)
            {
                ModelState.AddModelError("SelectedRegionIds", "Make sure that at least one region is selected");
            }
        }

        public async Task<List<JobPositionDto>> GetAllJobs()
        {
            return (await _jobPositionService.GetAllJobPositions()).ToList();
        }

        private async Task<string> CheckUniquePositionName(JobPosition position, bool checkEnglish = true)
        {
            if (position == null)
            {
                return null;
            }

            var pos = position;

            var positionsOfLevel = (await GetAllJobs()).Where(x => x.LevelCode.ToLower() == LevelCode.ToLower()).ToList();

            if (positionsOfLevel.Any())
            {
                var activeJobs = positionsOfLevel.Where(x => x.Active == 1 && x.JobTitleId != pos.Id).ToList();
                var inactiveJobs = positionsOfLevel.Where(x => x.Active == 0 && x.JobTitleId != pos.Id).ToList();

                if (checkEnglish)
                {
                    if (!string.IsNullOrWhiteSpace(pos.TitleEng))
                    {
                        if (activeJobs.Select(x => x.JobTitleEng.ToLowerInvariant()).Contains(pos.TitleEng.ToLowerInvariant()))
                        {
                            return "A position in the level " + LevelCode.ToUpper() + " already has that English title";
                        }
                        else if (inactiveJobs.Select(x => x.JobTitleEng.ToLowerInvariant()).Contains(pos.TitleEng.ToLowerInvariant()))
                        {
                            return "A position in the level " + LevelCode.ToUpper() + " already has that English title, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(pos.TitleFre))
                    {
                        if (activeJobs.Select(x => x.JobTitleFre.ToLowerInvariant()).Contains(pos.TitleFre.ToLowerInvariant()))
                        {
                            return "A position in the level " + LevelCode.ToUpper() + " already has that French title";
                        }
                        else if (inactiveJobs.Select(x => x.JobTitleFre.ToLowerInvariant()).Contains(pos.TitleFre.ToLowerInvariant()))
                        {
                            return "A position in the level " + LevelCode.ToUpper() + " already has that French title, but it was deleted. " +
                            "If you wish to enable it once again, contact technical support";
                        }
                    }
                }
            }

            return null;
        }

        private async Task PreparePageModel(int compIdToIgnore = 0, int certIdToIgnore = 0)
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);

            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();

            JobGroups = await _jobCompetencyService.GetJobGroups();

            if (!_context.JobGroups.Select(x => x.Id).Contains(JobGroupId))
            {
                JobGroupId = JobGroups[0].Id;
            }

            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;

            var acceptedRegionsIds = await _context.JobLocationRegions.Where(x => x.Active == 1).Select(x => x.Id).ToListAsync();
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds.Distinct().ToList())
            {
                int regionInt = 0;
                try
                {
                    regionInt = int.Parse(id);
                }
                catch
                {
                    regionInt = 0;
                }

                if (acceptedRegionsIds.Contains(regionInt))
                {
                    RegionIds += id + "-";
                } 
            }

            string[] compIdsArray = { AddedKnowledgeCompetencyIds, AddedTechnicalCompetencyIds, 
                AddedBehaviouralCompetencyIds, AddedExecutiveCompetencyIds};
            List<JobCompetencyRatingDto>[] compsArray = { AddedKnowledgeCompetencies, AddedTechnicalCompetencies,
                AddedBehaviouralCompetencies, AddedExecutiveCompetencies };

            for (int i = 0; i < compIdsArray.Length; i++)
            {
                var ids = compIdsArray[i];
                var compType = compsArray[i];

                foreach (var cid in ids.Split("-").Distinct())
                {
                    if (!string.IsNullOrEmpty(cid))
                    {
                        if (cid.Contains("&"))
                        {
                            var cidc = cid.Split("&")[0];
                            var clevel = cid.Split("&")[1];

                            if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                            {
                                try
                                {
                                    var cidInt = int.Parse(cidc);
                                    if (cidInt != compIdToIgnore)
                                    {
                                        var cLevel = int.Parse(clevel);
                                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                                        if (competency != null)
                                        {
                                            if (competency.Active == 1)
                                            {
                                                compType.Add(competency);
                                            }
                                        }
                                    }
                                }
                                catch 
                                {
                                    compIdToIgnore = -10;
                                }
                            }
                        }
                    }
                }
            }

            if (compIdToIgnore != 0)
            {
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

            foreach (var cid in AddedCertificateIds.Split("-").Distinct())
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    if (cid.Contains("&"))
                    {
                        try
                        {
                            var cidInt = int.Parse(cid.Split("&")[0]);
                            if (cidInt != certIdToIgnore)
                            {
                                var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                                if (certificateDto != null)
                                {
                                    if (certificateDto.Active == 1)
                                    {
                                        var certificateDescDto = await _jobCertificateService.GetJobCertificateDescriptionById(int.Parse(cid.Split("&")[1]));
                                        if (certificateDescDto != null)
                                        {
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
                            }
                        }
                        catch 
                        {
                            certIdToIgnore = -10;
                        }
                    }
                }
            }
            if (certIdToIgnore != 0)
            {
                AddedCertificateIds = string.Empty;
                foreach (var certificate in AddedCertificates)
                {
                    AddedCertificateIds += certificate.Id + "&" + certificate.CertificateDescId + "-";
                }
            }

            await ValidateModel();
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            // the id paremeter corresponds to the id of the position you want to copy (if applicable)

            bool savePositonsAs = false;
            if (id != null)
            {
                JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == id);
                if (JobPosition != null)
                {
                    if (JobPosition.Active == 1)
                    {
                        savePositonsAs = true;
                    }
                } 
            }

            if (savePositonsAs)
            {
                Id = 0;
                JobPosition.TitleEng = "";
                JobPosition.TitleFre = "";

                CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(id.Value);
                var PositionCertificates = await _jobCompetencyService.GetJobCertificatesById(id.Value);
                var jobHLCategory = await _jobCompetencyService.GetJobPositionHLCategoryIdByPositionId(id.Value);
                JobHLCategory = jobHLCategory.ToString();
                var selectedRegionIds = await _jobCompetencyService.GetJobLocationRegionsById(id.Value);
                foreach (var rid in selectedRegionIds)
                {
                    RegionIds += rid.JobLocationRegionId.ToString() + "-";
                    SelectedRegionIds.Add(rid.ToString());
                }
                if (PositionCertificates != null)
                {
                    foreach (var certificate in PositionCertificates)
                    {
                        if (certificate != null)
                        {
                            if (certificate.Active == 1)
                            {
                                var certDesc = _context.CertificateDescriptions.Where(x => x.Id == certificate.CertificateDescId).FirstOrDefault();
                                if (certDesc.Active != 1)
                                {
                                    certificate.DescFre = "";
                                    certificate.DescEng = "";
                                }
                                AddedCertificateIds += certificate.Id + "&" + certificate.CertificateDescId + "-";
                                AddedCertificates.Add(certificate);
                            }
                        }
                    }
                }

                string[] compIdsArray = new string[4];
                List<JobCompetencyRatingDto>[] compsArray = { AddedKnowledgeCompetencies, AddedTechnicalCompetencies,
                    AddedBehaviouralCompetencies, AddedExecutiveCompetencies};

                for (int i = 0; i < compIdsArray.Length; i++)
                {
                    bool exec = (i == compsArray.Length - 1);

                    var compType = compsArray[i];

                    var competenciesOfType = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(id.Value, i + 1);
                    if (competenciesOfType != null)
                    {
                        foreach (var competency in competenciesOfType)
                        {
                            if (competency != null)
                            {
                                if (!exec)
                                {
                                    compIdsArray[i] += competency.CompetencyId + "&" + competency.CompetencyRatingLevelId + "-";
                                }
                                else
                                {
                                    compIdsArray[i] += competency.CompetencyId + "&" + (competency.CompetencyRatingLevelId +
                                        (competency.CompetencyRatingLevelId <= 5 ? 5 : 0)) + "-";
                                }
                                compType.Add(competency);
                            }
                        }
                    }
                }
                AddedKnowledgeCompetencyIds = compIdsArray[0];
                AddedTechnicalCompetencyIds = compIdsArray[1];
                AddedBehaviouralCompetencyIds = compIdsArray[2];
                AddedExecutiveCompetencyIds = compIdsArray[3];

                JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
                JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
                JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
                JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
                JobCertificates = await _jobCompetencyService.GetJobCertificates();
                JobGroups = await _jobCompetencyService.GetJobGroups();
                JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
                JobGroupId = CurrentJobPosition.JobGroupId;
                CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(CurrentJobPosition.JobGroupId);
                JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
                SubJobGroupId = CurrentJobPosition.SubJobGroupId;
                JobGroupLevelId = CurrentJobPosition.JobGroupLevelId;
                LevelCode = CurrentJobPosition.LevelCode;
            }
            else
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

               // Since every position has all behavioural elements, they get added here by default to save time

                var behavComps = (await _jobCompetencyService.GetJobCompetenciesByTypeId(3)).Where(x => x.Active == 1).ToList();
                var levelOneRating = await _context.CompetencyRatingLevels.Where(x => x.Value == 1).FirstOrDefaultAsync();

                string behavIds = "";

                foreach (var comp in behavComps)
                {
                    var compRatingGroup = await _context.CompetencyRatingGroups
                        .Where(x => x.CompetencyId == comp.Id && x.CompetencyRatingLevelId == 1).FirstOrDefaultAsync();

                    var compWithDescs = await _jobCompetencyService.GetJobCompetencyById(comp.Id);

                    var newComp = new JobCompetencyRatingDto
                    {
                        JobPositionId = 0,
                        TypeId = 3,
                        TypeNameEng = comp.TypeNameEng,
                        TypeNameFre = comp.TypeNameFre,
                        CompetencyId = comp.Id,
                        CompetencyNameEng = comp.NameEng,
                        CompetencyNameFre = comp.NameFre,
                        CompetencyDescEng = comp.DescEng,
                        CompetencyDescFre = comp.DescFre,
                        RatingValue = levelOneRating.Value,
                        RatingNameEng = levelOneRating.NameEng,
                        RatingNameFre = levelOneRating.NameFre,
                        RatingDescEng = levelOneRating.DescEng,
                        RatingDescFre = levelOneRating.DescFre,
                        CompetencyRatingLevelId = 1,
                        CompetencyLevelReqDescEng = compWithDescs.Level1DescEng,
                        CompetencyLevelReqDescFre = compWithDescs.Level1DescFre,
                        Active = 1,
                        CompetencyLevelRequirementId = compRatingGroup.CompetencyLevelRequirementId
                    };
                    AddedBehaviouralCompetencies.Add(newComp);
                    behavIds += newComp.CompetencyId + "&" + newComp.CompetencyRatingLevelId + "-";
                }
                AddedBehaviouralCompetencyIds = behavIds;
            }

            return Page();
        }

        public async Task OnPostGroup()
        {
            await PreparePageModel();
        }

        public async Task OnPostCertificate()
        {
            var certificate = Request.Form["certificate"];
            var certificatedescId = Request.Form["CertificateDescriptionId"];

            if (certificate != Microsoft.Extensions.Primitives.StringValues.Empty 
                && certificatedescId != Microsoft.Extensions.Primitives.StringValues.Empty)
            {
                AddedCertificateIds += certificate[0] + "&" + certificatedescId[0] + "-";
            }

            await PreparePageModel();
        }

        public async Task OnPostCompetency(string competencytypename)
        {         
            var Id = Request.Form[$"{competencytypename}Competency"];
            var level = Request.Form[$"{competencytypename}Level"];

            if (Id != Microsoft.Extensions.Primitives.StringValues.Empty
                && level != Microsoft.Extensions.Primitives.StringValues.Empty)
            {
                var strToAdd = Id[0] + "&" + level[0] + "-";

                if (competencytypename == "knowledge")
                {
                    AddedKnowledgeCompetencyIds += strToAdd;
                }
                else if (competencytypename == "technical")
                {
                    AddedTechnicalCompetencyIds += strToAdd;
                }
                else if (competencytypename == "behavioural")
                {
                    AddedBehaviouralCompetencyIds += strToAdd;
                }
                else if (competencytypename == "executive")
                {
                    AddedExecutiveCompetencyIds += strToAdd;
                }
            }

            await PreparePageModel();
        }

        public async Task OnPostDeleteCertificate(int certificateid)
        {
            await PreparePageModel(0, certificateid);
        }

        public async Task OnPostDelete(int competencyid)
        {
            await PreparePageModel(competencyid);
        }

        public async Task<IActionResult> OnPostCreateAsync()
        {
            await PreparePageModel();

            if (!ModelState.IsValid)    // the model can't be validated right at the beginning of this function, otherwise the DTO
                                        // won't be in the proper state, since its properties won't have been set, yet
            {
                return Page();
            }

            int jobPositionId = await _jobCompetencyService.PostJobPositionGetId(JobPosition);

            bool validLevelValue = true;

            if (string.IsNullOrWhiteSpace(LevelValue))
            {
                validLevelValue = false;
            }
            else
            {
                if (!LevelValue.Contains("/"))
                {
                    validLevelValue = false;
                }
                else
                {
                    var splitLevel = LevelValue.Split("/");

                    try
                    {
                        int subGroupId = int.Parse(splitLevel[0]);
                        int jobGroupLevelId = int.Parse(splitLevel[1]);
                        string code = splitLevel[2];

                        var levelValues = JobGroupPositions.Select(x => x.LevelValue).ToList();
                        List<int> levelValuesInt = new List<int>();

                        foreach (var value in levelValues)
                        {
                            levelValuesInt.Add(int.Parse(value));
                        }

                        if (!_context.SubJobGroups.Select(x => x.Id).ToList().Contains(subGroupId) ||
                            !levelValuesInt.Contains(jobGroupLevelId))
                        {
                            validLevelValue = false;
                        }
                        else
                        {
                            var codes = JobGroupPositions.Select(x => x.LevelCode.ToLower()).ToList();
                            if (!codes.Contains(code.ToLower()))
                            {
                                validLevelValue = false;
                            }
                        }
                    }
                    catch
                    {
                        validLevelValue = false;
                    }
                }
            }

            if (!validLevelValue)
            {
                JobGroupId = JobGroups[0].Id;
                LevelValue = "25/1/AS-01";
            }

            var jobGroupPosition = new JobGroupPosition()
            {
                JobGroupId = JobGroupId,
                JobPositionId = jobPositionId,
                SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
            };
            await _jobCompetencyService.PostJobGroupPosition(jobGroupPosition);

            List<JobCompetencyRatingDto>[] compList = { AddedKnowledgeCompetencies, AddedTechnicalCompetencies,
            AddedBehaviouralCompetencies, AddedExecutiveCompetencies };
            for (int i = 0; i < compList.Length; i++)
            {
                var currCompType = compList.ElementAt(i);

                foreach (var competency in currCompType)
                {
                    var ratingLevelId = competency.CompetencyRatingLevelId - (competency.CompetencyRatingLevelId > 5 ? 5 : 0);
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,
                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = i + 1,
                        CompetencyRatingLevelId = ratingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };
                    await _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
            }

            foreach (var id in RegionIds.Split("-"))
            {
                if (!string.IsNullOrWhiteSpace(id))
                {
                    var jobrolepositionlocation = new JobRolePositionLocation()
                    {
                        JobLocationRegionId = int.Parse(id),
                        JobGroupId = JobGroupId,
                        JobPositionId = jobPositionId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1])
                    };
                    await _jobCompetencyService.PostJobRolePositionLocation(jobrolepositionlocation);
                }
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
            await _jobCompetencyService.PostJobRolePositionHLCategory(jobrolepositionhlcategory);

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
                await _jobCompetencyService.PostJobRolePositionCertificate(jobrolepositioncertificate);
            }

            return RedirectToPage("Details", new { positionid = jobPositionId });
        }

    }
}