﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (!(Session["yonet"] != null && Session["yonet"].ToString() == "1"))
            {
                Response.Redirect("login.aspx"); // session oluşturulmadıysa login sayfasında gönderdik
            }*/
            if (!IsPostBack)
            {
                LoadPageMenu();
            }
        }
        void LoadPageMenu()
        {
            PageManagementBLL pbl = new PageManagementBLL();
            rptMainMenu.DataSource = pbl.PageTablosuGetir(true);
            rptMainMenu.DataBind();
        }
    }
}