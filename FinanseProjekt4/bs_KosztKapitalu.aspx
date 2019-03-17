<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_KosztKapitalu.aspx.cs" Inherits="bs_KosztKapitalu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 49px;
            width: 147px;
        }
        .auto-style2 {
            height: 45px;
            width: 147px;
        }
        .auto-style3 {
            height: 38px;
            width: 147px;
        }
        .auto-style4 {
            height: 49px;
            width: 231px;
        }
        .auto-style5 {
            height: 45px;
            width: 231px;
        }
        .auto-style6 {
            height: 38px;
            width: 231px;
        }
        .auto-style7 {
            width: 500px;
        }
        #bsTabelaKosztowKapitalu {
            margin:auto;
        }
        #bsKosztDluguHL {
            
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
    <h1 style="text-align:center">Obliczenie kosztu kapitału</h1>
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
            <asp:Panel ID="bsGratulacje" runat="server">
                <p style="text-align:center;">Gratuluje - dodano do bazy kwote kapitalu</p>
            </asp:Panel>
            <asp:Panel ID="bsPrzykroMi" runat="server">
                <p style="text-align:center;">Przykro mi - nie dodano do bazy kwoty kapitalu</p>
            </asp:Panel>
        <table style="border: medium solid #FF0000; width:400px; margin:auto;margin-top:20px;margin-bottom:30px;" border="1">
            <tr>
                <td class="auto-style4">Wartosc rynkowa kapitału własnego:</td>
                <td class="auto-style1" style="text-align:center">
                    <asp:TextBox ID="bsWartoscRynkowaKapitaluWlasnegoTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Wartość rynkowa długu:</td>
                <td class="auto-style2" style="text-align:center">
                    <asp:TextBox ID="bsWartoscRynkowaDluguTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Koszt kapitału własnego:</td>
                <td class="auto-style3" style="text-align:center">
                    <asp:TextBox ID="bsKosztKapitaluWlasnegoTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Koszt długu:</td>
                <td class="auto-style3" style="text-align:center">
                    <asp:TextBox ID="bsKosztDluguTxb" runat="server" BorderColor="#009933" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
        </table>
            <p style="text-align:center;margin-bottom:20px;">
                <asp:Button ID="bsObliczKosztKapitaluWlasnegoBtn" runat="server" Text="Oblicz koszt kapitału własnego" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" OnClick="bsObliczKosztKapitaluWlasnegoBtn_Click" />
            </p>
            <p style="margin-bottom:30px;">
                <asp:GridView ID="bsTabelaKosztowKapitalu" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdKapitalu" Width="244px">
                    <Columns>
                        <asp:BoundField DataField="bsIdKapitalu" HeaderText="bsIdKapitalu" InsertVisible="False" ReadOnly="True" SortExpression="bsIdKapitalu" />
                        <asp:BoundField DataField="bsKosztKapitalu" HeaderText="bsKosztKapitalu" SortExpression="bsKosztKapitalu" />
                    </Columns>
                </asp:GridView>
            </p>
            <p style="text-align:center;margin-bottom:20px;">
                <asp:HyperLink ID="bsKosztDluguHL" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Visible="False" NavigateUrl="~/bs_KosztDlugu.aspx">Koszt dlugu</asp:HyperLink>
           </p>
    </div>
    </form>
</body>
</html>
