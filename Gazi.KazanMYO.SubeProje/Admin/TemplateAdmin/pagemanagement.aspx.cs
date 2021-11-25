using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;
using System.Data;
using System.Data.SqlClient;

namespace Gazi.KazanMYO.SubeProje.Admin.TemplateAdmin
{
    public partial class pagemanagement : System.Web.UI.Page
    {
        DataTable dt = null;
        public static string pageid;
        public static string pagesil;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //İşlem yaptığınız kodlar


                pageid = Request.QueryString["pageid"];
                pagesil = Request.QueryString["pagesil"];
                if (!IsPostBack)
                {
                    if (pageid != null)
                    {
                        PageTextboxlaraYaz(int.Parse(pageid));

                    }
                    else if (pagesil != null)
                    {
                        PageDelete(int.Parse(pagesil));
                        Response.Redirect("pagelist.aspx");
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            PageManagementBLL pm = new PageManagementBLL();
            

                //İşlem yaptığınız kodlar


                try
                {
                    if (pm.Insert(new PageManagementModel { PageName = txtPageName.Text.Trim(), PageContent = ck_contenet.Text, Title = txtTitle.Text.Trim(), Desription = txtDescription.Text.Trim(), Keywords = txtKeywords.Text.Trim(), IsActive = chkIsActive.Checked }))
                    {
                        Response.Redirect("pagelist.aspx");
                    }
                    else
                    {
                        Console.WriteLine("<script> alert(\" Kayıt Başarılı\");</scrtipt>");
                    }


                }
                catch (SqlException ex)
                {

                    Console.WriteLine("<script> alert(\" Veri tabanında hata Hata:{0}\");</scrtipt>", ex);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("<script> alert(\" hata Hata:{0}\");</scrtipt>", ex);
                }
            
        }
        void PageTextboxlaraYaz(int a)
        {
            PageManagementBLL pmb = new PageManagementBLL();

            PageManagementModel pmm = pmb.GetDetail(a);
            txtPageName.Text = pmm.PageName;
            ck_contenet.Text = pmm.PageContent;
            txtTitle.Text = pmm.Title;
            txtDescription.Text = pmm.Desription;
            txtKeywords.Text = pmm.Keywords;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            PageManagementBLL pm = new PageManagementBLL();
            

                //İşlem yaptığınız kodlar



                try
                {
                    if (pm.Update(new PageManagementModel { PageName = txtPageName.Text.Trim(), PageContent = ck_contenet.Text, Title = txtTitle.Text.Trim(), Desription = txtDescription.Text.Trim(), Keywords = txtKeywords.Text.Trim(), PageID = Convert.ToInt32(pageid) }))
                    {
                        Response.Redirect("pagelist.aspx");
                    }
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("<script> alert(\" Veri tabanında hata Hata:{0}\");</scrtipt>", ex);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("<script> alert(\" hata Hata:{0}\");</scrtipt>", ex);
                }
            }
        
        void PageDelete(int a)
        {
            PageManagementBLL pm = new PageManagementBLL();
            pm.Delete(a);
        }
    }
}