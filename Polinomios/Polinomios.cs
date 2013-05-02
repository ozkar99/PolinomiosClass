using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PolinomiosClass
{
    public class Polinomios
    {
        
        public Polinomios() { }                

        public Polinomios(string s)
        {
            eq = this.ParseEquation(s);
        }

        public double[] eq {get; set;} //polinomio       

        //puedes mandar o no equ
        public double CalculateEquation(double x)
        {
            //vector de la ecuacion en reversa, valor de x.
            //esta funcion calcula el valor de la ecuacion.

            double value = 0; //valor de la ecuacion
            int n = (this.eq.Length - 1); //longitud de e arreglo, orden n-1

            for (int i = n; i >= 0; i--)
            {
                value += this.eq[i] * Math.Pow(x, i); // sumatoria de Ai*x^i
            }
            return value;
        }//end CalculateEquation

        public double CalculateEquation(double[] equ, double x)
        {
            //vector de la ecuacion en reversa, valor de x.
            //esta funcion calcula el valor de la ecuacion.

            double value = 0; //valor de la ecuacion
            int n = (equ.Length - 1); //longitud de e arreglo, orden n-1

            for (int i = n; i >= 0; i--)
            {
                value += equ[i] * Math.Pow(x, i); // sumatoria de Ai*x^i
            }
            return value;
        }//end C

       //con equ y sin equ especificados.
       public double[] DerivateEquation( )
        {
            //vector inverso de coeficientes.
            //esta funcion regresa los coeficientes para la derivada de la funcion

            int order = this.eq.Length - 1;
            double[] DerEq = new double[order];

            for (int i = order; i > 0; i--)
            {
                DerEq[i - 1] = this.eq[i] * i; //aEcDer(i-1) = aEcOrig(i)*i
            }

            return DerEq;
            //lo bello de esto es que podemos usar este vector en la funcion de CalculateEquation

        }//end DerivateEquation

       public double[] DerivateEquation(double[] equ)
       {
           //vector inverso de coeficientes.
           //esta funcion regresa los coeficientes para la derivada de la funcion

           int order = equ.Length - 1;
           double[] DerEq = new double[order];

           for (int i = order; i > 0; i--)
           {
               DerEq[i - 1] = equ[i] * i; //aEcDer(i-1) = aEcOrig(i)*i
           }

           return DerEq;
           //lo bello de esto es que podemos usar este vector en la funcion de CalculateEquation

       }//end DerivateEquation

        //esta es de awebo, y es lo que se usa normalmente.
        public double[] ParseEquation(String stringEquation)
        {
            //parte el string de la ecuacion, en un vector de coeficientes inversos.
            //es decir: donde el indice es su exponente.

            String pattern = @"[X|x]\^*\d*";
            String comaString = Regex.Replace(stringEquation, pattern, ","); //quitar X^exp y sustituir por , 

            String[] arrayString = Regex.Split(comaString, ",");
            double[] equation = new double[arrayString.Length];

            for (int i = arrayString.Length - 1; i >= 0; i--)
            {
                double.TryParse(arrayString[i], out equation[i]); //convert from string to double.             
            }

            Array.Reverse(equation);//reverse the array to the form where index = exponential
            return equation;

        }//end ParseEquati
    
    }
}
