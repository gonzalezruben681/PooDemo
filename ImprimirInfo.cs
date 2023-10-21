using PooDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDemo
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe) {
            Console.WriteLine($"Id: {superHeroe.Id} , \n Nombre: {superHeroe.Nombre}, \n Identidad secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}
