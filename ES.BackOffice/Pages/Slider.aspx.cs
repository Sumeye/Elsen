using ES.BO.Repository;
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Slider : System.Web.UI.Page
{
    ContactRepository cr = new ContactRepository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void btnInsert_Click(object sender, EventArgs e)
    {
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
                    fuImage.PostedFiles[i].SaveAs(Server.MapPath("/Images/Upload/") + fuImage.PostedFiles[i].FileName);
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
        cr.Insert(new Contact
        {
            Title = txtTitle.Text,
            Body = txtBody.Text,
            ImagePath = durum,
            SortOrder = 1.ToString()

        });
        Response.Redirect("/Slider");

    }





}