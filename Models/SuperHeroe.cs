﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDemo.Models
{
    class SuperHeroe
    {
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;

        }
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder(); // sirve para concatenar strings 
            foreach (var superPoder in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el super poder {superPoder.Nombre}!!");
            }
            return sb.ToString();
        }
    }
}