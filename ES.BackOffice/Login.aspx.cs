using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        if (Response.Cookies["Email"] != null && Response.Cookies["Password"] != null)
        {
            txtEmail.Text = Response.Cookies["Email"].Value;
            txtPassword.Text = Response.Cookies["Password"].Value;
        }


    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var context = new ElsenOnlineEntities();
        foreach (var user in context.Admin)
        {
            if (user.Email == txtEmail.Text && user.Password == txtPassword.Text)
            {
                Session["adminSession"] = user.FullName;
                Session.Timeout = 30;
                Response.Redirect("/UrunleriListele");

            }
            else
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
            }

        }
    }
}