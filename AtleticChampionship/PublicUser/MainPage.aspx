<%@ Page Title="" Language="C#" MasterPageFile="~/PublicUser/PublicUser.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="AtleticChampionship.PublicUser.MainPage" %>
<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="row">
                <div class="containerBorder">
                    <div class="col-md-3">
                        <img class="alignRight" src="~/Images/logo2.png" runat="server" />
                    </div>
                    <div class="col-md-9 containerDifferentialColor containerOpacity containerBorder">
                        <div class="row">
                            <div class="col-md-12">
                                <h1 class="text-center alignCentral">Mi Perfil</h1>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <asp:Label runat="server" ID="DatoNombre"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <asp:Label runat="server" ID="DatoUsername"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <asp:Label runat="server" ID="DatoCodigoIAAF"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
