using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for clsSala
/// </summary>
public class clsSala : ObjetoBase
{
    public Int32 IDSala { get; set; }
    public Int32 IdCreador { get; set; }
    public String Nombre { get; set; }
    public String Passwrd { get; set; }
    public DateTime FechaCreacion { get; set; }

	public clsSala()
	{
        IDSala = 0;
        IdCreador = 0;
        Nombre = String.Empty;
        Passwrd = String.Empty;
	}

    public void CargarDesdeRegistro(DataRow Row)
    {
        IDSala = (Int32)CheckDBNull(Row["IDSala"], EnumTipoDeObjeto.TipoInteger);
        IdCreador = (Int32)CheckDBNull(Row["IdCreador"], EnumTipoDeObjeto.TipoInteger);
        Nombre = (String)CheckDBNull(Row["Nombre"], EnumTipoDeObjeto.TipoString);
        Passwrd = (String)CheckDBNull(Row["Passwrd"], EnumTipoDeObjeto.TipoString);
        FechaCreacion = (DateTime)CheckDBNull(Row["FechaCreacion"], EnumTipoDeObjeto.TipoDate);
    }
}