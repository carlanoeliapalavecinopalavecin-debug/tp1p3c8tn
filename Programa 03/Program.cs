namespace Programa_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Estatura (double)
            double estatura = 1.75;
            string Nombre = "Noelia";
            int edad = 41;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + estatura + " metros");

            // Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 199.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);
            Console.WriteLine("3. TIPO string Nombre (Nombre):");
            Console.WriteLine("   Valor guardado: " +Nombre  );
            Console.WriteLine("3. TIPO int  edad (edad):");
            Console.WriteLine("   Valor guardado: " + edad);
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
