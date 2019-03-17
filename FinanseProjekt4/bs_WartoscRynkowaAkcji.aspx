<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_WartoscRynkowaAkcji.aspx.cs" Inherits="bs_WartoscRynkowaAkcji" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #bsTabelaWRAgrid {
            margin:auto;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align:center">Obliczenie wartosci rynkowej akcji</h1>
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
            <asp:Panel ID="bsErrorStopaWzrostuMniejszaOdKosztuWlasnego" runat="server">
                <p style="text-align:center;">Error!!! - drugie pole musi być mniejsza od kapitalu wlasnego</p>
            </asp:Panel>
            <asp:Panel ID="bsGratulacje" runat="server">
                <p style="text-align:center;">Gratuluje - dodano do bazy wartosc akcji</p>
            </asp:Panel>
            <asp:Panel ID="bsPrzykroMi" runat="server">
                <p style="text-align:center;">Przykro mi - nie dodano do bazy wartosci akcji</p>
            </asp:Panel>
        <table style="border: medium solid #FF0000; width:400px; margin:auto;margin-top:20px;margin-bottom:30px;" border="1">
            <tr>
                <td class="auto-style4">Dywidenda w okresie poczatkowym:</td>
                <td class="auto-style1" style="text-align:center">
                    <asp:TextBox ID="bsDywidendaTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Stopa wzrostu dywidendy:</td>
                <td class="auto-style2" style="text-align:center">
                    <asp:TextBox ID="bsStopaWzrostuDywidendyTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Koszt kapitału własnego:</td>
                <td class="auto-style3" style="text-align:center">
                    <asp:TextBox ID="bsKosztKapitaluWlasnegoTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            </table>
            <p style="text-align:center;margin-bottom:20px;">
                <asp:Button ID="bsObliczWartoscRynkowaAkcji" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Text="Oblicz wartość rynkową akcji" OnClick="bsObliczWartoscRynkowaAkcji_Click" />
            </p>
            <p style="margin-bottom:30px;text-align:center;">
                <asp:GridView ID="bsTabelaWRAgrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdWRA" Width="236px">
                    <Columns>
                        <asp:BoundField DataField="bsIdWRA" HeaderText="bsIdWRA" InsertVisible="False" ReadOnly="True" SortExpression="bsIdWRA" />
                        <asp:BoundField DataField="bsWartoscRA" HeaderText="bsWartoscRA" SortExpression="bsWartoscRA" />
                    </Columns>
                </asp:GridView>
            </p>
            
    </div>
    </form>
</body>
</html>
