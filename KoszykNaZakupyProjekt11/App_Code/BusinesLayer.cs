using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for BusinesLayer
/// </summary>
public class BusinesLayer
{
    private DataAccessLayer warstwa_dostepu;
    public BusinesLayer()
    {

        warstwa_dostepu = new DataAccessLayer();
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable BLWyswietlTabeleTowarow()
    {
        DataTable bs_dt = new DataTable();
        bs_dt = warstwa_dostepu.DalWyswietlwGrid();
        return bs_dt;
    }
    public DataTable BLWyswietlTabeleKoszyk()
    {
        DataTable dt = new DataTable();
        dt = warstwa_dostepu.DalWyswietlKoszyk();
        return dt;
    }
    
    public bool BLDodajRekord(string nazwa, string kod,float cena)
    {
        return warstwa_dostepu.DalDodajTowarDoSklepu(nazwa, kod,cena);
    }
    public bool BLDodajProduktDoKoszyka(string nazwa,string kod,float cena,int ilosc)
    {
        return warstwa_dostepu.DalDodajProduktDoKoszyka(nazwa,kod,cena,ilosc);
    }
}