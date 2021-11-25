using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.AnaTema
{
    public partial class haberler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHaberMenu();

            }
        }
        #region "Kod Oluştur"
        public static string KodOlustur(string Text)
        {
            try

            {
                string strReturn = Text.Trim();
                strReturn = strReturn.Replace("ğ", "g");
                strReturn = strReturn.Replace("Ğ", "G");
                strReturn = strReturn.Replace("ü", "u");
                strReturn = strReturn.Replace("Ü", "U");
                strReturn = strReturn.Replace("ş", "s");
                strReturn = strReturn.Replace("Ş", "S");
                strReturn = strReturn.Replace("ı", "i");
                strReturn = strReturn.Replace("İ", "I");
                strReturn = strReturn.Replace("ö", "o");
                strReturn = strReturn.Replace("Ö", "O");
                strReturn = strReturn.Replace("ç", "c");
                strReturn = strReturn.Replace("Ç", "C");
                strReturn = strReturn.Replace("-", "+");
                strReturn = strReturn.Replace(" ", "+");
                strReturn = strReturn.Trim();
                strReturn = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9+]").Replace(strReturn, "");
                strReturn = strReturn.Trim();
                strReturn = strReturn.Replace("+", "-");
                return strReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
        void LoadHaberMenu()
        {
            HaberBLL pbl = new HaberBLL();
            rp_haberler.DataSource = pbl.HaberTablosuGetir2();
            rp_haberler.DataBind();
        }

    }
}