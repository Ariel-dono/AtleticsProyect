<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataManagement.aspx.cs" MasterPageFile="~/Administration/Administration.Master" Inherits="AtleticChampionship.Administration.DataManagement" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="row">
                <div class="col-md-12 text-center">
                    <h1 class="text-center alignCentral">Información de campeonatos</h1>
                </div>
            </div>
            <div class="row containerBorder">
                <div class="col-md-7 text-center">
                    <asp:Label runat="server">Información de Campeonatos:</asp:Label>
                </div>
                <div class="col-md-5 text-center">
                    <asp:Button runat="server" OnClick="xmlCampeonatos" Text="Cargar XML" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                </div>
            </div>
            <div class="row containerBorder">
                <div class="col-md-7 text-center">
                    <asp:Label runat="server">Información de posiciones en Campeonatos:</asp:Label>
                </div>
                <div class="col-md-5 text-center">
                    <asp:Button runat="server" OnClick="xmlPosiciones" Text="Cargar XML" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
