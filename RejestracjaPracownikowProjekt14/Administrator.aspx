<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Administrator.aspx.cs" Inherits="Administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style2 {
            width: 257px;
            height: 73px;
        }
        .auto-style3 {
            height: 73px;
        }
        .auto-style8 {
            width: 201px;
            height: 53px;
        }
        .auto-style9 {
            height: 53px;
            width: 181px;
        }
        .auto-style10 {
            width: 201px;
            height: 55px;
        }
        .auto-style11 {
            height: 55px;
            width: 181px;
        }
    </style>
</head>
<body>
    <div class="div_admina_ogolny">
        <h1>Znajdujesz się w panelu administratora</h1>
        <p>Mozesz tu dodawać dane o pracownikach</p>
            <form id="form1" runat="server">
            <div class="admin_form">
                <asp:Panel ID="KomunikatWylogowaniaAdmPnl" runat="server">
                        <p>Komunikat!!! - zostales wylogowany</p>

                    </asp:Panel>
                <asp:Panel ID="KomunikatWymaganePolaAdmPnl" runat="server">
                        <p>Komunikat!!! - wypelnij obydwa pola</p>

                    </asp:Panel>
                    <asp:Panel ID="KomunikatNiepoprawneDaneAdmPnl" runat="server">
                        <p>Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="KomunikatPowodzenieLogowaniaAdmPnl" runat="server">
                        <p>Gratuluje!!! - Jestes zalogowany jako admin</p>

                    </asp:Panel>
                    <asp:Panel ID="KomunikatNiepowodzenieLogowaniaAdmPnl" runat="server">
                        <p>Niestety!!! - nie zostales zalogowany</p>

                    </asp:Panel>
                <asp:Panel ID="KomunikatWymaganePolaSzAdmPnl" runat="server">
                        <p>Komunikat!!! - wypelnij wszystkie pola </p>
                    </asp:Panel>
                    <asp:Panel ID="KomunikatPoprawnoscSzAdmPnl" runat="server">
                        <p>Komunikat!!! - wprowadzono nie poprawne dane </p>
                    </asp:Panel>
                    <asp:Panel ID="KomunikatPowodzenieDodaniaSzAdmPnl" runat="server">
                        <p>Gratuluje!!! - szczegoly zostaly dodane </p>
                    </asp:Panel>
                    <asp:Panel ID="KomunikatNiepowodzenieDodaniaSzAdmPnl" runat="server">
                        <p>Niestety!!! - szczegoly nie zostaly dodane </p>
                    </asp:Panel>
                <asp:Panel ID="PanelLogowaniaAdminaPnl" runat="server">
                    <h2>Jednak najpierw zaloguj się jako admin:</h2>
                    
                    <table style="width:400px;margin:auto;">
                        <tr>
                            <td class="auto-style8" style="border: medium solid #000000">Login admina</td>
                            <td class="auto-style9" style="border: medium solid #000000">
                                <asp:TextBox ID="LoginAdmTxb" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10" style="border: medium solid #000000">Hasło admina</td>
                            <td class="auto-style11" style="border: medium solid #000000">
                                <asp:TextBox ID="HasloAdmTxb" AutoCompleteType="None" TextMode="Password" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <p>  
                        <asp:Button ID="ZalogujAdmBtn" runat="server" Text="Zaloguj mnie" Height="47px" OnClick="ZalogujAdmBtn_Click" Width="216px" />

                    </p>

                </asp:Panel>
                

                <asp:Panel ID="PanelForm" runat="server">
                    
                    <asp:GridView ID="bsLoginAdmGrid" runat="server" AutoGenerateColumns="False" BackColor="#66FF33" BorderColor="#0033CC" BorderStyle="Solid" BorderWidth="3px">
                        <Columns>
                            <asp:BoundField DataField="LoginAdmina" HeaderText="LoginAdmina" SortExpression="LoginAdmina" />
                        </Columns>
                    </asp:GridView>
                    <table style="width: 500px;margin:auto;">
                        <tr>
                            <td class="auto-style2" style="border: medium solid #000000">Wybierz imie pracownika</td>
                            <td class="auto-style3" style="border: medium solid #000000">
                                <asp:DropDownList ID="ImieDDLAdm" runat="server" DataSourceID="SqlDataSource1" DataTextField="Imie" DataValueField="Imie">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Imie] FROM [Pracownicy]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="border: medium solid #000000">Wpisz kod pocztowy</td>
                            <td class="auto-style3" style="border: medium solid #000000">
                                <asp:TextBox ID="KodPocztowyAdmTxb" runat="server" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="border: medium solid #000000">Wpisz nazwę miasta</td>
                            <td class="auto-style3" style="border: medium solid #000000">
                                <asp:TextBox ID="MiastoAdmTxb" runat="server" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="border: medium solid #000000">Wpisz ulicę</td>
                            <td class="auto-style3" style="border: medium solid #000000">
                                <asp:TextBox ID="UlicaAdmTxb" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                            </td>
                        </tr>
                        </table>
                    <p>
                        <asp:Button ID="bsDodajDodatkoweDanePracownikaAdmBtn" runat="server" Text="Dodaj dodatkowe dane pracownika" Height="45px" OnClick="bsDodajDodatkoweDanePracownikaAdmBtn_Click" Width="232px" />
                    </p>
                    <p>
                        <asp:Button ID="bsWylogujAdminaBtn" runat="server" Text="Wyloguj admina" Height="52px" Width="243px" OnClick="bsWylogujAdminaBtn_Click" />

                    </p>
                </asp:Panel>
                <p>
                    <asp:Button ID="PowrotDoRejestracjiPracownikaBtn" runat="server" Text="Powrót do rejestracji pracownika" Height="51px" OnClick="PowrotDoRejestracjiPracownikaBtn_Click" Width="241px" />

                </p>
                <p>
                    <asp:GridView ID="SzczegolyPracownikowGrid" runat="server" AutoGenerateColumns="False" BackColor="#66FF33" BorderColor="Blue" BorderStyle="Solid" BorderWidth="3px">
                        <Columns>
                            <asp:BoundField DataField="KodPocztowy" HeaderText="KodPocztowy" SortExpression="KodPocztowy" />
                            <asp:BoundField DataField="Miasto" HeaderText="Miasto" SortExpression="Miasto" />
                            <asp:BoundField DataField="Ulica" HeaderText="Ulica" SortExpression="Ulica" />
                            <asp:BoundField DataField="Imie" HeaderText="Imie" SortExpression="Imie" />
                        </Columns>
                    </asp:GridView>

                </p>
            </div>
            </form>
    </div>
</body>
</html>
