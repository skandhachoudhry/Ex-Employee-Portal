using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace GAIL
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                con.Open();
                SqlDataAdapter Adp = new SqlDataAdapter("Select [Query_ID],[Description] from Queries where Username='" + TextBox1.Text + "'", con);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                GridView1.DataSource = Dt;
                GridView1.DataBind();
                con.Close();
            }
           
            
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["GAIL"].ConnectionString;
                con.Open();
                SqlDataAdapter Adp = new SqlDataAdapter("select [Query_ID],[Solution] from Solution where Username='" + TextBox1.Text + "'", con);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                GridView2.DataSource = Dt;
                GridView2.DataBind();
                con.Close();
            }


        }
    }
}