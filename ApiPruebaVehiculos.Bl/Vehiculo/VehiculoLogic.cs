using ApiPruebaVehiculos.Dal.Vehiculo;
using ApiPruebaVehiculos.Dto;
using System.Data;
using System.Text.Json;

namespace ApiPruebaVehiculos.Bl.Vehiculo
{
    public class VehiculoLogic : IVehiculoLogic
    {
        private VehiculoRepository vehiculoRepository = new VehiculoRepository();
        private DataTable dt = new DataTable();
        private string resultado = string.Empty;

        public ResultadoModel CreaVehiculo(VehiculoModel vehiculo)
        {
            try
            {
                VehiculoPlacaModel placa = new VehiculoPlacaModel();

                placa.placaVehiculo = vehiculo.placa;

                dt = vehiculoRepository.SearchVehiculo(placa);

                if (dt.Rows.Count > 0) 
                {
                    return new ResultadoModel { error = true, message = "El Vehiculo con placa " + vehiculo.placa + " ya existe en el sistema." };
                }
                else
                {
                    dt = vehiculoRepository.CreateVehiculo(vehiculo);
                    resultado = Newtonsoft.Json.JsonConvert.SerializeObject(dt);
                    return new ResultadoModel { error = false, result = resultado };
                }           
            }
            catch (Exception ex) 
            {
                return new ResultadoModel {error = true,message = ex.Message.ToString()};
            }
        }

        public ResultadoModel DeleteVehiculo(VehiculoIdModel idVehiculo)
        {
            try
            {
                dt = vehiculoRepository.SearchVehiculoId(idVehiculo);

                if (dt.Rows.Count > 0 && int.Parse(dt.Rows[0]["IdFase"].ToString()) == 4)
                {
                   return new ResultadoModel() { error = true, message = "Este carro ha sido vendido y no se puede borrar del sistema." };
                }
                else
                {
                    bool result = vehiculoRepository.DeleteVehiculo(idVehiculo);

                    if (result == false) { return new ResultadoModel { error = result, message = "operacion no realizada" }; }

                    return new ResultadoModel { error = result, message = "operacion realizado" };
                }
            }
            catch
            {
                return new ResultadoModel { error = false, message = "Error al borrar el vehiculo" };
            }
        }

        public ResultadoModel GetVehiculos()
        {            

            dt = vehiculoRepository.GetVehiculos();

            resultado = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

            return new ResultadoModel { error = false, result = resultado};
        }

        public ResultadoModel SearchVehiculo(VehiculoPlacaModel placa)
        {
            try
            {
                dt = vehiculoRepository.SearchVehiculo(placa);
                if (dt.Rows.Count > 0)
                {
                    resultado = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    return new ResultadoModel { error= false, result= resultado};
                }
                else
                {
                    return new ResultadoModel { error = true, message = string.Format("No se encontro el Vehiculo Con Placa: {0}", placa.placaVehiculo)};
                }
            }
            catch (Exception ex)
            {
                return new ResultadoModel { error = true, message = ex.Message.ToString() };
            }
        }

        public ResultadoModel UpdateVehiculo(VehiculoModel vehiculo)
        {
            try
            {
                VehiculoIdModel idvehiculo = new();
                idvehiculo.idVehiculo = int.Parse(vehiculo.idVehiculo.ToString());

                dt = vehiculoRepository.SearchVehiculoId(idvehiculo);
                if (dt.Rows.Count > 0 && int.Parse(dt.Rows[0]["IdFase"].ToString()) == 4)
                {
                    return new ResultadoModel() { error = true, message = "Este carro ha sido vendido y no se puede editar." };
                }
                else
                {
                    
                    bool result = vehiculoRepository.UpdateVehiculo(vehiculo);

                    if (result == false) { return new ResultadoModel { error = result, message = "operacion no realizada" }; }

                    return new ResultadoModel { error = result, message = "operacion realizada" };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoModel { error = true, message = ex.Message.ToString() };
            }
        }
    }
}
