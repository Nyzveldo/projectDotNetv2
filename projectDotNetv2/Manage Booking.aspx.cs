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
            /*string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select LecturerName,DateTime,Description,Status from [dbo].[BookMeeting]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            string d;
            int i=0;
            if (!Page.IsPostBack)
            {
                
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select LecturerName,DateTime,Description,Status from [dbo].[BookMeeting]";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center>");
                sb.Append("<h1>How to bind data</h1>");
                sb.Append("<h2>using stringbuilder  class</h2>");
                sb.Append("<hr/>");
                sb.Append("<table border=1>");
                sb.Append("<tr>");
                sb.Append("<th>");
                sb.Append("Lecturer Name");
                sb.Append("</th>");
                sb.Append("<th>");
                sb.Append("Date and Time");
                sb.Append("</th>");
                sb.Append("<th>");
                sb.Append("Description");
                sb.Append("</th>");
                sb.Append("<th>");
                sb.Append("Status");
                sb.Append("</th>");
                sb.Append("<th>");
                sb.Append("&nbsp&nbsp&nbsp");
                sb.Append("</th>");
                sb.Append("<th>");
                sb.Append("&nbsp&nbsp&nbsp");
                sb.Append("</th>");
                sb.Append("</tr>");

                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append("<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");  
                    }
                    i++;
                    
                    sb.Append("<td>");
                    sb.Append("<asp:LinkButton ID=\"linkaccept\" runat=\"server\" OnClick=\"Accept\"> Accept</asp:LinkButton>");
                    sb.Append("</td>");
                    sb.Append("<td>");
                    Button button = new Button();
                    sb.Append("</td>");
                    sb.Append("</tr>");

                }
                sb.Append("</table>");
                sb.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
                sqlconn.Close();

            }*/
        }
        /*protected void lnkAccept_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string query = "UPDATE BookMeeting SET Status='Accepted' WHERE meetingID=@ID";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            sqlcmd.Parameters.AddWithValue("@ID", ID);
            sqlcmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            lblSuccessMessage.Text = "The meeting is accepted";
            
   
        }*/
        void PopulateGridview()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(mainconn))
            {
                sqlCon.Open();
                string sqlquery = "select Student,DateTime,Description,Status,Lecturer from [dbo].[BookMeeting]";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
               sqlcomm.CommandType = CommandType.Text;
               sqlcomm.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                /* if (dt.Rows.Count < 0)
                 {
                     dt.Rows.Add(dt.NewRow());
                     GridView1.DataSource = dt;
                     GridView1.DataBind();
                     GridView1.Rows[0].Cells.Clear();
                     GridView1.Rows[0].Cells.Add(new TableCell());
                     GridView1.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                     GridView1.Rows[0].Cells[0].Text = "No Meeting Found";
                     GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
                 }*/
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Accept")
            {
                string accept = "Accepted";
                //GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
                //GridView gv = (GridView)(e.CommandSource);
                //string s = gv.DataKeys[row.RowIndex][0].ToString();
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
                //int index = Convert.ToInt32(e.CommandArgument);

                //GridViewRow selectedrow = GridView1.Rows[index];
                //selectedrow.Cells[4].Text = "Accepted";

            }
        }
        /*protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (e.CommandName.Equals("Accept"))
            {
                using (SqlConnection Sqlcon = new SqlConnection(mainconn))
                {
                    Sqlcon.Open();
                    string query = "UPDATE BookMeeting SET Status='Accepted' WHERE meetingID=@id";
                    SqlCommand sqlcmd = new SqlCommand(query, Sqlcon);
                    sqlcmd.Parameters.AddWithValue("@id", Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()));
                    GridView1.EditIndex = -1;
                    sqlcmd.ExecuteNonQuery();
                    PopulateGridview();
                    lblSuccessMessage.Text = "The meeting is accepted";

                }
                using (SqlConnection sqlCon = new SqlConnection(mainconn))
           */
        }


    }
}