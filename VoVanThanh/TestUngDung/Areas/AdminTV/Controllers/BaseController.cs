using ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TestUngDung.Areas.AdminTV.Models;

namespace TestUngDung.Areas.AdminTV.Controllers
{
    public class BaseController : Controller
    {
        // GET: AdminTV/Base
        protected override void OnActionExecuting(ActionExecutingContext fillterContext)
        {
            var session = (LoginModel)Session[Constans.USER_SESSION];
            if (session == null)
            {
                fillterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Login", action = "Index", Areas = "AdminTV" }));
            }
            base.OnActionExecuting(fillterContext);
        }
    }
}