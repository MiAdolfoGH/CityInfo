using CityInfo.API.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{

    [Route("api/cities")]
    //[Route("api/[controller]")]         // Da problemas en refactorizaciones del código, esta atado al controlador
    public class CitiesController : Controller
    {
        ////[HttpGet("api/cities")]
        //[HttpGet()]
        //public JsonResult GetCities()  // Devolver un JsonResult, hace complicado trabajar con los codigos de estado HTTP
        //{
        //    // a) Creamos el dato en el return para prueba rapida
        //    //return new JsonResult(new List<object>()
        //    //{
        //    //    new {id=1, Name="New York City"},
        //    //    new {id=2, Name="Antwerp"}
        //    //}); 

        //    // Obtenemos datos de un almacen local (datos dummie)
        //    var result = new JsonResult(CitiesDataStore.Current.Cities);
        //    result.StatusCode = 200;
        //    return result;
        //}

        [HttpGet()]
        public IActionResult GetCities()
        {
            var cities = CitiesDataStore.Current.Cities;

            return Ok(cities);
        }
       

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            //Buscamos la ciudad
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }


    }
}
