using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebaVehiculos.Dto
{
    public class ResultadoModel
    {
        public string result {  get; set; }
        public bool error { get; set; }
        public string message { get; set; }

        public static ResultadoModel GetResultadoError(string mensaje, string resultado)
        {
            return new ResultadoModel { error = true, message = mensaje, result = resultado };
        }

        public static ResultadoModel GetResultadoSuccess(string mensaje, string resultado)
        {
            return new ResultadoModel { error = false, message = mensaje, result = resultado };
        }

    }
}
