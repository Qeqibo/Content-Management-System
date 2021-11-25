using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class SifreDegis : System.Web.UI.Page
    {
        LoginBLL lb = new LoginBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void SifreDeg(string Kullanici, string eskiPass, string yeniPass)
        {
            PasswordStrengthChecker ps = new PasswordStrengthChecker();
            if (ps.GeneratePasswordScore(yeniPass) >= 60)
            {
                try
                {

                     

                    if (lb.Update(Kullanici, eskiPass, yeniPass))
                    {
                        Console.WriteLine("<script> alert('Şifre Dğiştirme Başarılı'); </script>");
                        Session["yonet"] = "1";
                        Response.Redirect("default.aspx");

                    }
                    else
                        Console.WriteLine("<script> alert('Şifre Değişmedi'); </script>");


                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                Console.WriteLine("<script> alert('Lütfen Rakam ve Harf barındıran güçlü bir şifre deneyiniz'); </script>");
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
           
            SifreDeg(txtUsername.Text.Trim(), lb.MD5Sifrele(txtPasswordOld.Text), txtPasswordNew.Text);
        }
    }
}