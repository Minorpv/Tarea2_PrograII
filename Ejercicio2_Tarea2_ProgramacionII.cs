using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ejercicio2_PrograII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación
            //1. Deberá leer los siguientes datos para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1,
            //tarea 2, tarea 3, examen 1, examen 2 y examen 3. El programa deberá calcular el porcentaje de quices (25%),
            //porcentaje de tareas (30%), y el porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final
            //y reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas, porcentaje de exámenes, promedio final
            //y condición del estudiante. La condición del estudiante esta con base a: Si el promedio final es
            //mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y menor que 70 “Aplazado”
            //y si el promedio final es menor que 50 “Reprobado”. 9. 
            
            //Bienvenida
            Console.WriteLine("Bienvenido al sistema");

            //Ingreso de datos del estudiante
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el número de carnet del estudiante: ");
            string carnet = Console.ReadLine();

            //Notas de quices
            Console.WriteLine("Ingrese la nota del quiz 1: ");
            float quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del quiz 2: ");
            float quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del quiz 3: ");
            float quiz3 = float.Parse(Console.ReadLine());

            //Porcentaje quices
            float promedioquiz = 0;
            float sumatoriaquiz = 0;
            float porquiz = 0;
            sumatoriaquiz = quiz1 + quiz2 +quiz3;
            promedioquiz = sumatoriaquiz / 3;
            porquiz = promedioquiz * 0.25f;


            //Notas Tareas
            Console.WriteLine("Ingrese la nota de la tarea 1: ");
            float tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 2: ");
            float tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 3: ");
            float tarea3 = float.Parse(Console.ReadLine());

            //Porcentaje tareas
            float promediotareas = 0;
            float sumatoriatareas = 0;
            float portareas = 0;
            sumatoriatareas = tarea1 + tarea2 + tarea3;
            promediotareas = sumatoriatareas / 3;
            portareas = promediotareas * 0.30f;

            //Notas examenes
            Console.WriteLine("Ingrese la nota del examen 1: ");
            float examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen 2: ");
            float examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen 3: ");
            float examen3 = float.Parse(Console.ReadLine());

            //Porcentaje examenes
            float promedioexamen = 0;
            float sumatoriaexamen = 0;
            float porexamen = 0;
            sumatoriaexamen = examen1 + examen2 + examen3;
            promedioexamen = sumatoriaexamen / 3;
            porexamen = promedioexamen * 0.45f;

            //Calculo del promedio final
            float PromedioFinal = porexamen + porquiz + portareas;
            string condicion = "Aprobado";
            if (PromedioFinal > 70)
            {
                condicion = "Aprobado";
            }
            else if (PromedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else 
            {
                condicion = "Reprobado";
            }

            //Datos finales
            Console.Write($"Estudiante: {nombre}       ");
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Porcentaje de quices: {porquiz}");
            Console.WriteLine($"Porcentaje de tareas: {portareas}");
            Console.WriteLine($"Porcentaje de examenes: {porexamen}");
            Console.WriteLine($"Promedio final: {PromedioFinal}");
            Console.WriteLine($"Condición del estudiante: {condicion}");
            Console.ReadLine();

        }
    }
}
