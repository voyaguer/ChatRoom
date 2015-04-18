using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for clsUsuario
/// </summary>

public enum EnumRango { Usuario = 0, Administrador = 1}

public class clsUsuario : ObjetoBase
{
	public Int32 IDUsuario { get; set; }
    public String Nombre { get; set; }
    public String Email { get; set; }
    public EnumRango Rango { get; set; }
	
	public clsUsuario()
	{
        IDUsuario = 0;
        Nombre = String.Empty;
        Email = String.Empty;
        Rango = EnumRango.Usuario;
	}

    public void CargarDesdeRegistro(DataRow Row)
    {
        IDUsuario = (Int32)CheckDBNull(Row["IDUsuario"], EnumTipoDeObjeto.TipoInteger);
        Nombre = (String)CheckDBNull(Row["Nombre"], EnumTipoDeObjeto.TipoString);
        Email = (String)CheckDBNull(Row["Email"], EnumTipoDeObjeto.TipoString);
        String _Rango = (String)CheckDBNull(Row["Rango"], EnumTipoDeObjeto.TipoString);
        Rango = (EnumRango)Convert.ToInt32(_Rango);
    }
}