using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_NewProduct : System.Web.UI.Page
{
    ProductRepository pr = new ProductRepository();
    CategoryRepository cr = new CategoryRepository();
    BrandRepository br = new BrandRepository();
    SizeRepository sr = new SizeRepository();
    ColorRepository clr = new ColorRepository();
    ImageRepository Ir = new ImageRepository();
    ProductImage pI = new ProductImage();
    Product ProductId = new Product();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

        InitData();


    }
    bool aktifMi;
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        #region ÜrünAktifMiKontrolü !!
        if (urunaktifmi.Checked == true)
        {
            aktifMi = true;

        }
        else
        {
            aktifMi = false;
        }
        #endregion

        #region Image Ekleme!!!
        string durum = "";
        if (fuImage.HasFile)
        {
            IList<HttpPostedFile> SecilenDosyalar = fuImage.PostedFiles;
            FileInfo imgInfo = new FileInfo(fuImage.FileName);//dosya adı alındı
            string newimg = Guid.NewGuid().ToString() + imgInfo.Extension;//resme yeni ad verildi. guid unic bir sayı belirler
            if (newimg != null)
            {
                for (int i = 0; i < SecilenDosyalar.Count; i++)
                {
                    fuImage.PostedFiles[i].SaveAs(Server.MapPath("~/Images/Upload/") + fuImage.PostedFiles[i].FileName);
                }
                //fuImage.SaveAs(Server.MapPath("~/Images/Upload/") + newimg);
                durum = "/Images/Upload/" + newimg;
            }
        }
        if (durum == "")
        {
            durum = "Images/Upload/1.Png";
        }

        #endregion

        pr.Insert(new Product
        {


            ModelCode = txtModelCode.Text,
            Name = txtProductName.Text,
            CategoryID = Convert.ToInt32(ddlCategory.SelectedValue),
            OldPrice = Convert.ToDecimal(txtEskiFiyat.Text),
            SalesPrice = Convert.ToDecimal(txtFiyat.Text),
            ColorID = Convert.ToInt32(ddlColor.SelectedValue),
            SizeID = Convert.ToInt32(ddlSize.SelectedValue),
            Description = TextDesciption.Value,
            ReturnConditions = iadesartlari.Value,
            InstructionManual = textKullanmaTalimati.Value,
            Stock = Convert.ToInt32(txtQuantity.Text),
            BrandID = Convert.ToInt32(ddlBrand.SelectedValue),
            LastUpdate = DateTime.Now,
            CreatedDate = DateTime.Now,//ilk tarih nasıl tutulur?
            Status = aktifMi,
            ImagePath = durum,
        });
        Response.Redirect("/UrunleriListele");
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