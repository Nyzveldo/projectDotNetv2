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
    public partial class BookMeeting : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString= WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con.Open();
        }

        /*protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from data_table where lecturer='" + TextBox4.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows[0][0].ToString() == "1")
            {

                SqlCommand cmd = new SqlCommand("insert into BookMeeting" + "(LecturerName)values(@LecturerName)", con);
                cmd.Parameters.AddWithValue("@LecturerName", Label1);

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Succesful');</script>");
                Response.Write("alert('successful in login')");
                Response.Redirect("Menu.aspx");
            }


        }*/

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = (Calendar1.SelectedDate.ToShortDateString() + " " + TextBox1.Text).ToString();
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into BookMeeting"+"(LecturerName,DateTime,Description)values(@LecturerName,@DateTime,@Description)", con);
                cmd.Parameters.AddWithValue("@LecturerName", Label1);
                cmd.Parameters.AddWithValue("@DateTime", TextBox2);
                cmd.Parameters.AddWithValue("@Description", TextBox3);
                cmd.ExecuteNonQuery();

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Booking Succesfully Sumbmitted');</script>");
                Response.Write("alert('Booking Succesfully submit')");
            }
            catch(Exception){

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Booking failed to sumbit');</script>");

            }
        }

        /*protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.Text;
        } */

        protected void Button3_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {

                SqlCommand cmd = new SqlCommand("select* from data_table where lecturer='" + TextBox4.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Lecturer Found');</script>");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Lecturer Not Found');</script>");
                }
            }
            catch (Exception)
            {
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Lecturer Not Found');</script>");
            }

        }
    }
}