using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ProductUpdate : System.Web.UI.Page
{
    ProductRepository pr = new ProductRepository();
    CategoryRepository cr = new CategoryRepository();
    BrandRepository br = new BrandRepository();
    SizeRepository sr = new SizeRepository();
    ColorRepository clr = new ColorRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

        InitData();
        ProductList();


    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Product updated = pr.SelectById(Convert.ToInt32(Request.QueryString["ProductId"]));
        updated.Name = txtProductName.Text;
        updated.ModelCode = txtModelCode.Text;
        updated.InstructionManual = textKullanmaTalimati.Value;
        updated.Stock = Convert.ToInt32(txtQuantity.Text);
        updated.ReturnConditions = iadesartlari.Value;
        updated.SalesPrice = Convert.ToDecimal(txtFiyat.Text);
        updated.SizeID = Convert.ToInt32(ddlSize.SelectedValue);
        updated.BrandID = Convert.ToInt32(ddlBrand.SelectedValue);
        updated.CategoryID = Convert.ToInt32(ddlCategory.SelectedValue);
        updated.ColorID = Convert.ToInt32(ddlColor.SelectedValue);
        updated.OldPrice = Convert.ToDecimal(txtEskiFiyat.Text);
        updated.Description = TextDesciption.Value;
        pr.Update(updated);
        Response.Redirect("/UrunleriListele");

    }


    private void ProductList()
    {
        if (Request.QueryString["ProductId"] != null)
        {
            Product updated = pr.SelectById(Convert.ToInt32(Request.QueryString["ProductId"]));
            txtModelCode.Text = updated.ModelCode;
            txtProductName.Text = updated.Name;
            ddlCategory.SelectedValue = updated.CategoryID.ToString();
            txtEskiFiyat.Text = updated.OldPrice.ToString();
            txtFiyat.Text = updated.SalesPrice.ToString();
            ddlColor.SelectedValue = updated.ProductColor.ColorName;
            ddlSize.SelectedValue = updated.ProductSize.Name;
            ddlBrand.SelectedValue = updated.ProductBrand.BrandName;
            txtQuantity.Text = updated.Stock.ToString();
            iadesartlari.Value = updated.ReturnConditions;
            textKullanmaTalimati.Value = updated.InstructionManual;
            TextDesciption.Value = updated.Description;
        }
    }

    protected void InitData()
    {
        #region Kategorileri Doldur!!!

        ddlCategory.DataSource = cr.SelectAll();
        ddlCategory.DataTextField = "CategoryName";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        #endregion
        #region Marka Doldur!!!
        ddlBrand.DataSource = br.SelectAll();
        ddlBrand.DataTextField = "BrandName";
        ddlBrand.DataValueField = "BrandId";
        ddlBrand.DataBind();
        #endregion
        #region Size Doldur!!!
        ddlSize.DataSource = sr.SelectAll();
        ddlSize.DataTextField = "Name";
        ddlSize.DataValueField = "SizeID";
        ddlSize.DataBind();
        #endregion
        #region Color Doldur!!!
        ddlColor.DataSource = clr.SelectAll();
        ddlColor.DataTextField = "ColorName";
        ddlColor.DataValueField = "ColorId";
        ddlColor.DataBind();
        #endregion
    }

}