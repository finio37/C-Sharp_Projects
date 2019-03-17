using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsCzyDodanoProduktNaglasniajacy
/// </summary>
public class bsCzyDodanoProduktNaglasniajacy
{
    private static bool _czy_dodano_pr_nagl;
    public bsCzyDodanoProduktNaglasniajacy()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool bsCzyDodanoPrNagl { get { return _czy_dodano_pr_nagl; } set { _czy_dodano_pr_nagl = value; } }
}