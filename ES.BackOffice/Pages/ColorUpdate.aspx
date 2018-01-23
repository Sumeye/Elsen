<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="ColorUpdate.aspx.cs" Inherits="Pages_ColorUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <h1>Güncelleme</h1>
    <asp:TextBox ID="txtCode" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnInsert" runat="server" Text="Kaydet"   OnClick="btnInsert_Click" />
</asp:Content>

