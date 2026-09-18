Console.WriteLine("EJERCICIO 5"); // Título del ejercicio
Console.WriteLine("ANÁLISIS DE VIBRACIÓN EN MOTORES"); // Subtítulo del programa
Console.WriteLine(); 
Console.WriteLine("PLANTEAMIENTO:"); // Encabezado de planteamiento
Console.WriteLine("Diseñe un programa que permita analizar la vibración de varios motores. Para cada motor:"); // Planteamiento general
Console.WriteLine("a) Solicitar el nombre o identificador del motor."); // Requisito a
Console.WriteLine("b) Pedir cuatro mediciones de vibración mediante un ciclo for."); // Requisito b
Console.WriteLine("c) Calcular la vibración promedio."); // Requisito c
Console.WriteLine("d) Clasificar el estado del motor (<= 4.5 mm/s Normal, > 4.5 mm/s Mantenimiento)."); // Requisito d
Console.WriteLine("e) Preguntar si se desea analizar otro motor."); // Requisito e
Console.WriteLine("=================================================================================="); // Separador
Console.WriteLine(); 
int totalMotores = 0;        // Contador total de motores procesados
int motoresNormales = 0;     // Contador de motores con funcionamiento normal
int motoresMantenimiento = 0; // Contador de motores que requieren mantenimiento
string continuar = "S";      // Variable para control del ciclo while
while (continuar.ToUpper() == "S") // Evalúa la condición para continuar procesando motores
{
    Console.Write("Ingrese el nombre del motor: "); // Solicita el nombre o identificador
    string nombreMotor = Console.ReadLine(); // Lee el nombre del motor
    double suma = 0;          // Acumulador de las mediciones de vibración
    for (int medicion = 1; medicion <= 4; medicion++) // Ciclo for de 4 mediciones por motor
    {
        Console.Write($"Ingrese la lectura de vibración #{medicion} (mm/s): "); // Solicita la lectura
        double vibracion = Convert.ToDouble(Console.ReadLine()); // Lee e ingresa el valor medido
        suma = suma + vibracion; // Acumula la vibración capturada
    }
    double promedio = suma / 4; // Calcula el promedio de vibración del motor
    Console.WriteLine($"Vibración promedio del motor: {promedio:F2} mm/s"); // Muestra el promedio calculado

    if (promedio <= 4.5)     // Evalúa el umbral permitido de vibración (4.5 mm/s)
    {
        Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR"); // Mensaje de estado normal
        motoresNormales = motoresNormales + 1; // Incrementa el contador de normales
    }
    else
    {
        Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO"); // Mensaje de alerta por mantenimiento
        motoresMantenimiento = motoresMantenimiento + 1; // Incrementa el contador de mantenimiento
    }
    totalMotores = totalMotores + 1; // Incrementa el contador total de motores evaluados
    Console.WriteLine(); // Línea de separación
    Console.Write("¿Desea analizar otro motor? (S/N): "); // Solicita confirmación para continuar
    continuar = Console.ReadLine(); // Lee la decisión del usuario
    Console.WriteLine(); 
}
Console.WriteLine("=================================================================================="); // Separador final
Console.WriteLine($"Total de motores evaluados: {totalMotores}"); // Muestra el total de motores procesados
Console.WriteLine($"Cantidad de motores con funcionamiento normal: {motoresNormales}"); // Muestra el total de normales
Console.WriteLine($"Cantidad de motores que requieren mantenimiento: {motoresMantenimiento}"); // Muestra el total en alerta
