﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin.TemplateAdmin
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("yonet");

            Response.Redirect("login.aspx");

        }
    }
  
}