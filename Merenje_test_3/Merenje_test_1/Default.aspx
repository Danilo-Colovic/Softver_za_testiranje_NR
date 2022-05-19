<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Merenje_test_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Merenje_test_1</h1>
        <p></p>
        <asp:Panel ID="Panel1" runat="server" Height="302px">
            <table style="width:100%; height: 299px;">
                <tr>
                    <td class="modal-sm" style="width: 399px">&nbsp;</td>
                    <td class="modal-sm" style="width: 60px">&nbsp;</td>
                    <td style="width: 139px">&nbsp;</td>
                    <td style="width: 79px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 399px">&nbsp;</td>
                    <td class="modal-sm" style="width: 60px">Naziv:</td>
                    <td style="width: 139px">
                        <asp:TextBox ID="NazivTextBox" runat="server" Width="154px"></asp:TextBox>
                    </td>
                    <td style="width: 79px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 399px">&nbsp;</td>
                    <td class="modal-sm" style="width: 60px">Oznaka:</td>
                    <td style="width: 139px">
                        <asp:TextBox ID="OznakaTextBox" runat="server" Width="155px"></asp:TextBox>
                    </td>
                    <td style="width: 79px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 399px">&nbsp;</td>
                    <td class="modal-sm" style="width: 60px">&nbsp;</td>
                    <td style="width: 139px">
                        <asp:Button ID="SnimiButton" runat="server" Text="SNIMI" Width="160px" OnClick="SnimiButton_Click" style="margin-left: 3px" />
                    </td>
                    <td style="width: 79px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 399px">&nbsp;</td>
                    <td class="modal-sm" style="width: 60px">&nbsp;</td>
                    <td style="width: 139px">&nbsp;</td>
                    <td style="width: 79px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </div>

    </asp:Content>
