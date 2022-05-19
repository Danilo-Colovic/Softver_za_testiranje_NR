<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tabela.aspx.cs" Inherits="Merenje_test_1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="height: 484px"><%: Title %>
        <table style="width: 100%; height: 480px;">
            <tr>
                <td class="modal-sm" style="width: 353px">&nbsp;</td>
                <td style="width: 747px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 353px">&nbsp;</td>
                <td style="width: 747px">
                    <asp:ListBox ID="ListaListBox" runat="server" Height="268px" Width="743px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 353px">&nbsp;</td>
                <td style="width: 747px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </h2>
</asp:Content>
