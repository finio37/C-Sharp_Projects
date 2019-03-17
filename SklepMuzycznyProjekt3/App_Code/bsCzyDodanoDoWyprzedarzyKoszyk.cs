using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoDoWyprzedarzyKoszyk
/// </summary>
public class bsCzyDodanoDoWyprzedarzyKoszyk
{
    private static bool _czyDodanoDoWK;
    public bsCzyDodanoDoWyprzedarzyKoszyk()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoDoWypKoszyk { get { return _czyDodanoDoWK; } set { _czyDodanoDoWK = value; } }
}