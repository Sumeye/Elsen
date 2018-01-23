using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BO.Repository;
using ES.DALL.Models;
public partial class Pages_ColorList : System.Web.UI.Page
{
    ColorRepository clr = new ColorRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;
            SizeList();
      

    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        clr.Insert(new ProductColor { ColorName = txtName.Text, ColorCode = txtCode.Text });
        Response.Redirect("/RenkListele");

    }

    protected void rptColor_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                clr.Delete(Convert.ToInt32(e.CommandArgument));
                SizeList();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/ColorUpdate.aspx?ColorId={0}", e.CommandArgument));
                break;
        }
    }
    #region Color Listele!!
    protected void SizeList()
    {
        rptColor.DataSource = clr.SelectAll();
        rptColor.DataBind();

    }
    #endregion
}