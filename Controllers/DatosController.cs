
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
    /*
    PARA RECIBIR PARAMETROS ENVIADOS POR GET*/
    public ActionResult ProcesarDatos(string nombre)
    {
        var resultado = $"Datos recibidos: Nombre = {nombre}";
        return Content(resultado); // Enviar una respuesta JSON
        //return Content(json, "application/json");
    }
    /*public ActionResult ProcesarDatos([FromBody] MiModelo param)
    { 
        var objeto = new {param};
        string json = JsonConvert.SerializeObject(param);
        //var resultado = $"Datos recibidos: Nombre = {nombre}";
        return Content (json, "application/json");
    }*/
}