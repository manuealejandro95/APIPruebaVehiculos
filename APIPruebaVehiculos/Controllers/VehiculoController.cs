using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiPruebaVehiculos.Dto;
using ApiPruebaVehiculos.Bl.Vehiculo;


namespace APIPruebaVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoLogic vehiculoLogic;
        

        public VehiculoController()
        {
            vehiculoLogic = new VehiculoLogic();
        }

        [HttpPost]
        [Route("CreateVehiculo")]
        public dynamic CreateVehiculo([FromBody] VehiculoModel vehiculo)
        {
            var resultado = vehiculoLogic.CreaVehiculo(vehiculo);
            
            return resultado;
        }

        [HttpPut]
        [Route("UpdateVehiculo")]
        public dynamic UpdateVehiculo([FromBody] VehiculoModel vehiculo)
        {

            var resultado = vehiculoLogic.UpdateVehiculo(vehiculo);

            return resultado;

        }

        [HttpDelete]
        [Route("DeleteVehiculo")]
        public dynamic DeleteVehiculo([FromBody] VehiculoIdModel idvehiculo)
        {
            var resultado = vehiculoLogic.DeleteVehiculo(idvehiculo);

            return resultado;
        }

        [HttpGet]
        [Route("GetVehiculos")]
        public dynamic GetVehiculos()
        {
            var resultado = vehiculoLogic.GetVehiculos();

            return resultado;
        }

        [HttpPost]
        [Route("SearchVehiculo")]
        public dynamic SearchVehiculo([FromBody] VehiculoPlacaModel placavehiculo)
        {

            var resultado = vehiculoLogic.SearchVehiculo(placavehiculo);

            return resultado;
        }
    }
}
