using ApiPruebaVehiculos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebaVehiculos.Bl.Vehiculo
{
    public interface IVehiculoLogic
    {
        ResultadoModel CreaVehiculo(VehiculoModel vehiculo);

        ResultadoModel UpdateVehiculo(VehiculoModel vehiculo);

        ResultadoModel DeleteVehiculo(VehiculoIdModel idVehiculo);

        ResultadoModel GetVehiculos();

        ResultadoModel SearchVehiculo(VehiculoPlacaModel placa);
    }
}
