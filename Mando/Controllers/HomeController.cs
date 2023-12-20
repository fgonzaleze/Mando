using DAL;
using Mando.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Mando.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SqlConnection connection = new SqlConnection();
            ViewBag.ConnectionState = "No se ha podido conectar";

            try
            {
                SqlConnection miConexion = new SqlConnection();
                connection.ConnectionString = clsConnection.connection();
                connection.Open();
                ViewBag.ConnectionState = $"Conectado: {connection.State}";
            }
            catch (Exception ex)
            {
                ViewBag.ConnectionState = $"Error al conectar: {ex.Message}";
            }

            return View();
        }

        public ActionResult ListaMisiones()
        {
            return View(clsListaMisiones.listadoMisiones());
        }

        public ActionResult Details(int id)
        {
            return View("Details", clsListaMisiones.getMisionId(id));
        }
    }
}
