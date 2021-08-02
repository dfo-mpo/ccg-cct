using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Web.Pages
{
    public class ToPdfController : Controller
    {

        [Route("PositionDetails")]
        public ActionResult PositionDetails(int id, string language)
        {
            ViewData["Id"] = id;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetPositionDetailsAsPdf", ViewData);
        }

        [Route("SimilarLists")]
        public ActionResult SimilarList(string id, string similarjobids70, string similarjobids80, string similarjobids90, string similarjobids100, int positionid, string language)
        {
            ViewData["Id"] = id;
            ViewData["SimilarJobIds100"] = similarjobids100;
            ViewData["SimilarJobIds90"] = similarjobids90;
            ViewData["SimilarJobIds80"] = similarjobids80;
            ViewData["SimilarJobIds70"] = similarjobids70;
            ViewData["Language"] = language;
            ViewData["PositionId"] = positionid;
            return new ViewAsPdf("GetSimilarPositionsAsPdf", ViewData);
        }

        [Route("SimilarListCandidate")]
        public ActionResult SimilarListCandidate(int id, int hlid, string language)
        {
            ViewData["Id"] = id;
            ViewData["HLId"] = hlid;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetSimilarPositionsCandidateAsPdf", ViewData);
        }

        [Route("StudentPositionsList")]
        public ActionResult StudentPositionsList(string shoresideIds, string seagoingIds, string language)
        {
            ViewData["shoresideId"] = shoresideIds;
            ViewData["seagoingId"] = seagoingIds;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetStudentPositionsAsPdf", ViewData);
        }

        [Route("StudentShoresidePositionsList")]
        public ActionResult StudentShoresidePositionsList(string shoresideIds, string language)
        {
            ViewData["shoresideId"] = shoresideIds;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetStudentShoresidePositionsAsPdf", ViewData);
        }

        [Route("StudentSeagoingPositionsList")]
        public ActionResult StudentSeagoingPositionsList(string seagoingIds, string language)
        {
            ViewData["seagoingId"] = seagoingIds;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetStudentSeagoingPositionsAsPdf", ViewData);
        }

        [Route("Delta")]
        public ActionResult Delta(int id, int obj, string language)
        {
            ViewData["Id"] = id;
            ViewData["Obj"] = obj;
            ViewData["Language"] = language;
            return new ViewAsPdf("GetDeltaAsPdf", ViewData);
        }

    }
}
