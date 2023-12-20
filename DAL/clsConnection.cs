
namespace DAL
{
    /// <summary>
    /// Clase que contiene la conexión como string de nuestra base de datos
    /// </summary>
    public class clsConnection
    {
        public static string connection() {

            return "server=jgonzaleze.database.windows.net;database=JaviDB;uid=prueba;pwd=fernandoG321;trustServerCertificate=true";
        }
    }
}
