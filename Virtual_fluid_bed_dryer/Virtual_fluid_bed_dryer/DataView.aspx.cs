using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Virtual_fluid_bed_dryer
{
    public partial class DataView : System.Web.UI.Page
    {
        Label lblLogin;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblLogin = (Label)Master.FindControl("lblLogin");
            lblLogin.Text = Server.UrlDecode(Request.QueryString["Data"]).ToString();

            try
            {
                DataEditor de = new DataEditor();
                lblUserId.Text = de.getUserId(lblLogin.Text).ToString();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

        protected void grvExperimentResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = (grvExperimentResult.SelectedRow.Cells)[1].Text.ToString();
            Label exp_lbl = (Label)Master.FindControl("lblExpNb");
            exp_lbl.Text = lblResult.Text;
        }


        protected void Save_Click(object sender, EventArgs e)
        {
            lblLogin = (Label)Master.FindControl("lblLogin");
            Response.Redirect("Main.aspx?Data=" + Server.UrlEncode(lblLogin.Text) + "&Exp=" + Server.UrlEncode(lblResult.Text));
        }
    }
}