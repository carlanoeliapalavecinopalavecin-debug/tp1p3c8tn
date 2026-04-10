namespace programa07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);


            //ejercicio 1

            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal Valor_nominal = 0.19m; // 19% fijo
            const bool MODO_PRUEBA1 = true; // Control de seguridad
            const char SIMBOLO_PESO1 = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN 1---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase1 = 1500.50m;
            decimal impuestoCalculado1 = precioBase1 * Valor_nominal;
            decimal total1 = precioBase1 + impuestoCalculado1;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO1 + precioBase1);
            Console.WriteLine("IVA (" + (Valor_nominal * 100) + "%): " + SIMBOLO_PESO1 + impuestoCalculado1);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO1 + total1);

            //ejercicio 2

            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA2 = 0.19m; // 19% fijo
            const bool MODO_PRUEBA2= false; // Control de seguridad
            const char SIMBOLO_PESO2= '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN 2 ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase2 = 2000.50m;
            decimal impuestoCalculado2 = precioBase2 * TASA_IVA2;
            decimal total2 = precioBase2 + impuestoCalculado2;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO2 + precioBase2);
            Console.WriteLine("IVA (" + (TASA_IVA2 * 100) + "%): " + SIMBOLO_PESO2 + impuestoCalculado2);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO2 + total2);

            //Ejercicio 3

            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal PlazoFijo = 0.30m; // 30% fijo
            const bool MODO_PRUEBA3 = true; // Control de seguridad
            const char SIMBOLO_PESO3 = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN 3 ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA3);

            decimal precioBase3 = 3000.50m;
            decimal impuestoCalculado3 = precioBase3 * PlazoFijo
                ;
            decimal total3 = precioBase3 + impuestoCalculado3;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO3 + precioBase3);
            Console.WriteLine("IVA (" + (PlazoFijo * 100) + "%): " + SIMBOLO_PESO3 + impuestoCalculado3);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO3 + total3);
             

            //Ejercicio 4

            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal PlazoFijo2 = 0.40m; // 40% fijo
            const bool MODO_PRUEBA4 = false; // Control de seguridad
            const char SIMBOLO_PESO4 = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN 4 ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA4);

            decimal precioBase4 = 4000.00m;
            decimal impuestoCalculado4 = precioBase * PlazoFijo2;
            decimal total4 = precioBase4 + impuestoCalculado4;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO4 + precioBase4);
            Console.WriteLine("IVA (" + (PlazoFijo2 * 100) + "%): " + SIMBOLO_PESO4 + impuestoCalculado4);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO4 + total4);

            //Ejercicio 5

            // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal ART = 0.12m; // 12% fijo
            const bool MODO_PRUEBA5 = true; // Control de seguridad
            const char SIMBOLO_PESO5 = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN 5---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA5);

            decimal precioBase5 = 350.50m;
            decimal impuestoCalculado5 = precioBase5 * ART;
            decimal total5 = precioBase5 + impuestoCalculado5;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO5 + precioBase5);
            Console.WriteLine("IVA (" + (ART * 100) + "%): " + SIMBOLO_PESO5 + impuestoCalculado5);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO5 + total5);


            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
