using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ColorUpdate : System.Web.UI.Page
{
    ColorRepository clr = new ColorRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

        ColorList();


    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        ProductColor updated = clr.SelectById(Convert.ToInt32(Request.QueryString["ColorId"]));
        updated.ColorName = txtName.Text;
        updated.ColorCode = txtCode.Text;
        clr.Update(updated);
        Response.Redirect("/RenkListele");
    }
    private void ColorList()
    {
        if (Request.QueryString["ColorId"] != null)
        {
            ProductColor updated = clr.SelectById(Convert.ToInt32(Request.QueryString["ColorId"]));
            txtName.Text = updated.ColorName;
            txtCode.Text = updated.ColorCode;
        }
    }
}