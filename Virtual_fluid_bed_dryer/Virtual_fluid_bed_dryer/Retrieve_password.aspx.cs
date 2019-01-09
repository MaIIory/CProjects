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
    public partial class Retrieve_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {


            try
            {
                DataEditor editor = new DataEditor();
                bool emailOccupied = editor.isEmailPresent(txtEmail.Text.Trim());

            if (!emailOccupied)
            {
                ClientMessageBox.Show("Account with specified email does not exist!", this);
            }
            else //email exist
            {
                User usr = new User();
                usr = DataEditor.GetUserByEmail(txtEmail.Text.Trim());

                try
                {
                SendPasswordMail(txtEmail.Text, usr.Password);
                txtEmail.Text = "";
                lblConfirmation.Text = "Check your email box. \nThe email with your password was sent.";
                }
                catch(Exception ex)
                {
                    ClientMessageBox.Show(ex.Message.ToString(), this);
                }
            }

            }
            catch (Exception ex)
            {
                ClientMessageBox.Show("Error occured during email verification. Try again later.", this);
            }
        }

        protected void SendPasswordMail(string To, string password)
        {
            MailAddress from = new MailAddress("lukasz@lc.edu.pl");
            MailAddress to = new MailAddress(To);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "[Virtual Fluid Bed Dryer] Password Recovery";
            message.Body = "Hello,\n your password is: " + password + ".";
            //SmtpClient smtpClient = new SmtpClient("lc.edu.pl", 587);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            //smtpClient.Credentials = new NetworkCredential("lukasz@lc.edu.pl", "sky1mal");
            smtpClient.Credentials = new NetworkCredential("luk.cnota@gmail.com", "supermaly1");
            
            smtpClient.Send(message);

           

        }
    }
}