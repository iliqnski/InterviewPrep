namespace PracticalIoC.Infrastructure
{
    using Controllers;
    using Models;
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.SessionState;

    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName.ToLower().StartsWith("proteintracker"))
            {
                var service = new ProteinTrackingService();
                var controller = new ProteinTrackerController(service);

                return controller;
            }

            return new DefaultControllerFactory()
                .CreateController(requestContext, controllerName);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;
            if(disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}