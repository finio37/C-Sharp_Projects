using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for bs_InicjacjaPolaczenia
/// </summary>
public class bs_InicjacjaPolaczenia
{
    // prywatne pola zmiennych adaptera i polaczenia
    private SqlDataAdapter bs_adapter;
    private SqlConnection bs_polaczenie;
    public bs_InicjacjaPolaczenia()
    {
        //inicjalizacja adaptera i połączenia poprzez konstruktor klasy bs_InicjacjaPolaczenia
        bs_adapter = new SqlDataAdapter();
        bs_polaczenie = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseDBConnectionString"].ConnectionString);

        //
        // TODO: Add constructor logic here
        //
    }
    //metoda otwierająca połączenie
    private SqlConnection bs_MetodaPolaczeniaDoBazy()
    {
        bs_polaczenie.Open();
        return bs_polaczenie;
    }
    //metoda zaykająca połączenie
    private SqlConnection bs_MetodaZamykaniaPolaczenia()
    {
        bs_polaczenie.Close();
        return bs_polaczenie;
    }
    //metoda wykonująca dowolne zapytanie z parametrami
    public DataTable bs_WykonajZapytaniezParametrem(string bs_zapytanie, SqlParameter[] bs_param)
    {
        //bs_polaczenie.Open();
        //string bs_sql_command = "select bs_Id_user,bs_Login from bs_Uzytkownicy where bs_Login=@bs_Login";
        //instancja polecenia sql
        SqlCommand com_par = new SqlCommand();
        //obiekt datatable
        DataTable bs_dt = new DataTable();
        //otwarcie połączenia
        com_par.Connection = bs_MetodaPolaczeniaDoBazy();
        //przypisanie zapytania 
        com_par.CommandText = bs_zapytanie;
        //dołączenie wszystkich parametrów
        com_par.Parameters.AddRange(bs_param);
        //wykonanie polecenia sql
        com_par.ExecuteNonQuery();
        SqlDataAdapter bs_adapter = new SqlDataAdapter(com_par);
        //zamknięcie połączenia
        com_par.Connection = bs_MetodaZamykaniaPolaczenia();
        //utworzenie instancji dataset
        DataSet bs_ds = new DataSet();
        //wypełnienie wiersz po wierszu
        bs_adapter.Fill(bs_ds);
        bs_dt = bs_ds.Tables[0];
        //zwrócenie przez obiekt bs_dt
        return bs_dt;
    }
    //metoda wykonująca zapytania bez parametrów
    public DataTable bs_IniWykonajZapytanieBezParametru(string bs_zapytanie)
    {
        //utworzenie obiektu sql
        SqlCommand com_par = new SqlCommand();
        //utworzenie obiektu datatable
        DataTable bs_dt = new DataTable();
        //otwarcie połączenia
        com_par.Connection = bs_MetodaPolaczeniaDoBazy();
        //przypisanie zapytania
        com_par.CommandText = bs_zapytanie;
        //wykonanie polecenia
        com_par.ExecuteNonQuery();
        
        SqlDataAdapter bs_adapter = new SqlDataAdapter(com_par);
        //zamknięcie połączenia
        com_par.Connection = bs_MetodaZamykaniaPolaczenia();
        //utworzenie obiektu dataset
        DataSet bs_ds = new DataSet();
        //wypisanie wiersz po wierszu
        bs_adapter.Fill(bs_ds);
        bs_dt = bs_ds.Tables[0];
        //zwrócenie przez obiekt dataset
        return bs_dt;
    }
    //logiczna metoda, która zwraca true jeżeli rekord został odnaleziony oraz false jeśli nie
    public bool bs_IniCzyIstniejeTakiRekord(string bs_zapytanie,SqlParameter[] bs_param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = bs_zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(bs_param);
            //przypisanie instrukcji select
            bs_adapter.SelectCommand = com_par;
            //wykonanie polecenia sql
            com_par.ExecuteNonQuery();
        }
        catch (Exception)
        {
            //zamknięcie połączenia
            com_par.Connection = bs_MetodaZamykaniaPolaczenia();
            return false;
        }
        finally
        {
            //zamknięcie połączenia
            com_par.Connection = bs_MetodaZamykaniaPolaczenia();

        }
        //zwrócenie wartości logicznej
        return true;
    }
    public bool bs_IniWykonajDodawanieDoBazy(string bs_zapytanie, SqlParameter[] bs_param)
    {
        //utworzenie instancji polecenia sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            // otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = bs_zapytanie;
            //dołączenie parametrów
            com_par.Parameters.AddRange(bs_param);
            //dodanie polecenia insert
            bs_adapter.InsertCommand = com_par;
            //wykonanie polecenia sal
            com_par.ExecuteNonQuery();
        }
        catch (Exception)
        {
            //zamknięcie połączenia
            com_par.Connection = bs_MetodaZamykaniaPolaczenia();
            return false;
        }
        finally
        {
            //zamknięcie połączenia
            com_par.Connection = bs_MetodaZamykaniaPolaczenia();
        }
        //zwrócenie wartości logicznej
        return true;
    }
    

}