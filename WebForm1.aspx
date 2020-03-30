<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalcApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 61px">Number1</td>
            <td style="width: 155px">Operator</td>
            <td class="modal-sm" style="width: 154px">Number 2</td>
            <td style="width: 184px">&nbsp;</td>
            <td class="modal-sm" style="width: 184px">Result</td>
        </tr>
        <tr>
            <td style="width: 61px">
                <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            </td>
            <td style="width: 155px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="+">Add</asp:ListItem>
                    <asp:ListItem Value="-">Sub</asp:ListItem>
                    <asp:ListItem Value="*">Mult</asp:ListItem>
                    <asp:ListItem Value="/">Div</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="modal-sm" style="width: 154px">
                <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            </td>
            <td style="width: 184px">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="=" />
            </td>
            <td class="modal-sm" style="width: 184px">
                <asp:Label ID="lblresult" runat="server" Text="Result"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
