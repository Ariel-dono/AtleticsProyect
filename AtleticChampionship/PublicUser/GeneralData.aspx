<%@ Page Title="" Language="C#" MasterPageFile="~/PublicUser/PublicUser.Master" AutoEventWireup="true" CodeBehind="GeneralData.aspx.cs" Inherits="AtleticChampionship.PublicUser.GeneralData" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="containerDifferentialColor containerBorder">
                <div class="row">
                    <div class="col-md-12">
                        <h1 class="text-center alignCentral">Campeonatos en Estadisticas</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4  alignCentral">
                        <asp:Label runat="server">Seleccione un campeonato</asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:ListBox runat="server" ID="DropCampeonatos" CssClass="buttomCustom">
                        </asp:ListBox>
                    </div>
                    <div class="col-md-4 alignCentral">
                        <asp:Button runat="server" OnClick="Consultar" Text="Consultar" CssClass="text-center btn btn-default buttomCustom" />
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
