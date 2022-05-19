<%@ Page Title="Tabela država" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tabela.aspx.cs" Inherits="Merenje_test_1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1> Tabela država </h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="182px" Width="910px">
        <Columns>
            <asp:BoundField DataField="Naziv" HeaderText="Naziv" SortExpression="Naziv" />
            <asp:BoundField DataField="Oznaka" HeaderText="Oznaka" SortExpression="Oznaka" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NasaKonekcija %>" SelectCommand="SELECT [Naziv], [Oznaka] FROM [DrzavaTable]"></asp:SqlDataSource>
</asp:Content>
