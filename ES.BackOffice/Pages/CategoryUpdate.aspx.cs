using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_CategoryUpdate : System.Web.UI.Page
{
    CategoryRepository cr = new CategoryRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminSession"] == null)
        {
            Response.Redirect("/Login");
        }
        if (!IsPostBack) return;
        CategoryFill();

    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Category updated = cr.SelectById(Convert.ToInt32(Request.QueryString["CategoryId"]));
        updated.CategoryName = txtCategoryName.Text;
        cr.Update(updated);
        Response.Redirect("/KategoriListele");
    }
    private void CategoryFill()
    {
        if (Request.QueryString["CategoryId"] != null)
        {
            Category updated = cr.SelectById(Convert.ToInt32(Request.QueryString["CategoryId"]));
            txtCategoryName.Text = updated.CategoryName;
        }

    }
}