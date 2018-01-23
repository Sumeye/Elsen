<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeFile="AdminAdd.aspx.cs" Inherits="Pages_AdminAdd" %>

<script runat="server">

    protected void rptAdmin_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- start form for validation -->
    <h1>ADMİN EKLE</h1>
    <label for="fullname">Full Name * :</label>
    <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server"></asp:TextBox>


    <label for="email">Email * :</label>
    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
    <label for="email">Password * :</label>
    <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password" data-parsley-trigger="change"></asp:TextBox>


    <asp:Button ID="btnInsert" runat="server" Text="KAYDET" CssClass="btn btn btn-success" OnClick="btnInsert_Click" />
    <!-- end form for validations -->




    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h2>ADMİN LİSTELE<small></small></h2>
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
                            <th>Adı Soyadı</th>
                            <th>E-Mail</th>
                            <th>Şifre</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptAdmin" runat="server"    OnItemCommand="rptAdmin_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("FullName") %></td>
                                    <td><%#Eval("Email") %></td>
                                    <td><%#Eval("Password") %></td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("AdminID") %>' OnClientClick="return confirm('Bu kategoriyi silmek istediginizden emni misiniz?')" />
                                    </td>
                                    <td>
                                        <asp:ImageButton ImageUrl="../Images/icon/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("AdminID") %>' /></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>



</asp:Content>

