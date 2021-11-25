using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                {
                LoadPageMenu();
                }
               
        }
        void LoadPageMenu()
        {
            ResimBLL rbl = new ResimBLL();
            rptResimler.DataSource = rbl.ResimleriGetir2();
            rptResimler.DataBind();
        }
    }
}