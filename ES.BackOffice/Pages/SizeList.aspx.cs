using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BO.Repository;
using ES.DALL.Models;
public partial class Pages_SizeAdd : System.Web.UI.Page
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

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        sr.Insert(new ProductSize { Name = txtName.Text, Code=txtCode.Text });
        Response.Redirect("/OlcuListele");
    }

    protected void rptSize_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                sr.Delete(Convert.ToInt32(e.CommandArgument));
                SizeList();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/SizeUpdate.aspx?SizeID={0}", e.CommandArgument));
                break;
        }

    }
    #region Size Listele!!
    protected void SizeList()
    {
        rptSize.DataSource = sr.SelectAll();
        rptSize.DataBind();

    }
#endregion
}