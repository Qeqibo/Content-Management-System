using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin.TemplateAdmin
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["yonet"] != null && Session["yonet"].ToString() == "1"))
            {
                Response.Redirect("login.aspx"); // session oluşturulmadıysa login sayfasında gönderdik
            }
        }
    }
}