// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Laboratorio01.Entidades;
using Laboratorio01.Negocio;

Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona("Angel", 30, 'H', 70.5, 1.70);
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el sexo (H o M):");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso en kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura en m:");
            double altura = double.Parse(Console.ReadLine());

            ClsPersona persona = new ClsPersona(nombre, edad, sexo, peso, altura);

            persona.CalcularIMC();
            persona.EsMayorDeEdad();

            Console.ReadKey();
        }
    }


