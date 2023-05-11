using Entidades;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Veterinaria";
            //Nombre de la mascota
            //Edad(Validar 1 - 12)
            //Tipo: (Validar “gato”, “perro”, “hamster”)
            //Peso: (Validar 0 - 50)
            //Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

            //Informes:

            //Nombre de la mascota más vieja
            //Cantidad de mascotas con parásitos
            //Nombre, edad y diagnóstico de la mascota más joven ingresada.
            string nombre;
            int edad;
            string tipo;
            int peso;
            string diagnostico;

            int edadMayor = 50;
            string nombreMayor = "";

            int contadorParasitos = 0;

            string nombreMenor = "";
            int edadMenor = 0;
            string diagnosticoMenor = "";

            bool primerMascota = true;
            int rangoMinEdad = 1;
            int rangoMaxEdad = 12;
            int rangoMinPeso = 0;
            int rangoMaxPeso = 50000;

            char continuar;

            do 
            {
                nombre = IngresarDatos.ProbarRegEx();
                tipo = IngresarDatos.IngresarTexto("Ingrese el tipo (gato, perro, hamster): ", "gato", "perro", "hamster");
                edad = IngresarDatos.IngresarNum(rangoMinEdad, rangoMaxEdad, $"Ingrese la edad ({rangoMinEdad},{rangoMaxEdad}): ");
                peso = IngresarDatos.IngresarNum(rangoMinPeso, rangoMaxPeso, $"Ingrese en GR el peso ({rangoMinPeso},{rangoMaxPeso}): ");
                diagnostico = IngresarDatos.IngresarTexto("Ingrese el diagnostico (otitis, alergias, parasitos): ", "otitis", "alergias", "parasitos");

                if (primerMascota)
                {
                    edadMayor = edad;
                    nombreMayor = nombre;

                    edadMenor = edad;
                    nombreMenor = nombre;
                    diagnosticoMenor = diagnostico;
                    primerMascota = false;
                }
                else 
                {
                    if (edad > edadMayor)
                    {
                        edadMayor = edad;
                        nombreMayor = nombre;
                    }
                    else if (edad < edadMenor) 
                    {
                        edadMenor = edad;
                        nombreMenor = nombre;
                        diagnosticoMenor = diagnostico;
                    }
                }

                if (diagnostico == "parasitos") 
                {
                    contadorParasitos += 1;
                }

                Console.WriteLine("Ingrese 'n' para salir, o cualquier tecla para continuar");
                char.TryParse(Console.ReadLine(), out continuar);
                if (continuar == 'n')
                {
                    break;
                }

            } while (true);

            Console.WriteLine($"La mascota de mayor edad es {nombreMayor} con {edadMayor} años.");
            Console.WriteLine($"La mascota de menor edad es {nombreMenor} con {edadMenor}; siendo su diagnostico: {diagnosticoMenor}");
            Console.WriteLine($"La cantidad de mascotas con parasitos es de: {contadorParasitos}");
            Console.ReadKey();
        }
    }
}