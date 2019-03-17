using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Administrator
/// </summary>
public class AdministratorPola
{
    private static string _adminLogin;
    private static string _adminHaslo;
    private static int _logCheck;
    private static int _hasCheck;
    public AdministratorPola()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string AdminLogin { get { return _adminLogin; }set { _adminLogin = value; } }
    public static string AdminHaslo { get { return _adminHaslo; } set { _adminHaslo = value; } }
    public static int LogAdmCheck { get { return _logCheck; } set { _logCheck = value; } }
    public static int HasAdmCheck { get { return _hasCheck; } set { _hasCheck = value; } }
}