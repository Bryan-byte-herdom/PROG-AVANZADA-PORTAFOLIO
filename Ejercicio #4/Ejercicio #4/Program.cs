Console.WriteLine("EJERCICIO_5");
Console.WriteLine("CÁLCULO DEL PROMEDIO DE CINCO CALIFICACIONES");
Console.WriteLine();

double suma = 0;

for (int N = 1; N <= 5; N++)
{
    Console.Write($"Ingrese la calificación {N}: ");
    double calificacion = Convert.ToDouble(Console.ReadLine());
    suma += calificacion;
}

double promedio = suma / 5;
Console.WriteLine($"\nEl promedio de las cinco calificaciones es: {promedio:F2}");

// Evaluación de aprobación
if (promedio >= 70)
{
    Console.WriteLine("¡Felicidades, has aprobado!");
}
else
{
    Console.WriteLine("Lo siento, has reprobado.");
}

// Clasificación del rendimiento del alumno
if (promedio < 50)
{
    Console.WriteLine("Estado: Alumno deficiente");
}
else if (promedio >= 50 && promedio < 70)
{
    Console.WriteLine("Estado: Alumno requiere apoyo");
}
else if (promedio >= 70 && promedio < 80)
{
    Console.WriteLine("Estado: Alumno regular");
}
else if (promedio >= 80 && promedio < 90)
{
    Console.WriteLine("Estado: Alumno bueno");
}
else if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Estado: Alumno excelente");
}