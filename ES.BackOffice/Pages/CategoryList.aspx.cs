using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_CategoryList : System.Web.UI.Page
{
    CategoryRepository cr = new CategoryRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (IsPostBack) return;

        CategoryFill();

    }
    protected void rptCategory_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "delete":
                cr.Delete(Convert.ToInt32(e.CommandArgument));
                CategoryFill();
                break;
            case "update":
                Response.Redirect(string.Format("~/Pages/CategoryUpdate.aspx?CategoryId={0}", e.CommandArgument));
                break;
        }
    }


    #region Kategorileri Doldur!!
    protected void CategoryFill()
    {
        rptCategory.DataSource = cr.SelectAll();
        rptCategory.DataBind();

    }
    #endregion

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        cr.Insert(new Category { CategoryName = txtCategoryName.Text });
        Response.Redirect("/KategoriListele");

    }
}