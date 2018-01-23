using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPages_Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] != null)
        {
            lblwelcome.Text = "Hoşgeldin" + Session["adminSession"];
            lblhosgeldin2.Text = ""+ Session["adminSession"];

        }
        else
        {
            Response.Redirect("/Login");
        }
    }
}
