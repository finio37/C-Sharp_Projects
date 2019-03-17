using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PolaPracownika
/// </summary>
public class PolaPracownika
{
    private static int _imiePrac;
    private static int _nazwiskoPrac;
    
    public PolaPracownika()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int ImiePrac { get { return _imiePrac; }set { _imiePrac = value; } }
    public static int NazwiskoPrac { get { return _nazwiskoPrac; }set { _nazwiskoPrac = value; } } 
}