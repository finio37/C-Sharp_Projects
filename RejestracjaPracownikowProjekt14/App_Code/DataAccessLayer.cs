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
    public DataTable DalWyswietlWszystkichPracownikow()
    {
        string zapytanie = "select IdPracownika,Imie,Nazwisko,NazwaDzialu from Pracownicy,Dzialy";
        return polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public DataTable DalWyswietlPracownikowJednegoDzialu()
    {
        string zapytanie = "select Pracownicy.Imie, Pracownicy.Nazwisko, Dzialy.NazwaDzialu from Dzialy INNER JOIN Pracownicy ON Dzialy.IdDzialu = Pracownicy.IdDzialu";
        
        return polaczenie.IniWykonajZapytanieBezParametru(zapytanie);

    }
    public DataTable DalWyswietlSzczegoloweDanePracownikow()
    {
        string zapytanie = "select Adresy.KodPocztowy, Adresy.Miasto, Adresy.Ulica, Pracownicy.Imie from Adresy inner join Pracownicy ON Adresy.IdPracownika = Pracownicy.IdPracownika";
        return polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public DataTable DalWyswietlLoginAdmina(string login, string haslo)
    {
        string zapytanie = "select LoginAdmina from Administrator where LoginAdmina=@LoginAdmina and HasloAdmina=@HasloAdmina";
        SqlParameter[] sql_parameters = new SqlParameter[2];
        //utworzenie dwóch parametrów
        sql_parameters[0] = new SqlParameter("@LoginAdmina", SqlDbType.VarChar);
        sql_parameters[0].Value = login;
        sql_parameters[1] = new SqlParameter("@HasloAdmina", SqlDbType.VarChar);
        sql_parameters[1].Value = haslo;
        return polaczenie.WykonajZapytaniezParametrem(zapytanie,sql_parameters);
    }
    
    public int DalZwrocIdPracownika(string imie)
    {
        string zapytanie = "select IdPracownika from Pracownicy where Imie=@Imie";
        SqlParameter[] sql_parameters = new SqlParameter[1];
        //utworzenie dwóch parametrów
        sql_parameters[0] = new SqlParameter("@Imie", SqlDbType.VarChar);
        sql_parameters[0].Value = imie;
        
        int id = Convert.ToInt32(polaczenie.WykonajZapytaniezParametrem_i_zwrocLoginAdmina_str(zapytanie,sql_parameters));
        return id;
    }
    public bool DalDodajPracownika(string imie, string nazwisko, int id_dzialu)
    {
        string zapytanie = "insert into Pracownicy (Imie,Nazwisko,IdDzialu) values (@Imie,@Nazwisko,@IdDzialu)";
        SqlParameter[] sql_parameters = new SqlParameter[3];
        sql_parameters[0] = new SqlParameter("@Imie", SqlDbType.VarChar);
        sql_parameters[0].Value = imie;
        sql_parameters[1] = new SqlParameter("@Nazwisko", SqlDbType.VarChar);
        sql_parameters[1].Value = nazwisko;
        sql_parameters[2] = new SqlParameter("@IdDzialu", SqlDbType.Int);
        sql_parameters[2].Value = id_dzialu;
        return polaczenie.IniWykonajDodawanieDoBazy(zapytanie, sql_parameters);
    }
    public bool DalDodajSzczegoloweDanePracownika(int kod_pocz,string miasto,string ulica,int id_pracownika)
    {
        string zapytanie = "insert into Adresy (KodPocztowy,Miasto,Ulica,IdPracownika) values (@KodPocztowy,@Miasto,@Ulica,@IdPracownika)";
        SqlParameter[] sql_parameters = new SqlParameter[4];
        sql_parameters[0] = new SqlParameter("@KodPocztowy", SqlDbType.Int);
        sql_parameters[0].Value = kod_pocz;
        sql_parameters[1] = new SqlParameter("@Miasto", SqlDbType.VarChar);
        sql_parameters[1].Value = miasto;
        sql_parameters[2] = new SqlParameter("@Ulica", SqlDbType.VarChar);
        sql_parameters[2].Value = ulica;
        sql_parameters[3] = new SqlParameter("@IdPracownika",SqlDbType.Int);
        sql_parameters[3].Value = id_pracownika;
        return polaczenie.IniWykonajDodawanieDoBazy(zapytanie, sql_parameters);

    }
}