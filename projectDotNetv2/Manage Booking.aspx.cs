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
    public partial class WebForm3 : System.Web.UI.Page
    {
        int no=0;
        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridview();
            }
            
        }
        
        void PopulateGridview()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(mainconn))
            {
                sqlCon.Open();
                string sqlquery = "select Student,DateTime,Description,Status from [dbo].[BookMeeting]";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
               sqlcomm.CommandType = CommandType.Text;
               sqlcomm.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                
            }
        }

        /*protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Accept")
            {
                string accept ="accepted";
                
                using (SqlConnection sqlCon = new SqlConnection(mainconn))
                {
                    sqlCon.Open();
                    string sqlquery = "UPDATE BookMeeting SET Status='"+accept+"WHERE meetingID=" + s + "')";

                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.Parameters.AddWithValue("@meetingID", s);
                    sqlcomm.ExecuteNonQuery();

                    SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                
            }
        }*/
        
        }


    }
