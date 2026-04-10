namespace Programa_01
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");
         
            {
                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu nombre: ");
                string nombre = Console.ReadLine();


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

               // ejercio n 1

                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu Apellido: ");
                string apellido = Console.ReadLine();
         
                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa tu dni: ");
                string dniTexto = Console.ReadLine();
                int dni = int.Parse(dniTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa tu peso (ejemplo: 71,50): ");
                double peso = double.Parse  (Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine(" dni: " + (dni)); // Operación matemática
                Console.WriteLine("peso: " + peso + " Kgs");

                // ejercio n 2

                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu apodo: ");
                string apodo = Console.ReadLine();

                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa   numeros de mayor a menor: ");
                string numerosTexto = Console.ReadLine();
                int numeros = int.Parse(numerosTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa tu peso Ideal, segun estatura (ejemplo: 60): ");
                double pesoideal = double.Parse(Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("Apodo: " + apodo);
                Console.WriteLine(" numeros: " + (numeros)); // Operación matemática
                Console.WriteLine("peso ideal para estatura: " + pesoideal + " Kgs");

                // ejercio n 3

                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu gmail: ");
                string gmail = Console.ReadLine();

                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa tu numero de legajo: ");
                string numeroslegajoTexto = Console.ReadLine();
                int numeroslegajo = int.Parse(numerosTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa un numero con decimales (ejemplo: 1,32): ");
                double numerosdecimales = double.Parse(Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("gmail: " + gmail);
                Console.WriteLine(" legajo numero: " + (numeroslegajo)); // Operación matemática
                Console.WriteLine("numeros con decimales: " + numerosdecimales + "  numeros escongidos con decimales ");

                // ejercio n 4

                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa el nombre de tu mascota: ");
                string nombremascota = Console.ReadLine();

                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa la edad de tu mascota: ");
                string edadmascotaTexto = Console.ReadLine();
                int edadmascota = int.Parse(numerosTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa el peso de tu mascota (ejemplo: 1,30): ");
                double pesomascota = double.Parse(Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("nombre mascota: " + nombremascota);
                Console.WriteLine(" edad : " + edadmascota); // Operación matemática
                Console.WriteLine("peso : " + pesomascota + "  kgrs ");

                // ejercio n 5

                // 1. Entrada de Texto (Simple)
                Console.Write("Por favor, ingresa tu segundo nombre: ");
                string segundonombre = Console.ReadLine();

                // 2. Entrada de Números (Requiere Conversión)
                Console.Write("Ingresa tu numero de celular: ");
                string numerocelularTexto = Console.ReadLine();
                int numerocelular = int.Parse(numerosTexto); // Convertimos el texto a número entero

                // 3. Entrada de Decimales (Precios o Medidas)
                Console.Write("Ingresa el peso estimativo promedio de la poblacion (ejemplo: 1,32): ");
                double pesopromedio = double.Parse(Console.ReadLine()); // Conversión directa en una línea

                // 4. Mostrar los resultados procesados
                Console.WriteLine("\n--- PERFIL CREADO ---");
                Console.WriteLine("segundo nombre: " + segundonombre);
                Console.WriteLine(" numeros celular: " + numerocelular); // Operación matemática
                Console.WriteLine("numeros peso promedio poblacion: " + pesopromedio + "kgs ");
            }
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
