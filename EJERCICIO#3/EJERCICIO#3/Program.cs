Console.WriteLine("EJERCICIO_3");                                    // Numero del ejercicio
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");                  // Se solicita al usuario que ingrese la primera calificación
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");                  // Se solicita al usuario que ingrese la segunda calificación
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");                  // Se solicita al usuario que ingrese la tercera calificación
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; // Calculamos el promedio de las tres calificaciones

Console.WriteLine();                                                      //  Se deja un espacio en blanco en la consola
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); // Se imprime el promedio con dos decimales. $ une dos tipos de datos. F2 muestra la cantidad de decimales que decidamos si esta en 0 no muestra ninguno, si esta en 1 muestra un decimal, si esta en 2 muestra dos decimales y asi sucesivamente. 
if (promedio > 70)
{
    Console.WriteLine("¡Felicidades haz aprobado"); // Si el promedio es mayor o igual a 70, se imprime un mensaje de felicitaciones
}
else
{
    Console.WriteLine("Lo siento, haz reprobado"); // Si el promedio es menor a 70, se imprime un mensaje de reprobación)
}
if (promedio <50)
{
    Console.WriteLine("Alumno deficiente"); // Si el promedio es menor a 50, se imprime un mensaje de reprobación
}
else if (promedio <69 && promedio >   51)

{
    Console.WriteLine("Alumno requiere apoyo"); // Si el promedio es menor a 69 y mayor o igual a 51, se imprime un mensaje de reprobación
}
else if (promedio >70 && promedio <79)
{
    Console.WriteLine("Alumno regular"); // Si el promedio es mayor o igual a 70 y menor o igual a 100, se imprime un mensaje de felicitaciones
}
else if (promedio > 80 && promedio < 89)
{
    Console.WriteLine("Alumno bueno"); // Si el promedio es mayor o igual a 80 y menor o igual a 100, se imprime un mensaje de felicitaciones
}
else if (promedio > 90 && promedio < 100)
{
    Console.WriteLine("Alumno excelente"); // Si el promedio es mayor o igual a 90 y menor o igual a 100, se imprime un mensaje de felicitaciones
}
