using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace projectDotNetv2
{
    public partial class Whatsapp_Api : System.Web.UI.Page
    {
        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(mainconn))
            {
                string name = TextBox1.Text;
                sqlCon.Open();
                string sqlquery = "SELECT Lect_Name,Email,PhoneNum FROM [dbo].[LecturerInfo] WHERE LOWER(Lect_Name) LIKE LOWER('"+TextBox1.Text+"')";
                
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.Parameters.AddWithValue("@name", name);
                sqlcomm.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();



            }
        }
    }
}