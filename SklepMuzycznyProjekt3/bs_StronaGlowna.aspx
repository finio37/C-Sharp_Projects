<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_StronaGlowna.aspx.cs" Inherits="bs_StronaGlowna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        
        
        .klasa_logowanie_rejestrowanie {
            width: 536px;
            float:right;
            
        }
        .klasa_button_kosz{
            width:140px;
            float:left;
        }
        .auto-style1 {
            width: 812px;
            margin-left: 7px;
        }
        .auto-style2 {
            width: 111px;
        }
        .auto-style3 {
            width: 110px;
        }
        .auto-style4 {
            width: 143px;
        }
        .auto-style5 {
            margin-left: 2px;
        }
        .auto-style6 {
            margin-left: 16px;
        }
        .auto-style7 {
            width: 158px;
        }
        .auto-style8 {
            margin-left: 18px;
        }
        </style>
</head>
<body>
    <h1 style="text-align:center;">Witam w Internetowym Sklepie Muzycznym</h1>
    <p style="text-align:center;">Bartosz Szmit sem.V nr. albumu: 41965</p>
    <form id="form1" runat="server" >
    
    <div id="gorne_menu" style="margin-top:10px;background-color:green;padding-top:10px;padding-bottom:20px;margin-bottom:-20px;" class="klasa_gorne_menu">
        <ul class="auto-style1">
            <li><asp:Button ID="bsONasBtn" runat="server" Text="O nas" Height="32px" Width="92px" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" OnClick="bsONasBtn_Click" /></li>
            
            <li><asp:Button ID="bsKontaktBtn" runat="server" Text="Kontakt" Width="88px" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" OnClick="bsKontaktBtn_Click" /></li>
            <li><asp:Button ID="bsFAQBtn" runat="server" Text="FAQ" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" Width="85px" OnClick="bsFAQBtn_Click" /></li>
            <li><asp:Button ID="bsRatyPayUBtn" runat="server" Text="Raty PayU" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" OnClick="bsRatyPayUBtn_Click" Width="104px" /></li>
            <li><asp:Button ID="bsTransportBtn" runat="server" Text="Transport" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" OnClick="bsTransportBtn_Click" Width="95px" /></li>
            <li><asp:Button ID="bsPlatnosciBtn" runat="server" Text="Płatności" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" OnClick="bsPlatnosciBtn_Click" Width="98px" /></li>
            <li><asp:Button ID="bsTaxFreeBtn" runat="server" Text="Tax Free" BackColor="White" BorderColor="#003300" BorderStyle="Solid" BorderWidth="3px" Height="32px" OnClick="bsTaxFreeBtn_Click" Width="96px" /></li>
            

        </ul>
        <div style="clear:both"></div>
        
    </div>
    <div style="background-color:green;" class="przedzialka clear">
        <hr class="klasa_przedzialka_gorna" style="border: 3px solid black;" />
            <ul class="klasa_button_kosz">
                <li>
                    <asp:Button ID="bsKoszykBtn" runat="server" Text="Koszyk" OnClick="bsKoszykBtn_Click" Width="110px" style="border:2px solid black"/>

                </li>
            </ul>
            <ul class="klasa_logowanie_rejestrowanie">
                <li><asp:TextBox ID="bsLoginTxb" runat="server" Width="61px" style="border:2px solid yellow"></asp:TextBox></li>
                <li><asp:TextBox ID="bsHasloTxb" AutoCompleteType="None" TextMode="Password" runat="server" Width="59px" style="border:2px solid yellow"></asp:TextBox></li>
                <li><asp:Button ID="bsZalogujBtn" runat="server" Text="Zaloguj się" Width="83px" OnClick="bsZalogujBtn_Click" style="2px solid black" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" BackColor="White"/></li>
                <li><asp:Button ID="bsRejestrowanieBtn" runat="server" Text="Rejestrowanie" Height="22px" Width="90px" BackColor="White" OnClick="bsRejestrowanieBtn_Click" style="2px solid black" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"/></li>
                <li><asp:Button ID="bsAdministratorBtn" runat="server" Text="Administrator" BackColor="White" Height="23px" OnClick="bsAdministratorBtn_Click" CssClass="auto-style5" Width="132px" style="2px solid black" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"/></li>
                
            </ul>
         <hr class="klasa_przedzialka_dolna clear" style="border: 1px solid black" />
        
    </div>
    <div class="content" style="background-color:green;min-height:500px;">
        <div style="background-color:green;margin-top:-15px;min-height:400px;" class="lewy_sidebar_widoczny_zawsze">
           <ul>
               <li> <asp:Button ID="bsWyprzedarzBtn" runat="server" Text="Wyprzedarz" Width="146px" OnClick="bsWyprzedarzBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
               
               <li><asp:Button ID="bsInstrumentyBtn" runat="server" Text="Instrumenty" Width="146px" OnClick="bsInstrumentyBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
               <li><asp:Button ID="bsNaglosnienieBtn" runat="server" Text="Nagłośnienie" Width="146px" OnClick="bsNaglosnienieBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" /></li>
               <li><asp:Button ID="bsAkcesoriaBtn" runat="server" Text="Akcesoria" Width="146px" OnClick="bsAkcesoriaBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"/></li>
               <li><asp:Button ID="bsOprogramowanieBtn" runat="server" Text="Oprogramowanie" Width="146px" OnClick="bsOprogramowanieBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"/></li>
               <li><asp:Button ID="bsStudioBtn" runat="server" Text="Studio" Width="146px" OnClick="bsStudioBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"/></li>
               <li><asp:Button ID="bsProcesoryBtn" runat="server" Text="Procesory DSP" Width="146px" OnClick="bsProcesoryBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px"/></li>
           </ul>
        </div>
        <div class="podkontent" style="background-color:forestgreen;padding-bottom:30px;">
            <asp:Panel ID="bsCzolowaZyczeniaPnl" runat="server" Height="258px">
                <h1 style="margin-left:20px;margin-right:20px;">Witamy w naszym sklepie muzycznym</h1>
                <p style="margin-left:20px;">Z okazji Świąt Bożego Narodzenia i Nowego Roku chcieliśmy Państwu życzyć wszystkiego 
                    najpiękniejszego. Konkretnie jednak udanych i przemyślanych wyborów 
                    produktów i udanych zakupów. Mamy nadzieję, że zakupy w naszym sklepie 
                    okażą się rewelacyjną decyzją oraz że nasi klienci będą chcieli
                    kupować u nas częściej.
                </p>
                <p style="margin-left:20px;">Pozdrawiamy;-)</p>
            </asp:Panel>
            <asp:Panel ID="bsWyprzedarzPln" runat="server" Height="258px">
                <h1 style="margin-left:20px">Znajdujesz się w dziale wyprzedarzy</h1>
                <p style="margin-left:20px">Możesz tutaj kupić produkty, których ceną opracowaliśmy
                    specjalnie dla ciebie;-)
                </p>
                <p>Zapraszamy;-)</p>
                <asp:Panel ID="bsPowodzenieDodaniaDoKoszykaWK" runat="server">
                    <p style="text-align:center">
                        Gratulujemy udanego zakupu. Produkt dodano do koszyka.
                    </p>
                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieDodaniaDoKoszykaWK" runat="server">
                    <p style="text-align:center">
                        Przykro nam. Nie dodano produktu do koszyka.
                    </p>
                </asp:Panel>
                <p style="text-align:center;">
                    <asp:GridView ID="bsTabelaWyprzedarzyGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaWyprzedarzyGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="bsNazwaWyp" HeaderText="bsNazwaWyp" SortExpression="bsNazwaWyp" />
                            <asp:BoundField DataField="bsKodWyp" HeaderText="bsKodWyp" SortExpression="bsKodWyp" />
                            <asp:BoundField DataField="bsCenaWyp" HeaderText="bsCenaWyp" SortExpression="bsCenaWyp" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                        </Columns>
                    </asp:GridView>
                </p>
            </asp:Panel>
            <asp:Panel ID="bsInstrumentyPnl" runat="server">
                <h1>Dodaj do koszyka swój wymarzony instrument</h1>
                <asp:Panel ID="bsPowodzenieDodaniaDoKoszykaIKPnl" runat="server">
                   <p style="text-align:center">Gratuluje, dodano produkt do koszyka</p>
                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieDodaniaDoKoszykaIKPnl" runat="server">
                   <p style="text-align:center">Niestety, nie dodano produktu do koszyka</p>
                </asp:Panel>
                <p><asp:GridView ID="bsTabelaInstrumentowGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaInstrumentowGrid_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="bsNazwaInstr" HeaderText="bsNazwaInstr" SortExpression="bsNazwaInstr" />
                        <asp:BoundField DataField="bsKodInstr" HeaderText="bsKodInstr" SortExpression="bsKodInstr" />
                        <asp:BoundField DataField="bsCenaInstr" HeaderText="bsCenaInstr" SortExpression="bsCenaInstr" />
                        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                    </Columns>
                    </asp:GridView></p>
                
            </asp:Panel>
            <asp:Panel ID="bsNaglosnieniePnl" runat="server">
                <h1 style="margin-left:20px">Kup mikser, kolumny, mikrofony...</h1>
                <asp:Panel ID="bsPowodzenieDodaniaDoKoszykaNK" runat="server">
                    <p style="text-align:center">Gratuluje, dodano produkt do koszyka</p>

                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieDodaniaDoKoszykaNK" runat="server">
                    <p style="text-align:center">Niestety, nie dodano produktu do koszyka</p>

                </asp:Panel>
                <p>
                    <asp:GridView ID="bsTabelaNaglosnienieGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaNaglosnienieGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="bsNazwaNagl" HeaderText="bsNazwaNagl" SortExpression="bsNazwaNagl" />
                            <asp:BoundField DataField="bsKodNagl" HeaderText="bsKodNagl" SortExpression="bsKodNagl" />
                            <asp:BoundField DataField="bsCenaNagl" HeaderText="bsCenaNagl" SortExpression="bsCenaNagl" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                        </Columns>
                    </asp:GridView>
                </p>

            </asp:Panel>
            <asp:Panel ID="bsAkcesoriaPnl" runat="server">
                <h1 style="margin-left:20px">Kup rozmoite akcesoria</h1>
                <p style="margin-left:20px">Możesz u nas znaleźć: tunery, pasy do gitar,
                    kostki do gry i wiele innych
                </p>
                 
                    <asp:Panel ID="bsGratulacjeDodanoAkcesoriumDoKoszyka" runat="server">
                        <p style="text-align:center;">Gratuluje zakupu. Produkt akcesoriow dodano do koszyka</p>

                    </asp:Panel>
                <asp:Panel ID="bsPrzykroNamNieDodanoProduktuDoKoszyka" runat="server">
                        <p style="text-align:center;">Przykro nam, nie dodano produktu do koszyka</p>

                    </asp:Panel>
                
                <p style="text-align:center;">
                    <asp:GridView ID="bsTabelaAkcesoriowGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaAkcesoriowGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="bsNazwaAkcesoria" HeaderText="bsNazwaAkcesoria" SortExpression="bsNazwaAkcesoria" />
                            <asp:BoundField DataField="bsKodAkcesoria" HeaderText="bsKodAkcesoria" SortExpression="bsKodAkcesoria" />
                            <asp:BoundField DataField="bsCenaAkcesoria" HeaderText="bsCenaAkcesoria" SortExpression="bsCenaAkcesoria" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                        </Columns>
                    </asp:GridView>
                </p>

            </asp:Panel>
            <asp:Panel ID="bsOprogramowaniePnl" runat="server">
                <h1 style="margin-left:20px">Kup programy do produkcji muzyki</h1>
                <p style="margin-left:20px">Mamy w ofercie programy takie, jak: Finale, Cubase i wiele innych
                </p>
                <asp:Panel ID="bsPowodzenieOKDodaniaDoKoszykaPnl" runat="server">
                    <p style="text-align:center;">Gratuluje, dodano program do koszyka</p>
                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieOKDodaniaDoKoszykaPnl" runat="server">
                    <p style="text-align:center;">Niestety, nie dodano programu do koszyka</p>
                </asp:Panel>
                <p>
                    <asp:GridView ID="bsOprogramowanieGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsOprogramowanieGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="bsNazwaOp" HeaderText="bsNazwaOp" SortExpression="bsNazwaOp" />
                            <asp:BoundField DataField="bsKodOp" HeaderText="bsKodOp" SortExpression="bsKodOp" />
                            <asp:BoundField DataField="bsCenaOp" HeaderText="bsCenaOp" SortExpression="bsCenaOp" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                        </Columns>
                    </asp:GridView>
                </p>

            </asp:Panel>
            <asp:Panel ID="bsStudioPnl" runat="server">
                <h1 style="margin-left:20px;">Rozbuduj studio,kup konsolete lub mikser</h1>
                <p style="margin-left:20px">W naszej ofercie występują zaawansowane technologicznie konsolety, miksery
                    oraz inne super fajne pomocne urządzenia, których możesz użyć w swoim studio.
                    Zapraszamy;-)
                </p>
                <asp:Panel ID="bsPowodzenieSKDodaniaDoKoszykaPnl" runat="server">
                    <p style="text-align:center">Gratuluje, produkt dodano do koszyka</p>
                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieSKDodaniaDoKoszykaPnl" runat="server">
                    <p style="text-align:center">Niestet, produktu nie dodano do koszyka</p>
                </asp:Panel>
                <asp:GridView ID="bsTabelaStudioGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaStudioGrid_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="bsNazwaSt" HeaderText="bsNazwaSt" SortExpression="bsNazwaSt" />
                        <asp:BoundField DataField="bsKodSt" HeaderText="bsKodSt" SortExpression="bsKodSt" />
                        <asp:BoundField DataField="bsCenaSt" HeaderText="bsCenaSt" SortExpression="bsCenaSt" />
                        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
            <asp:Panel ID="bsProcesoryPnl" runat="server">
                <h1 style="margin-left:20xp">Spraw sobie nowy multiefekt do studia</h1>
                <asp:Panel ID="bsPowodzenieDodaniaDK_DoKoszykaPnl" runat="server">
                    <p style="text-align:center">Gratuluje, dodano produkt do koszyka</p>
                </asp:Panel>
                <asp:Panel ID="bsNiepowodzenieDodaniaDK_DoKoszykaPnl" runat="server">
                    <p style="text-align:center">Niestety, nie dodano produktu do koszyka</p>
                </asp:Panel>
                <asp:GridView ID="bsTabelaDspGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="bsTabelaDspGrid_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="bsNazwaDsp" HeaderText="bsNazwaDsp" SortExpression="bsNazwaDsp" />
                        <asp:BoundField DataField="bsKodDsp" HeaderText="bsKodDsp" SortExpression="bsKodDsp" />
                        <asp:BoundField DataField="bsCenaDsp" HeaderText="bsCenaDsp" SortExpression="bsCenaDsp" />
                        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Do koszyka" ShowHeader="True" Text="Do koszyka" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
            <asp:Panel ID="bsONasPnl" runat="server">
                <h1 style="margin-left:20px">Kilka informacji o naszym sklepie</h1>
                <p style="margin-left:20px">Działamy na polskim rynku od 20 lat. Cechuje nas różnorodność produktów studyjnych,
                    estradowych, rozmaite instrumenty i powiązane z nimi akcesoria.
                    Jesteśmy otwarci na wszelkie inspiracje ze strony naszych klientów.
                    Zatem, jeśli masz jakiś pomysł na swoje studio, zadzwoń do nas i zamów u nas
                    sprzęt, którego jeszcze nie mamy w ofercie. Ty na tym zyskasz, bo będziesz miał w studio coś 
                    nowego, ale i my na tym zyskamy, gdy twój zakup wzbogaci naszą ofertę.
                    Zapraszam do zakupów u nas.
                </p>

            </asp:Panel>
            <asp:Panel ID="bsKontaktPnl" runat="server">
                <h1 style="margin-left:20px">Zapraszamy do kontaktu z nami</h1>
                <p style="margin-left:20px">Infolinia: 22 333 333 333 </p>
                <p style="margin-left:20px">Przedstawiciel handlowy: Anna Kowalska tel.934583746</p>
                <p style="margin-left:20px">Dyrektor sklepu: Tomasz Kowalski tel. 333456784</p>
                <p style="margin-left:20px">Pracujemy od pondziałku do piątku wodzinach 9-17</p>
                <p style="margin-left:20px">Infolinia czynna w godzinach 9-21</p>
            </asp:Panel>
            <asp:Panel ID="bsFaqPnl" runat="server">
                <h1 style="margin-left:20px;">Najcześciej zadawane pytania</h1>
                <p style="margin-left:20px;">1.Kupiłem produkt na dane firmy, ale chciałbym go zwrócić. Jak mogę to zrobić?<br />
                    Niestety polskie prawo nie daje możliwości zwrotu produktów zakupionych przez firmę.
                    Prawo do zwrotu przysługuje tylko konsumentom, a więc stosuje się wyłącznie do sprzedarzy osobie fizycznej.
                </p>
                <p style="margin-left:20px;">2.Dlaczego cena produktu zmieniła się w ciągu dnia?<br />
                    Ponieważ cena zależy od dostawców. Może się zdarzyć, że 
                    cena wybranych produktów może się zmienić z dnia na dzień lub nawet w ciągu dnia.
                 </p>
                <p style="margin-left:20px;">3.Czy moje dane osobowe są bezpieczne?<br />
                    Tak.Zastosowanie najnowocześnejszych technik szyfrujących SSL w obszarze koszyka zakupowego
                    zapewnia optymalną ochronę.
                </p>
                <p style="margin-left:20px;">4.Czy obowiązuje minimalna wartość zamówienia?<br />
                    Tak. Minimalna wartość zamówienia to 10 zł.
                </p>

            </asp:Panel>
            <asp:Panel ID="bsTransportPnl" runat="server">
                <h1 style="margin-left:20px;">Koszty wysyłki:</h1>
                
                    <table style="width: 350px;margin:auto;" border="1">
                        <tr>
                            <td class="auto-style2">Firma kurierska</td>
                            <td class="auto-style3">Przelew</td>
                            <td>Pobranie</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Ups</td>
                            <td class="auto-style3">12 zł</td>
                            <td>15 zł</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">DPD</td>
                            <td class="auto-style3">14 zł</td>
                            <td>20 zł</td>
                        </tr>
                    </table>

                

            </asp:Panel>
            <asp:Panel ID="bsPlatnosciPnl" runat="server">
                <h1 style="margin-left:20px;">Płatności</h1>
                <p style="margin-left:20px;">W naszym sklepie zamawiąjący ma możliwość wyboru kliku rodzajów płatności na zamówienie:</p>
                <p style="margin-left:20px;">W imieniu firmy Pasja Jolanta Zalewska obsługą płatności
                     elektronicznych zajmuje się firma PayU S.A. z siedzibą w
                     Poznaniu, która występuje jako pobierający opłatę 
                    (np. rejestrze transakcji dokonanych kartą). </p>
                <p style="margin-left:20px;">* e-przelewy - Alior Bank, BOŚ Bank, Bank BPH, Przelewy24 Bank Zachodni WBK,
                     Płacę z City Handlowy, Eurobank, ING, Inteligo,
                     Credit Agricole Bank Polska, mTransfer, MerituBank, Millennium Bank,
                     MultiTransfer, PEKAO S.A.,Płacę z PKO, Deutsche Bank, BNP Paribas, Paylink Idea, </p>
                <p style="margin-left:20px;">* karty płatnicze - karty VISA, MasterCard; </p>
                <p style="margin-left:20px;">Przelew bankowy mBank - płacisz po złożeniu zamówienia. Numer konta przyślemy
                     Ci w mailu, potwierdzającym przyjęcie zamówienia.
