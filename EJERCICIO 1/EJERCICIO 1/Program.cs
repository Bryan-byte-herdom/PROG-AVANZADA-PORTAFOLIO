Console.WriteLine("EJERCICIO_1");                                    // #1
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");                  // Se solicita al usuario que ingrese la primera calificación
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");                  // Se solicita al usuario que ingrese la segunda calificación
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");                  // Se solicita al usuario que ingrese la tercera calificación
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; // Calculamos el promedio de las tres calificaciones

Console.WriteLine();                                                      //  Se deja un espacio en blanco en la consola
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); // Se imprime el promedio con dos decimales
