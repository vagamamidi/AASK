using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AASK
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        
            //new SqlConnection(@"Data Source=VIJAY\SQLEXPRESS;Initial Catalog=aask;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["aaskConnectionString"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter();

            String sqlQuery = @"select CategoryID, CategoryName from Categories$";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProductNameDropDownList.DataSource = rd;
                    ProductNameDropDownList.DataValueField = "CategoryID";
                    ProductNameDropDownList.DataTextField = "CategoryName";
                    ProductNameDropDownList.DataBind();
                }
            }

        }
 


    }
}