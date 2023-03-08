<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MasterClass.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Bandas de música elegidas por las y los coders</h1><br />

    <div class="container" style="font-size: larger">
        <label class="form-label" for="banda">Banda musical: </label>
        <asp:Label class="form-label" Text="Valor preformateado" runat="server" ID="lblBanda" /><br />
        <label class="form-label" for="coder">Elegida por: </label>
        <asp:Label class="form-label" Text="Valor preformateado" runat="server" ID="lblCoder" />
    </div>





</asp:Content>
