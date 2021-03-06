﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" href="images/favicon.ico" type="image/ico" />
    <title>Gentelella Alela! | </title>
    <!-- Bootstrap -->
    <link href="../Design/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link href="../Design/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <!-- NProgress -->
    <link href="../Design/vendors/nprogress/nprogress.css" rel="stylesheet" />
    <!-- Animate.css -->

    <link href="Design/vendors/animate.css/animate.min.css" rel="stylesheet" />
    <!-- Custom Theme Style -->
    <link href="../Design/build/css/custom.min.css" rel="stylesheet" />

</head>
<body class="login">

    <div>
        <a class="hiddenanchor" id="signup"></a>
        <a class="hiddenanchor" id="signin"></a>

        <div class="login_wrapper">
            <div class="animate form login_form">
                <section class="login_content">
                    <form runat="server">
                        <h1>GİRİŞ FORMU</h1>
                        <div>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div>
                            <asp:TextBox ID="txtPassword"   runat="server" CssClass="form-control"  TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Button ID="btnLogin" CssClass="btn btn-default submit"  runat="server" Text="Giriş Yap" OnClick="btnLogin_Click"/>
                            <a class="reset_pass" href="#">Şifreni mi unuttun?</a>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <p class="change_link">
                                Hesabın Yokmu?
                 
                                <a href="#signup" class="to_register">Hesap Oluştur </a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-paw"></i>ELSEN</h1>
                                <p>©2017 Tüm Hakları Saklıdır. SWEB DESIGN tarafından yapılmıştır.</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>

            <div id="register" class="animate form registration_form">
                <section class="login_content">
                    <form>
                        <h1>Hesap Oluştur</h1>
                        <div>
                            <input type="text" class="form-control" placeholder="Username" required="" />
                        </div>
                        <div>
                            <input type="email" class="form-control" placeholder="Email" required="" />
                        </div>
                        <div>
                            <input type="password" class="form-control" placeholder="Password" required="" />
                        </div>
                        <div>
                            <a class="btn btn-default submit" href="index.html">Submit</a>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <p class="change_link">
                               Şifreni mi Unuttun ?
                 
                                <a href="#signin" class="to_register">Giriş Yap </a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-paw"></i>ELSEN</h1>
                                <p>©2018 Tüm Hakları Saklıdır. SWEB DESIGN tarafından yapılmıştır.</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>
        </div>
    </div>
</body>


</html>
