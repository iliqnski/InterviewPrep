using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplicationFundamentals
{
    public class MyModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            // Register event handler of the pipe line
            context.BeginRequest += new EventHandler(this.context_BeginRequest);
            context.EndRequest += new EventHandler(this.context_EndRequest);

        }

        public void context_EndRequest(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\requestLog.txt", true);
            sw.WriteLine("End Request called at " + DateTime.Now.ToString()); sw.Close();
        }
        public void context_BeginRequest(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\requestLog.txt", true);
            sw.WriteLine("Begin request called at " + DateTime.Now.ToString()); sw.Close();
        }
    }
}