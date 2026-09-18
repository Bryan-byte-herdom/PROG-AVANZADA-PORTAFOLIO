Console.WriteLine("EJERCICIO 1"); // Numero 
Console.WriteLine("CÁLCULO DE LA POTENCIA ELÉCTRICA DE UN MOTOR DE CORRIENTE DIRECTA");
Console.WriteLine();
Console.WriteLine("PLANTEAMIENTO:"); // Planteamiento del problema
Console.WriteLine("Diseñe un programa que solicite al usuario el voltaje y la corriente consumida");
Console.WriteLine("por un motor de corriente directa. El programa deberá calcular la potencia eléctrica");
Console.WriteLine("mediante: P = V * I. Después deberá clasificar el funcionamiento del motor de");
Console.WriteLine("acuerdo con lo siguiente:");
Console.WriteLine("a) Si la potencia es menor o igual a 120 W, mostrar: CONSUMO NORMAL.");
Console.WriteLine("b) Si la potencia es mayor que 120 W, mostrar: ADVERTENCIA: CONSUMO ELEVADO.");
Console.WriteLine("==================================================================================");
Console.WriteLine();
Console.Write("Ingrese el voltaje del motor (V): "); // Entrada de datos de voltaje
double voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente consumida (A): "); // Entrada de datos de corriente
double corriente = Convert.ToDouble(Console.ReadLine());
double potencia = voltaje * corriente; // Calculamos la potencia eléctrica mediante P = V × I
Console.WriteLine();
Console.WriteLine($"La potencia eléctrica del motor es: {potencia:F2} W"); // Muestras la potencia eléctrica calculada con dos decimales
if (potencia <= 120) 
{
    Console.WriteLine("CONSUMO NORMAL"); // Clasificamos el consumo del motor si esta es menor o igual a 120 W
}
else
{
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO"); // Clasificamos el consumo del motor si esta es por encima de 120 W
}