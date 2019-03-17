<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StronaGlowna.aspx.cs" Inherits="StronaGlowna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 195px;
            height: 43px;
        }
        .auto-style5 {
            height: 43px;
            text-align:center;
        }
        .auto-style6 {
            width: 195px;
            height: 39px;
        }
        .auto-style7 {
            height: 39px;
            text-align:center;
        }
        .auto-style8 {
            width: 195px;
            height: 44px;
        }
        .auto-style9 {
            height: 44px;
            text-align:center;
        }
        #TabelaTowarowSklepowych {
            width:380px;margin:auto;
        }
        #PrzejscieDoWidokuKoszyka {
            
            padding-top:20px;
            padding-left:20px;
            padding-right:20px;
            padding-bottom:20px;
            background-color:green;
            color:white;
        }
         #PrzejscieDoWidokuKoszyka:hover {
            
            padding-top:20px;
            padding-left:20px;
            padding-right:20px;
            padding-bottom:20px;
            background-color:white;
            color:green;
            border:5px solid green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:540px;margin:auto;border:5px solid black;">
    <h1 style="text-align:center;">Dodaj towar do sklepu</h1>
       
            <asp:Panel ID="KomunikatPowodzenia" runat="server">
                <p style="text-align:center;">Towar dodano do sklepu</p>
        </asp:Panel>
        <asp:Panel ID="NiepowodzenieDodaniaTowaruDoSklepu" runat="server">
                <p style="text-align:center;">Towaru nie dodano do sklepu</p>
        </asp:Panel>
        <asp:Panel ID="ErrorWymagane" runat="server">
                <p style="text-align:center;">Error!!! - proszę wypełnić wszystkie pola</p>
        </asp:Panel>
         <asp:Panel ID="ErrorPoprawnosci" runat="server">
                <p style="text-align:center;">Error!!! - wprowadziłeś niepoprawne dane </p>
             <p style="text-align:center">Nazwa i Kod mają być string.Cena musi być liczba</p>
        </asp:Panel>
        <asp:Panel ID="DodanoProduktDoKoszyka" runat="server">
                <p style="text-align:center;">Gratuluję!!! - dodano produkt do koszyka</p>
        </asp:Panel>
        <asp:Panel ID="NieDodanoProduktuDoKoszyka" runat="server">
                <p style="text-align:center;">Niestety nie dodano produktu do koszyka</p>
        </asp:Panel>
            <table border="1" style="border: medium solid #008000; width:400px; color: #000000;margin:auto;">
                <tr>
                    <td class="auto-style6">Nazwa towaru:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="nazwaTowaruTxb" runat="server" Height="24px" BorderColor="#0099FF" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Kod towaru:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="kodTowaruTxb" runat="server" Height="24px" BorderColor="#0066CC" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Cena towaru:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="cenaTowaruTxb" runat="server" Height="24px" BorderColor="#0066CC" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        <p style="text-align:center;">
            <asp:Button ID="DodajTowarDoSklepuBtn" runat="server" BorderColor="#000099" BorderStyle="Solid" BorderWidth="3px" Font-Size="Medium" Height="44px" Text="Dodaj towar do sklepu" Width="264px" OnClick="DodajTowarDoSklepuBtn_Click" />
        </p>
        <p style="margin-bottom:40px;">
            <asp:GridView ID="TabelaTowarowSklepowych" runat="server" AutoGenerateColumns="False" DataKeyNames="IdTowaru" BorderColor="#006600" BorderStyle="Solid" BorderWidth="3px" Width="448px" OnSelectedIndexChanged="TabelaTowarowSklepowych_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="IdTowaru" HeaderText="IdTowaru" InsertVisible="False" ReadOnly="True" SortExpression="IdTowaru" />
                    <asp:BoundField DataField="NazwaTowaru" HeaderText="NazwaTowaru" SortExpression="NazwaTowaru" />
                    <asp:BoundField DataField="KodTowaru" HeaderText="KodTowaru" SortExpression="KodTowaru" />
                    <asp:BoundField DataField="CenaTowaru" HeaderText="CenaTowaru" SortExpression="CenaTowaru" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select" ShowHeader="True" Text="Do koszyka" />
                </Columns>
            </asp:GridView>
        </p>
        <p style="text-align:center;margin-top:40px;margin-bottom:40px;">
        <asp:HyperLink ID="PrzejscieDoWidokuKoszyka" runat="server" NavigateUrl="~/Koszyk.aspx">Przejdź do koszyka</asp:HyperLink>
            </p>
    </div>
    </form>
</body>
</html>
