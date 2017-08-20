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
                    while (rd.Read())
                    {
                        CategoryDropDownList.DataSource = rd;
                        CategoryDropDownList.DataValueField = "CategoryID";
                        CategoryDropDownList.DataTextField = "CategoryName";
                        CategoryDropDownList.DataBind();
                    }
                }
            }
        }

        protected void onSubmitButtonClick(object sender, EventArgs e)
        {
            String sqlQuery = @"insert into Products$ (ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder,
                                ReorderLevel, Discontinued, Online, Sale) values(@ProductID, @ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice,
                                @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued, @Online, @Sale)";
            SqlCommand insertCmd = new SqlCommand(sqlQuery, conn);
            insertCmd.Parameters.AddWithValue("@ProductID", ProductIDTextBox.Text);
            insertCmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text);
            insertCmd.Parameters.AddWithValue("@SupplierID", SupplierIDTextBox.Text);

            insertCmd.Parameters.AddWithValue("@CategoryID", CategoryDropDownList.SelectedValue);

            insertCmd.Parameters.AddWithValue("@QuantityPerUnit", QuantityPerUnitTextBox.Text);
            insertCmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text);
            insertCmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStockTextBox.Text);
            insertCmd.Parameters.AddWithValue("@UnitsOnOrder", UnitsOnOrderTextBox.Text);
            insertCmd.Parameters.AddWithValue("@ReorderLevel", ReorderLevelTextBox.Text);

            insertCmd.Parameters.AddWithValue("@Discontinued", DiscontinuedDropDownList.SelectedValue);
            insertCmd.Parameters.AddWithValue("@Online", OnlineDropDownList.SelectedValue);
            insertCmd.Parameters.AddWithValue("@Sale", SaleDropDownList.SelectedValue);

            insertCmd.CommandType = CommandType.Text;
            conn.Open();

            int rowsAffected = insertCmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                //Success notification
                NotifyLabel.Text = "Query executed successfully. " + rowsAffected + " row(s) affected.";
                NotifyLabel.ForeColor = System.Drawing.Color.Green;
                NotifyLabel.Visible = true;
            }
            else
            {
                //Error notification
                NotifyLabel.Text = "There was an error inserting your record.";
                NotifyLabel.ForeColor = System.Drawing.Color.Red;
                NotifyLabel.Visible = true;
            }

            conn.Close();
        }
    }
}