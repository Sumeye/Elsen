<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="Pages_ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h2>Ürünleri Listele<small></small></h2>
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
                            <th>Model Kodu</th>
                            <th>Ürün Adı</th>
                            <th>Kategori Adı</th>
                            <th>Eski fiyat</th>
                            <th>Satış fiyatı</th>
                            <th>Stok</th>
                            <th>Açıklama</th>
                            <th>İade Şartları</th>
                            <th>Kullanma Talimatı</th>
                            <th>Aktiflik</th>
                            <th>Ölçü</th>
                            <th>Resim</th>
                            <th>Renk</th>
                            <th>Marka</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptProductList" runat="server" OnItemCommand="rptProductList_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("ModelCode") %></td>
                                    <td><%#Eval("Name") %></td>
                                    <td><%#Eval("CategoryName") %></td>
                                    <td><%#Eval("OldPrice") %></td>
                                    <td><%#Eval("SalesPrice") %></td>
                                    <td><%#Eval("Stock") %></td>
                                    <td><%#Eval("Description") %></td>
                                    <td><%#Eval("ReturnConditions") %></td>
                                    <td><%#Eval("InstructionManual") %></td>

                                    <td><%#Eval("Status") %></td>
                                    <td><%#Eval("SizeID") %></td>
                                    <td>
                                        <img width="75" height="30" src="http://localhost:55871/<%#Eval("ImagePath")%>" /></td>

                                    <td><%#Eval("ColorName") %></td>
                                    <td><%#Eval("BrandName") %></td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("ProductId") %>' OnClientClick="return confirm('Bu kategoriyi silmek istediginizden emni misiniz?')" />
                                    </td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("ProductId") %>' /></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
</asp:Content>

