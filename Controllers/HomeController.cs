using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PokeInfo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("pokeinfo/{id}")]
        public IActionResult GetInfo(int id)
        {
            var PokeObject = new Pokemon();

            WebRequest.GetPokemonDataAsync(id, PokeResponse =>
            {
                PokeObject = PokeResponse;
            }).Wait();
            ViewBag.Pokemon = PokeObject;
            return View();
        }
    }
}
