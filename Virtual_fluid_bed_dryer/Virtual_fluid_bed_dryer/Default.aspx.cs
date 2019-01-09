using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Virtual_fluid_bed_dryer
{
    public partial class Default : System.Web.UI.Page
    {
        public static User user = new User();

        public User User
        {
            get { return user; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registration.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> tmp_lst = DataEditor.GetUserByName(txtLogin.Text.Trim());
                if (tmp_lst.Count == 0) ClientMessageBox.Show("You are not registered", this);
                else if (tmp_lst.Count > 1) ClientMessageBox.Show("Error occured, administrator was informed. Sorry for inconvenience.", this);
                else
                {
                    user = tmp_lst[0];
                    if (user.Confirmed)
                    {
                        if (DataEditor.isPasswordMatch(txtLogin.Text.Trim(), txtPass.Text))
                        {
                            Session[txtLogin.Text.ToString()] = txtLogin.Text;
                            Response.Redirect("Main.aspx?Data=" + Server.UrlEncode(txtLogin.Text));
                        }
                        else ClientMessageBox.Show("Wrong password", this);
                    }
                    else
                    {
                        ClientMessageBox.Show("Your account was not confirmed", this);
                    }
                }

            }
            catch (Exception ex)
            {
                ClientMessageBox.Show(ex.Message.ToString(), this);
            }

        }

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
        }
    
}

//TIPS
//bezposrednie wywolanie alarmu z poziomu kodu html
//<asp:Button OnClientClick="alert('data will be saved')" ID="Button2" CausesValidation="false" runat="server" Text="Button"/>