Przesyłka zostanie wysłana dopiero, gdy pieniądze wpłyną na nasze 
                    konto (czas zaksięgowania środków to średnio 24 godzin).
                     O wysłaniu paczki poinformujemy Cię osobnym mailem. </p>
                <p style="margin-left:20px;">Numer konta bankowego: 02 9283 1234 2345 3456 4532 3456</p>
                <p style="margin-left:20px;">Adres:Sklep Muzyczna Bartosz Szmit ul.Kwiatowa 4 </p>
                <p style="margin-left:20px;">kod poczt.02-324 Warszawa</p>
            </asp:Panel>
            <asp:Panel ID="bsTaxFreePnl" runat="server">
                <h1 style="margin-left:20px;">Zasady Tax Free</h1>
                <p style="margin-left:20px;">Jako turysta posiadający stałe miejsce zamieszkania poza 
                    obszarem Unii Europejskiej (UE) jesteś uprawniony do żądania zwrotu podatku VAT,
                     jeżeli zakupione w Polsce produkty wywozisz w stanie nienaruszonym poza obszar UE.</p>
                <p style="margin-left:20px;">
                    Minimalna kwota łącznej wartości zakupów wraz z podatkiem VAT, na jednym formularzu TAX-FREE z dołączonym do niego jednym paragonem z kasy fiskalnej, uprawniająca do zwrotu VAT, wynosi 200 zł.
                </p>
                <p style="margin-left:20px;">System 3 kroków jest prosty w użyciu i łatwy do zapamiętania, wystarczy postąpić zgodnie z poniższą instrukcją, aby uzyskać zwrot podatku VAT:</p>
                <p style="margin-left:20px;">1. Sklep - Zawsze gdy robisz zakupy poproś personel o wystawienie formularza TAX-FREE. Upewnij się, czy twoje imię i nazwisko, adres i numer paszportu zostały prawidłowo wpisane oraz czy paragon z kasy fiskalnej został dołączony do formularza. Data na wystawionym formularzu musi być zgodna z datą na paragonie. Zachowaj formularz TAX-FREE wraz z ulotką do momentu refundacji.</p>
                <p style="margin-left:20px;">2. Urząd Celny - Gdy opuszczasz Polskę i Unię Europejską musisz pokazać zakupione towary (w stanie nienaruszonym), formularz TAX-FREE z załączonym paragonem z kasy fiskalnej oraz paszport w celu ostemplowania go przez polskiego bądź innego celnika z UE. Potwierdzenie wywozu z UE musi nastąpić najpóźniej w ostatnim dniu trzeciego miesiąca następującego po miesiącu dokonania zakupów.</p>
                <p style="margin-left:20px;">BRAK PIECZĘCI CELNIKA NA FORMULARZU TAX-FREE = ODMOWA REFUNDACJI</p>
                <p style="margin-left:20px;">3. Punkt Refundacji Global Blue - Wreszcie odzyskaj gotówkę realizując formularz TAX-FREE w  najbliższym Punkcie Obsługi Klienta Global Blue lub w jednym z partnerskich Punktów Refundacji (listę biur znajdziesz w ulotce dołączonej do formularza) . Należy pamiętać o tym, aby zrealizować formularz TAX-FREE nie później niż po 7 miesiącach następujących po miesiącu dokonania zakupów. Kwota zwrotu jest skalkulowana po odjęciu kosztów usługi.</p>

            </asp:Panel>
            <asp:Panel ID="bsLogowaniePnl" runat="server">
                <asp:Panel ID="bsKomunikatWymaganePolaLogowania" runat="server">
                    <p style="text-align:center;">Komunikat!!! - wypelnij wszystkie pola</p>
                </asp:Panel>
                <asp:Panel ID="bsKomunikatCzyIstniejeTakiUser" runat="server">
                    <p style="text-align:center;">
                        <asp:Label ID="bsKomunikatBrakTakiegoUseraLbl" runat="server" Text=""></asp:Label></p>
                </asp:Panel>

                <asp:Panel ID="bsKomunikatJestesZalogowany" runat="server">
                    <p style="text-align:center;">Komunikat!!! - Jestes zalogowany/ana</p>
                </asp:Panel>
                <asp:Panel ID="bsKomunikatNieJestesZalogowany" runat="server">
                    <p style="text-align:center;">Komunikat!!! - Nie jestes zalogowany/ana</p>
                </asp:Panel>
                <h1>Zaloguj się...</h1>
                <asp:Panel ID="bsFormaLogowaniaPnl" runat="server">
                    <table style="width: 300px;margin:auto;">
                        <tr>
                            <td class="auto-style4">Login:</td>
                            <td></td>
                        
                        </tr>
                        <tr>
                            <td class="auto-style4">Hasło</td>
                            <td></td>
                        
                        </tr>
                    
                    </table>
                </asp:Panel>
                <asp:Panel ID="Panel1" runat="server">

                    <asp:GridView ID="bsGridPokazujacyZalogowanegoUsera" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="bsLoginUser" HeaderText="bsLoginUser" SortExpression="bsLoginUser" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
                <p style="text-align:center;"></p>
            <p style="text-align:center;">
                <asp:Button ID="bsWylogujBtn" runat="server" Text="Wyloguj" Width="163px" OnClick="bsWylogujBtn_Click" /></p>
            </asp:Panel>
            <asp:Panel ID="bsRejestrowaniePnl" runat="server">
                <asp:Panel ID="bsKomunikatRejestracjiWymaganePola" runat="server">
                    <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                </asp:Panel>
                <asp:Panel ID="bsKomunikatRejestracjiPoprawnoscDanych" runat="server">
                    <p style="text-align:center">Komunikat!!! - liczby zabronione</p>

                </asp:Panel>
                <asp:Panel ID="bsKomunikatPowodzeniaUtworzeniaKontaUsera" runat="server">
                    <p style="text-align:center">Gratuluje!!! - udalo sie utworzyc konto</p>

                </asp:Panel>
                <asp:Panel ID="bsKomunikatNiepowodzeniaUtworzeniaKonta" runat="server">
                    <p style="text-align:center">Niestety!!! - nie udalo sie utworzyc konta</p>

                </asp:Panel>
                <h1>Zarejestruj się...</h1>
                <asp:Panel ID="bsFormalarzRejestracjiPnl" runat="server">
                    
                            <table style="width: 300px;margin:auto;">
                            <tr>
                                <td class="auto-style4">Login:</td>
                                <td><asp:TextBox ID="bsLoginRejTxb" runat="server"></asp:TextBox></td>
                        
                            </tr>
                            <tr>
                                <td class="auto-style4">Hasło</td>
                                <td><asp:TextBox ID="bsHasloRejTxb" AutoCompleteType="None" TextMode="Password" runat="server"></asp:TextBox></td>
                        
                            </tr>
                    
                        </table>
                    
                </asp:Panel>
                <asp:Panel ID="bsRejestrujPnl" runat="server">
                    <p style="text-align:center;"><asp:Button ID="bsRejestrujBtn" runat="server" Text="Zarejestruj" Width="164px" OnClick="bsRejestrujBtn_Click" /></p>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel ID="bsLogowanieAdminaPnl" runat="server">
                <asp:Panel ID="bsKomunikatLogowaniaAdminaWymaganePolaPnl" runat="server">
                    <p style="text-align:center">Komunikat!!! - wypelnij wszystkie pola</p>

                </asp:Panel>
                <asp:Panel ID="bsAdmPowodzeniePolaPln" runat="server">
                    <p style="text-align:center;">Kominikat!!! - udalo sie zalgować jako administrator</p>

                </asp:Panel>
                <asp:Panel ID="bsKomikatOPoprawnosciDanych" runat="server">
                    <p style="text-align:center;">Kominikat!!! - dane nie moga byc liczbami</p>

                </asp:Panel>
                <h1>Zaloguj się jako administrator</h1>
                <asp:Panel ID="bsFormularzLogowaniaAdminaPnl" runat="server">
                    <table style="width: 400px;margin:auto;">
                        <tr>
                            <td class="auto-style7">Login</td>
                            <td>
                                <asp:TextBox ID="bsAdminLoginTxb" runat="server" CssClass="auto-style6" Width="130px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Haslo</td>
                            <td><asp:TextBox ID="bsAdminHasloTxb" AutoCompleteType="None" TextMode="Password" runat="server" CssClass="auto-style8" Width="130px"></asp:TextBox></td>
                        </tr>
                    
                    </table>
                </asp:Panel>
                <p style="text-align:center;"><asp:Button ID="bsZalogujAdminaBtn" runat="server" Text="Zaloguj admina" Width="145px" OnClick="bsZalogujAdminaBtn_Click" /></p>
            </asp:Panel>
        </div>
        <div class="clear"></div>
     </div>
    </form>
</body>
</html>
