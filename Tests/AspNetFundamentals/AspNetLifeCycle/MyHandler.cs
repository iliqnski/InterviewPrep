namespace AspNetLifeCycle
{
    using System;
    using System.Web;

    public class MyHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("My Handler called.");
        }
    }
}