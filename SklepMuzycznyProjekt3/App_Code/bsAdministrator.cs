using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsAdministrator
/// </summary>
public class bsAdministrator
{
    private string _bsLoginAdmin;
    private string _bsHasloAdmin;
    private static  string _wynikZapytania;
    public bsAdministrator()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string bsLoginAdmin { get { return _bsLoginAdmin; } set { _bsLoginAdmin = value; } }
    public string bsHasloAdmin { get { return _bsHasloAdmin; } set { _bsHasloAdmin = value; } }
    public static string bswynikZapytania { get { return _wynikZapytania; }set { _wynikZapytania = value; } }
}