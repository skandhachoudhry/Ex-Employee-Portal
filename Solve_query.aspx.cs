using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace GAIL
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                con.Open();
                SqlDataAdapter Adp = new SqlDataAdapter("select [Username],[Query_ID],[Description] from Queries where Department='" + DropDownList1.Text + "'", con);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                GridView1.DataSource = Dt;
                GridView1.DataBind();
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Page.IsPostBack == true)
            {
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
                {
                    Label1.Text = "Fields can't be empty !!";

                }
                else
                {
                    con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                    con.Open();
                    string query = "insert into Solution values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Label1.Text = "Query Solved !";
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