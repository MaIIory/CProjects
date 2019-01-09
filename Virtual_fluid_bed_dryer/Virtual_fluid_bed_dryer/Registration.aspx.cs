using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;



namespace Virtual_fluid_bed_dryer
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            
            DataEditor editor = new DataEditor();

            string GUID;

            do {
                GUID = System.Guid.NewGuid().ToString();
                }while(editor.isGuidPresent(GUID));

            bool loginOccupied = DataEditor.isLoginPresent(txtLogin.Text.Trim());
            bool emailOccupied = editor.isEmailPresent(txtEmail.Text.Trim());


            if (loginOccupied && emailOccupied) ClientMessageBox.Show("Login and email address are already occupied", this);
            else if (!loginOccupied && emailOccupied) ClientMessageBox.Show("Email address is already occupied", this);
            else if (loginOccupied && !emailOccupied) ClientMessageBox.Show("Login is already occupied", this);
            else
            {
                try
                {
                    editor.AddUser(txtLogin.Text.Trim(), txtPassword.Text, txtEmail.Text.Trim(), GUID);
                    SendConfirmationMail(txtEmail.Text, GUID);
                }
                catch(Exception ex)
                {
                    ClientMessageBox.Show(ex.Message.ToString(), this);
                }

                txtConfirmPassword.Text = "";
                txtEmail.Text = "";
                txtLogin.Text = "";
                txtPassword.Text = "";
                lblConfirmation.Text = "Check your email box, activation link was just sent";
                lblConfirmation.Visible = true;
                hlinkDefault.Visible = true;
            }
		}

        protected void SendConfirmationMail(string To, string GUID)
        {
            MailAddress from = new MailAddress("lukasz@lc.edu.pl");
            MailAddress to = new MailAddress(To);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "[Virtual Fluid Bed Dryer] Activation Link";
            message.Body = "Hello, you are almost registered to virtualfluidbeddryer.com! \n All you have to do is to click to below activation link: \n" + 
                "http://localhost:51031/ConfirmAccount.aspx?confirmation=" + GUID +
                "\nYou have 7 days, after that your request will expire!";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("luk.cnota@gmail.com", "supermaly1");
            smtpClient.Send(message);

        }

        public static class ClientMessageBox
        {

            public static void Show(string message, Control owner)
            {
                Page page = (owner as Page) ?? owner.Page;
                if (page == null) return;

                page.ClientScript.RegisterStartupScript(owner.GetType(),
                    "ShowMessage", string.Format("<script type='text/javascript'>alert('{0}')</script>",
                    message));

            }
            //bezposrednie wywolanie alarmu z poziomu kodu html
            //<asp:Button OnClientClick="alert('data will be saved')" ID="Button2" CausesValidation="false" runat="server" Text="Button"/>

        }


    }

}
