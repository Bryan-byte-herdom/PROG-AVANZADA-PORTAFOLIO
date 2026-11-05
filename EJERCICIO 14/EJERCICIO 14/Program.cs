using System;

Console.WriteLine("SISTEMA DE MONITOREO DE SENSORES INDUSTRIALES");
Console.WriteLine();

Console.WriteLine("Seleccione el tipo de sensor:");
Console.WriteLine("1. Sensor de Temperatura");
Console.WriteLine("2. Sensor de Presión");
Console.WriteLine("3. Sensor de Distancia");
Console.Write("Ingrese opción: ");
string opcion = Console.ReadLine() ?? "";

// De acuerdo a la opción seleccionada
Sensor sensor;
if (opcion == "1") sensor = new SensorTemperatura();
else if (opcion == "2") sensor = new SensorPresion();
else sensor = new SensorDistancia();

// Capturar datos que se aplican a todos los sensores
Console.Write("Ingrese el identificador del sensor: ");
sensor.Identificador = Console.ReadLine() ?? "Sin identificador";
Console.Write("Ingrese el valor medido: ");
sensor.ValorMedio = Convert.ToDouble(Console.ReadLine());
Console.Write("¿El sensor está activo? (s/n): ");
string activoInput = (Console.ReadLine() ?? "").Trim().ToLower();
sensor.Activo = (activoInput == "s" || activoInput == "si" || activoInput == "sí");

// Mostrar resultados que se aplican a todos los sensores
Console.WriteLine();
Console.WriteLine("DATOS DEL SENSOR");
sensor.MostrarDatos();

// Mostrar resultados específicos según el tipo de sensor
if (sensor is SensorTemperatura temp)
{
    Console.WriteLine($"Evaluación de condición: {temp.EvaluarTemperatura()}");
}
else if (sensor is SensorPresion pres)
{
    Console.WriteLine($"Evaluación de condición: {pres.EvaluarPresion()}");
}
else if (sensor is SensorDistancia dist)
{
    Console.WriteLine($"Evaluación de condición: {dist.EvaluarDistancia()}");
}

// CLASE BASE
class Sensor
{
    public string Identificador { get; set; } = "";
    public double ValorMedio { get; set; }
    public bool Activo { get; set; }

    public string ObtenerEstado()
    {
        if (Activo)
            return "Sensor activo";
        else
            return "Sensor inactivo";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Identificador: {Identificador}");
        Console.WriteLine($"Valor medido: {ValorMedio}");
        Console.WriteLine($"Estado: {ObtenerEstado()}");
    }
}

// CLASES DERIVADAS
class SensorTemperatura : Sensor
{
    public string EvaluarTemperatura()
    {
        if (ValorMedio > 80)
            return "ALERTA: La temperatura supera los 80 °C. Requiere atención.";

        return "Temperatura dentro del criterio establecido.";
    }
}

class SensorPresion : Sensor
{
    public string EvaluarPresion()
    {
        if (ValorMedio > 10)
            return "ALERTA: La presión supera los 10 bar. Requiere atención.";

        return "Presión dentro del criterio establecido.";
    }
}

class SensorDistancia : Sensor
{
    public string EvaluarDistancia()
    {
        if (ValorMedio < 20)
            return "ALERTA: Objeto detectado a menos de 20 cm. Requiere atención.";

        return "Distancia dentro del criterio establecido.";
    }
}