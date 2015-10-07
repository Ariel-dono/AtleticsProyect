<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Administration.Master" AutoEventWireup="true" CodeBehind="Campeonatos.aspx.cs" Inherits="AtleticChampionship.Administration.AdmEntidades.Campeonatos" %>
<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="containerDifferentialColor containerBorder">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="text-center alignCentral">Administración de entidades de Campeonatos</h1>
                    </div>
                </div>
                <div class="row">
                     <div class="col-md-6">
                         <asp:Label runat="server">Seleccione para modificar o insertar</asp:Label>
                     </div>
                    <div class="col-md-6">
                        <asp:DropDownList runat="server" OnSelectedIndexChanged="CargarEntidades" CssClass="buttomCustom">
                            <asp:ListItem Text="Campeonatos" Value="0"/>
                            <asp:ListItem Text="Competencia" Value="1"/>
                            <asp:ListItem Text="Etapa" Value="2"/>
                            <asp:ListItem Text="Concurso" Value="3"/>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
