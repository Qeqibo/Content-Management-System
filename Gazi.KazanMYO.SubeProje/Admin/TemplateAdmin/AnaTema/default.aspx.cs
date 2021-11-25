using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using System.Threading;

namespace Gazi.KazanMYO.SubeProje.AnaTema
{
    public partial class _default : System.Web.UI.Page
    {
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(_default));
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPageMenu();
                LoadHaberMenu();
            }
        }
        private static void ImplemetLoggingFunction()
        {
            var secs = 3;
            Log.Fatal("Start log Fatal...");
            Console.WriteLine("<script> alert(\" Start Log Fatal\");</scrtipt>");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            Log.Error("Start log Error...");
            Console.WriteLine("<script> alert(\" Start Log Erorr\");</scrtipt>");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            Log.Warn("Start log Warn...");
            Console.WriteLine("<script> alert(\" Start Log Warn\");</scrtipt>");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            Log.Warn("Start log Info...");
            Console.WriteLine("<script> alert(\" Start Log Info\");</scrtipt>");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            Log.Warn("Start log Debug...");
            Console.WriteLine("<script> alert(\" Start Log Debug\");</scrtipt>");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

        }
        void LoadPageMenu()
        {
            PageManagementBLL pbl = new PageManagementBLL();
            rpt_sayfa.DataSource = pbl.PageTablosuGetir(true);
            rpt_sayfa.DataBind();
        }
        void LoadHaberMenu()
        {
            
            HaberBLL pbl = new HaberBLL();
            rpt_Haber.DataSource = pbl.HaberTablosuGetir2();
            rpt_Haber.DataBind();
        }
    }
}