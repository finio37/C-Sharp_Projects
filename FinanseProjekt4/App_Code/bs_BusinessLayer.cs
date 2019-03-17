using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Linq;
/// <summary>
/// Summary description for bs_BusinessLayer
/// </summary>
public class bs_BusinessLayer
{
    //pole typu dostepu do danych
    private bs_DataAccessLayer bs_warstwa_dostepu;
    public bs_BusinessLayer()
    {
        //utworzenie instancji przez konstruktor
        bs_warstwa_dostepu = new bs_DataAccessLayer();
        //
        // TODO: Add constructor logic here
        //
    }
    //metoda logiczna zwracająca wartośc logiczną przez warstwe dostepu
    public bool bs_BLCzyIstniejeTakiRekord(string bs_login_par,string bs_haslo_par)
    {
        return bs_warstwa_dostepu.bs_DalCzyIstnieTakiRekord(bs_login_par,bs_haslo_par);

    }
    //metoda zwracająca wynik zapytania
    public DataTable bs_WyswietlwGridzie(string bs_login_par,string bs_haslo_par)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlwGrid(bs_login_par,bs_haslo_par);

        return bs_dt;
    }
    //metoda zwracająca wynik zapytania rejestracji
    public DataTable bs_BLWyswietlwGridzieRejestracji(string bs_login_par, string bs_haslo_par)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlwGridzieRejestracji(bs_login_par, bs_haslo_par);

        return bs_dt;
    }
    
    public DataTable bs_BlWyswietlTablelaKosztowKapitalu()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlKwotyKapitalu();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleKosztyDlugu()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlKosztyDlugu();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleWartoscRynkoweAkcji()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlWartosciRynkoweAkcji();
        return bs_dt;
    }
    //metoda zwracająca nazwę jednego uzytkownika
    public bs_KlasaUzytkownika bs_BalWyswietlMojLogin(string bs_login_par,string bs_haslo_par)
    {
        bs_KlasaUzytkownika bs_obiekt_uzytkownika = new bs_KlasaUzytkownika();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlLogin(bs_login_par,bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bs_obiekt_uzytkownika.bsLogin = bs_dr["bs_Login"].ToString();
        }
       

        return bs_obiekt_uzytkownika;
    }

    public bs_KlasaUzytkownika bs_CzyJestemZalogowany(string bs_login_par,string bs_haslo_par)
    {
        bs_KlasaUzytkownika bs_obiekt_uzytkownika = new bs_KlasaUzytkownika();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlLogin(bs_login_par,bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bs_obiekt_uzytkownika.bsLogin = bs_dr["bs_Login"].ToString();
        }
        

        return bs_obiekt_uzytkownika;
    }
    
    //metoda zwracająca zapytanie o login
    public bs_KlasaUzytkownika bs_BLCzyJestTakiUzytkownik(string bs_login_par, string bs_haslo_par)
    {
        bs_KlasaUzytkownika bs_obiekt_uzytkownika = new bs_KlasaUzytkownika();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalCzyJestTakiUzytkownik(bs_login_par, bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bs_obiekt_uzytkownika.bsLogin = bs_dr["bs_Login"].ToString();
            
        }
        

        return bs_obiekt_uzytkownika;
    }
    //metoda zwracają true, jeśli rekord dodano, a false jeśli nie
    public bool bs_BLDodajRekord(string bs_login_par, string bs_haslo_par)
    {
        return bs_warstwa_dostepu.bs_DalDodajRekord(bs_login_par,bs_haslo_par);
    }
   
    public bool bs_BLDodajKosztKapitalu(float bs_kk)
    {
        return bs_warstwa_dostepu.bs_DalDodajKosztKapitalu(bs_kk);
    }
    public bool bs_BLDodajKosztDlugu(float bs_kd)
    {
        return bs_warstwa_dostepu.bs_DalDodajKosztDlugu(bs_kd);
    }
    public bool bs_BLDodajWartoscRynkowoAkcji(float bs_wra)
    {
        return bs_warstwa_dostepu.bs_DalDodajWartoscRynkowaAkcji(bs_wra);
    }
}