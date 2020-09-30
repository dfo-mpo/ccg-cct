using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Data.Auth.Model;
using CCG.AspNetCore.Web.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Controllers.Code;

namespace Service.Controllers.Auth
{
    [Route("api/auth/SystemRole"), PrivilegeAuthorize("Auth_Role_Manage")]

    public class SystemRoleManageController : AbstractCodeManagerManageController<SystemRole>
    {
        public SystemRoleManageController(ICommandSender commandSender) : base(commandSender)
        {
        }
    }
}