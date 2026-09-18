Console.WriteLine("EJERCICIO 3");
Console.WriteLine("SIMULACIÓN DE CARGA DE BATERÍA (12.6 V)");
Console.WriteLine();
Console.WriteLine("PLANTEAMIENTO:");
Console.WriteLine("Diseñe un programa que simule la carga de una batería de 12.6 V. El usuario deberá ingresar:");
Console.WriteLine("a) El voltaje inicial de la batería.");
Console.WriteLine("b) El incremento de voltaje producido en cada ciclo de carga.");
Console.WriteLine("Mediante un ciclo while, el programa aumentará el voltaje hasta alcanzar 12.6 V.");
Console.WriteLine("En cada repetición deberá mostrar el número de ciclo y el voltaje actual.");
Console.WriteLine("Si el incremento introducido es igual o menor que cero, el programa deberá mostrar");
Console.WriteLine("un mensaje de error y no ejecutar la simulación.");
Console.WriteLine("==================================================================================");
Console.WriteLine();
Console.Write("Ingrese el voltaje inicial (V): "); // Ingresar voltaje inicial e incremento
double voltajeInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el incremento por ciclo: "); // ingrsar incremento por ciclo
double incremento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if (incremento <= 0) // Evaluación: Incremento <= 0
{
    Console.WriteLine("ERROR INCREMENTO DEBE SER >0"); // Si -> Mostrar "ERROR INCREMENTO DEBE SER >0"
}
else
{
    int ciclo = 0; // No -> Ciclo = 0
    double voltajeActual = voltajeInicial;
    while (voltajeActual < 12.6) // Evaluación del ciclo while: Voltaje < 12.6
    {
        ciclo = ciclo + 1; // Si -> Ciclo = Ciclo + 1
        voltajeActual = voltajeActual + incremento; // Voltaje = Voltaje + Incremento
        double voltajeMostrar = Math.Min(voltajeActual, 12.6); // Ajuste de tope a 12.6 V usando Math.Min para la salida en consola
        Console.WriteLine($"Ciclo #{ciclo}: Voltaje = {voltajeMostrar:F2} V"); // Mostrar Ciclo y Voltaje
    }
    Console.WriteLine("CARGA COMPLETADA"); // No -> Mostrar "CARGA COMPLETADA"
}
