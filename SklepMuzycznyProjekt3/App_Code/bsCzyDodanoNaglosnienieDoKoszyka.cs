using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoNaglosnienieDoKoszyka
/// </summary>
public class bsCzyDodanoNaglosnienieDoKoszyka
{
    private static bool _czyDodanoNK;
    public bsCzyDodanoNaglosnienieDoKoszyka()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoNK { get { return _czyDodanoNK; }set { _czyDodanoNK = value; } }
}