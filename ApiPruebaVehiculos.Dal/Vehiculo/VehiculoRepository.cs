using System.Data;
using ApiPruebaVehiculos.Dal.Conexion;
using ApiPruebaVehiculos.Dto;

namespace ApiPruebaVehiculos.Dal.Vehiculo
{
    public class VehiculoRepository
    {
        private DataTable _dataTable;
        private ConexionBd _conexionBd;
        private string _query;

        public VehiculoRepository() {
            _dataTable = new DataTable();
            _conexionBd = new ConexionBd();
            _query = string.Empty;
        }
        public DataTable CreateVehiculo(VehiculoModel vehiculo) 
        {
            try
            {
                _query = string.Format("EXECUTE [dbo].GuardaVehiculos {0},{1},{2},{3},'{4}','{5}',{6},{7},'{8}'", vehiculo.idColor, vehiculo.idMarca, vehiculo.idYear, vehiculo.idFase, vehiculo.linea, vehiculo.placa.ToUpper(), vehiculo.kilometros, vehiculo.valor, vehiculo.observaciones);
                _dataTable = _conexionBd.GetDatos(_query);
                return _dataTable;
            }
            catch (Exception ex)
            {
                return _dataTable;
            }
            
        }
        public DataTable GetVehiculos()
        {
            try
            {
                _query = "EXECUTE [dbo].VerVehiculos";                
                _dataTable = _conexionBd.GetDatos(_query);

                return _dataTable;
            }
            catch (Exception ex)
            {
                return _dataTable;
            }           
        }

        public bool DeleteVehiculo(VehiculoIdModel vehiculoId)
        {
            try
            {
                _query = string.Format("DELETE FROM VEHICULO WHERE IdVehiculo = {0}", vehiculoId.idVehiculo);
                bool resultado = _conexionBd.SaveData(_query);

                return resultado;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchVehiculo(VehiculoPlacaModel placaModel)
        {
            try
            {
                _query = string.Format("SELECT * FROM VEHICULO WHERE Placa = '{0}'", placaModel.placaVehiculo.ToUpper());
                _dataTable = _conexionBd.GetDatos(_query);

                return _dataTable;
            }
            catch
            {
                return _dataTable;
            }
        }

        public DataTable SearchVehiculoId(VehiculoIdModel vehiculoIdModel)
        {
            try
            {
                _query = string.Format("SELECT * FROM VEHICULO WHERE IdVehiculo = {0}", vehiculoIdModel.idVehiculo);
                _dataTable = _conexionBd.GetDatos(_query);

                return _dataTable;
            }
            catch
            {
                return _dataTable;
            }
        }

        public bool UpdateVehiculo(VehiculoModel vehiculo)
        {
            try
            {
                _query = string.Format("UPDATE VEHICULO SET IdColor = {0}, IdMarca = {1}, IdYear = {2}, IdFase = {3}, Linea = '{4}', Placa = '{5}', Kilometros = {6}, Valor = {7}, Observaciones = '{8}' WHERE IdVehiculo = {9} ", vehiculo.idColor, vehiculo.idMarca, vehiculo.idYear, vehiculo.idFase, vehiculo.linea, vehiculo.placa.ToUpper(), vehiculo.kilometros, vehiculo.valor, vehiculo.observaciones, vehiculo.idVehiculo);
                bool resul = _conexionBd.SaveData(_query);
                return resul;
            }
            catch
            {
                return false;
            }
        }
    }
}
