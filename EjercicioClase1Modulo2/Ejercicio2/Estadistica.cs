﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio2
{
    public class Estadistica
    {
        [JsonPropertyName("equipo")]
        public string Equipo {  get; set; }

        [JsonPropertyName("jugadores")]
        public List<Jugador> Jugadores { get; set; }

        [JsonPropertyName("campeon")]
        public bool Campeon {  get; set; }
    }   
}
