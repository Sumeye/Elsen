<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

                <asp:Repeater ID="rptSlider" runat="server">
                    <ItemTemplate>


                        <img width="1920" height="570" src="<%#String.Format("{0}/Upload/banners/",Eval("ImagePath")) %>" />
                       
                        <%#Eval("Body") %> <%#Eval("Title") %>
                    </ItemTemplate>
                </asp:Repeater>

</asp:Content>

