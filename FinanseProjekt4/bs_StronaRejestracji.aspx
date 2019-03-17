<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_StronaRejestracji.aspx.cs" Inherits="bs_StronaRejestracji" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 146px;
            height: 42px;
        }
        .auto-style3 {
            height: 42px;
        }
        .auto-style4 {
            width: 146px;
            height: 45px;
        }
        .auto-style5 {
            height: 45px;
        }
        #GridView1 {
            width:300px;
            margin:auto;
        }
    </style>
</head>
<body>

    <h1 style="text-align:center;">Witamy na stronie rejestracji</h1>
    <form id="form1" runat="server">
    
        
    <div style="width:400px;margin:auto;border:5px solid black">
    <asp:Panel ID="bs_KomunikatOZarejestrowaniu" runat="server">
            <p style="text-align:center; color: #FF0000;">Gratuluję!!! Zostałeś zarejestrowany.</p>
        <p style="text-align:center; color: #FF0000;">Możesz się teraz zalogować -> 
            <asp:HyperLink ID="bs_LogowanieLink" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
            </p>
        </asp:Panel>
        <asp:Panel ID="bs_KomunikatONiezarejestrowaniu" runat="server">
            <p style="text-align:center; color: #FF0000;">Przykro mi,nie zostałeś zarejestrowany.</p>
            <p style="text-align:center; color: #FF0000;">Jeśli masz konto, zaloguj się... <asp:HyperLink ID="bs_PowrotDoStronyLogowania" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
         </p>
        </asp:Panel>
        <asp:Panel ID="bs_ErrorIstnienieTakiUzytkownikPL" runat="server">
            <p style="text-align:center; color: #FF0000;">Przykro mi, taki uzytkownik już istnieje.</p>
            <p style="text-align:center; color: #FF0000;">Jeśli masz konto, zaloguj się... <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
         </p>
        </asp:Panel>
        <asp:Panel ID="bs_KomunikatWymaganychPolPL" runat="server">
            <p style="text-align:center; color: #FF0000;">ERROR!!! - proszę wypełnić wszystkie pola</p>
            <p style="text-align:center; color: #FF0000;">Jeśli masz konto, zaloguj się... <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
         </p>
        </asp:Panel>
        <asp:Panel ID="bs_KomunikatJesliLoginJestInt" runat="server">
            <p style="text-align:center; color: #FF0000;">ERROR!!! - Login - dozwolone tylko ciągi znaków.</p>
            <p style="text-align:center; color: #FF0000;">Jeśli masz konto, zaloguj się... <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
         </p>
        </asp:Panel>
        <p style="text-align:center;">
            <table style="border: medium solid #008000; width:300px; margin:auto;" border="1">
            <tr>
                <td class="auto-style2">Login:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="bs_LoginTxb" runat="server" Height="26px" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Hasło:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="bs_HasloTxb" runat="server" Height="26px" TextMode="Password" AutoCompleteType="None" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="3px"></asp:TextBox>
                </td>
            </tr>
        </table>
            </p>
    <p style="text-align:center;">
        <asp:Button ID="bs_ZarejestrujBtn" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="3px" Height="46px" Text="Zarejestruj" Width="295px" OnClick="bs_ZarejestrujBtn_Click" />
        </p>
        <p style="text-align:center;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bs_Id_user" Width="292px" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="3px">
                <Columns>
                    <asp:BoundField DataField="bs_Id_user" HeaderText="bs_Id_user" InsertVisible="False" ReadOnly="True" SortExpression="bs_Id_user" />
                    <asp:BoundField DataField="bs_Login" HeaderText="bs_Login" SortExpression="bs_Login" />
                </Columns>
        </asp:GridView></p>
        <asp:Panel ID="bs_PowrotDoLogowania" runat="server">
           <p style="text-align:center; color: #FF0000;">Jeśli masz już konto</p>
        <p style="text-align:center; color: #FF0000;">Możesz się teraz zalogować -> 
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/bs_StronaGlowna.aspx">Do logowania</asp:HyperLink>
            </p>
        </asp:Panel>
    </div>
       
    </form>
</body>
</html>
