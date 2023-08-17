
using formulario.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace formulario.Controllers;

public class DatosController : Controller
{
    public IActionResult Index()
    {
        var formulario = new Datos()
        {
            Nombre = "elias"
        };

        return View(formulario);
    }
    public ActionResult ProcesarDatos(string name)
    {
        //string json = JsonConvert.SerializeObject(param);
        // Hacer algo con los datos (por ejemplo, guardarlos en la base de datos)
        var resultado = $"Datos recibidos: Nombre = {name}";
        return Json(resultado); // Enviar una respuesta JSON
        //return Content(json, "application/json");
    }
}