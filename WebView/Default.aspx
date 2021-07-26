<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebView._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cadastro</h1>
        <h3>Cadastro Produto</h3>
        <asp:Label ID="lbNomeProduto" runat="server" Text="Produto:"></asp:Label>
        <asp:TextBox ID="tbxNomeProduto" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbDescricaoProduto" runat="server" Text="Descricao:"></asp:Label>    
        <asp:TextBox ID="tbxDescricaoProduto" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbCategoriaProduto" runat="server" Text="Categoria:"></asp:Label>
        <asp:TextBox ID="tbxCategoriaProduto" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSalvarProduto" runat="server" Text="Salvar" />
        <asp:Button ID="btnLimparProduto" runat="server" Text="Limpar" />
        <asp:GridView ID="gvProduto" runat="server"></asp:GridView>
        <br />
        <h3>Cadastro Categoria</h3>
        <asp:Label ID="lbNomeCategoria" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="tbxNomeCategoria" runat="server"></asp:TextBox>
        <br />        
        <asp:Label ID="lbDescricaoCategoria" runat="server" Text="Descricao:"></asp:Label>
        <asp:TextBox ID="tbxDescricaoCategoria" runat="server"></asp:TextBox>
        <br />        
        <asp:Button ID="btnSalvarCategoria" runat="server" Text="Salvar" />
        <asp:Button ID="btnLimparCategoria" runat="server" Text="Limpar" />
        <asp:GridView ID="gvCategoria" runat="server"></asp:GridView>
        <br />

        </div>

</asp:Content>
