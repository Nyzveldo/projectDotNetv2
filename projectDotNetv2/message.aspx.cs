using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace projectDotNetv2
{
    public partial class message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void sendMessagge(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("projectdotnet1819@gmail.com", "dotnet123");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add("danialwafiy1014@gmail.com");
                msgobj.From = new MailAddress("projectdotnet1819@gmail.com");
                msgobj.Subject = "A MESSAGE FROM THE LECTURE";
                msgobj.Body = msgText.Text;
                client.Send(msgobj);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Message has been sent')", true);

            }
            catch (Exception ex)
            {
                Response.Write("Could not send message"+ex.Message);
            }
        }
    }
}