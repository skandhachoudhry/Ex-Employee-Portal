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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
           
        }
        protected void Login_Click1(object sender, EventArgs e)
        {
            int result = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
            con.Open();
            string query = "Select * from Reg_data where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'and User_Type='" + DropDownList1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            result = cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows && DropDownList1.Text == "Ex_Employee")
            {
                Label1.Text = "Login Successful !";
                Response.Redirect("~/Add_Query.aspx");
            }
            else if (rdr.HasRows && DropDownList1.Text == "Admin")
            {
                Label1.Text = "Login Successful !";
                Response.Redirect("~/Solve_query.aspx");
            }
            else
            {
                Label1.Text = "Usename & Password does'nt exist !";
            }
            con.Close();
        }
    }
}