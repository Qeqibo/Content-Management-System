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
   public class PageManagementBLL
    {
        public bool Insert(PageManagementModel pm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@PageName", pm.PageName), new SqlParameter("@PageContent", pm.PageContent), new SqlParameter("@Title", pm.Title), new SqlParameter("@Desription", pm.Desription), new SqlParameter("@Keywords", pm.Keywords), new SqlParameter("@IsActive", pm.IsActive) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Insert into tblPages values(@PageName,@PageContent,@Title,@Desription,@Keywords,@IsActive)", p) > 0;
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
        public bool Update(PageManagementModel pm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", pm.PageID),new SqlParameter("@PageName", pm.PageName), new SqlParameter("@PageContent", pm.PageContent), new SqlParameter("@Title", pm.Title), new SqlParameter("@Desription", pm.Desription), new SqlParameter("@Keywords", pm.Keywords) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update tblPages Set PageName=@PageName,PageContent=@PageContent,Title=@Title,Desription=@Desription,Keywords=@Keywords where PageID=@id", p) > 0;
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
                return hlp.ExecuteNonQuery("Delete from tblPages where PageID=@id", p)>0 ;
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
        public List<PageManagementModel> PageListesiGetir()
        {
            List<PageManagementModel> lst = new List<PageManagementModel>();
            Helper hlp = Helper.Ornek;
            SqlDataReader dr = hlp.ExecuteReader("Select PageID, PageName, from tblPages", null);
            while (dr.Read())
            {
                lst.Add(new PageManagementModel { PageName = dr["PageName"].ToString(), PageID = Convert.ToInt32(dr["PageID"]) });
            }
            dr.Close();
            return lst;


        }
        public DataTable PageTablosuGetir(bool IsActive)
        {

            Helper hlp = Helper.Ornek;
            SqlParameter[] p = { new SqlParameter("@IsActive", IsActive) };
            return hlp.MyDataTable("Select PageID, PageName from tblPages where IsActive=@IsActive", p);
        }
        public DataTable PageTablosuGetir2()//////////////// Grid view
        {
            Helper hlp = Helper.Ornek;
          
            return hlp.MyDataTable("Select PageID, PageName,PageContent,Title,Desription,Keywords from tblPages", null);
        }

        public PageManagementModel GetDetail(int id)
        {
            PageManagementModel pmm = null;
            Helper hlp = Helper.Ornek;
            SqlParameter[] p = { new SqlParameter("@id", id) };
            SqlDataReader dr = hlp.ExecuteReader("Select PageID, PageName,PageContent,Title,Desription,Keywords from tblPages where PageID=@id", p);
           
            if (dr.Read())
            {
                pmm = new PageManagementModel();
                pmm.PageName = dr["PageName"].ToString();
                pmm.PageContent = dr["PageContent"].ToString();
                pmm.Title = dr["Title"].ToString();
                pmm.Desription = dr["Desription"].ToString();
                pmm.Keywords= dr["Keywords"].ToString();
                //   pmm.add(new PageManagementModel { PageName = dr["PageName"].ToString(), PageID = Convert.ToInt32(dr["PageID"]) });
            }
                dr.Close();
            return pmm;
        }
    }
}
