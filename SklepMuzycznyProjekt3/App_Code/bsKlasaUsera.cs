using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsKlasaUsera
/// </summary>
public class bsKlasaUsera
{

    private static string _bsLoginUsera;
    private static string _bsHasloUsera;
    private static string _otrzymanyUser;
    private string _bsLoginU;
    private string _bsHasloU;

    public bsKlasaUsera()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string bsLoginU { get { return _bsLoginU; } set { _bsLoginU = value; } }
    public string bsHasloU { get { return _bsHasloU; } set { _bsHasloU = value; } }
    public static string bsLoginUsera { get { return _bsLoginUsera; } set { _bsLoginUsera = value; } }
    public static string bsHasloUsera { get { return _bsHasloUsera; } set { _bsHasloUsera = value; } }
    public static string bsOtrzymanyUser { get { return _otrzymanyUser; } set { _otrzymanyUser = value; } }

    
}