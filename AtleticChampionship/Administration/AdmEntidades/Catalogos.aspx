<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Administration.Master" AutoEventWireup="true" CodeBehind="Catalogos.aspx.cs" Inherits="AtleticChampionship.Administration.AdmEntidades.Catalogos" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    <div class="separatorTopContainer separatorBottomContainer containerUserBackground">
        <div class="container containerOpacity containerColor containerTop containerBottom">
            <div class="containerDifferentialColor containerBorder">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="text-center alignCentral">Administración de Entidades-Catalogo</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <asp:Label runat="server">Seleccione para modificar o insertar</asp:Label>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList runat="server" OnSelectedIndexChanged="CargarEntidades" CssClass="buttomCustom" ID="Entidades" AutoPostBack="true">
                            <asp:ListItem Text="Estado" Value="0" />
                            <asp:ListItem Text="TipoCompetencia" Value="1" />
                            <asp:ListItem Text="TipoSanción" Value="2" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:ListBox runat="server" ID="InformacionEntidades" CssClass="buttomCustom" />
                    </div>
                </div>
                <asp:Panel runat="server" ID="Operaciones">
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Button runat="server" OnClick="Actualiza" Text="Actualizar" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                        </div>
                        <div class="col-md-6">
                            <asp:Button runat="server" OnClick="Inserta" Text="Insertar" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                        </div>
                    </div>
                    <div class="row">
                        <asp:Panel runat="server" ID="OperacionPuntual">
                            <div class="col-md-6">
                                <asp:TextBox runat="server" ID="nuevaDescripcion" CssClass="buttomCustom"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Button runat="server" OnClick="Commit" Text="Commit" CssClass="text-center btn btn-default buttomCustom alignCentral" />
                            </div>
                        </asp:Panel>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
