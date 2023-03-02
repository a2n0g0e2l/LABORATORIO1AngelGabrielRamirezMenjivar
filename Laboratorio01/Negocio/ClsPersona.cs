using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio01.Entidades;

namespace Laboratorio01.Negocio
{
    public class ClsPersona
    {
      
    
        // Atributos
        private string nombre;
        private int edad;
        private char sexo;
        private double peso;
        private double altura;

        // Constructor
        public ClsPersona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        // Métodos
        public double CalcularIMC()
        {
            double imc = peso / Math.Pow(altura, 2);

            if (imc < 24)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc > 25)
            {
                Console.WriteLine("Tiene sobrepeso");
            }

            return imc;
        }

        public bool EsMayorDeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
                return true;
            }
            else
            {
                Console.WriteLine("Es menor de edad");
                return false;
            }
        }
    }
}

