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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register_Click(object sender, EventArgs e)
        {
           
        }

        protected void Register_Click1(object sender, EventArgs e)
        {
            int result=0;
            if (Page.IsPostBack == true)
            {
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || DropDownList1.SelectedValue == "Select")
                {
                    Label1.Text = "Fields can't be empty !!";
                    // TextBox1.Focus();

                }
                else if (TextBox7.Text != TextBox8.Text)
                {
                    Label2.Text = "Password do not Match !!";
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                    con.Open();
                    string query = "insert into Reg_data values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DropDownList1.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Label1.Text = "Account Created :)";
                    }
                    else
                    {
                        Label1.Text = "Please try Again :(";
                    }
                    con.Close();
                }

            }
        }
    }
}
