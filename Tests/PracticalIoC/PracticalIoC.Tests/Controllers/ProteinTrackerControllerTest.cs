namespace PracticalIoC.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PracticalIoC.Controllers;
    using System.Web.Mvc;
    using Microsoft.CSharp.RuntimeBinder;
    using PracticalIoC.Models;

    [TestClass]
    public class ProteinTrackerControllerTest
    {
        [TestMethod]
        public void WhenNothingHasHappenedTotalAndGoalAreZero()
        {
            ProteinTrackerController controller = new ProteinTrackerController(new SubtrackingService());

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual(0, result.ViewBag.Total);
            Assert.AreEqual(0, result.ViewBag.Goal);
        }

        public class SubtrackingService : IProteinTrackingService
        {
            public int Total { get; set; }

            public int Goal { get; set; }

            public void AddProtein(int amount)
            {
                Total += amount;
            }
        }
    }
}
