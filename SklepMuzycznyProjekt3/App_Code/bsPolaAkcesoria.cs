using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaAkcesoria
/// </summary>
public class bsPolaAkcesoria
{
    private static float _bsCenaAkcesoria;
    private static int _bsNazwaAkcesoria;
    

    public bsPolaAkcesoria()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static float bsCenaAkcesoria { get { return _bsCenaAkcesoria; }set { _bsCenaAkcesoria = value; } }
    public static int bsNazwaAkcesoria { get { return _bsNazwaAkcesoria; } set { _bsNazwaAkcesoria = value; } }
}