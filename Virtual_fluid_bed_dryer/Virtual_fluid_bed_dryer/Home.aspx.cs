using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Virtual_fluid_bed_dryer
{
    public partial class tempForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label label = (Label)Master.FindControl("lblLogin");
            label.Text = Server.UrlDecode(Request.QueryString["Data"]).ToString();
        }
    }
}