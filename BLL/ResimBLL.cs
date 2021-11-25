using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public class ResimBLL
    {
        public bool Insert(ResimModel rm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ResimYol", rm.ResimYol), };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Insert into tblResim(ResimYolu) values(@ResimYol)", p) > 0;
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
        public bool Delete(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Delete from tblResim where ResimID=@id", p) > 0;
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
        public bool Update(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update tblResim set Durum=1 where ResimID=@id", p) > 0;
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
        public DataTable ResimleriGetir()
        {

            Helper hlp = Helper.Ornek;
            return hlp.MyDataTable("Select  ResimID,ResimYolu from tblResim", null);
        }
        public DataTable ResimleriGetir2()
        {

            Helper hlp = Helper.Ornek;
            return hlp.MyDataTable("Select  ResimID,ResimYolu from tblResim where Durum=1", null);
        }
    }
}
