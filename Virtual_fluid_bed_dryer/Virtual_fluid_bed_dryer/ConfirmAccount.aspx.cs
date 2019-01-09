using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Virtual_fluid_bed_dryer
{
    public partial class ConfirmAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string confirmationToken = Request["confirmation"];

            try
            {
                if (new DataEditor().isGuidPresent(confirmationToken))
                {
                    lblResult.Text = "Your registration complete succesfully";
                    linkLogin.Visible = true;

                    DataEditor editor = new DataEditor();
                    int user_id = editor.deleteRowByGuid(confirmationToken);
                    editor.confirmRegistration(user_id);

                }
                else
                {
                    lblResult.Text = "Your registration request expired or you are already registered.";
                }
            }
            catch (Exception ex)
            {
                ClientMessageBox.Show(ex.Message.ToString(), this);
            }
        }
    }
}