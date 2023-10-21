// See https://aka.ms/new-console-template for more information

using PooDemo;
using PooDemo.Models;
using System.Text;

var imprimirInfo = new ImprimirInfo();

var superman = new SuperHeroe();

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Poder Volar";
poderVolar.Nivel = NivelPoder.NivelDos;

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);

var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;
//Console.WriteLine(superman == superman2);
//SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");
//SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");
//Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarElMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarElMundo);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

imprimirInfo.ImprimirSuperHeroe(wolverine);

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelDos;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);
string accionAntiheroe = wolverine.RealzarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

// los record sirven para cuando se hace un microservicio que se comunican con otros servicios
public record SuperHeroRecord( 
int Id,
string Nombre,
string IdentidadSecreta
    );
