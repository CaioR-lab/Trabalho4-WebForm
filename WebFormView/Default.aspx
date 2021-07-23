<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebFormView._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cadastro Categoria</h1>
        <asp:Label ID="Cadastro" runat="server" Text="Cadastro:"></asp:Label>
        <asp:TextBox ID="Id" runat="server"></asp:TextBox>
        <asp:TextBox ID="Nome" runat="server"></asp:TextBox>


</asp:Content>
