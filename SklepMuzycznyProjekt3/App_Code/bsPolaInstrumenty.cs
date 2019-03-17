using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bsPolaInstrumenty
/// </summary>
public class bsPolaInstrumenty
{
    private static int _poleIdInstr_int;
    private static int _poleNazwaInstr_int;
    private static int _poleKodInstr_int;
    private static float _poleCenaInstr_float;
    
    public bsPolaInstrumenty()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int PoleIdInstr_int { get { return _poleIdInstr_int; } set { _poleIdInstr_int = value; } }
    public static int PoleNazwaInstr_int { get { return _poleNazwaInstr_int; } set { _poleNazwaInstr_int = value; } }
    public static int PoleKodInstr_int { get { return _poleKodInstr_int; } set { _poleKodInstr_int = value; } }
    public static float PoleCenaInstr_float { get { return _poleCenaInstr_float; }set { _poleCenaInstr_float = value; } }
}