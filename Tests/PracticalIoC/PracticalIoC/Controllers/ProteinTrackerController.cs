namespace PracticalIoC.Controllers
{
    using Models;
    using System.Web.Mvc;

    public class ProteinTrackerController : Controller
    {
        private IProteinTrackingService proteinTrackingService;

        public ProteinTrackerController(IProteinTrackingService service)
        {
            this.proteinTrackingService = service;
        }

        public ActionResult Index()
        {
            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View();
        }

        public ActionResult AddProtein(int amount)
        {
            proteinTrackingService.AddProtein(amount);

            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View("Index");
        }
    }
}