Console.WriteLine("EJERCICIO 2");
Console.WriteLine("CÁLCULO DE LA TEMPERATURA PROMEDIO DE UN MOTOR");
Console.WriteLine();
Console.WriteLine("PLANTEAMIENTO:");
Console.WriteLine("Un sensor mide diez veces la temperatura de un motor. Diseñe un programa en el que se");
Console.WriteLine("escriba una sola vez las instrucciones para solicitar las diez mediciones, sumarlas");
Console.WriteLine("y calcular la temperatura promedio. El programa deberá indicar:");
Console.WriteLine("a) TEMPERATURA NORMAL, si el promedio es menor o igual que 70°C.");
Console.WriteLine("b) ALERTA DE TEMPERATURA, si el promedio es mayor que 70°C.");
Console.WriteLine("==================================================================================");
Console.WriteLine();
double suma = 0; // Inicialización de suma en 0
for (int i = 1; i <= 10; i++) // Ciclo para solicitar las 10 mediciones (i <= 10)
{
    Console.Write($"Ingrese la lectura de temperatura #{i} (°C): ");
    double temp = Convert.ToDouble(Console.ReadLine()); // Leer temperatura
    suma = suma + temp; // suma = suma + Temp
}
double promedio = suma / 10.0; // Promedio = suma / 10
Console.WriteLine();
Console.WriteLine($"La temperatura promedio es: {promedio:F2} °C"); // Evaluación de la condición: Promedio <= 70°
if (promedio <= 70)
{
    Console.WriteLine("TEMPERATURA NORMAL"); // Si -> Mostrar "TEMPERATURA NORMAL"
}
else
{
    Console.WriteLine("ALERTA DE TEMPERATURA"); // No -> Mostrar "ALERTA DE TEMPERATURA"
}
