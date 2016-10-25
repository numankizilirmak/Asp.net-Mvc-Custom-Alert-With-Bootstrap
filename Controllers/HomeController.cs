using MvcCustomAlertWithBootstrap.Enums;
using MvcCustomAlertWithBootstrap.Models;
using System.Web.Mvc;

namespace MvcCustomAlertWithBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public RedirectToRouteResult Error()
        {
            AlertMessageResult result = new AlertMessageResult
            {
                IsSuccess = false,
                Verbosity = MessageVerbosityLevelEnum.Error,
                Message = "Something goes wrong!!!",
            };

            TempData["AlertMessage"] = result;

            return RedirectToAction("Index");
        }
        public RedirectToRouteResult Success()
        {
            AlertMessageResult result = new AlertMessageResult
            {
                IsSuccess = false,
                Verbosity = MessageVerbosityLevelEnum.Success,
                Message = "Process Success",
            };

            TempData["AlertMessage"] = result;

            return RedirectToAction("Index");
        }
        public RedirectToRouteResult Warning()
        {
            AlertMessageResult result = new AlertMessageResult
            {
                IsSuccess = false,
                Verbosity = MessageVerbosityLevelEnum.Warning,
                Message = "Warning",
            };

            TempData["AlertMessage"] = result;

            return RedirectToAction("Index");
        }
    }
}