using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio1
{
    public class Aplicacion
    {
        [JsonPropertyName("usuario")]
        public string Usuario {  get; set; }

        [JsonPropertyName("amigos_usuario")]
        public List<string> AmigosUsuario {  get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool NotificacionesUsuario { get; set; }
    }
}
