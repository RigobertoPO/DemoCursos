using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UNACH.DEMOCURSOS.WS
{
    /// <summary>
    /// Descripción breve de UsuariosService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class UsuariosService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloUsuarios()
        {
            return "Hola a todos";
        }
    }
}
