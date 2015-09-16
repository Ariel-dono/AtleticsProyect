<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Administration/Administration.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="AtleticChampionship.Administration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container containerPaddingBottom containerOpacity containerColor separatorHeader">
        <div class="row">
            <div class="col-md-4">
                <img src="Images/logo2.png" runat="server" class="containerCustom alignImage" />
            </div>
            <div class="col-md-7">
                <div class="row">
                    <div class="containerCustom containerDifferentialColor containerColor">
                        <h1 class="text-center">Delegado de IAAF</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="containerCustom containerDifferentialColor">
                        <asp:Label ID="NombreUsuario" runat = "server" CssClass="fontCustom"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
