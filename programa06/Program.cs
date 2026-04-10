namespace programa06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");

            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);

            //ejercicio1

            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string Gasto_fijo = "Luz";
            const string Usuario = "u.122";
            const int mayor_edad = 18;

            Console.WriteLine("=== " + Gasto_fijo + " (" + Usuario + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Debe ser mayor de edad " + mayor_edad + " años.");

            // Intento de uso con constantes (sin estructuras de control)
            const int edad_persona = 20;
            const int edad_promedio = 20;
            const bool puede_entrar = edad_persona >= edad_promedio; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + edad_persona + " años...");
            Console.WriteLine("Edad promedio " + edad_promedio);
            Console.WriteLine("Acceso permitido (valor bool constante): " + puede_entrar);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante gasto fijo = " + Gasto_fijo);
            Console.WriteLine("Constante Usuario = " + Usuario);

            //ejercicio2

            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string Telefonia = "Abono";
            const string celular = "38111111";
            const int año = 2026;

            Console.WriteLine("=== " + Telefonia + " (" + celular + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Debe estar desde el presente año " + año + " año en curso.");

            // Intento de uso con constantes (sin estructuras de control)
            const int edad_Usuario = 21;
            const int edad_cliente = 21;

            const bool puede_acceder = edad_Usuario >= edad_cliente; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + edad_Usuario + " años...");
            Console.WriteLine("Edad promedio " + edad_cliente);
            Console.WriteLine("Acceso permitido (valor bool constante): " + puede_acceder);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante gasto en telefonia = " + Telefonia);
            Console.WriteLine("Constante Usuario del numero de celular = " + celular);

            //ejercicio3

            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string Apellido = "Diaz";
            const string alias = "Diaz";
            const int numero1 = 50;

            Console.WriteLine("=== " + Apellido + " (" + alias + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Debe tener un numero mayor a 20 " + numero1 + "lugar");

            // Intento de uso con constantes (sin estructuras de control)
            const int edad_personamayor = 21;
            const int edad_personamenor = 15;
            const bool noingresar = edad_personamayor == edad_personamenor; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + edad_personamayor + " años...");
            Console.WriteLine("Edad es: " + edad_personamayor);
            Console.WriteLine("Acceso no  permitido (valor bool constante): " + noingresar);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante Apellido = " + Apellido);
            Console.WriteLine("Constante Alias = " + alias);

            //ejercicio4

            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string provincia = "Tucuman";
            const string Cuidad = "Capital";
            const int Codpostal = 4000;

            Console.WriteLine("=== " + provincia + " (" + Cuidad + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Debe tener un numero mayor a tres cifras " + Codpostal + "del lugar");

            // Intento de uso con constantes (sin estructuras de control)
            const int cantidadpoblacion = 1000;
            const int cantidadpersonas = 10;
            const bool noesprovincia = cantidadpoblacion <= cantidadpersonas; // expresión booleana

            Console.WriteLine("\nVerificando poblacion " + cantidadpoblacion + " cantidad...");
            Console.WriteLine(" La cantidad por poblacion es: " + cantidadpoblacion);
            Console.WriteLine(" noesprovincia  (valor bool constante): " + noesprovincia);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante provincia = " + provincia);
            Console.WriteLine("Constante Cuidad = " + Cuidad);

            //ejercicio5

            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string Pais = "Argentina";
            const string Sudamericano = "Sur";
            const int numeroprovincias = 24;

            Console.WriteLine("=== " + Pais + " (" + Sudamericano + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Debe tener un numero mayor a 5 provincias para ser  un Pais " + numeroprovincias + "lugar");

            // Intento de uso con constantes (sin estructuras de control)
            const int edadadultomayor = 60;
            const int edadjovenes = 18;
            const bool norequierepase = edadadultomayor > edadjovenes;// expresión booleana

            Console.WriteLine("\nVerificando cliente de " + edadadultomayor + " años...");
            Console.WriteLine("Edad es: " + edad_personamayor);
            Console.WriteLine("Acceso   permitido sin pase (valor bool constante): " + norequierepase);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante pais = " + Sudamericano);
            Console.WriteLine("Constante de numeroprovincias = " + numeroprovincias);


            Console.ReadLine();
            Console.ReadKey();  

        }
    }
}


