<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bs_StronaGlowna.aspx.cs" Inherits="StronaGlowna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 126px;
            height: 46px;
        }
        .auto-style3 {
            height: 46px;
        }
        .auto-style4 {
            width: 400px;
            border-radius:inherit;

        }
        .auto-style5 {
            width: 126px;
            height: 47px;
        }
        .auto-style6 {
            height: 47px;
        }
       .komentarzOLogowaniu{
           text-align:center;

       }
       #bs_ObliczanieKosztuKapitaluLink{
           
           
           width:400px;
           padding-top:20px;
           padding-left:20px;
           padding-right:20px;
           padding-bottom:20px;
           background-color:black;
           color:white;
           

       }
       #bs_ZmienneStopyProcentoweLink{
           
           margin-bottom:30px;
           padding-top:20px;
           padding-left:20px;
           padding-right:20px;
           padding-bottom:20px;
           width:400px;
           height:50px;
           background-color:black;
           color:white

       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-style: italic; font-variant: normal;text-align:center;">Projekt II - strona główna</h1>
        
        <asp:Panel ID="bs_InfoKorzystaniaZeStrony" runat="server">
            <p class="komentarzOLogowaniu" style="color: #FF0000">Zeby skorzystac z funkcjonalności strony, zaloguj się.</p>
            
        </asp:Panel>
       
        <asp:Panel ID="bs_ErrorWypelnienieWymaganychPolPL" runat="server">
             <p style="text-align:center; color: #FF0000;">
                 ERROR!!! - proszę wypełnić wszystkie pola.

        </p>
        </asp:Panel>
        <asp:Panel ID="bs_ErrorPoprawnosciDanychPL" runat="server">
             <p style="text-align:center; color: #FF0000;">
                 ERROR!!! - taki uzytkownik nie istnieje.

        </p>
        </asp:Panel>
        <div style="width:400px;margin:auto;border:5px solid black;">
        <asp:Panel ID="bs_FormularzLogowaniaPnl" runat="server" Height="100px">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style2">Login:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="bs_loginTxb" runat="server" Height="24px" Width="229px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Hasło:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="bs_hasloTbx" runat="server" TextMode="Password" AutoCompleteType="None" Height="24px" Width="227px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
            </div>
        <p style="text-align:center;">Czy jesteś zalogowany/na?:<asp:Label ID="bs_StatusLogowania" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bs_Id_user" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="bs_Id_user" HeaderText="bs_Id_user" InsertVisible="False" ReadOnly="True" SortExpression="bs_Id_user" />
                    <asp:BoundField DataField="bs_Login" HeaderText="bs_Login" SortExpression="bs_Login" />
                </Columns>
            </asp:GridView>
        </p>
        <p style="text-align:center;">Jesteś zalogowany jako:
            <asp:Label ID="bs_twojLoginLbl" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="text-align:center;">
            <asp:Button ID="bs_zalogujBtn" runat="server" Text="Zaloguj mnie" OnClick="bs_zalogujBtn_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Font-Size="Large" Height="48px" Width="163px" />
        </p>
        
        
        <asp:Panel ID="bs_OpcjaRejestracjiPnl" runat="server">
            <p style="text-align:center;">Jeśli nie masz konta, załóż je:<asp:HyperLink ID="bs_StronaRejestracjiLink" runat="server" BackColor="White" NavigateUrl="~/bs_StronaRejestracji.aspx">Do rejestracji</asp:HyperLink></p>
        </asp:Panel>
        
        
            <p style="text-align:center">
                
                <asp:Button ID="bs_WylogujBtn" runat="server" BorderStyle="Solid" BorderWidth="3px" Font-Size="Large" Height="43px" Text="Wyloguj" Width="150px" BackColor="White" OnClick="Button1_Click" />
                
            </p>
        
        <br />
    
    </div>
        
        <p style="text-align:center;margin-bottom:50px;">
        <asp:HyperLink ID="bs_ObliczanieKosztuKapitaluLink" runat="server" NavigateUrl="~/bs_KosztKapitalu.aspx" Visible="False" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" ForeColor="White">Obliczanie kosztu kapitalu</asp:HyperLink>
        <br /></p>
        
    </form>
</body>
</html>
