using PooDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDemo.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre;
        public int Id { get; set; }
        public override string Nombre { 
            get { 
                return _Nombre;
            } 
            set { 
                _Nombre = value.Trim();
            } 
        }
        public string NombreIdentidadSecreta { get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            } }
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;

        }
        public virtual string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder(); // sirve para concatenar strings 
            foreach (var superPoder in SuperPoderes)
            {
                sb.AppendLine($"{NombreIdentidadSecreta} esta usando el super poder {superPoder.Nombre}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreIdentidadSecreta} ha salvado la tierra ";
        }
    }
}
