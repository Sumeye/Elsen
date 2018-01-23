using ES.BO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ProductList : System.Web.UI.Page
{
    ProductRepository pr = new ProductRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

        ProductList();

    }

    protected void rptProductList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                pr.Delete(Convert.ToInt32(e.CommandArgument));
                ProductList();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/ProductUpdate.aspx?ProductId={0}", e.CommandArgument));
                break;
        }

    }

    #region Ürün Listele!!
    protected void ProductList()
    {
        rptProductList.DataSource = pr.SelectAll().Select(a => new
        {
            a.ModelCode,
            a.Name,
            a.OldPrice,
            a.ProductBrand.BrandName,
            a.Category.CategoryName,
            a.SalesPrice,
            a.Description,
            a.InstructionManual,
            a.ReturnConditions,
            a.ProductColor.ColorName,
            a.ProductSize.SizeID,
            a.Quantity,
            a.Status,
            a.Stock,
            a.ImagePath,

            a.CreatedDate,
            a.ProductID,




        });
        rptProductList.DataBind();

    }
    #endregion
}