using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFundamentals
{
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
            context.Response.Write("The page request is " + context.Request.RawUrl.ToString());
        }
    }
}