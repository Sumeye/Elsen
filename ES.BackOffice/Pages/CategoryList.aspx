﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="CategoryList.aspx.cs" Inherits="Pages_CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12">Kategori EKLE</label>
        <div class="col-md-9 col-sm-9 col-xs-12">
            <div class="input-group demo2">
                <asp:Label ID="Label1" runat="server" Text="Kategori Adı"></asp:Label><br />
                <asp:TextBox runat="server" ID="txtCategoryName" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnInsert" runat="server" Text="Kaydet" OnClick="btnInsert_Click" CssClass="btn btn-success" />

            </div>
        </div>
    </div>





    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h2>Kategorileri Listele<small></small></h2>
                <ul class="nav navbar-right panel_toolbox">
                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                    </li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="#">Settings 1</a>
                            </li>
                            <li><a href="#">Settings 2</a>
                            </li>
                        </ul>
                    </li>
                    <li><a class="close-link"><i class="fa fa-close"></i></a>
                    </li>
                </ul>
                <div class="clearfix"></div>
            </div>
            <div class="x_content">
                <p class="text-muted font-13 m-b-30">
                    
                </p>

                <table id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" width="100%">
                    <thead>
                        <tr>
                            <th>Kategori Adı</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptCategory" runat="server" OnItemCommand="rptCategory_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("CategoryName") %></td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("CategoryId") %>' OnClientClick="return confirm('Bu kategoriyi silmek istediginizden emni misiniz?')" />
                                    </td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("CategoryId") %>' /></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</asp:Content>

