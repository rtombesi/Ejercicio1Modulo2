using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio3
{
    public class Detalle
    {
        [JsonPropertyName("peso")]
        public double Peso {  get; set; }

        [JsonPropertyName("dimensiones")]
        public Dimension dimension { get; set; }
    }
}
