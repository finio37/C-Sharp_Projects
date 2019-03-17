<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RejestracjaPracownika.aspx.cs" Inherits="RejestracjaPracownika" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style2 {
            width: 164px;
            height: 41px;
            text-align:center;
        }
        .auto-style3 {
            height: 41px;
            width: 297px;
            text-align:center
        }
        .auto-style4 {
            width: 164px;
            height: 46px;
            text-align:center;
        }
        .auto-style5 {
            height: 46px;
            width: 297px;
            text-align:center;
        }
    </style>
</head>
<body>
    <div class="div_ogolny">
        <form id="form1" runat="server">
            <h1>Formularz rejestracyjny nowego pracownika</h1>
            <asp:Panel ID="KomunikatWymaganePolaPracownik" runat="server">
                <p>Komunikat!!! - pypelnij wszystkie pola</p>
            </asp:Panel>
            <asp:Panel ID="KomunikatNiepoprawneDanePracownik" runat="server">
                <p>Komunikat!!! - wprowadzono nie poprawne dane</p>
            </asp:Panel>
            <asp:Panel ID="KomunikatPowodzenieRejestracjiPraconik" runat="server">
                <p>Gratuluje!!! - rejestracja powiodla sie</p>
            </asp:Panel>
            <asp:Panel ID="KomunikatNiepowodzenieRejestracjiPracownik" runat="server">
                <p>Niestety!!! - rejestracja nie powiodla sie</p>
            </asp:Panel>
        <div class="formularz">
            <table style="padding: 0px; border: 3px solid #000000; width: 500px; margin:auto; table-layout: auto; border-collapse: separate;">
                <tr>
                    <td class="auto-style2" style="border: medium solid #000000">Imie pracownika</td>
                    <td class="auto-style3" style="border: medium solid #000000">
                        <asp:TextBox ID="ImiePracownikaTxb" runat="server" Width="159px" BorderColor="Red" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="border: medium solid #000000">Nazwisko pracownika</td>
                    <td class="auto-style5" style="border: medium solid #000000">
                        <asp:TextBox ID="NazwiskoPracownikaTxb" runat="server" Width="151px" BorderColor="Red" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="border: medium solid #000000">Stanowisko pracownika</td>
                    <td class="auto-style5" style="border: medium solid #000000">
                        <asp:DropDownList ID="ListaDzialowDdl" runat="server" Height="33px" Width="250px">
                            <asp:ListItem>IT</asp:ListItem>
                            <asp:ListItem>HR</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="border: medium solid #000000">
                        <asp:Button ID="RejestrujBtn" runat="server" Text="Rejestruj" Width="143px" OnClick="RejestrujBtn_Click" />
                    </td>
                    <td class="auto-style5" style="border: medium solid #000000">
                        <asp:Button ID="doAdminaBtn" runat="server" Text="Przejdź do strony admina" Width="198px" OnClick="doAdminaBtn_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="ListaZarejestrowanychPraconikowGrid" runat="server" AutoGenerateColumns="False" BackColor="#33CC33" BorderColor="#0033CC" BorderStyle="Solid" BorderWidth="3px">
                <Columns>
                    <asp:BoundField DataField="Imie" HeaderText="Imie" SortExpression="Imie" />
                    <asp:BoundField DataField="Nazwisko" HeaderText="Nazwisko" SortExpression="Nazwisko" />
                    <asp:BoundField DataField="NazwaDzialu" HeaderText="NazwaDzialu" SortExpression="NazwaDzialu" />
                </Columns>
            </asp:GridView>


        </div>
        </form>
    </div>
</body>
</html>
