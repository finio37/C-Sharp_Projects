using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
//using System.Configuration;
/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class bs_DataAccessLayer
{
    //dodanie prywatnej instancji klasy bs_inicjacja
    private bs_InicjacjaPolaczenia bs_polaczenie;
    //SqlConnection bs_polaczenie = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseDBConnectionString"].ConnectionString);
    public bs_DataAccessLayer()
    {
        //utworzenie obiektu połączenia przez konstruktor
        bs_polaczenie = new bs_InicjacjaPolaczenia();
        //
        // TODO: Add constructor logic here
        //
    }
    //metoda wyświetlająca w datagrid loginu
    public DataTable bs_DalWyswietlwGrid(string bs_login,string bs_haslo_par)
    {
        //utworzenie obiektu datatable
        DataTable bs_dt = new DataTable();
        //zapytanie
        string bs_zapytanie = "select bs_Id_user,bs_Login from bs_Uzytkownicy where bs_Login = @bs_Login and bs_Haslo = @bs_Haslo";
        //tablica typu sql parameter
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        //utworzenie dwóch parametrów
        bs_sql_parameters[0] = new SqlParameter("@bs_Login", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_haslo_par);
        //zwrócenie zapytania z parametrem korzystając z klasy InicjacjaPołączenia
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    //metoda zwracająca wynik zapytania do rejestracji
    public DataTable bs_DalWyswietlwGridzieRejestracji(string bs_login, string bs_haslo_par)
    {

        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bs_Id_user,bs_Login,bs_Haslo from bs_Uzytkownicy where bs_Login = @bs_Login and bs_Haslo = @bs_Haslo";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bs_Login", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_haslo_par);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    
    //metoda zwracająca zapytanie o login przy pomocy parametrów loginu i hasla
    public DataTable bs_DalWyswietlLogin(string bs_Login,string bs_Haslo)
    {
        string bs_zapytanie = "select bs_Id_user,bs_Login from bs_Uzytkownicy where bs_Login = @bs_Login and bs_Haslo = @bs_Haslo";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bs_Login",SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie,bs_sql_parameters);


    }
    
    public DataTable bs_DalCzyJestTakiUzytkownik(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "select bs_Login from bs_Uzytkownicy where bs_Login = @bs_Login and bs_Haslo = @bs_Haslo";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bs_Login", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);


    }
    
    
    public DataTable bs_DalWyswietlKwotyKapitalu()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdKapitalu,bsKosztKapitalu from bsKapitalWlasny";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlKosztyDlugu()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdDlugu,bsKosztDlugu from bsTabelaKosztDlugu";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlWartosciRynkoweAkcji()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdWRA,bsWartoscRA from bsTabelaWartoscRynkowaAkcji";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public bool bs_DalCzyIstnieTakiRekord(string bs_Login,string bs_Haslo)
    {
        string bs_zapytanie = "select Count(*) from bs_Uzytkownicy where bs_Login = @bs_Login and bs_Haslo = @bs_Haslo";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bs_Login", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_IniCzyIstniejeTakiRekord(bs_zapytanie, bs_sql_parameters);
    }
    //metoda logiczna - true, jeśli dodano - false, jeśli nie dodano
    public bool bs_DalDodajRekord(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "insert into bs_Uzytkownicy (bs_Login,bs_Haslo) values(@bs_Login,@bs_Haslo)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bs_Login", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bs_Haslo", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie,bs_sql_parameters);
    }
    
    public bool bs_DalDodajKosztKapitalu(float bs_kk)
    {
        string bs_zapytanie = "insert into bsKapitalWlasny (bsKosztKapitalu) values (@bsKosztKapitalu)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsKosztKapitalu", SqlDbType.Float);
        bs_sql_parameters[0].Value = Convert.ToString(bs_kk);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie,bs_sql_parameters);
    }
    public bool bs_DalDodajKosztDlugu(float bs_kd)
    {
        string bs_zapytanie = "insert into bsTabelaKosztDlugu (bsKosztDlugu) values (@bsKosztDlugu)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsKosztDlugu", SqlDbType.Float);
        bs_sql_parameters[0].Value = Convert.ToString(bs_kd);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajWartoscRynkowaAkcji(float bs_wra)
    {
        string bs_zapytanie = "insert into bsTabelaWartoscRynkowaAkcji (bsWartoscRA) values (@bsWartoscRA)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsWartoscRA", SqlDbType.Float);
        bs_sql_parameters[0].Value = Convert.ToString(bs_wra);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
}