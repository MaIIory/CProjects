using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Virtual_fluid_bed_dryer
{
    public partial class HowTo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            Label label = (Label)Master.FindControl("lblLogin");
            label.Text = Server.UrlDecode(Request.QueryString["Data"]).ToString();
            txtLogin.Text = label.Text;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Label login_label = (Label)Master.FindControl("lblLogin");

            try
            {
                if (DataEditor.isLoginPresent(login_label.Text.Trim()))
                {
                    if (DataEditor.isPasswordMatch(login_label.Text.Trim(), txtOldPassword.Text.Trim()))
                    {
                        DataEditor editor = new DataEditor();

                        if (txtMail.Text.Trim() != "")
                            editor.changeUserEmail(login_label.Text, txtMail.Text.Trim());
                        if (chkPassword.Checked)
                            editor.changeUserPassword(login_label.Text, txtPass.Text);
                        

                        ClientMessageBox.Show("Your data is changed", this);

                    }
                    else
                    {
                        ClientMessageBox.Show("Old password is wrong", this);
                    }
                }
                else
                {
                    ClientMessageBox.Show("Login was not found in database", this);
                }
            }
            catch (Exception em)
            {
                ClientMessageBox.Show(em.Message, this);
            }

            chkPassword.Checked = false;
        }

        protected void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPass.Enabled = true;
                txtConfirmPassword.Enabled = true;
                valid1.Enabled = true;
                valid2.Enabled = true;
                valid3.Enabled = true;
                txtConfirmPassword.Attributes.Remove("style");
                txtPass.Attributes.Remove("style");
            }
            else
            {
                txtPass.Enabled = false;
                txtConfirmPassword.Enabled = false;
                valid1.Enabled = false;
                valid2.Enabled = false;
                valid3.Enabled = false;

                txtPass.Attributes.Add("style", "background: transparent url('images/bg4.jpg') no-repeat;");
                txtConfirmPassword.Attributes.Add("style", "background: transparent url('images/bg4.jpg') no-repeat;");
            }
            
            
        }
    }
}