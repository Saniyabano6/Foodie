using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApplication1.Admin;

namespace WebApplication1
{
    public class Connection
    {
       
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
    public class utils
    {
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public static bool IsValidExtension(string fileName)
        {
            bool isValid = false;
            string[] FileExtension = { ".jpg", ".jpeg", ".png" };
            for (int i = 0; i <= FileExtension.Length - 1; i++)
            {
                if (fileName.Contains(FileExtension[i]))
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }
        public static string GetImageUrl(object url)
        {
            string url1 = "";
            if (string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
            {
                url1 = "../Images/No_Image.png";
            }
            else
            {
                url1 = String.Format("../(0)", url);
            }
            return url1;
        }
        public bool updateCartQuantity(int quantity,int productID, int userID)
        {
            bool isUpdated = false;
            Con = new SqlConnection(Connection.GetConnectionString());
            cmd = new SqlCommand("Cart_Crud", Con);
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@ProductID", productID);                    
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                isUpdated = true;
            }
            catch (Exception ex) {
                isUpdated=false; 
                System.Web.HttpContext.Current.Response.Write("<script>alert('Error =" + ex.Message + "');</script>");
                    }
            finally
            {
                Con.Close();
            }
            return isUpdated;
                    
        }
        public int cartCount(int userID)
        {
            Con = new SqlConnection(Connection.GetConnectionString());
            cmd = new SqlCommand("Cart_Crud", Con);
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows.Count;
        }
    }
}