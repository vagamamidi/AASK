using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AASK
{
    public partial class AddProducts : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["aaskConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String sqlQuery = @"select CategoryID, CategoryName from Categories$";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    do
                    {
                        CategoryDropDownList.DataSource = rd;
                        CategoryDropDownList.DataValueField = "CategoryID";
                        CategoryDropDownList.DataTextField = "CategoryName";
                        CategoryDropDownList.DataBind();
                    }
                    while (rd.Read());
                }
            }
        }

        protected void onSubmitButtonClick(object sender, EventArgs e)
        {
            String sqlQuery = @"insert into Products$ (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder,
                                ReorderLevel, Discontinued, Online, Sale) values(@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice,
                                @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued, @Online, @Sale)";
            SqlCommand insertCmd = new SqlCommand(sqlQuery, conn);

            insertCmd.Parameters.AddWithValue("@ProductName", ProductNameInput.Value);
            insertCmd.Parameters.AddWithValue("@SupplierID", SupplierIDInput.Value);
            insertCmd.Parameters.AddWithValue("@CategoryID", CategoryDropDownList.SelectedValue);
            insertCmd.Parameters.AddWithValue("@QuantityPerUnit", QuantityPerUnitInput.Value);
            insertCmd.Parameters.AddWithValue("@UnitPrice", UnitPriceInput.Value);
            insertCmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStockInput.Value);
            insertCmd.Parameters.AddWithValue("@UnitsOnOrder", UnitsOnOrderInput.Value);
            insertCmd.Parameters.AddWithValue("@ReorderLevel", ReorderLevelInput.Value);
            insertCmd.Parameters.AddWithValue("@Discontinued", DiscontinuedDropDownList.SelectedValue);
            insertCmd.Parameters.AddWithValue("@Online", OnlineDropDownList.SelectedValue);
            insertCmd.Parameters.AddWithValue("@Sale", SaleDropDownList.SelectedValue);

            insertCmd.CommandType = CommandType.Text;
            conn.Open();

            int rowsAffected = insertCmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                //Success notification
                Response.Redirect("~/ProductsList.aspx");
            }
            else
            {
                //Error notification
                
            }

            conn.Close();
        }
    }
}