using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio01.Entidades;

namespace Laboratorio01.Negocio
{
    public class ClsPersona
    
    {
        public string CalcularIMC(Persona per)
        {
            double Promedio = per.Peso / Math.Pow(per.Altura, 2);

            if(Promedio > 25)
            {
                return $"Tiene sobre peso";
            }
            else
            {
                return $"Tiene un peso ideal";
            }
        }
        public String MayorDeEdad(Persona per)
        {       
            if(per.Edad >= 18)
            {    
                return $"Es mayor de edad";
            }
            else
            {       
                return $"Es mayor de edad";
            }
        }
    }
}

