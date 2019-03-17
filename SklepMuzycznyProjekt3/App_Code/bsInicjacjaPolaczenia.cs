using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for bsInicjacjaPolaczenia
/// </summary>
public class bsInicjacjaPolaczenia
{

    private SqlDataAdapter bs_adapter;
    private SqlConnection bs_polaczenie;
    public bsInicjacjaPolaczenia()
    {
        bs_adapter = new SqlDataAdapter();
        bs_polaczenie = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

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

    public DataTable IniWykonajZapytanieBezParametru(string zapytanie)
    {
        //utworzenie obiektu sql
        SqlCommand com_par = new SqlCommand();
        //utworzenie obiektu datatable
        DataTable dt = new DataTable();
        //otwarcie połączenia
        com_par.Connection = bs_MetodaPolaczeniaDoBazy();
        //przypisanie zapytania
        com_par.CommandText = zapytanie;
        //wykonanie polecenia
        com_par.ExecuteNonQuery();

        SqlDataAdapter adapter = new SqlDataAdapter(com_par);
        //zamknięcie połączenia
        com_par.Connection = bs_MetodaZamykaniaPolaczenia();
        //utworzenie obiektu dataset
        DataSet ds = new DataSet();
        //wypisanie wiersz po wierszu
        adapter.Fill(ds);
        dt = ds.Tables[0];
        //zwrócenie przez obiekt dataset
        return dt;
    }
    public string bs_WykonajZapytaniezParametremOrazZwrocPoleStringiem(string bs_zapytanie, SqlParameter[] bs_param)
    {
        string error = "Taki użytkownik nie istnieje";
        
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
        if (bs_ds.Tables[0].Rows.Count > 0)
            return bs_ds.Tables[0].Rows[0]["bsLoginAdmin"].ToString();
        else
            return error;
        
    }
    public string bs_WykonajZapytaniezParametremOrazZwrocPoleLogin_tabelaUsers(string bs_zapytanie, SqlParameter[] bs_param)
    {
        bsTrescErrorow.brakTakiegoUsera = "brak takiego uzytkownika";
        bsTrescErrorow.istnienieUsera = null;
        
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
        if (bs_ds.Tables[0].Rows.Count > 0)
            return bs_ds.Tables[0].Rows[0]["bsLoginUser"].ToString();
        else
            return bsTrescErrorow.istnienieUsera;
       
    }

    public string bs_WykonajZapytaniezParametremOrazZwrocPoleHaslo_tabelaUsers(string bs_zapytanie, SqlParameter[] bs_param)
    {
        
        //instancja polecenia sql
        bsTrescErrorow.brakTakiegoUsera = "Brak takiego uzytkownika";
        bsTrescErrorow.istnienieUsera = null;
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
        if (bs_ds.Tables[0].Rows.Count > 0)
            return bs_ds.Tables[0].Rows[0]["bsHasloUser"].ToString();
        else
            return bsTrescErrorow.istnienieUsera;
        
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
    public bool bs_IniModyfikacjaDanychAkcesoriow(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychInstrumentow(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychNaglosnienia(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychOprogramowania(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychStudio(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychWyprzedarz(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
    public bool bs_IniModyfikacjaDanychDsp(string zapytanie, SqlParameter[] param)
    {
        //utworzenie instancji sql
        SqlCommand com_par = new SqlCommand();
        try
        {
            //otwarcie połączenia
            com_par.Connection = bs_MetodaPolaczeniaDoBazy();
            //przypisanie polecenia sql
            com_par.CommandText = zapytanie;
            //dołączenia parametrów
            com_par.Parameters.AddRange(param);
            //przypisanie instrukcji select
            bs_adapter.UpdateCommand = com_par;
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
}