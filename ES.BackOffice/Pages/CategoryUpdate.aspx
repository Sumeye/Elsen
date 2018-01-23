<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="CategoryUpdate.aspx.cs" Inherits="Pages_CategoryUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
    <asp:Button ID="btnInsert" runat="server" Text="Güncelle" OnClick="btnInsert_Click" />
</asp:Content>

