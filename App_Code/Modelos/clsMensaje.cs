using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for clsMensaje
/// </summary>
public class clsMensaje : ObjetoBase
{
    public Int32 IDMensaje { get; set; }
    public Int32 NumeroMensaje { get; set; }
    public Int32 IdUsuario { get; set; }
    public Int32 IdSala { get; set; }
    public DateTime FechaHora { get; set; }
    public String Mensaje { get; set; }

	public clsMensaje()
	{
        IDMensaje = 0;
        NumeroMensaje = 0;
        IdUsuario = 0;
        IdSala = 0;
        Mensaje = String.Empty;
	}

    public void CargarDesdeRegistro(DataRow Row)
    {
        IDMensaje = (Int32)CheckDBNull(Row["IDMensaje"], EnumTipoDeObjeto.TipoInteger);
        NumeroMensaje = (Int32)CheckDBNull(Row["NumeroMensaje"], EnumTipoDeObjeto.TipoInteger);
        IdUsuario = (Int32)CheckDBNull(Row["IdUsuario"], EnumTipoDeObjeto.TipoInteger);
        IdSala = (Int32)CheckDBNull(Row["IdSala"], EnumTipoDeObjeto.TipoInteger);
        Mensaje = (String)CheckDBNull(Row["Mensaje"], EnumTipoDeObjeto.TipoString);
    }
}