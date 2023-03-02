// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Laboratorio01.Entidades;
using Laboratorio01.Negocio;

Persona per = new Persona();
ClsPersona clsPersona = new ClsPersona();

Console.Write(@"Bienvenido a su calculador de IMC

ingrese los siguientes datos para continuar

ingrese su nombre -> ");
per.Nombre = Console.ReadLine();

Console.Write("\nIngrese su edad -> ");
per.Edad = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese su Sexo -> ");
per.Sexo = Console.ReadLine();

Console.Write("\nIngrese su peso en KG -> ");
per.Peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nIngrese su altura en metros -> ");
per.Altura = Convert.ToDouble(Console.ReadLine());

Console.Write($@"
Nombre: {per.Nombre} edad: {per.Edad} sexo: {per.Sexo}

Peso: {per.Sexo}

Altura: {per.Altura}

Usted {clsPersona.CalcularIMC(per)}

Usted {clsPersona.MayorDeEdad(per)}");

    
     

