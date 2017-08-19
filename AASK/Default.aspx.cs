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
    public partial class _Default : Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=VIJAY\SQLEXPRESS;Initial Catalog=aask;Integrated Security=True");
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter da = new SqlDataAdapter();

                String sqlQuery = @"select * from Products$";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                da.SelectCommand = cmd;

                DataSet ds = new DataSet();

                conn.Open();
                da.Fill(ds);

                conn.Close();

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }


        }

        protected void onSearchButtonClick(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();

            String sqlQuery = String.Empty;
            sqlQuery = @"select * from products$ where" ;

            if (onSale.Checked == true)
            {
                if (checkedBoxCounter() > 1 && sqlQuery.Length != 29)
                {
                    sqlQuery += " and sale = 1";
                }
                else
                { sqlQuery += " sale = 1"; }
            }
            if (discontinued.Checked == true)
            {
                if (checkedBoxCounter() > 1 && sqlQuery.Length != 29)
                {
                    sqlQuery += " and discontinued = 1";
                }
                else
                { sqlQuery += " discontinued = 1"; }
               
            }
            if (onlineOnly.Checked == true)
            {
                if (checkedBoxCounter() > 1 && sqlQuery.Length != 29)
                {
                    sqlQuery += " and online = 1";
                }
                else
                { sqlQuery += " online = 1"; }
            }


            if (onSale.Checked == false && discontinued.Checked == false && onlineOnly.Checked == false)
            {
                sqlQuery = @"select * from products$";
            }

            if(!string.IsNullOrEmpty(searchBox.Text))
            {
                if (checkedBoxCounter() > 0)
                {
                    sqlQuery += " and ProductName like '%" + searchBox.Text.Trim() + "%'";
                }
                else
                sqlQuery += " ProductName like '%" + searchBox.Text.Trim() + "%'";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            da.SelectCommand = cmd;

            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);

            conn.Close();

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        private int checkedBoxCounter()
        {
            //String sqlQuery = @"select * from Products$ where ";
            //String str_Checkboxes = "";
            ////Loop through each control on the form, we are looking for checkboxes
            //foreach (Control c in this.Controls)
            //{
            //    if (c is CheckBox)
            //    {
            //        if (((CheckBox)c).Checked)
            //        {
            //            //Bypass putting AND at the beginning of str_Checkboxes
            //            if (str_Checkboxes != "")
            //                str_Checkboxes += " and ";
            //            //Checkbox text is the same as the field name in the database
            //            str_Checkboxes += (((CheckBox)c).Text) + " = 1";
            //        }
            //    }
            //}

            ////build the SQL
            //sqlQuery += str_Checkboxes + ";";


            //return sqlQuery;

            int checkedBoxCount = 0;

            if (onlineOnly.Checked == true)
                checkedBoxCount++;
            if (onSale.Checked == true)
                checkedBoxCount++;
            if (discontinued.Checked == true)
                checkedBoxCount++;

            return checkedBoxCount;
        }


    }
}