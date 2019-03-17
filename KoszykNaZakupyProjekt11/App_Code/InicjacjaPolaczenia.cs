using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for InicjacjaPolaczenia
/// </summary>
public class InicjacjaPolaczenia
{
    private SqlDataAdapter adapter;
    private SqlConnection polaczenie;
    public InicjacjaPolaczenia()
    {
        adapter = new SqlDataAdapter();
        polaczenie = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        //
        // TODO: Add constructor logic here
        //
    }
    //metoda otwierająca połączenie
    private SqlConnection MetodaPolaczeniaDoBazy()
    {
        polaczenie.Open();
        return polaczenie;
    }
    //metoda zaykająca połączenie
    private SqlConnection MetodaZamykaniaPolaczenia()
    {
        polaczenie.Close();
        return polaczenie;
    }
    //metoda wykonująca dowolne zapytanie z parametrami
    public DataTable WykonajZapytaniezParametrem(string zapytanie, SqlParameter[] param)
    {
        //bs_polaczenie.Open();
        //string bs_sql_command = "select bs_Id_user,bs_Login from bs_Uzytkownicy where bs_Login=@bs_Login";
        //instancja polecenia sql
        SqlCommand com_par = new SqlCommand();
        //obiekt datatable
        DataTable dt = new DataTable();
        //otwarcie połączenia
        com_par.Connection = MetodaPolaczeniaDoBazy();
        //przypisanie zapytania 
        com_par.CommandText = zapytanie;
        //dołączenie wszystkich parametrów
        com_par.Parameters.AddRange(param);
        //wykonanie polecenia sql
        com_par.ExecuteNonQuery();
        SqlDataAdapter bs_adapter = new SqlDataAdapter(com_par);
        //zamknięcie połączenia
        com_par.Connection = MetodaZamykaniaPolaczenia();
        //utworzenie instancji dataset
        DataSet ds = new DataSet();
        //wypełnienie wiersz po wierszu
        adapter.Fill(ds);
        dt = ds.Tables[0];
        //zwrócenie przez obiekt bs_dt
        return dt;
    }
    public DataTable IniWykonajZapytanieBezParametru(string zapytanie)
    {
        //utworzenie obiektu sql
        SqlCommand com_par = new SqlCommand();
        //utworzenie obiektu datatable
        DataTable dt = new DataTable();
        //otwarcie połączenia
        com_par.Connection = MetodaPolaczeniaDoBazy();
        //przypisanie zapytania
        com_par.CommandText = zapytanie;
        //wykonanie polecenia
        com_par.ExecuteNonQuery();

        SqlDataAdapter adapter = new SqlDataAdapter(com_par);
        //zamknięcie połączenia
        com_par.Connection = MetodaZamykaniaPolaczenia();
        //utworzenie obiektu dataset
        DataSet ds = new DataSet();
        //wypisanie wiersz po wierszu
        adapter.Fill(ds);
        dt = ds.Tables[0];
        //zwrócenie przez obiekt dataset
        return dt;
    }
    public bool IniWykonajDodawanieDoBazy(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji polecenia sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            // otwarcie połączenia
            com_par.Connection = MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenie parametrów
            com_par.Parameters.AddRange(param);
            //dodanie polecenia insert
            adapter.InsertCommand = com_par;
            //wykonanie polecenia sal
            com_par.ExecuteNonQuery();
        }
        catch (Exception)
        {
            //zamknięcie połączenia
            com_par.Connection = MetodaZamykaniaPolaczenia();
            return false;
        }
        finally
        {
            //zamknięcie połączenia
            com_par.Connection = MetodaZamykaniaPolaczenia();
        }
        //zwrócenie wartości logicznej
        return true;
    }
}