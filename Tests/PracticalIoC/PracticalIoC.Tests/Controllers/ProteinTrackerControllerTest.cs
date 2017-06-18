namespace PracticalIoC.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PracticalIoC.Controllers;
    using System.Web.Mvc;

    [TestClass]
    public class ProteinTrackerControllerTest
    {
        [TestMethod]
        public void WhenNothingHasHappenedTotalAndGoalAreZero()
        {
            ProteinTrackerController controller = new ProteinTrackerController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual(0, result.ViewBag.Total);
            Assert.AreEqual(0, result.ViewBag.Goal);
        }
    }
}
