using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


//Definicion de la clase estudiante 
public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
}
class Program
{
    static void Main()
    {
        //cree la lista Estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Id= 4, Nombre ="Carla Santos",   Edad= 20, Carrera= "Software" },
            new Estudiante { Id= 5, Nombre="Sebastian Santana", Edad= 24,Carrera= "Derecho"},
            new Estudiante { Id= 6, Nombre="Said Martinez", Edad= 18, Carrera= "IA"},
            new Estudiante { Id= 7, Nombre= "Joel De Los Santos", Edad= 19, Carrera="Informatica forense"}
        };

        //Consulta para mostrar los estudiantes menores de 21 
        var estudiantesMenoresDe21 = from estudiante in estudiantes
                                     where estudiante.Edad < 21
                                     select estudiante;
        Console.WriteLine("Estudiantes menores de 21 años:");
        foreach (var estudiante in estudiantesMenoresDe21)
        {
            Console.WriteLine($"{estudiante.Nombre} - {estudiante.Edad} años ");
        }

        //Consulta para mostrar los estudiantes con Id multiplo de 2 
        var estudianteIdmultiploDe2 = from estudiante in estudiantes
                                      where estudiante.Id % 2 == 0
                                      select estudiante;
        Console.WriteLine("Estudiantes con Id multiplo de 2: ");
        foreach(var estudiante in estudianteIdmultiploDe2)
        {
            Console.WriteLine($"{estudiante.Id} - {estudiante.Nombre}");
        }
        // ordene los estudiantes por edad 
        var estudiantesOrdenados = from estudiante in estudiantes
                                   orderby estudiante.Edad
                                   select estudiante;
        Console.WriteLine("\nEstudiantes Ordenados por Edad:");
        foreach (var estudiante in estudiantesOrdenados)
        {
            Console.WriteLine(estudiante.Edad);
        }

        //Muestra el estudiante con el nombre mas pequeño 
        var longitudMinima = estudiantes.Min(e => e.Nombre.Length);
        var nombreMasCorto = from estudiante in estudiantes
                             where estudiante.Nombre.Length == longitudMinima
                             select estudiante;

        Console.WriteLine("\nEstudiante con el nombre más pequeño :");
        foreach (var estudiante in nombreMasCorto)
        {
            Console.WriteLine($"{estudiante.Nombre} - {estudiante.Nombre.Length} caracteres");
        }

        //Muestra el estudiante con el nombre mas Largo
        var LongitudMaxima = estudiantes.Max(e  => e.Nombre.Length);
        var NombreMasLargo = from estudiante in estudiantes
                             where estudiante.Nombre.Length == LongitudMaxima
                             select estudiante;

        Console.WriteLine("\nEstudiante con el nombre más largo:");
        foreach (var estudiante in NombreMasLargo)
        {
            Console.WriteLine($"{estudiante.Nombre} - {estudiante.Nombre.Length} caracteres");
        }

        //muestra el total de los estudiantes 
        var cantidadEstudiantes = (from estudiante in estudiantes
                                   select estudiante).Count();
        Console.WriteLine("\nCantidad total de estudiantes:");
        Console.WriteLine(cantidadEstudiantes);



    }
}
