<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="NewProduct.aspx.cs" Inherits="Pages_NewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="col-md-6 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h1>Ürün Ekleme işlemleri</h1>
            </div>
            <div class="x_content">
                <br />
                <div class="control-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Model Kodu :</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtModelCode" runat="server" CssClass="tags form-control"></asp:TextBox>
                        <div id="suggestions-container" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Ürün Adı :</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtProductName" runat="server" CssClass="tags form-control"></asp:TextBox>
                        <div id="suggestions-container1" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Kategori</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control"></asp:DropDownList>
                        <div id="suggestions-container3" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Marka</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:DropDownList ID="ddlBrand" runat="server" CssClass="form-control"></asp:DropDownList>
                        <div id="suggestions-container4" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">
                        Açıklama <span class="required">*</span>
                    </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <textarea id="TextDesciption" class="form-control" rows="3" placeholder="" runat="server"></textarea>
                        <div id="suggestions-container5" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">
                        Kullanma Talimatı : <span class="required">*</span>
                    </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <textarea id="textKullanmaTalimati" class="form-control" rows="3" placeholder="" runat="server"></textarea>
                        <div id="suggestions-container6" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">
                        İade Şartları : <span class="required">*</span>
                    </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <textarea id="iadesartlari" class="form-control" rows="3" placeholder="" runat="server"></textarea>
                        <div id="suggestions-container7" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">
                        Stok : <span class="required">*</span>
                    </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control"></asp:TextBox>
                        <div id="suggestions-container8" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Fiyat </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtFiyat" runat="server" CssClass="tags form-control"></asp:TextBox>
                        <div id="suggestions-container10" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Eski Fiyat </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtEskiFiyat" runat="server" CssClass="tags form-control"></asp:TextBox>
                        <div id="suggestions-container11" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Ölçü</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:DropDownList ID="ddlSize" runat="server" CssClass="form-control"></asp:DropDownList>
                        <div id="suggestions-container9" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <!-- form color picker -->
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Renk</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:DropDownList ID="ddlColor" runat="server" CssClass="form-control"></asp:DropDownList>
                        <div id="suggestions-container13" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                </div>
                <!-- /form color picker -->
            
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Resim </label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:FileUpload ID="fuImage" runat="server" AllowMultiple="true" />
                        <div id="suggestions-container12" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                    </div>
                    </div>
                <div class="form-group">
                    <label class="control-label col-md-3 col-sm-3 col-xs-12">Switch</label>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <div class="">
                            <label>
                                <input id="urunaktifmi" type="checkbox" class="js-switch" checked  runat="server"/>
                                Ürün Yayınlansın mı
                           
                            </label>
                        </div>
                    </div>
                    <div class="ln_solid"></div>
                    <div class="form-group   ">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                            <asp:Button ID="btnInsert" runat="server" CssClass="btn btn-success" Text="KAYDET" OnClick="btnInsert_Click" />
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</asp:Content>

