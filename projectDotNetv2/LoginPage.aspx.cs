using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace projectDotNetv2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from SQLQuery1 where urname='" + TextBox1.Text + "' and passwd ='" + TextBox2.Text + "' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Succesful');</script>");
                    Response.Write("alert('successful in login')");
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    Response.Write("alert('error in login')");
                }
            }
            catch (Exception)
            {
                Response.Write("error in login");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed');</script>");
            }
        }

        protected void ButtonGoogeLogin_Click(object sender, EventArgs e)
        {

        }
    }
}