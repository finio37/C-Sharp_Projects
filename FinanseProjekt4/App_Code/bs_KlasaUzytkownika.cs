using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bs_KlasaUzytkownika
/// </summary>
public class bs_KlasaUzytkownika
{
    private int bs_Id_User;
    private string bs_Login;
    private string bs_Haslo;
    private int bs_Rok;
    private List<double> bs_Stopa;
    private int bs_ilosc_wartosci;
    public bs_KlasaUzytkownika()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int bs_idUser
    {
        get { return bs_Id_User; }
        set { bs_Id_User = value; }

    }
    public string bsLogin
    {
        get { return bs_Login; }
        set { bs_Login = value; }

    }
    public string bsHaslo {
        get { return bs_Haslo; }
        set { bs_Haslo = value; }
    }
    public int bsRok {
        get { return bs_Rok; }
        set { bs_Rok = value; }
    }
    public List<double> bsStopa
    {
        get { return bs_Stopa; }
        set { bs_Stopa = value; }
    }
    public int bsIloscWartosci
    {
        get { return bs_ilosc_wartosci; }
        set { bs_ilosc_wartosci = value; }
    }
}