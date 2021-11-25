using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;
using BLL;
using MODEL;
namespace Gazi.KazanMYO.SubeProje.AnaTema
{
    public partial class haberdetay : System.Web.UI.Page
    {
        int HaberID;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //HaberID = Convert.ToInt32(Page.RouteData.Values["HaberID"]);
            HaberBLL hbr = new HaberBLL();
            HaberModel hbrmod = new HaberModel();

            hbrmod = hbr.GetDetail(2);
            lbl_HaberAd.Text = hbrmod.HaberBaslik;
            lbl_HaberIcerık.Text = hbrmod.Icerik;

        }
    }
}