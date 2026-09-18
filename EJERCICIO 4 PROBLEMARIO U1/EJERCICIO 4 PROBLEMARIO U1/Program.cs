Console.WriteLine("EJERCICIO 4");
Console.WriteLine("ANÁLISIS DE CORRIENTE EN ACTUADOR");
Console.WriteLine();
Console.WriteLine("PLANTEAMIENTO:");
Console.WriteLine("Diseñe un programa que tome 8 lecturas de corriente de un actuador mecatrónico.");
Console.WriteLine("a) Registre individualmente cada lectura dentro de un ciclo de 8 repeticiones.");
Console.WriteLine("b) Clasifique cuántas mediciones son normales (<= 5 A) y cuántas son sobrecorrientes (> 5 A).");
Console.WriteLine("El programa calculará la corriente promedio y mostrará la cantidad de lecturas");
Console.WriteLine("normales y en sobrecorriente. Al final, según el recuento de sobrecorrientes,");
Console.WriteLine("mostrará un mensaje de 'SISTEMA EN ESTADO OPTIMO' o 'ALERTA DE REVISIÓN EN EL CIRCUITO'.");
Console.WriteLine("==================================================================================");
Console.WriteLine();
double suma = 0;             // Acumulador para la corriente total
int normales = 0;            // Contador de mediciones <= 5 A
int sobrecorrientes = 0;     // Contador de mediciones > 5 A
int i = 1;                   // Contador para el bucle (8 lecturas)
while (i <= 8)               // Evalúa que no se excedan las 8 lecturas
{
    Console.Write($"Ingrese la lectura de corriente #{i} (A): ");
    double corriente = Convert.ToDouble(Console.ReadLine()); // Lee la lectura actual de corriente

    suma = suma + corriente; // Acumula la corriente medida

    if (corriente <= 5)      // Verifica si la medición está en rango normal
    {
        normales = normales + 1; // Incrementa el contador de normales
    }
    else
    {
        sobrecorrientes = sobrecorrientes + 1; // Incrementa el contador de sobrecorrientes
    }
    i = i + 1;               // Incrementa la variable de control del ciclo
}
Console.WriteLine();
double promedio = suma / 8;  // Calcula la corriente promedio
Console.WriteLine($"Corriente promedio registrada: {promedio:F2} A");
Console.WriteLine($"Mediciones normales: {normales}");
Console.WriteLine($"Mediciones en sobrecorriente: {sobrecorrientes}");
Console.WriteLine();
if (sobrecorrientes == 0)    // Evalúa si existió alguna sobrecorriente en el proceso
{
    Console.WriteLine("SISTEMA EN ESTADO OPTIMO"); // Diagnóstico de sistema seguro
}
else
{
    Console.WriteLine("ALERTA DE REVISIÓN EN EL CIRCUITO"); // Diagnóstico de alerta por sobrecorriente
}