using System;

Console.WriteLine("SISTEMA DE CONTROL DE MOTORES");
Console.WriteLine();

Console.WriteLine("Seleccione el tipo de motor:");
Console.WriteLine("1. Motor CD");
Console.WriteLine("2. Motor AC");
Console.WriteLine("3. Servomotor");
Console.Write("Ingrese opción: ");
string opcion = Console.ReadLine() ?? "";

// De acuerdo a la opción seleccionada
Motor motor;
if (opcion == "1") motor = new MotorCD();
else if (opcion == "2") motor = new MotorAC();
else motor = new Servomotor();

// Capturar datos que se aplican a todos los motores
Console.Write("Ingrese el identificador del motor: ");
motor.Identificador = Console.ReadLine() ?? "Sin identificador";
Console.Write("Ingrese la temperatura del motor: ");
motor.Temperatura = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente del motor: ");
motor.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del motor en rpm: ");
motor.Velocidad = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el voltaje del motor: ");
motor.Voltaje = Convert.ToDouble(Console.ReadLine());

// Capturar propiedades específicas
if (motor is MotorAC motorAC)
{
    Console.Write("Ingrese la fase de operación (Monofasico, Bifasico, Trifasico): ");
    motorAC.FasesOperacion = Console.ReadLine() ?? "";
}
else if (motor is Servomotor servo)
{
    Console.Write("Ingrese la posición angular del motor: ");
    servo.PosicionAngular = Convert.ToDouble(Console.ReadLine());
}

// Mostrar resultados que se aplican a todos los motores
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR");
Console.WriteLine($"Motor: {motor.Identificador}");
Console.WriteLine($"Temperatura: {motor.Temperatura} °C");
Console.WriteLine($"Corriente: {motor.Corriente} A");
Console.WriteLine($"Velocidad: {motor.Velocidad} rpm");
Console.WriteLine($"Voltaje: {motor.Voltaje} V");
Console.WriteLine($"Estado: {motor.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {motor.RevisarTemperatura()}");

// Mostrar resultados específicos
if (motor is MotorAC mac)
{
    Console.WriteLine($"Fase de operación: {mac.FasesOperacion}");
    Console.WriteLine($"Análisis de frecuencia: {mac.DeterminarFrecuencia()}");
}
else if (motor is Servomotor s)
{
    Console.WriteLine($"Posición angular: {s.PosicionAngular}°");
    Console.WriteLine($"Determinación de posición: {s.DeterminarPosicion()}");
}


// CLASE BASE
class Motor
{
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }
    public double Voltaje { get; set; }

    public string ObtenerEstado()
    {
        if (Velocidad > 0)
            return "Motor en marcha";
        else
            return "Motor detenido";
    }

    public string RevisarTemperatura()
    {
        if (Temperatura > 70)
            return "ALERTA: Temperatura elevada";

        return "Temperatura normal";
    }
}

// CLASES DERIVADAS
class MotorCD : Motor { }

class MotorAC : Motor
{
    public string FasesOperacion { get; set; } = "";

    public string DeterminarFrecuencia()
    {
        string fase = FasesOperacion.ToLower().Trim();
        if (fase.Contains("monofas")) return "Frecuencia estimada: 60 Hz (Sistema Monofásico)";
        if (fase.Contains("bifas")) return "Frecuencia estimada: 60 Hz (Sistema Bifásico)";
        if (fase.Contains("trifas")) return "Frecuencia industrial estimada: 50/60 Hz (Sistema Trifásico)";
        return "Frecuencia indeterminada";
    }
}

class Servomotor : Motor
{
    public double PosicionAngular { get; set; }

    public string DeterminarPosicion()
    {
        if (PosicionAngular == 0) return "Posición en 0 grados";
        if (PosicionAngular == 90) return "Posición en 90 grados";
        if (PosicionAngular == 180) return "Posición en 180 grados";
        return "Posición en ángulo intermedio";
    }
}