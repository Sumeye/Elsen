using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_BrandUpdate : System.Web.UI.Page
{
    BrandRepository br = new BrandRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

           BrandFill();
       
    }

    private void BrandFill()
    {
        if (Request.QueryString["BrandId"] != null)
        {
            ProductBrand updated = br.SelectById(Convert.ToInt32(Request.QueryString["BrandId"]));
            txtBrandName.Text = updated.BrandName;
        }
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        ProductBrand updated = br.SelectById(Convert.ToInt32(Request.QueryString["BrandId"]));
        updated.BrandName = txtBrandName.Text;
        br.Update(updated);
        Response.Redirect("/MarkaListele");
    }
}