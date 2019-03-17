using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for bsBusinesLayer
/// </summary>
public class bsBusinesLayer
{
    private bsDataAccessLayer bs_warstwa_dostepu;
    public bsBusinesLayer()
    {
        bs_warstwa_dostepu = new bsDataAccessLayer();
    }
    //metoda zwracająca wynik zapytania
    public DataTable bs_BalWyswietlLoginZalogowanegoUsera(string bs_login_par, string bs_haslo_par)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bsDalWyswietlLoginGridZalogowanegoUsera(bs_login_par, bs_haslo_par);

        return bs_dt;
    }
    public DataTable bs_BLWyswietlAkcesoriaKoszyk(string bs_login_par)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlAkcesoriaKoszyk(bs_login_par);

        return bs_dt;
    }
    public DataTable bs_BLWyswietlInstrumentyKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlInstrumentyKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlNaglosnienieKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlNaglosnienieKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlOprogramowanieKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlOprogramowanieKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlStudioKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlStudioKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlWyprzedarzKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlWyprzedarzKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlDspKoszyk(string bs_login)
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlDspKoszyk(bs_login);
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleAkcesoriowGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlAkcesoriawGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleAkcesoriowAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlAkcesoriaAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleInstrumentowGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlInstrumentyGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleInstrumentowAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlInstrumentyAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaNaglosnienieGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlNaglosnienieGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaNaglosnienieAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlNaglosnienieAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleOprogramowanieGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlOprogramowanieGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleOprogramowanieAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlOprogramowanieAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleStGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlStGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabeleStAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlStAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaWypGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlWypGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaWypAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlWypAdmGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaDspGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlDspGrid();
        return bs_dt;
    }
    public DataTable bs_BLWyswietlTabelaDspAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlDspAdmGrid();
        return bs_dt;
    }
    public bsKlasaUsera bs_BalWyswietlMojLogin(string bs_login_par, string bs_haslo_par)
    {
        bsKlasaUsera bs_obiekt_uzytkownika = new bsKlasaUsera();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu. bs_DalWyswietlLogin(bs_login_par, bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bsKlasaUsera.bsLoginUsera = bs_dr["bsLoginUser"].ToString();

        }
        
        return bs_obiekt_uzytkownika;
    }

    public bsKlasaUsera bs_BalWyswietlMojeHaslo(string bs_login_par, string bs_haslo_par)
    {
        bsKlasaUsera bs_obiekt_uzytkownika = new bsKlasaUsera();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlLogin(bs_login_par, bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bsKlasaUsera.bsHasloUsera = bs_dr["bsHasloUser"].ToString();

        }
        
        return bs_obiekt_uzytkownika;
    }
    public bsAdministrator bs_BalWyswietlLoginAdmina(string bs_login_par, string bs_haslo_par)
    {
        bsAdministrator bs_admin = new bsAdministrator();
        DataTable bs_dt = new DataTable();
        bs_dt = bs_warstwa_dostepu.bs_DalWyswietlLoginAdmina(bs_login_par, bs_haslo_par);
        foreach (DataRow bs_dr in bs_dt.Rows)
        {
            bs_admin.bsLoginAdmin = bs_dr["bsLoginAdmin"].ToString();
        }
        return bs_admin;
    }
    public string bsBLMetodaZwracajacaWartoscStringZKomorki(string bs_login_par, string bs_haslo_par)
    {

        return bs_warstwa_dostepu.bs_DalZwrocStringazTabeliAdministratrzy(bs_login_par,bs_haslo_par);
    }

    //***************************login
    public string bsBLMetodaZwracajacaLoginzTabeliUsers(string bs_login_par, string bs_haslo_par)
    {
        return bs_warstwa_dostepu.bs_DalZwrocStringzTabeliUsers_Login(bs_login_par,bs_haslo_par);
    }
    //*****************************haslo

    public string bsBLMetodaZwracajacaHaslozTabeliUsers(string bs_login_par, string bs_haslo_par)
    {
        return bs_warstwa_dostepu.bs_DalZwrocStringzTabeliUsers_Haslo(bs_login_par,bs_haslo_par);
    }
    public string bsBLMetodaZwracajacaSamLogin_I_PobierajacaTylkoLogin(string bs_login_par)
    {
        return bs_warstwa_dostepu.bs_DalZwrocSamLoginZTabeliUsers(bs_login_par);
    }
    public bool bs_BLDodajRekord(string bs_login_par, string bs_haslo_par)
    {
        return bs_warstwa_dostepu.bs_DalDodajRekord(bs_login_par, bs_haslo_par);
    }
    public bool bs_BLDodajProduktDoTabeliAkcesoria(string bs_nazwa_akcesoria,string bs_kod_akcesoria, float bs_cena_akcesoria)
    {
        return bs_warstwa_dostepu.bs_DalDodajAkcesoriaDoSklepu(bs_nazwa_akcesoria,bs_kod_akcesoria,bs_cena_akcesoria);
    }
    public bool bs_BLDodajInstrumentDoSklepu(string bs_nazwa_instrumentu,string bs_kod_instrumentu,float bs_cena_instrumentu)
    {
        return bs_warstwa_dostepu.bs_DalDodajInstrumentyDoSklepu(bs_nazwa_instrumentu,bs_kod_instrumentu,bs_cena_instrumentu);
    }
    public bool bs_BLModyfikujDaneInstrumentu(int bs_id,string bs_nazwa_instrumentu,string bs_kod_instrumentu,float bs_cena_instrumentu)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordInstrumentow(bs_id,bs_nazwa_instrumentu,bs_kod_instrumentu,bs_cena_instrumentu);
    }
    public bool bs_BLModyfikujRekordAkcesoriow(int bs_id_ack,string bs_nazwa_akc,string bs_kod_akc,float bs_cena_akc)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordAkcesoriow(bs_id_ack,bs_nazwa_akc,bs_kod_akc,bs_cena_akc);
    }
    public bool bs_BLDodajAkcesoriaDoKoszyka(string bs_nazwa_ak_koszyk, string bs_kod_ak_koszyk, float bs_cena_ak_koszyk, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajAkcesoriaDoKoszyka(bs_nazwa_ak_koszyk,bs_kod_ak_koszyk,bs_cena_ak_koszyk,bs_login);
    }

    public bool bs_BLDodajNaglosnienieDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalDodajNaglosnienieDoSklepu(bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLModyfikujRekordNaglosnienia(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordNaglosnienia(bs_id,bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLDodajOprogramowanieDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalDodajOprogramowanieDoSklepu(bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLModyfikujDaneOprogramowania(int bs_id,string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordOprogramowania(bs_id,bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLDodajStudyjneDoSklepu(string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalDodajStudyjneDoSklepu(bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLModyfikujDaneStudio(int bs_id,string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordSt(bs_id,bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLDodajWypDoSklepu(string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalDodajWypDoSklepu(bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLModyfikujRekordWyp(int bs_id,string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordWyp(bs_id,bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLDodajDspDoSklepu(string bs_nazwa,string bs_kod,float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalDodajDspDoSklepu(bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLModyfikujeDsp(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        return bs_warstwa_dostepu.bs_DalModyfikujRekordDsp(bs_id,bs_nazwa,bs_kod,bs_cena);
    }
    public bool bs_BLDodajProduktWyprzedarzowyDoKoszyka(string bs_nazwa,string bs_kod,float bs_cena,string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajProdWyprzedarzowyDoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }
    public bool bs_BLDodajIKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajIKDoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }
    public bool bs_BLDodajNKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajNKDoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }
    public bool bs_BLDodajOKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajOKDoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }
    public bool bs_BLDodajSKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajSKDoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }
    public bool bs_BLDodajDK_DoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        return bs_warstwa_dostepu.bs_DalDodajDK_DoKoszyka(bs_nazwa,bs_kod,bs_cena,bs_login);
    }

}