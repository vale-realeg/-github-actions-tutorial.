using System;

class Formulario
{
    static void Main(string[] args)
    {
        //Bienvenida
        Console.WriteLine("=== Formulario Informativo ===\n");

        // Para ingresar el nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Verificar si la edad es válida
        int edad;
        while (true)
        {
            Console.Write("Ingrese su edad: ");
            string edadInput = Console.ReadLine();
            
            if (int.TryParse(edadInput, out edad) && edad > 0) //Este if es para evitar que el usuario ponga 0 como edad
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida >:|");
            }
        }

        // Solicitar el correo electrónico
        Console.Write("Ingrese su correo electrónico: ");
        string correo = Console.ReadLine();

        // Mostrar los datos ingresados
        Console.WriteLine("\n=== Datos Ingresados ===");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Correo Electrónico: {correo}");

        // Finalizar el programa
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
