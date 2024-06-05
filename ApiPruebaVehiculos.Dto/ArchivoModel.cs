using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebaVehiculos.Dto
{
    public class ArchivoModel
    {
        public int? idArchivo { get; set; }
        public int idVehiculo { get; set; }
        public string nombreArchivo { get; set; }
        public string extension { get; set; }
        public string formato { get; set; }
        public string archivo { get; set; }
        public double tamano { get; set; }

    }
}
