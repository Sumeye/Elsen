using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BO.Repository;
using ES.DALL.Models;

public partial class Pages_BrandList : System.Web.UI.Page
{
    BrandRepository br = new BrandRepository();
    protected void Page_Load(object sender, EventArgs e)
    {   if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

     
        BrandFill();

    }

    protected void rptBrand_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                br.Delete(Convert.ToInt32(e.CommandArgument));
                BrandFill();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/BrandUpdate.aspx?BrandId={0}", e.CommandArgument));
                break;
        }

    }
    #region Marka Doldur!!
    protected void BrandFill()
    {
        rptBrand.DataSource = br.SelectAll();
        rptBrand.DataBind();

    }
    #endregion

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        br.Insert(new ProductBrand { BrandName = txtBrandName.Text });
        Response.Redirect("/MarkaListele");
    }
}