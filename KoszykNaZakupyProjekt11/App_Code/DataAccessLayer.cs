using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    private InicjacjaPolaczenia polaczenie;
    public DataAccessLayer()
    {
        polaczenie = new InicjacjaPolaczenia();
        
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable DalWyswietlwGrid()
    {
        //utworzenie obiektu datatable
        DataTable dt = new DataTable();
        //zapytanie
        string zapytanie = "select IdTowaru,NazwaTowaru,KodTowaru,CenaTowaru from Towary";
        //tablica typu sql parameter
        
        //zwrócenie zapytania z parametrem korzystając z klasy InicjacjaPołączenia
        return polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public DataTable DalWyswietlKoszyk()
    {
        DataTable dt = new DataTable();
        string zapytanie = "select IdProdukt,NazwaProduktu,KodProduktu,CenaProduktu,Ilosc from TabelaKoszyk";
        return polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public bool DalDodajTowarDoSklepu(string nazwa, string kod,float cena)
    {
        string zapytanie = "insert into Towary (NazwaTowaru,KodTowaru,CenaTowaru) values(@NazwaTowaru,@KodTowaru,@CenaTowaru)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@NazwaTowaru", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(nazwa);
        bs_sql_parameters[1] = new SqlParameter("@KodTowaru", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(kod);
        bs_sql_parameters[2] = new SqlParameter("@CenaTowaru",SqlDbType.Float);
        bs_sql_parameters[2].Value = Convert.ToString(cena);
        return polaczenie.IniWykonajDodawanieDoBazy(zapytanie, bs_sql_parameters);
    }
    public bool DalDodajProduktDoKoszyka(string nazwa, string kod, float cena,int ilosc)
    {
        string zapytanie = "insert into TabelaKoszyk (NazwaProduktu,KodProduktu,CenaProduktu,Ilosc) values(@NazwaProduktu,@KodProduktu,@CenaProduktu,@Ilosc)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        
        bs_sql_parameters[0] = new SqlParameter("@NazwaProduktu", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(nazwa);
        bs_sql_parameters[1] = new SqlParameter("@KodProduktu", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(kod);
        bs_sql_parameters[2] = new SqlParameter("@CenaProduktu", SqlDbType.Float);
        bs_sql_parameters[2].Value = Convert.ToString(cena);
        bs_sql_parameters[3] = new SqlParameter("@Ilosc",ilosc);
        bs_sql_parameters[3].Value = ilosc;
        return polaczenie.IniWykonajDodawanieDoBazy(zapytanie, bs_sql_parameters);
    }
}