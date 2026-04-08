namespace Programa_04
{
    internal class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Cadena de texto (string) - Comillas dobles ""
            string nombre = "Noelia Palavecino";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombre);

            // Carácter único (char) - Comillas simples ''
            char Apellido = 'P';
            Console.WriteLine("\n5. TIPO CARÁCTER (Apellido):");
            Console.WriteLine("   Valor guardado: '" + Apellido);
                 string Pais = "Argentina";
            Console.WriteLine("6. TIPO TEXTO (Pais):");
            Console.WriteLine("   Valor guardado: " + Pais);
            string alias = "ARG";
            Console.WriteLine("7. TIPO TEXTO (alias):");
            Console.WriteLine("   Valor guardado: " + alias);
            string domicilio = "Jujuy 200";
            Console.WriteLine("8. TIPO TEXTO (domicilio):");
            Console.WriteLine("   Valor guardado: " + domicilio);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
            Console.ReadKey();
         
        }
    }
}
