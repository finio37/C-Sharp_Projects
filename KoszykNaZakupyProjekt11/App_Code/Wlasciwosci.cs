using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Wlasciwosci
/// </summary>
public class Wlasciwosci
{
    private int _IdProduktu;
    private string _NazwaProduktu;
    private string _KodPruduktu;
    private double _CenaPruduktu;
    public Wlasciwosci()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int IdProduktu
    {
        get { return _IdProduktu; }
        set { _IdProduktu = value; }
    }
    public string NazwaTowaru
    {
        get { return _NazwaProduktu; }
        set { _NazwaProduktu = value; }
    }
    public string KodProduktu
    {
        get { return _KodPruduktu; }
        set { _KodPruduktu = value; }
    }
    public double CenaProduktu
    {
        get { return _CenaPruduktu; }
        set { _CenaPruduktu = value; }
    }
}