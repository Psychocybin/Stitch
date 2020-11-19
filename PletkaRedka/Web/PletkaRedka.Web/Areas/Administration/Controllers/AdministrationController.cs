namespace PletkaRedka.Web.Areas.Administration.Controllers
{
    using PletkaRedka.Common;
    using PletkaRedka.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
