<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="BrandUpdate.aspx.cs" Inherits="Pages_BrandUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox>
    <asp:Button ID="btnInsert" runat="server" Text="Güncelle" OnClick="btnInsert_Click" />
</asp:Content>

