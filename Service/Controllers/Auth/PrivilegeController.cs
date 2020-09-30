using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Data.Auth.Model;
using CCG.AspNetCore.Web.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Controllers.Code;

namespace Service.Controllers.Auth
{
    [Route("api/auth/[controller]"), PrivilegeAuthorize("Auth_Privilege_View")] 
    public class PrivilegeController : AbstractCodeManagerViewController<Privilege>
    {
        public PrivilegeController(IQueryProcessor queryProcessor) : base(queryProcessor)
        {
        }
    }
}