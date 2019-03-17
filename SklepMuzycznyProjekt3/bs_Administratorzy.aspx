<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_Administratorzy.aspx.cs" Inherits="bs_Administratorzy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
        .auto-style2 {
            height: 41px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            height: 39px;
        }
        .auto-style8 {
            height: 38px;
            width: 419px;
        }
        .auto-style9 {
            height: 41px;
            width: 419px;
        }
        .auto-style10 {
            height: 39px;
            width: 419px;
        }
        .auto-style11 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <div style="background-color:green;border:5px solid blue;" class="administratorzy_block">
        <h1>Jesteś na stronie Administacyjnej</h1>
        <form id="form1" runat="server">
        <div class="administratorzy_gorne_menu">
            <asp:Panel ID="bsGorneMenuAdministracjaPnl" runat="server">
            <ul class="administratorzy_menu">
                <li><asp:Button ID="bsAkcesoriaAdmBtn" runat="server" Text="Akcesoria" OnClick="bsAkcesoriaAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Width="83px" /></li>
                
                <li><asp:Button ID="bsInstrumentyAdmBtn" runat="server" Text="Instrumenty" OnClick="bsInstrumentyAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Width="94px" /></li>
                <li><asp:Button ID="bsNaglosnienieAdmBtn" runat="server" Text="Nagłośnienie" OnClick="bsNaglosnienieAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Width="108px" /></li>
                <li><asp:Button ID="bsOprogramowanieAdmBtn" runat="server" Text="Oprogramowanie" OnClick="bsOprogramowanieAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Width="144px" /></li>
                <li><asp:Button ID="bsStudioAdmBtn" runat="server" Text="Studio" OnClick="bsStudioAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
                <li><asp:Button ID="bsWyprzedarzAdmBtn" runat="server" Text="Wyprzedarz" OnClick="bsWyprzedarzAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
                <li><asp:Button ID="bsDspAdmBtn" runat="server" Text="DSP" OnClick="bsDspAdmBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
            </ul>
                </asp:Panel>
        </div>
            <div class="clear"></div>
            <div class="formularzAdm_div">
                
                <asp:Panel ID="bsAkcesoriaPnl" runat="server">
                    <asp:Panel ID="bsWymaganePolaAkcesoriaPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    
                    
                    <asp:Panel ID="bsKomunikatWprowadzonoNiepoprawneDaneAkcPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsGratulacjeDodanoAkcesoriumDoSklepuPnl" runat="server">
                        <p style="text-align:center;">Gratulacje!!! - Dodano produkt akcesoriow do sklepu</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiestetyNieDodanoAkcesoriumDoSklepuPnl" runat="server">
                        <p style="text-align:center;">Niestety!!! - Nie dodano produktu akcesoriow do sklepu</p>

                    </asp:Panel>
                    
                    <h2>Formularz dodawania akcesoriów</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa Akcesoria</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaAkcesoriaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod Akcesoria</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodAkcesoriaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Akcesoria</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaAkcesoriaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajAkcesoriaBtn" runat="server" Text="Dodaj Produkt Do Akcesoriów" Height="41px" Width="466px" OnClick="bsDodajAkcesoriaBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    
                    <asp:Panel ID="bsWypelnijWszystkiePolaModyfikacjiAkcesoriowPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wypelnij wszystkie pola modyfikacji </p>

                    </asp:Panel>
                    <asp:Panel ID="bsKomunikatNiepoprawneDaneAkcModAdmPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wprowadzono nie poprawne dane </p>

                    </asp:Panel>
                    
                    <asp:Panel ID="bsGratulujeUdalosieZmodyfikowacRekordAkcesoriowPnl" runat="server">
                        <p style="text-align:center;">Gratuluje!!! - Rekord akcesoriow zostal zmodyfikowany </p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiestetyNieUdaloSieZmodyfikowacRekorduAkcesoriowPnl" runat="server">
                        <p style="text-align:center;">Niestety!!! - nie udalo sie zmodyfikowac rekordu akcesoriow </p>

                    </asp:Panel>
                    <h2>Formularz modyfikacji akcesoriów</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id Akcesoria</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdAkcesoriaModyfikacjaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa Akcesoria</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaAkcesoriaModyfikacjaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod Akcesoria</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodAkcesoriaModyfikacjaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Akcesoria</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaAkcesoriaModyfikacjaTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    <p style="text-align:center;"> 
                    <asp:GridView ID="bsTabelaAdministracyjnaAkcesoriowGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdAkcesoria">
                        <Columns>
                            <asp:BoundField DataField="bsIdAkcesoria" HeaderText="bsIdAkcesoria" InsertVisible="False" ReadOnly="True" SortExpression="bsIdAkcesoria" />
                            <asp:BoundField DataField="bsNazwaAkcesoria" HeaderText="bsNazwaAkcesoria" SortExpression="bsNazwaAkcesoria" />
                            <asp:BoundField DataField="bsKodAkcesoria" HeaderText="bsKodAkcesoria" SortExpression="bsKodAkcesoria" />
                            <asp:BoundField DataField="bsCenaAkcesoria" HeaderText="bsCenaAkcesoria" SortExpression="bsCenaAkcesoria" />
                        </Columns>
                        </asp:GridView>
                        </p>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujAkcesoriaBtn" runat="server" Text="Modyfikuj dane o Produkcie Akcesoriów" Height="41px" Width="466px" OnClick="bsModyfikujAkcesoriaTxb_Click" BackColor="#0099FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    
                </asp:Panel>
                <asp:Panel ID="bsInstrumentyPnl" runat="server">

                    <asp:Panel ID="bsWymaganePolaDodawanieInstrumentowPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsWprowadzoneDaneSaNiepoprawneInstPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadzone dane sa nie poprawne</p>

                    </asp:Panel>
                    <asp:Panel ID="bsGratulacjeDodanoInstrumentDoSklepuPnl" runat="server">
                        <p style="text-align:center">Gratulacje!!! - dodano instrument do sklepu</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPrzykroNamNieDodanoInstrumentuDoSklepuPnl" runat="server">
                        <p style="text-align:center">Przykro nam!!! - nie dodano instrumentu do sklepu</p>

                    </asp:Panel>
                    <h2>Formularz dodawania instrumentów</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa Instrumentu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaInstrTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod instrumentu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodInstrTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Instrumentu</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaInstrTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajInstrDoSklepuBtn" runat="server" Text="Dodaj instrument do sklepu" Height="41px" Width="466px" OnClick="bsDodajInstrDoSklepuBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:Panel ID="bsWymaganePolaModPln" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola modyfikacji</p>

                    </asp:Panel>
                    <asp:Panel ID="bsWprowadzoneDaneNieSaPoprawneModInstrPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadzone dane nie sa poprawne</p>

                    </asp:Panel>
                    <asp:Panel ID="bsGratulujeModyfikacjaDanychInstrumentuPowiodlasie" runat="server">
                        <p style="text-align:center">Gratuluje!!! - modyfikacja danych instrumentu powiodla sie</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiestetyModyfikacjaDanychInstrumentuNiePowiodlasie" runat="server">
                        <p style="text-align:center">Niestety!!! - modyfikacja danych instrumentu nie powiodla sie</p>

                    </asp:Panel>
                    <h2>Formularz modyfikacji danych o instrumentach</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id Instrumentu</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdInstrModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa Instrumentu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaInstrModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod Instrumentu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodInstrModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Instrumentu</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaInstrModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujInstrBtn" runat="server" Text="Modyfikuj dane o instrumencie" Height="41px" Width="466px" OnClick="bsModyfikujInstrBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <p>
                        <asp:GridView ID="bsTabelaInstrumentowAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdInstr">
                            <Columns>
                                <asp:BoundField DataField="bsIdInstr" HeaderText="bsIdInstr" InsertVisible="False" ReadOnly="True" SortExpression="bsIdInstr" />
                                <asp:BoundField DataField="bsNazwaInstr" HeaderText="bsNazwaInstr" SortExpression="bsNazwaInstr" />
                                <asp:BoundField DataField="bsKodInstr" HeaderText="bsKodInstr" SortExpression="bsKodInstr" />
                                <asp:BoundField DataField="bsCenaInstr" HeaderText="bsCenaInstr" SortExpression="bsCenaInstr" />
                            </Columns>
                        </asp:GridView>
                    </p>
                </asp:Panel>
                <asp:Panel ID="bsNaglosnieniePnl" runat="server">
                    <asp:Panel ID="bsWypelnijWszystkiePolaNaglosnieniePnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsWpisalesNiepoprawneDaneDodNaglPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wpisales nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsGratulujeDodanoNaglosnienieDoSklepuPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - dodano naglosnienie do sklepu</p>

                    </asp:Panel>
                     <asp:Panel ID="bsNiestetyNiedodanoNaglosnieniaDoSklepu" runat="server">
                        <p style="text-align:center">Niestety!!! - nie dodano naglosnienia do sklepu</p>

                    </asp:Panel>
                    <h2>Formularz dodawania produktów nagłaśniających</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaProduktuNaglTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod:</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodProduktuNaglTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaProduktuNaglTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajProdukNaglasniajacyAdmBtn" runat="server" Text="Dodaj Produkt Do Artykułów Nagłaśniających" Height="41px" Width="466px" OnClick="bsDodajProdukNaglasniajacyAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:Panel ID="bsWszystkiePolaModNaglMuszaZostacWypelnione" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola </p>
                    </asp:Panel>
                    <asp:Panel ID="bsWpisalesNiepoprawneDaneModNaglPln" runat="server">
                        <p style="text-align:center">Komunikat!!! - wpisales nie poprawne dane </p>
                    </asp:Panel>
                    <asp:Panel ID="bsGratulacjeModyfikacjaNaglPowiodlasie" runat="server">
                        <p style="text-align:center">Gratulacje!!! - modyfikacja powiodla sie </p>
                    </asp:Panel>
                    <asp:Panel ID="bsNiestetyModyfikacjaNaglNiepowiodlasie" runat="server">
                        <p style="text-align:center">Niestety!!! - modyfikacja nie powiodla sie </p>
                    </asp:Panel>
                    <h2>Formularz modyfikacji produktów nagłaśniających</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdNaglModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaNaglModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodNaglModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaNaglModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujNaglAdmBtn" runat="server" Text="Modyfikuj dane o Produkcie Akcesoriów" Height="41px" Width="466px" OnClick="bsModyfikujNaglAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:GridView ID="bsTabelaNaglosnienieAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdNagl">
                        <Columns>
                            <asp:BoundField DataField="bsIdNagl" HeaderText="bsIdNagl" InsertVisible="False" ReadOnly="True" SortExpression="bsIdNagl" />
                            <asp:BoundField DataField="bsNazwaNagl" HeaderText="bsNazwaNagl" SortExpression="bsNazwaNagl" />
                            <asp:BoundField DataField="bsKodNagl" HeaderText="bsKodNagl" SortExpression="bsKodNagl" />
                            <asp:BoundField DataField="bsCenaNagl" HeaderText="bsCenaNagl" SortExpression="bsCenaNagl" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
                <asp:Panel ID="bsOprogramowaniePnl" runat="server">

                    <asp:Panel ID="bsWymaganePolaOpAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepoprawneDaneOpAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieDodaniaOprogramowaniaDoSklepuPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - dodano program do sklepu</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieDodaniaOprogramowanieDoSklepuPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - nie dodano programu do sklepu</p>

                    </asp:Panel>
                    <h2>Formularz dodawania oprogramowania</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa Programu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaOpAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod Programu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodOpAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Programu</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaOpAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajOpAdmBtn" runat="server" Text="Dodaj Program Do Sklepu" Height="41px" Width="466px" OnClick="bsDodajOpAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    
                    <asp:Panel ID="bsWymaganePolaOpModAdmPnl" runat="server">

                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>
                    </asp:Panel>
                    <asp:Panel ID="bsPoprawnoscDanychOpAdmPln" runat="server">

                        <p style="text-align:center">Komunikat!!! - wprowadzono nie poprawne dane</p>
                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieModyfikacjiDanychOprogramowaniaPnl" runat="server">

                        <p style="text-align:center">Gratuluje!!! - zmodyfikowano dane o programie</p>
                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieModyfikacjiDanychOprogramowaniaPnl" runat="server">

                        <p style="text-align:center">Niestety!!! - nie zmodyfikowano danych o programie</p>
                    </asp:Panel>
                    <h2>Formularz modyfikacji oprogramowania</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdOpModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa Programu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaOpModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod Programu</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodOpModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena Programu</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaOpModTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujOpAdmBtn" runat="server" Text="Modyfikuj dane o Programie" Height="41px" Width="466px" OnClick="bsModyfikujOpAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:GridView ID="bsTabelaOprogramowanieAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdOp">
                        <Columns>
                            <asp:BoundField DataField="bsIdOp" HeaderText="bsIdOp" InsertVisible="False" ReadOnly="True" SortExpression="bsIdOp" />
                            <asp:BoundField DataField="bsNazwaOp" HeaderText="bsNazwaOp" SortExpression="bsNazwaOp" />
                            <asp:BoundField DataField="bsKodOp" HeaderText="bsKodOp" SortExpression="bsKodOp" />
                            <asp:BoundField DataField="bsCenaOp" HeaderText="bsCenaOp" SortExpression="bsCenaOp" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
                <asp:Panel ID="bsStudioPnl" runat="server">
                    <asp:Panel ID="bsWymaganePolaStAdmPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepoprawneDaneStAdmPnl" runat="server">
                        <p style="text-align:center;">Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieDodaniaStudyjnychDoSklepu" runat="server">
                        <p style="text-align:center;">Gratuluje!!! - dodano produkt do sklepu</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieDodaniaStudyjnychDoSklepu" runat="server">
                        <p style="text-align:center;">Niestety!!! - nie dodano produktu do sklepu</p>

                    </asp:Panel>
                    <h2>Formularz dodawania produktów studyjnych</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaStAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodStAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaStAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajStDoSklepuBtn" runat="server" Text="Dodaj Produkt Studyjny Do Sklepu" Height="41px" Width="466px" OnClick="bsDodajStDoSklepuBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:Panel ID="bsKomunikatWymaganePolaModAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola modyfikacji</p>

                    </asp:Panel>
                    <asp:Panel ID="bsKomunikatNiepoprawneDaneStModAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadziles nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieModyfikacjiStudioAdmPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - modyfikacja powiodla sie</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieModyfikacjiStudioAdmPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - modyfikacja nie powiodla sie</p>

                    </asp:Panel>
                    <h2>Formularz modyfikacji produktów studyjnych</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdStModAdmTxb" runat="server" Width="282px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaStModAdmTxb" runat="server" Width="282px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod:</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodStModAdmTxb" runat="server" Width="282px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaStModAdmTxb" runat="server" Width="282px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujStAdmBtn" runat="server" Text="Modyfikuj dane produktu studyjnego" Height="41px" Width="466px" OnClick="bsModyfikujStAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:GridView ID="bsTabelaStAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdSt">
                        <Columns>
                            <asp:BoundField DataField="bsIdSt" HeaderText="bsIdSt" InsertVisible="False" ReadOnly="True" SortExpression="bsIdSt" />
                            <asp:BoundField DataField="bsNazwaSt" HeaderText="bsNazwaSt" SortExpression="bsNazwaSt" />
                            <asp:BoundField DataField="bsKodSt" HeaderText="bsKodSt" SortExpression="bsKodSt" />
                            <asp:BoundField DataField="bsCenaSt" HeaderText="bsCenaSt" SortExpression="bsCenaSt" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
                <asp:Panel ID="bsWyprzedarzPnl" runat="server">
                    <asp:Panel ID="bsKomunikatWymaganePolaWypAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsKomunikatNiepoprawneDaneWypAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieDodaniaWypAdmPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - dodano produkt do dzialu wyprzedarz</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieDodaniaWypAdmPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - nie dodano produktu do dzialu wyprzedarz</p>

                    </asp:Panel>
                    <h2>Formularz dodawania produktów do wyprzedarzy</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaWypAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodWypAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaWypAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajWypAdmBtn" runat="server" Text="Dodaj Produkt Wyprzedarzy Do Sklepu" Height="41px" Width="466px" OnClick="bsDodajWypAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:Panel ID="bsKomunikatWymaganePolaModWypAdmPnl" runat="server">
                        <p style="text-align:center">Komuniat!!! - wypelnij wszystkie pola</p>
                    </asp:Panel>
                    <asp:Panel ID="bsKomunikatNieprawidloweDaneModWypAdmPnl" runat="server">
                        <p style="text-align:center">Komuniat!!! - wprowadzono nie prawidlowe dane</p>
                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieModyfikacjiWypAdmPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - zmodyfikowano dane z dzialu wyprzedarz</p>
                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieModyfikacjiWypAdmPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - nie zmodyfikowano danych</p>
                    </asp:Panel>
                    <h2>Formularz modyfikacji produktów z wyprzedarzy</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdWypModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaWypModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodWypModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaWypModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujWypAdmBtn" runat="server" Text="Modyfikuj dane produktu z wyprzedarzy" Height="41px" Width="466px" OnClick="bsModyfikujWypAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:GridView ID="bsTabelaWyprzedarzyAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdWyp">
                        <Columns>
                            <asp:BoundField DataField="bsIdWyp" HeaderText="bsIdWyp" InsertVisible="False" ReadOnly="True" SortExpression="bsIdWyp" />
                            <asp:BoundField DataField="bsNazwaWyp" HeaderText="bsNazwaWyp" SortExpression="bsNazwaWyp" />
                            <asp:BoundField DataField="bsKodWyp" HeaderText="bsKodWyp" SortExpression="bsKodWyp" />
                            <asp:BoundField DataField="bsCenaWyp" HeaderText="bsCenaWyp" SortExpression="bsCenaWyp" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>

                <asp:Panel ID="bsDspPnl" runat="server">
                    <asp:Panel ID="bsWymaganePolaDspAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepoprawneDaneDspAdmPnl" runat="server">
                        <p style="text-align:center">Komunikat!!! - wprowadzono nie poprawne dane</p>

                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieDodaniaDspAdmPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - dodano produkt do dzialu dsp</p>

                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieDodaniaDspAdmPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - nie dodano produktu do dzialu dsp</p>

                    </asp:Panel>
                    <h2>Formularz dodawania produktów do dsp</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaDspAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodDspAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaDspAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                   
                    <p style="text-align:center;"><asp:Button ID="bsDodajDspAdmBtn" runat="server" Text="Dodaj Produkt Dsp Do Sklepu" Height="41px" Width="466px" OnClick="bsDodajDspAdmBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    <asp:Panel ID="bsKomunikatWymaganePolaDspModAdmPnl" runat="server">
                        <p style="text-align:center">Komuniat!!! - wypelnij wszystkie pola</p>
                    </asp:Panel>
                    <asp:Panel ID="bsKomunikatNiepoprawneDaneDspModAdmPnl" runat="server">
                        <p style="text-align:center">Komuniat!!! - wprowadzono nie prawidlowe dane</p>
                    </asp:Panel>
                    <asp:Panel ID="bsPowodzenieModyfikacjiDspPnl" runat="server">
                        <p style="text-align:center">Gratuluje!!! - zmodyfikowano dane z dzialu dsp</p>
                    </asp:Panel>
                    <asp:Panel ID="bsNiepowodzenieModyfikacjiDspPnl" runat="server">
                        <p style="text-align:center">Niestety!!! - nie zmodyfikowano danych</p>
                    </asp:Panel>
                    <h2>Formularz modyfikacji produktów dsp</h2>
                    

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style8">Id</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="bsIdDspModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Nazwa</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsNazwaDspModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Kod</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="bsKodDspModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">Cena</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="bsCenaDspModAdmTxb" runat="server" Width="282px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    <p style="text-align:center;"><asp:Button ID="bsModyfikujDspBtn" runat="server" Text="Modyfikuj dane produktu dsp" Height="41px" Width="466px" OnClick="bsModyfikujDspBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></p>
                    
                    <asp:GridView ID="bsTabelaDspAdmGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="bsIdDsp">
                        <Columns>
                            <asp:BoundField DataField="bsIdDsp" HeaderText="bsIdDsp" InsertVisible="False" ReadOnly="True" SortExpression="bsIdDsp" />
                            <asp:BoundField DataField="bsNazwaDsp" HeaderText="bsNazwaDsp" SortExpression="bsNazwaDsp" />
                            <asp:BoundField DataField="bsKodDsp" HeaderText="bsKodDsp" SortExpression="bsKodDsp" />
                            <asp:BoundField DataField="bsCenaDsp" HeaderText="bsCenaDsp" SortExpression="bsCenaDsp" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>

                <asp:Panel ID="bsWylogowaniePnl" runat="server" CssClass="auto-style11">
                    <p style="text-align:center;"><asp:Button ID="bsWylogujBtn" runat="server" Text="Wyloguj i Wroc do Strony Glownej Sklepu" Height="43px" OnClick="bsWylogujBtn_Click" BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"/></p>

                </asp:Panel>
            </div>
        </form>
    </div>
</body>
</html>
