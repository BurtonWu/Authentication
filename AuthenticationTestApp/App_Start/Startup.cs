using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

//Upon Application Load, Owin starts here, typeof changes it to an object containing information about the class
[assembly: OwinStartup(typeof(AuthenticationTestApp.App_Start.Startup))]
namespace AuthenticationTestApp.App_Start
{
    public class Startup
    {
        //IAppBuilder composes the application for Owin
        public void Configuration(IAppBuilder app)
        {
            //to configure API routes for the application
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            //wires up ASP.NET Web API(config) to Owin server pipeline(app)
            app.UseWebApi(config);
        }
    }
}