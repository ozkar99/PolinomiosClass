using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomiosClass
{
    public class Integral : Polinomios
    {

        public int limInf { get; set; } //limite inferior
        public int limSup { get; set; } //limite superior
        public int N { get; set; }
        public int h { get; set; }

        /*constructores:*/
        public Integral() { }
        public Integral(string s, string z, string x, string y)
        {
            this.eq = this.ParseEquation(s);
            this.SetLimits(z);

            int buf = 0;

            int.TryParse(x, out buf);
            this.N = buf;

            int.TryParse(y, out buf);
            this.h = buf;


        }

        /* metodo interno para setear limites de la integral: */
        private void SetLimits(string s)
        {
            int izq = 0, der = 0;

            string[] words = s.Split('/');

            int.TryParse(words[0], out izq);
            int.TryParse(words[1], out der);

            this.limInf = izq;
            this.limSup = der;

        }


        public double Trapezios()
        {
            /*tomando N y h como numero de pasos y delta x calcular trapecios cool stuff podemos usar this.CaclculateEquation para sacar f(x)*/
            double x = 0;

            return x;
        }

        public double Integrar()
        {
            /*esta funcion es un wrapper, tal como GetRoot es el wrapper en Roots.
             *probablemente (prob) solo saque lo que regresa trapezios*/
            return this.Trapezios();
        }


    }
}
