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
                string command = "INSERT INTO SQLQuery1(urname,email,phonenum,passwd) VALUES(@urname,@email,@phonenum,@passwd)";
                SqlCommand cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@urname", txturname.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@passwd", txtpasswd.Text);
                cmd.Parameters.AddWithValue("@phonenum", txtphonenum.Text);

                cmd.ExecuteNonQuery();

                Label1.Visible = true;

            }
            catch(Exception)
            {
                Label1.Text = "Something Goes Wrong.";
                
            }
            finally
            {
                con.Close();
            }
        }
    }
}