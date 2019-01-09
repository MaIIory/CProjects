using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace Virtual_fluid_bed_dryer
{
    public partial class Contact_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label label = (Label)Master.FindControl("lblLogin");
            label.Text = Server.UrlDecode(Request.QueryString["Data"]).ToString();
            txtLogin.Text = label.Text;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessage("luk.cnota@gmail.com", txtTopic.Text, txtLogin.Text, txtName.Text, txtMessage.Text, txtMail.Text);
                txtMail.Text = "";
                txtMessage.Text = "";
                txtName.Text = "";
                txtTopic.Text = "";

                ClientMessageBox.Show("Email was successfully sent.", this);
            }
            catch (Exception ex)
            {
                ClientMessageBox.Show("Email was not sent. Try again.", this);
            }
        }

        protected void SendMessage(string To, string topic, string login, string name, string message_content, string mail_to_reply)
        {
            MailAddress from = new MailAddress("luk.cnota@gmail.com");
            MailAddress to = new MailAddress(To);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "[VFBD Contact Form] " + topic;
            message.Body = "User: " + login + "\n" +
            "Name: " + name + "\n" +
            "Mail to reply: " + mail_to_reply + "\n" +
            "Message: " + message_content + "\n";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("luk.cnota@gmail.com", "supermaly1");
            smtpClient.Send(message);
        }


    }
}