using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Virtual_fluid_bed_dryer
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string login;

        protected void Page_Load(object sender, EventArgs e)
        {
               
        }


        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?Data=" + Server.UrlEncode(lblLogin.Text));
        }

        protected void ExperimentsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx?Data=" + Server.UrlEncode(lblLogin.Text));
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataView.aspx?Data=" + Server.UrlEncode(lblLogin.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "";
            Server.Transfer("Default.aspx");
        }


        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx?Data=" + Server.UrlEncode(lblLogin.Text));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact_form.aspx?Data=" + Server.UrlEncode(lblLogin.Text));
        }


    }
}