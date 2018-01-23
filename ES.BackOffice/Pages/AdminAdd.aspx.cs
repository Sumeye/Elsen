using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_AdminAdd : System.Web.UI.Page
{
    AdminRepository ar = new AdminRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AdminFill();
        }

    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        ar.Insert(new Admin
        {
            FullName = txtFullName.Text,
            Email = txtEmail.Text,
            Password = txtPassword.Text,

        });
        Response.Redirect("/Admin");
    }

    protected void rptAdmin_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                ar.Delete(Convert.ToInt32(e.CommandArgument));
                AdminFill();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/AdminUpdate.aspx?AdminID={0}", e.CommandArgument));
                break;
        }
    }


    #region Admin Doldur!!
    protected void AdminFill()
    {
        rptAdmin.DataSource = ar.SelectAll();
        rptAdmin.DataBind();

    }
    #endregion
}