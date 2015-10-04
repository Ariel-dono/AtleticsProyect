<%@ Page Title="" Language="C#" MasterPageFile="~/PublicUser/PublicUser.Master" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="AtleticChampionship.PublicUser.UserData" %>
<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="containerDifferentialColor containerBorder">
                <div class="row">
                    <div class="col-md-12">
                        <h1 class="text-center alignCentral">Mis Estadisticas</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView runat="server" ID="GeneralInfo">
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
