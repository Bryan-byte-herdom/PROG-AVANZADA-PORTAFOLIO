Console.WriteLine("EJERCICIO_5");                                    // Numero del ejercicio
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola
double suma = 0; // Declaramos la variable suma para almacenar la suma de las calificaciones
for (int N = 1; N <= 5; N++)
{
Console.Write($"Ingrese la calificación {N}: ");
double calificacion = Convert.ToDouble(Console.ReadLine());
suma = suma + calificacion;
}
double promedio = suma / 5;
Console.WriteLine($"El promedio de las cinco calificaciones es: {promedio :F2}");
if (promedio > 70)
{
Console.WriteLine("¡Felicidades haz aprobado"); // Si el promedio es mayor o igual a 70, se imprime un mensaje de felicitaciones
}

{
Console.WriteLine("Lo siento, haz reprobado"); // Si el promedio es menor a 70, se imprime un mensaje de reprobación)
}
if (promedio < 50)
{
Console.WriteLine("Alumno deficiente"); // Si el promedio es menor a 50, se imprime un mensaje de reprobación
}
else if (promedio < 69 && promedio > 51)

{
    Console.WriteLine("Alumno requiere apoyo"); // Si el promedio es menor a 69 y mayor o igual a 51, se imprime un mensaje de reprobación
}
else if (promedio > 70 && promedio <79)
{
    Console.WriteLine("Alumno regular"); // Si el promedio es mayor o igual a 70 y menor o igual a 100, se imprime un mensaje de felicitaciones
}

else if (promedio > 80 && promedio < 89)
{
    Console.WriteLine("Alumno bueno"); // Si el promedio es mayor o igual a 80 y menor o igual a 100, se imprime un mensaje de felicitaciones
}
else if (promedio > 90 && promedio <100)
{
    Console.WriteLine("Alumno excelente"); // Si el promedio es mayor o igual a 90 y menor o igual a 100, se imprime un mensaje de felicitaciones
}
