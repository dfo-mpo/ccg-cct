using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa;
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
            return new Rotativa.AspNetCore.ViewAsPdf("GetPositionDetailsAsPdf", ViewData);
        }

        [Route("SimilarLists")]
        public ActionResult SimilarList(string id, int positionid, string language)
        {
            ViewData["Id"] = id;
            ViewData["Language"] = language;
            ViewData["PositionId"] = positionid;
            return new Rotativa.AspNetCore.ViewAsPdf("GetSimilarPositionsAsPdf", ViewData);
        }

        [Route("SimilarListCandidate")]
        public ActionResult SimilarListCandidate(int id, int hlid, string language)
        {
            ViewData["Id"] = id;
            ViewData["HLId"] = hlid;
            ViewData["Language"] = language;
            return new Rotativa.AspNetCore.ViewAsPdf("GetSimilarPositionsCandidateAsPdf", ViewData);
        }

        [Route("StudentPositionsList")]
        public ActionResult StudentPositionsList(string shoresideIds, string seagoingIds, string language)
        {
            ViewData["shoresideId"] = shoresideIds;
            ViewData["seagoingId"] = seagoingIds;
            ViewData["Language"] = language;
            return new Rotativa.AspNetCore.ViewAsPdf("GetStudentPositionsAsPdf", ViewData);
        }

        [Route("StudentShoresidePositionsList")]
        public ActionResult StudentShoresidePositionsList(string shoresideIds, string language)
        {
            ViewData["shoresideId"] = shoresideIds;
            ViewData["Language"] = language;
            return new Rotativa.AspNetCore.ViewAsPdf("GetStudentShoresidePositionsAsPdf", ViewData);
        }

        [Route("StudentSeagoingPositionsList")]
        public ActionResult StudentSeagoingPositionsList(string seagoingIds, string language)
        {
            ViewData["seagoingId"] = seagoingIds;
            ViewData["Language"] = language;
            return new Rotativa.AspNetCore.ViewAsPdf("GetStudentSeagoingPositionsAsPdf", ViewData);
        }

        [Route("Delta")]
        public ActionResult Delta(int id, int obj, string language)
        {
            ViewData["Id"] = id;
            ViewData["Obj"] = obj;
            ViewData["Language"] = language;
            return new Rotativa.AspNetCore.ViewAsPdf("GetDeltaAsPdf", ViewData);
        }

    }
}
