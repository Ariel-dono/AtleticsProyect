<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Administration.Master" AutoEventWireup="true" CodeBehind="AdministracionEntidades.aspx.cs" Inherits="AtleticChampionship.Administration.AdministracionEntidades" %>
<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="containerDifferentialColor containerBorder">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="text-center alignCentral">Administración de entidades</h1>
                    </div>
                </div>
                <div class="row containerBorder">
                    <div class="col-md-12 text-center">
                        <asp:Button runat="server" OnClick="admCatalogos" Text="Catalogos" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
