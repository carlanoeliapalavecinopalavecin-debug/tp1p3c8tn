namespace programa02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");
            
            // Declaración de un entero
            int edad = 28;

            // Declaración de decimales
            double a = 1.70;

            // Declaración de Provincia
            string provincia = "Tucuman";

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
            Console.WriteLine("   Valor guardado: " + edad);

            Console.WriteLine("--- BLOQUE 2: NÚMEROS decimales ---");
            Console.WriteLine("   Valor guardado: " +a);

            Console.WriteLine("--- BLOQUE 3 Provincia");
            Console.WriteLine("   Valor guardado: " + provincia);



            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

