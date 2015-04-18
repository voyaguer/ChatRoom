using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ObjetoBase
/// </summary>
public class ObjetoBase
{

    public enum EnumTipoDeObjeto
    {
        TipoString = 0,
        TipoInteger = 1,
        TipoFloat = 2,
        TipoDate = 3,
        TipoBoolean = 4
    }

    public ObjetoBase() { }

    protected void LogError(string Error)
    {
        try
        {
            using (var _StreamWriter = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log.txt", true, System.Text.Encoding.UTF8))
            {
                _StreamWriter.Write(Error);
            }
        }
        catch (Exception) { }
    }

    public Object CheckDBNull(Object Objeto, EnumTipoDeObjeto Tipo)
    {
        if (Tipo == EnumTipoDeObjeto.TipoString && DBNull.Value == Objeto)
            return "";
        else if (Tipo == EnumTipoDeObjeto.TipoInteger && DBNull.Value == Objeto)
            return 0;
        else if (Tipo == EnumTipoDeObjeto.TipoFloat && DBNull.Value == Objeto)
            return 0.0F;
        else if (Tipo == EnumTipoDeObjeto.TipoDate && DBNull.Value == Objeto)
            return null;
        else if (Tipo == EnumTipoDeObjeto.TipoBoolean && DBNull.Value == Objeto)
            return false;
        
        return Objeto;
    }
}
