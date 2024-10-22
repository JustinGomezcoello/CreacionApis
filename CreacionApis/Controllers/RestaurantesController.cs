using CreacionApis.Models;
using CreacionApis.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreacionApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesController : ControllerBase
    {
        [HttpGet]
        [Route("InformacionRestaurante")]
        public ActionResult DevuelveRestaurante(int id)
        {
            try
            {


                RestauranteRepository repo = new RestauranteRepository();
                var restaurantes = repo.DevuelveRestaurantes();

                if (restaurantes.Any(x => x.Id == id))
                {
                    var info_restaurante = restaurantes.Find(x => x.Id == id);

                    return Ok(info_restaurante);
                }
                else
                {
                    return NotFound(); 
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("ListadoRestaurantes")]
        public List<Restaurante> DevuelveListadoRestaurante()
        {
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();

        }

    }
}
