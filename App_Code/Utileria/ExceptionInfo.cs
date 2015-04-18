using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ExceptionInfo
/// </summary>
public sealed class ExceptionInfo
{
    string Mensaje;
    string Clase;
    string Metodo;
    public string Info { get { return Clase + '.' + Metodo + ": " + Mensaje + '\n'; } }

	public ExceptionInfo(string Mensaje, string Clase, string Metodo)
	{
        this.Mensaje = Mensaje;
        this.Clase = Clase;
        this.Metodo = Metodo;
	}
}