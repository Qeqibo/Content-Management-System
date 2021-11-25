using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class LoginBLL
    {
        public LoginModel LoginGetir(string sifre)
        {
            LoginModel lm = null;
            Helper hlp = Helper.Ornek;
            string md5 = MD5Sifrele(sifre);
            SqlParameter[] p = { new SqlParameter("@sifre", md5) };
            SqlDataReader dr = hlp.ExecuteReader("Select LoginName,LoginPassword from tblLogin where LoginPassword=@sifre", p);

            if (dr.Read())
            {
                lm = new LoginModel();
                lm.LoginName = dr["LoginName"].ToString();
                lm.LoginPassword = dr["LoginPassword"].ToString();
             }
            dr.Close();
            return lm;
        }
        public bool Update(string UserName,string OldPass,string NewPass)
        {
            string pass = MD5Sifrele(NewPass);
            try
            {
                SqlParameter[] p = { new SqlParameter("@LoginName", UserName), new SqlParameter("@OldPass", OldPass), new SqlParameter("@NewPass", pass) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update tblLogin Set LoginName=@LoginName,LoginPassword=@NewPass where LoginPassword=@OldPass", p) > 0;
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
        public  string MD5Sifrele(string metin)
        {
            // MD5CryptoServiceProvider nesnenin yeni bir instance'sını oluşturalım.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();


            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }
       
    }
}
