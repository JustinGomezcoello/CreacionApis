using CreacionApis.Models;

namespace CreacionApis.Repositories
{
    public class RestauranteRepository
    {

        public Restaurante DevuelveRestaurante()
        {
            Restaurante restaurante = new Restaurante()
            {
                Id = 1,
                Nombre = "MacDonals",
                CostoComercial = 10000,
                Direccion = "Alado del quicentro",
                AceptaMascotas = false


            };
            return restaurante;
        }

        public List<Restaurante> DevuelveRestaurantes()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();
            Restaurante restaurante = new Restaurante()
            {
                Id = 1,
                Nombre = "MacDonals",
                CostoComercial = 10000,
                Direccion = "Alado del quicentro",
                AceptaMascotas = false


            };
            Restaurante restaurante2 = new Restaurante()
            {
                Id = 2,
                Nombre = "Burguer",
                CostoComercial = 20000,
                Direccion = "Condado",
                AceptaMascotas = true
            };
            restaurantes.Add(restaurante);
            restaurantes.Add(restaurante2);

            return restaurantes;
        }

    }
}
