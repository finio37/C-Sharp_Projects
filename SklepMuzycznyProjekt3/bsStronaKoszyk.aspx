<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bsStronaKoszyk.aspx.cs" Inherits="bsStronaKoszyk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />

</head>
    
<body>
    <form id="form1" runat="server">
    <div style="width:500px;margin:auto;background-color:green;border:5px solid blue;">
    <h1>To jest koszyk uzytkownika:<asp:Label ID="bsNazwaUzytkownikaLbl" runat="server" Text="Nikt"></asp:Label> </h1>
        <p style="text-align:center;">
            <p style="text-align:center;">Tabela akcesoriow w koszyku</p>
        </p>
        <p style="text-align:center;">

            <asp:GridView ID="bsTAkcesoriaKoszyk" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="bsNazwaAK" HeaderText="bsNazwaAK" SortExpression="bsNazwaAK" />
                    <asp:BoundField DataField="bsKodAK" HeaderText="bsKodAK" SortExpression="bsKodAK" />
                    <asp:BoundField DataField="bsCenaAK" HeaderText="bsCenaAK" SortExpression="bsCenaAK" />
                    <asp:BoundField DataField="bsLoginAK" HeaderText="bsLoginAK" SortExpression="bsLoginAK" />
                </Columns>
            </asp:GridView>
        </p>
        <p style="text-align:center;">Tabela instrumentow w koszyku</p>
        <p style="text-align:center;">
         <asp:GridView ID="bsTabelaInstrumentowKoszyk" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaIK" HeaderText="bsNazwaIK" SortExpression="bsNazwaIK" />
                <asp:BoundField DataField="bsKodIK" HeaderText="bsKodIK" SortExpression="bsKodIK" />
                <asp:BoundField DataField="bsCenaIK" HeaderText="bsCenaIK" SortExpression="bsCenaIK" />
                <asp:BoundField DataField="bsLoginIK" HeaderText="bsLoginIK" SortExpression="bsLoginIK" />
            </Columns>
        </asp:GridView>
        </p>
        <p style="text-align:center;">Tabela naglosnienia w koszyku</p>
        <p style="text-align:center;">
        <asp:GridView ID="bsTabelaNaglosnieniaKoszykGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaNK" HeaderText="bsNazwaNK" SortExpression="bsNazwaNK" />
                <asp:BoundField DataField="bsKodNK" HeaderText="bsKodNK" SortExpression="bsKodNK" />
                <asp:BoundField DataField="bsCenaNK" HeaderText="bsCenaNK" SortExpression="bsCenaNK" />
                <asp:BoundField DataField="bsLoginNK" HeaderText="bsLoginNK" SortExpression="bsLoginNK" />
            </Columns>
        </asp:GridView>
            </p>
        <p style="text-align:center;">Tabela oprogramowania w koszyku</p>
        <p style="text-align:center;">
        <asp:GridView ID="bsTabelaOprogramowaniaKoszykGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaOK" HeaderText="bsNazwaOK" SortExpression="bsNazwaOK" />
                <asp:BoundField DataField="bsKodOK" HeaderText="bsKodOK" SortExpression="bsKodOK" />
                <asp:BoundField DataField="bsCenaOK" HeaderText="bsCenaOK" SortExpression="bsCenaOK" />
                <asp:BoundField DataField="bsLoginOK" HeaderText="bsLoginOK" SortExpression="bsLoginOK" />
            </Columns>
        </asp:GridView>
            </p>
        <p style="text-align:center;">Tabela produktow studyjnych w koszyku</p>
        <p style="text-align:center;">
        <asp:GridView ID="bsTabelaProduktowStKoszykGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaSK" HeaderText="bsNazwaSK" SortExpression="bsNazwaSK" />
                <asp:BoundField DataField="bsKodSK" HeaderText="bsKodSK" SortExpression="bsKodSK" />
                <asp:BoundField DataField="bsCenaSK" HeaderText="bsCenaSK" SortExpression="bsCenaSK" />
                <asp:BoundField DataField="bsLoginSK" HeaderText="bsLoginSK" SortExpression="bsLoginSK" />
            </Columns>
        </asp:GridView>
            </p>
        <p style="text-align:center;">Tabela produktow wyprzedarzowych w koszyku</p>
        <p style="text-align:center;">
        <asp:GridView ID="bsTabelaProduktowWyprzedarzowychKoszykGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaWK" HeaderText="bsNazwaWK" SortExpression="bsNazwaWK" />
                <asp:BoundField DataField="bsKodWK" HeaderText="bsKodWK" SortExpression="bsKodWK" />
                <asp:BoundField DataField="bsCenaWK" HeaderText="bsCenaWK" SortExpression="bsCenaWK" />
                <asp:BoundField DataField="bsLoginWK" HeaderText="bsLoginWK" SortExpression="bsLoginWK" />
            </Columns>
        </asp:GridView>
            </p>
        <p style="text-align:center;">Tabela produktow dsp w koszyku</p>
        <p style="text-align:center;">
        <asp:GridView ID="bsTabelaProduktowDspKoszykGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="bsNazwaDK" HeaderText="bsNazwaDK" SortExpression="bsNazwaDK" />
                <asp:BoundField DataField="bsKodDK" HeaderText="bsKodDK" SortExpression="bsKodDK" />
                <asp:BoundField DataField="bsCenaDK" HeaderText="bsCenaDK" SortExpression="bsCenaDK" />
                <asp:BoundField DataField="bsLoginDK" HeaderText="bsLoginDK" SortExpression="bsLoginDK" />
            </Columns>
        </asp:GridView>
            </p>

    </div>
        
        <p style="text-align:center;">
            <asp:Button ID="bsPowrotDoStronyGlownejBtn" runat="server" Text="Powrot do strony głównej" OnClick="bsPowrotDoStronyGlownejBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" />

        </p>
    </form>
</body>
</html>
