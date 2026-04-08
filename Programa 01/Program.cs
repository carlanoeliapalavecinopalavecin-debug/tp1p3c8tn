namespace Programa_01
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");
            int c = 0;
            while (c <= 2)
            {
                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese , Apellido");
                string apellido = Console.ReadLine();


                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa tu edad: ");
                string edadTexto = Console.ReadLine();
                int edad = int.Parse(edadTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa tu estatura (ejemplo: 1,70): ");
                double estatura = double.Parse(Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
                Console.WriteLine("Estatura: " + estatura + " metros");
                
                c = c + 1;
           
             }
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
