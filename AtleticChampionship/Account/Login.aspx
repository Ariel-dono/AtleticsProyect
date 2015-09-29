<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AtleticChampionship.Account.Login" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="containerTop containerBottom2 containerBackground">
        <div class="container containerOpacity containerColor">
            <div class="containerBorder">
                <p class="text-danger">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <div class="row">
                    <div class="col-md-12">
                        <h2 class="text-center"><%: Title %></h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2">
                        <asp:Label runat="server" AssociatedControlID="UserName">Nombre de Usuario:</asp:Label>
                    </div>
                    <div class="col-md-10">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center">
                        <asp:Label runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                    </div>
                    <div class="col-md-10">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="El campo de contraseña es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Button runat="server" OnClick="LogIn" Text="Iniciar sesión" CssClass="text-center btn btn-default buttomCustom alignRight" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
