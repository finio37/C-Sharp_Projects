using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer
{
    private DataAccessLayer warstwa_dostepu;
    public BusinessLayer()
    {
        warstwa_dostepu = new DataAccessLayer();

        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable BLWyswietlWszystkichPracownikow()
    {
        DataTable dt = new DataTable();
        dt = warstwa_dostepu.DalWyswietlWszystkichPracownikow();
        return dt;
    }
    public DataTable BLWyswietlPracownikaZJednegoDzialu()
    {
        DataTable dt = new DataTable();
        dt = warstwa_dostepu.DalWyswietlPracownikowJednegoDzialu();
        return dt;
    }
    public DataTable BLWyswietlLoginAdmina(string login, string haslo)
    {
        DataTable dt = new DataTable();
        dt = warstwa_dostepu.DalWyswietlLoginAdmina(login,haslo);
        return dt;
    }
    public DataTable BLWyswietlSzczegoloweDanePracownikow()
    {
        DataTable dt = new DataTable();
        dt = warstwa_dostepu.DalWyswietlSzczegoloweDanePracownikow();
        return dt;
    }
    public bool BLDodajSzczegolyPracownika(int kod, string miasto, string ulica, int id_pracownika)
    {
        return warstwa_dostepu.DalDodajSzczegoloweDanePracownika(kod,miasto,ulica,id_pracownika);
    }

    public int BLWyswietlIdPracownika(string imie)
    {
        return warstwa_dostepu.DalZwrocIdPracownika(imie);
    }
    public bool BLDodajPracownika(string imie, string nazwisko, int id_dzialu)
    {
        return warstwa_dostepu.DalDodajPracownika(imie,nazwisko,id_dzialu);
    }
}