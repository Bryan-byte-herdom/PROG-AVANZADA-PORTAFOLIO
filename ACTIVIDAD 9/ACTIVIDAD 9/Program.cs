Console.WriteLine("SISTEMA DE MONITOREO DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();
// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados llamando a los métodos comparadores
Console.WriteLine();
Console.WriteLine("--- DATOS Y EVALUACIÓN DEL MOTOR ---");
Console.WriteLine($"Identificador: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura:F1} °C");
Console.WriteLine($"Corriente: {motor1.Corriente:F2} A");
Console.WriteLine($"Velocidad: {motor1.Velocidad:F1} RPM");
Console.WriteLine($"Evaluación Temperatura: {motor1.CompararTemperatura()}");
Console.WriteLine($"Estado del Motor: {motor1.CompararVelocidad()}");


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; } // En RPM


    // Método comparador de temperatura
    public string CompararTemperatura()
    {
        if (Temperatura > 70)
        {
            return "MAYOR A 70 °C (Sobrecalentamiento)";
        }
        else
        {
            return "NORMAL (Menor o igual a 70 °C)";
        }
    }

    // Determina si está detenido o en marcha de acuerdo a las RPM
    public string CompararVelocidad()
    {
        if (Velocidad > 0)
        {
            return $"EN MARCHA ({Velocidad:F1} RPM)";
        }
        else
        {
            return "DETENIDO (0 RPM)";
        }
    }
}