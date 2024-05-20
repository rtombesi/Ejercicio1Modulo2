using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio2
{
    public class CentroEstadisticas
    {
        [JsonPropertyName("estadistica")]
        public List<Estadistica> Estadisticas { get; set; }
    }
}
