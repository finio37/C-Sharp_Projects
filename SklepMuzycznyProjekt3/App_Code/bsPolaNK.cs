using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaNK
/// </summary>
public class bsPolaNK
{
    private static string _nazwaNK;
    private static string _kodNK;
    private static float _cenaNK;
    
    public bsPolaNK()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsNazwaNK { get { return _nazwaNK; }set { _nazwaNK = value; } }
    public static string bsKodNK { get { return _kodNK; } set { _kodNK = value; } }
    public static float bsCenaNK { get { return _cenaNK; } set { _cenaNK = value; } }
}