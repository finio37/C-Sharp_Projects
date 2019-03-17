using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsAdministratorzyStatic
/// </summary>
public class bsAdministratorzyStatic
{
    

    private static string _bsLoginAdm;
    private static string _bsHasloAdm;
    public bsAdministratorzyStatic()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string bsLoginAdm { get { return _bsLoginAdm; } set { _bsLoginAdm = value; } }
    public static string bsHasloAdm { get { return _bsHasloAdm; } set { _bsHasloAdm = value; } }
    
}