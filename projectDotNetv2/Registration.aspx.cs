using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace projectDotNetv2
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string command = "INSERT INTO regi(urname,email,passwd) VALUES(@urname,@email,@passwd)";
                SqlCommand cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@urname", txturname.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@passwd", txtpasswd.Text);

                cmd.ExecuteNonQuery();

                Label1.Visible = true;
            }
            catch(Exception)
            {
                Label1.Text = "Something Goes Wrong.";
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}