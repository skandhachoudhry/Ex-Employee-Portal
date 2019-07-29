using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace GAIL
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int result;
            if (Page.IsPostBack == true)
            {
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || Calendar1.SelectedDate == null || DropDownList1.SelectedValue == "Select")
                {
                    Label2.Text = "Fields can't be empty !!";
                    TextBox3.Focus();

                }
                else
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                    con1.Open();
                    string query = "insert into Queries values('" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox3.Text + "','" + Calendar1.SelectedDate + "','" + TextBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con1);
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Label2.Text = "Query Submited we ll try to respond soon :)";
                    }
                    else
                    {
                        Label2.Text = "Please try Again :(";
                    }
                    con1.Close();
                }

            }
        }
    }
}