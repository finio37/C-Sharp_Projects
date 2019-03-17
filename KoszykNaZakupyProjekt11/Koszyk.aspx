<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Koszyk.aspx.cs" Inherits="Koszyk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #tabelaKoszyk {
            width:380px;
            margin:auto;
            margin-bottom:30px;
        }
        #powrotDoSklepu {
            
            padding-top:20px;
            padding-left:20px;
            padding-right:20px;
            padding-bottom:20px;
            background-color:black;
            color:white;
        }
        #powrotDoSklepu:hover {
            padding-top:20px;
            padding-left:20px;
            padding-right:20px;
            padding-bottom:20px;
            background-color:white;
            border:5px solid black;
            color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:500px;margin:auto;border:5px solid black;">
        <h1 style="text-align:center;">To jest twój koszyk z zakupami</h1>
        <p style="text-align:center;">


            <asp:GridView ID="tabelaKoszyk" runat="server" AutoGenerateColumns="False" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="3px" DataKeyNames="IdProdukt" Width="455px">
                <Columns>
                    <asp:BoundField DataField="IdProdukt" HeaderText="IdProdukt" InsertVisible="False" ReadOnly="True" SortExpression="IdProdukt" />
                    <asp:BoundField DataField="NazwaProduktu" HeaderText="NazwaProduktu" SortExpression="NazwaProduktu" />
                    <asp:BoundField DataField="KodProduktu" HeaderText="KodProduktu" SortExpression="KodProduktu" />
                    <asp:BoundField DataField="CenaProduktu" HeaderText="CenaProduktu" SortExpression="CenaProduktu" />
                    <asp:BoundField DataField="Ilosc" HeaderText="Ilosc" SortExpression="Ilosc" />
                </Columns>
            </asp:GridView>


        </p>
       
    </div>
         <p style="text-align:center;margin-top:30px;">
             <asp:HyperLink ID="powrotDoSklepu" runat="server" NavigateUrl="~/StronaGlowna.aspx">Powrót do sklepu</asp:HyperLink>
        </p>
        
    </form>
</body>
</html>
