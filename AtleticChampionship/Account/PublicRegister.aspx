<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicRegister.aspx.cs" Inherits="AtleticChampionship.Account.PublicRegister" %>
<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerBackground">
        <div class="container containerOpacity containerColor">
            <div class="container containerBorder">
                <p class="text-danger">
                    <asp:Literal runat="server" ID="ErrorMessage"/>
                </p>
                <div class="row">
                    <div class="col-md-12">
                        <h2 class="text-center">Registro</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <h4 class="text-center">Crear una nueva cuenta</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Nombre">Nombre</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Nombre" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre"
                                CssClass="text-danger" ErrorMessage="El campo de nombre es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Apellido">Apellido</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Apellido" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Apellido"
                                CssClass="text-danger" ErrorMessage="El campo de apellido es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Cedula">Cedula</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Cedula" CssClass="form-control" TextMode="Number" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Cedula"
                                CssClass="text-danger" ErrorMessage="El campo de cedula es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Codigo">Codigo de la IAAF</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Codigo" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Codigo"
                                CssClass="text-danger" ErrorMessage="El campo de codigo de delegado de la IAAF es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Telefono">Teléfono</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Telefono" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Telefono"
                                CssClass="text-danger" ErrorMessage="El campo de teléfono es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Email">Correo electrónico</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="El campo de correo electrónico es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Username">Nombre de Usuario</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Username" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Username"
                                CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                CssClass="text-danger" ErrorMessage="El campo de contraseña es obligatorio." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2 text-center containerCustom">
                        <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirmar contraseña</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="El campo de confirmación de contraseña es obligatorio." />
                            <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="La contraseña y la contraseña de confirmación no coinciden." />
                        </div>
                    </div>
                </div>
                <div class="row separatorContainer2">
                    <div class="col-md-11">
                        <div class="form-group">
                            <asp:Button runat="server" OnClick="CreateUser_Click" Text="Registrarse" CssClass="text-center btn btn-default buttomCustom alignRight" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
