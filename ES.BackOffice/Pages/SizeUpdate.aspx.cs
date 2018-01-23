using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_SizeUpdate : System.Web.UI.Page
{
    SizeRepository sr = new SizeRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;
        SizeList();

    }
    private void SizeList()
    {
        if (Request.QueryString["SizeID"] != null)
        {
            ProductSize updated = sr.SelectById(Convert.ToInt32(Request.QueryString["SizeID"]));
            txtName.Text = updated.Name;
            txtCode.Text = updated.Code;
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        ProductSize updated = sr.SelectById(Convert.ToInt32(Request.QueryString["SizeID"]));
        updated.Name = txtName.Text;
        updated.Code = txtCode.Text;
        sr.Update(updated);
        Response.Redirect("/OlcuListele");
    }
}