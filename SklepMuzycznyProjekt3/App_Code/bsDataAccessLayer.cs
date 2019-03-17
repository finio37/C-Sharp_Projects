using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for bsDataAccessLayer
/// </summary>
public class bsDataAccessLayer
{
    private bsInicjacjaPolaczenia bs_polaczenie;
    public bsDataAccessLayer()
    {
        bs_polaczenie = new bsInicjacjaPolaczenia();

        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable bsDalWyswietlLoginGridZalogowanegoUsera(string bs_login, string bs_haslo_par)
    {
        //utworzenie obiektu datatable
        DataTable bs_dt = new DataTable();
        //zapytanie
        string bs_zapytanie = "select bsLoginUser from bsTabelaUsers where bsLoginUser = @bsLoginUser and bsHasloUser = @bsHasloUser";
        //tablica typu sql parameter
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        //utworzenie dwóch parametrów
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloUser", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_haslo_par);
        //zwrócenie zapytania z parametrem korzystając z klasy InicjacjaPołączenia
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlLogin(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "select bsLoginUser from bsTabelaUsers where bsLoginUser = @bsLoginUser and bsHasloUser = @bsHasloUser";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloUser", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlLoginAdmina(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "select bsLoginAdmin from bsTabelaAdmin where bsLoginAdmin = @bsLoginAdmin and bsHasloAdmin = @bsHasloAdmin";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginAdmin", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloAdmin", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    
    public string bs_DalZwrocStringazTabeliAdministratrzy(string bs_login, string bs_pass)
    {
        string bs_zapytanie = "select bsLoginAdmin from bsTabelaAdmin where bsLoginAdmin = @bsLoginAdmin and bsHasloAdmin = @bsHasloAdmin";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginAdmin", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloAdmin", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_pass);

        return bs_polaczenie.bs_WykonajZapytaniezParametremOrazZwrocPoleStringiem(bs_zapytanie,bs_sql_parameters);
    }
    public string bs_DalZwrocStringzTabeliUsers_Login(string bs_login, string bs_haslo)
    {
        string bs_zapytanie = "select bsLoginUser from bsTabelaUsers where bsLoginUser = @bsLoginUser and bsHasloUser = @bsHasloUser";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloUser", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametremOrazZwrocPoleLogin_tabelaUsers(bs_zapytanie,bs_sql_parameters);
    }
    public string bs_DalZwrocStringzTabeliUsers_Haslo(string bs_login, string bs_haslo)
    {
        string bs_zapytanie = "select bsHasloUser from bsTabelaUsers where bsLoginUser = @bsLoginUser and bsHasloUser = @bsHasloUser";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloUser", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametremOrazZwrocPoleHaslo_tabelaUsers(bs_zapytanie, bs_sql_parameters);
    }
    public string bs_DalZwrocSamLoginZTabeliUsers(string bs_login)
    {
        string bs_zapytanie = "select bsLoginUser from bsTabelaUsers where bsLoginUser = @bsLoginUser";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        return bs_polaczenie.bs_WykonajZapytaniezParametremOrazZwrocPoleLogin_tabelaUsers(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlHasloAdmina(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "select bsHasloAdmin from bsTabelaAdmin where bsLoginAdmin = @bsLoginAdmin and bsHasloAdmin = @bsHasloAdmin";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginAdmin", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloAdmin", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }

    //metoda logiczna - true, jeśli dodano - false, jeśli nie dodano
    public bool bs_DalDodajRekord(string bs_Login, string bs_Haslo)
    {
        string bs_zapytanie = "insert into bsTabelaUsers (bsLoginUser,bsHasloUser) values(@bsLoginUser,@bsHasloUser)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[2];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginUser", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_Login);
        bs_sql_parameters[1] = new SqlParameter("@bsHasloUser", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = Convert.ToString(bs_Haslo);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajAkcesoriaDoSklepu(string bs_nazwa_akcesoria, string bs_kod_akcesoria,float bs_cena_akcesoria)
    {
        string bs_zapytanie = "insert into bsTabelaAkcesoria (bsNazwaAkcesoria,bsKodAkcesoria,bsCenaAkcesoria) values (@bsNazwaAkcesoria,@bsKodAkcesoria,@bsCenaAkcesoria)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaAkcesoria", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_nazwa_akcesoria);
        bs_sql_parameters[1] = new SqlParameter("@bsKodAkcesoria",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod_akcesoria;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaAkcesoria", SqlDbType.Float);
        bs_sql_parameters[2].Value = Convert.ToString(bs_cena_akcesoria);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajInstrumentyDoSklepu(string bs_nazwa_instrumentu, string bs_kod_instrumentu, float bs_cena_instrumentu)
    {
        string bs_zapytanie = "insert into bsTabelaInstr (bsNazwaInstr,bsKodInstr,bsCenaInstr) values (@bsNazwaInstr,@bsKodInstr,@bsCenaInstr)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaInstr", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_nazwa_instrumentu);
        bs_sql_parameters[1] = new SqlParameter("@bsKodInstr", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod_instrumentu;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaInstr", SqlDbType.Float);
        bs_sql_parameters[2].Value = Convert.ToString(bs_cena_instrumentu);
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajNaglosnienieDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "insert into bsTabelaNaglosnienie (bsNazwaNagl,bsKodNagl,bsCenaNagl) values (@bsNazwaNagl,@bsKodNagl,@bsCenaNagl)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaNagl",SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodNagl",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaNagl",SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie,bs_sql_parameters);
    }
    public bool bs_DalDodajAkcesoriaDoKoszyka(string bs_nazwa_ak_koszyk, string bs_kod_ak_koszyk, float bs_cena_ak_koszyk, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaAkcesoriaKoszyk (bsNazwaAK,bsKodAK,bsCenaAK,bsLoginAK) values (@bsNazwaAK,@bsKodAK,@bsCenaAK,@bsLoginAK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaAK",SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa_ak_koszyk;
        bs_sql_parameters[1] = new SqlParameter("@bsKodAK",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod_ak_koszyk;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaAK",SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena_ak_koszyk;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginAK",SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie,bs_sql_parameters);

    }
    public bool bs_DalDodajProdWyprzedarzowyDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaWyprzedarzKoszyk (bsNazwaWK,bsKodWK,bsCenaWK,bsLoginWK) values (@bsNazwaWK,@bsKodWK,@bsCenaWK,@bsLoginWK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaWK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodWK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaWK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginWK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalDodajIKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaInstrumentowKoszyk (bsNazwaIK,bsKodIK,bsCenaIK,bsLoginIK) values (@bsNazwaIK,@bsKodIK,@bsCenaIK,@bsLoginIK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaIK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodIK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaIK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginIK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalDodajNKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaNaglosnienieKoszyk (bsNazwaNK,bsKodNK,bsCenaNK,bsLoginNK) values (@bsNazwaNK,@bsKodNK,@bsCenaNK,@bsLoginNK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaNK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodNK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaNK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginNK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalDodajOKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaOprogramowanieKoszyk (bsNazwaOK,bsKodOK,bsCenaOK,bsLoginOK) values (@bsNazwaOK,@bsKodOK,@bsCenaOK,@bsLoginOK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaOK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodOK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaOK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginOK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalDodajSKDoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaStudioKoszyk (bsNazwaSK,bsKodSK,bsCenaSK,bsLoginSK) values (@bsNazwaSK,@bsKodSK,@bsCenaSK,@bsLoginSK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaSK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodSK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaSK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginSK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalDodajDK_DoKoszyka(string bs_nazwa, string bs_kod, float bs_cena, string bs_login)
    {
        string bs_zapytanie = "insert into bsTabelaDspKoszyk (bsNazwaDK,bsKodDK,bsCenaDK,bsLoginDK) values (@bsNazwaDK,@bsKodDK,@bsCenaDK,@bsLoginDK)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaDK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodDK", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaDK", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        bs_sql_parameters[3] = new SqlParameter("@bsLoginDK", SqlDbType.VarChar);
        bs_sql_parameters[3].Value = bs_login;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);

    }
    public bool bs_DalModyfikujRekordAkcesoriow(int bs_id, string bs_nazwa_akcesoria, string bs_kod_akcesoria, float bs_cena_akcesoria)
    {
        string bs_zapytanie = "update bsTabelaAkcesoria set bsNazwaAkcesoria=@bsNazwaAkcesoria,bsKodAkcesoria=@bsKodAkcesoria,bsCenaAkcesoria=@bsCenaAkcesoria where bsIdAkcesoria=@bsIdAkcesoria";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("bsNazwaAkcesoria", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa_akcesoria;
        bs_sql_parameters[1] = new SqlParameter("@bsKodAkcesoria", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod_akcesoria;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaAkcesoria", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena_akcesoria;
        bs_sql_parameters[3] = new SqlParameter("@bsIdAkcesoria", SqlDbType.Int);
        bs_sql_parameters[3].Value = bs_id;
        return bs_polaczenie.bs_IniModyfikacjaDanychAkcesoriow(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalModyfikujRekordInstrumentow(int bs_id,string bs_nazwa_instrumentow,string bs_kod_instrumentow,float bs_cena_instrumentu)
    {
        string bs_zapytanie = "update bsTabelaInstr set bsNazwaInstr=@bsNazwaInstr,bsKodInstr=@bsKodInstr,bsCenaInstr=@bsCenaInstr where bsIdInstr=@bsIdInstr";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdInstr", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaInstr",SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa_instrumentow;
        bs_sql_parameters[2] = new SqlParameter("@bsKodInstr",SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod_instrumentow;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaInstr",SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena_instrumentu;
        
        return bs_polaczenie.bs_IniModyfikacjaDanychInstrumentow(bs_zapytanie,bs_sql_parameters);
    }
    public bool bs_DalModyfikujRekordNaglosnienia(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "update bsTabelaNaglosnienie set bsNazwaNagl=@bsNazwaNagl,bsKodNagl=@bsKodNagl,bsCenaNagl=@bsCenaNagl where bsIdNagl=@bsIdNagl";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdNagl", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaNagl", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa;
        bs_sql_parameters[2] = new SqlParameter("@bsKodNagl", SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaNagl", SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena;
        return bs_polaczenie.bs_IniModyfikacjaDanychNaglosnienia(bs_zapytanie,bs_sql_parameters);
    }
    public bool bs_DalDodajOprogramowanieDoSklepu(string bs_nazwa,string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "insert into bsTabelaOprogramowania (bsNazwaOp,bsKodOp,bsCenaOp) values (@bsNazwaOp,@bsKodOp,@bsCenaOp)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaOp", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodOp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaOp", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie,bs_sql_parameters);
    }

    public bool bs_DalModyfikujRekordOprogramowania(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "update bsTabelaOprogramowania set bsNazwaOp=@bsNazwaOp,bsKodOp=@bsKodOp,bsCenaOp=@bsCenaOp where bsIdOp=@bsIdOp";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdOp", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaOp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa;
        bs_sql_parameters[2] = new SqlParameter("@bsKodOp", SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaOp", SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena;
        return bs_polaczenie.bs_IniModyfikacjaDanychOprogramowania(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajStudyjneDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "insert into bsTabelaStudio (bsNazwaSt,bsKodSt,bsCenaSt) values (@bsNazwaSt,@bsKodSt,@bsCenaSt)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaSt", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodSt", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaSt", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalModyfikujRekordSt(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "update bsTabelaStudio set bsNazwaSt=@bsNazwaSt,bsKodSt=@bsKodSt,bsCenaSt=@bsCenaSt where bsIdSt=@bsIdSt";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdSt", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaSt", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa;
        bs_sql_parameters[2] = new SqlParameter("@bsKodSt", SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaSt", SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena;
        return bs_polaczenie.bs_IniModyfikacjaDanychStudio(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajWypDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "insert into bsTabelaWyprzedarz (bsNazwaWyp,bsKodWyp,bsCenaWyp) values (@bsNazwaWyp,@bsKodWyp,@bsCenaWyp)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaWyp", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodWyp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaWyp", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalModyfikujRekordWyp(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "update bsTabelaWyprzedarz set bsNazwaWyp=@bsNazwaWyp,bsKodWyp=@bsKodWyp,bsCenaWyp=@bsCenaWyp where bsIdWyp=@bsIdWyp";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdWyp", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaWyp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa;
        bs_sql_parameters[2] = new SqlParameter("@bsKodWyp", SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaWyp", SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena;
        return bs_polaczenie.bs_IniModyfikacjaDanychWyprzedarz(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalDodajDspDoSklepu(string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "insert into bsTabelaDsp (bsNazwaDsp,bsKodDsp,bsCenaDsp) values (@bsNazwaDsp,@bsKodDsp,@bsCenaDsp)";
        SqlParameter[] bs_sql_parameters = new SqlParameter[3];
        bs_sql_parameters[0] = new SqlParameter("@bsNazwaDsp", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = bs_nazwa;
        bs_sql_parameters[1] = new SqlParameter("@bsKodDsp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_kod;
        bs_sql_parameters[2] = new SqlParameter("@bsCenaDsp", SqlDbType.Float);
        bs_sql_parameters[2].Value = bs_cena;
        return bs_polaczenie.bs_IniWykonajDodawanieDoBazy(bs_zapytanie, bs_sql_parameters);
    }
    public bool bs_DalModyfikujRekordDsp(int bs_id, string bs_nazwa, string bs_kod, float bs_cena)
    {
        string bs_zapytanie = "update bsTabelaDsp set bsNazwaDsp=@bsNazwaDsp,bsKodDsp=@bsKodDsp,bsCenaDsp=@bsCenaDsp where bsIdDsp=@bsIdDsp";
        SqlParameter[] bs_sql_parameters = new SqlParameter[4];
        bs_sql_parameters[0] = new SqlParameter("@bsIdDsp", SqlDbType.Int);
        bs_sql_parameters[0].Value = bs_id;
        bs_sql_parameters[1] = new SqlParameter("@bsNazwaDsp", SqlDbType.VarChar);
        bs_sql_parameters[1].Value = bs_nazwa;
        bs_sql_parameters[2] = new SqlParameter("@bsKodDsp", SqlDbType.VarChar);
        bs_sql_parameters[2].Value = bs_kod;
        bs_sql_parameters[3] = new SqlParameter("@bsCenaDsp", SqlDbType.Float);
        bs_sql_parameters[3].Value = bs_cena;
        return bs_polaczenie.bs_IniModyfikacjaDanychDsp(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlAkcesoriaKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaAK,bsKodAK,bsCenaAK,bsLoginAK from bsTabelaAkcesoriaKoszyk where bsLoginAK=@bsLoginAK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginAK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);
        
        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlInstrumentyKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaIK,bsKodIK,bsCenaIK,bsLoginIK from bsTabelaInstrumentowKoszyk where bsLoginIK=@bsLoginIK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginIK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlNaglosnienieKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaNK,bsKodNK,bsCenaNK,bsLoginNK from bsTabelaNaglosnienieKoszyk where bsLoginNK=@bsLoginNK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginNK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlOprogramowanieKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaOK,bsKodOK,bsCenaOK,bsLoginOK from bsTabelaOprogramowanieKoszyk where bsLoginOK=@bsLoginOK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginOK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlStudioKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaSK,bsKodSK,bsCenaSK,bsLoginSK from bsTabelaStudioKoszyk where bsLoginSK=@bsLoginSK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginSK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlWyprzedarzKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaWK,bsKodWK,bsCenaWK,bsLoginWK from bsTabelaWyprzedarzKoszyk where bsLoginWK=@bsLoginWK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginWK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlDspKoszyk(string bs_login)
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaDK,bsKodDK,bsCenaDK,bsLoginDK from bsTabelaDspKoszyk where bsLoginDK=@bsLoginDK";
        SqlParameter[] bs_sql_parameters = new SqlParameter[1];
        bs_sql_parameters[0] = new SqlParameter("@bsLoginDK", SqlDbType.VarChar);
        bs_sql_parameters[0].Value = Convert.ToString(bs_login);

        return bs_polaczenie.bs_WykonajZapytaniezParametrem(bs_zapytanie, bs_sql_parameters);
    }
    public DataTable bs_DalWyswietlAkcesoriawGrid()
    {
        //utworzenie obiektu datatable
        DataTable dt = new DataTable();
        //zapytanie
        string zapytanie = "select bsNazwaAkcesoria,bsKodAkcesoria,bsCenaAkcesoria from bsTabelaAkcesoria";
        //tablica typu sql parameter

        //zwrócenie zapytania z parametrem korzystając z klasy InicjacjaPołączenia
        return bs_polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public DataTable bs_DalWyswietlInstrumentyGrid()
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsNazwaInstr,bsKodInstr,bsCenaInstr from bsTabelaInstr";
        
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlInstrumentyAdmGrid()
    {
        DataTable dt = new DataTable();
        string bs_zapytanie = "select bsIdInstr,bsNazwaInstr,bsKodInstr,bsCenaInstr from bsTabelaInstr";

        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlAkcesoriaAdmGrid()
    {
        DataTable dt = new DataTable();
        //zapytanie
        string zapytanie = "select bsIdAkcesoria,bsNazwaAkcesoria,bsKodAkcesoria,bsCenaAkcesoria from bsTabelaAkcesoria";
        //tablica typu sql parameter

        //zwrócenie zapytania z parametrem korzystając z klasy InicjacjaPołączenia
        return bs_polaczenie.IniWykonajZapytanieBezParametru(zapytanie);
    }
    public DataTable bs_DalWyswietlNaglosnienieGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsNazwaNagl,bsKodNagl,bsCenaNagl from bsTabelaNaglosnienie";
        return bs_polaczenie.IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlNaglosnienieAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdNagl,bsNazwaNagl,bsKodNagl,bsCenaNagl from bsTabelaNaglosnienie";
        return bs_polaczenie.IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlOprogramowanieGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsNazwaOp,bsKodOp,bsCenaOp from bsTabelaOprogramowania";
        return bs_polaczenie.IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlOprogramowanieAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdOp,bsNazwaOp,bsKodOp,bsCenaOp from bsTabelaOprogramowania";
        return bs_polaczenie.IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlStGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsNazwaSt,bsKodSt,bsCenaSt from bsTabelaStudio";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlStAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdSt,bsNazwaSt,bsKodSt,bsCenaSt from bsTabelaStudio";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlWypGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsNazwaWyp,bsKodWyp,bsCenaWyp from bsTabelaWyprzedarz";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlWypAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdWyp,bsNazwaWyp,bsKodWyp,bsCenaWyp from bsTabelaWyprzedarz";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }

    public DataTable bs_DalWyswietlDspGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsNazwaDsp,bsKodDsp,bsCenaDsp from bsTabelaDsp";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    public DataTable bs_DalWyswietlDspAdmGrid()
    {
        DataTable bs_dt = new DataTable();
        string bs_zapytanie = "select bsIdDsp,bsNazwaDsp,bsKodDsp,bsCenaDsp from bsTabelaDsp";
        return bs_polaczenie.bs_IniWykonajZapytanieBezParametru(bs_zapytanie);
    }
    

}