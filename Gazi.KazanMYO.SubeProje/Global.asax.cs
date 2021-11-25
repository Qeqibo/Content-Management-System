using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
namespace Gazi.KazanMYO.SubeProje
{
    public class Global : System.Web.HttpApplication
    {
        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            routes.MapPageRoute("", "{HaberID}/{HaberBaslik}", "~/AnaTema/haberdetay.aspx");
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            RegisterRoutes(System.Web.Routing.RouteTable.Routes);
        }
    }
}