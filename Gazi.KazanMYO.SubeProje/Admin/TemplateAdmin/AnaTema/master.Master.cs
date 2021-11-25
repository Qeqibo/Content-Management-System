using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.AnaTema
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadResimMenu();
                LoadPageMenu();
               
            }
        }
        void LoadPageMenu()
        {
            PageManagementBLL pbl = new PageManagementBLL();
            rptMainMenu.DataSource = pbl.PageTablosuGetir(true);
            rptMainMenu.DataBind();
        }
        void LoadResimMenu()
        {
            ResimBLL pbl = new ResimBLL();
            
            rpt_resim.DataSource = pbl.ResimleriGetir2();
            rpt_resim.DataBind();
        }

    }
}