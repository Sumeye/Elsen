<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="Slider.aspx.cs" Inherits="Pages_Slider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12">SliDER EKLE</label>
        <div class="col-md-9 col-sm-9 col-xs-12">
            <div class="input-group demo2">
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label><br />
                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"></asp:TextBox>
                   <asp:Label ID="Label2" runat="server" Text="İçerik"></asp:Label><br />
                <asp:TextBox runat="server" ID="txtBody" CssClass="form-control"></asp:TextBox>
                          <asp:Label ID="Label3" runat="server" Text="Fotoğraf"></asp:Label><br />
                <asp:FileUpload ID="fuImage" runat="server" />
             <asp:Button ID="btnInsert" runat="server" Text="Kaydet"   OnClick="btnInsert_Click"  CssClass="btn btn-success" />

            </div>
        </div>
    </div>
</asp:Content>

