using System.ComponentModel.DataAnnotations;

namespace ApiPruebaVehiculos.Dto
{
    public class VehiculoModel
    {
        public int? idVehiculo { get; set; }

        [Required(ErrorMessage = "Campo IdColor Requerido")]
        public int idColor { get; set; }

        [Required(ErrorMessage = "Campo IdMarca Requerido")]
        public int idMarca { get; set; }

        [Required(ErrorMessage = "Campo IdYear Requerido")]
        public int idYear { get; set; }

        [Required(ErrorMessage = "Campo IdFase Requerido")]
        public int idFase { get; set; }

        [Required(ErrorMessage = "Campo Linea Requerido")]
        public string linea { get; set; }

        [Required(ErrorMessage = "Campo placa Requerido")]
        [MinLength(6, ErrorMessage = "Placa Incorrecta, minimo 6  caracteres sin espacios, y sin caracteres especiales")]
        [MaxLength(6, ErrorMessage = "Placa Incorrecta, maximo 6  caracteres sin espacios, y sin caracteres especiales")]
        public string placa { get; set; }

        [Required(ErrorMessage = "Campo Kilometros Requerido")]
        public int kilometros { get; set; }

        [Required(ErrorMessage = "Campo Valor Requerido")]
        public int valor { get; set; }

        [Required(ErrorMessage = "Campo observaciones Requerido")]
        public string observaciones { get; set; }
    }

    public class VehiculoIdModel
    {
        [Required(ErrorMessage = "Campo IdVehiculo Requerido")]
        public int idVehiculo { get; set; }
    }

    public class VehiculoPlacaModel
    {
        [Required(ErrorMessage = "Campo placaVehiculo Requerido")]
        [MinLength(6, ErrorMessage = "Placa Incorrecta, minimo 6  caracteres sin espacios, y sin caracteres especiales")]
        [MaxLength(6, ErrorMessage = "Placa Incorrecta, maximo 6  caracteres sin espacios, y sin caracteres especiales")]
        public string placaVehiculo { get; set; }
    }
}
