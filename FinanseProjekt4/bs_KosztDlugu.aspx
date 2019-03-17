<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_KosztDlugu.aspx.cs" Inherits="bs_KosztDlugu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #bsTabelaKosztowDlugu{
            margin:auto;
        }
        #bsWartoscRynkowaAkcjiHL {
            
            padding-top:20px;
            padding-left:20px;
            padding-right:20px;
            padding-bottom:20px;
            background-color:black;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align:center">Obliczenie kosztu dlugu</h1>
        <div style="border: medium solid #0000FF; width:500px; margin:auto;" class="auto-style7">
    
            <asp:Panel ID="bsErrorWymaganePnl" runat="server">
                <p style="text-align:center;">Error!!! - proszę wypełnić wszystkie pola</p>
            </asp:Panel>
            <asp:Panel ID="bsErrorPoprawnosciDanych" runat="server">
                <p style="text-align:center;">Error!!! - pola musza być liczbowe</p>
            </asp:Panel>
            <asp:Panel ID="bsErrorMniejszOdZera" runat="server">
                <p style="text-align:center;">Error!!! - wartosci musza byc wieksze od zera</p>
            </asp:Panel>
            <asp:Panel ID="bsErrorWiecejNizJeden" runat="server">
                <p style="text-align:center;">Error!!! - pola nie moga byc wieksze od jeden</p>
            </asp:Panel>
            <asp:Panel ID="bsGratulacje" runat="server">
                <p style="text-align:center;">Gratuluje - dodano do bazy koszt dlugu</p>
            </asp:Panel>
            <asp:Panel ID="bsPrzykroMi" runat="server">
                <p style="text-align:center;">Przykro mi - nie dodano do bazy kosztu dlugu</p>
            </asp:Panel>
        <table style="border: medium solid #FF0000; width:400px; margin:auto;margin-top:20px;margin-bottom:30px;" border="1">
            <tr>
                <td class="auto-style4">Nominalna stopa oprocentowania:</td>
                <td class="auto-style1" style="text-align:center">
                    <asp:TextBox ID="bsNominalnaStopaTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Stawka opodatkowania:</td>
                <td class="auto-style2" style="text-align:center">
                    <asp:TextBox ID="bsStawkaOpodatkowaniaTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            </table>
            <p style="text-align:center;margin-bottom:20px;">
                <asp:Button ID="bsKosztDluguBtn" runat="server" Text="Oblicz koszt dlugu" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" OnClick="bsKosztDluguBtn_Click" />
            </p>
            <p style="text-align:center; margin-bottom:30px;">
                <asp:GridView ID="bsTabelaKosztowDlugu" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdDlugu" Width="334px">
                    <Columns>
                        <asp:BoundField DataField="bsIdDlugu" HeaderText="bsIdDlugu" InsertVisible="False" ReadOnly="True" SortExpression="bsIdDlugu" />
                        <asp:BoundField DataField="bsKosztDlugu" HeaderText="bsKosztDlugu" SortExpression="bsKosztDlugu" />
                    </Columns>
                </asp:GridView>
            </p>
            <p style="text-align:center;margin-bottom:20px;margin-top:20px;">
                <asp:HyperLink ID="bsWartoscRynkowaAkcjiHL" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Visible="False" NavigateUrl="~/bs_WartoscRynkowaAkcji.aspx">Wartość rynkowa akcji</asp:HyperLink>
           </p>
    </div>
    </form>
</body>
</html>
