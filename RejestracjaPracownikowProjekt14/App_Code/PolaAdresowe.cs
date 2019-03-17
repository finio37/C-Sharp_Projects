using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PolaAdresowe
/// </summary>
public class PolaAdresowe
{
    private static int _kodPoczt;
    private static int _miasto;
    private static int _ulica;

    public PolaAdresowe()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int KodPoczt { get { return _kodPoczt; } set { _kodPoczt = value; } }
    public static int Miasto { get { return _miasto; } set { _miasto = value; } }
    public static int Ulica { get { return _ulica; } set { _ulica = value; } }
}