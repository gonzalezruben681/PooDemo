using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDemo.Models
{
    internal class AntiHeroe : SuperHeroe
    { 
        public string RealzarAccionDeAntiheroe(string accion) {
            return $"El Antiheroe {NombreIdentidadSecreta} ha realizado: {accion}";
        }

        public override string UsarSuperPoderes()
        {
            //return base.UsarSuperPoderes();
            return $"{NombreIdentidadSecreta} ha utilizado el super poder";
        }
    }
}
