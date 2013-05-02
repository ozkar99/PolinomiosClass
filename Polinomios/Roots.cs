using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorClass;


namespace PolinomiosClass
{
    public class Roots : Polinomios
    {

        public Roots() { }

        public Roots(string s)
        {
            this.eq = this.ParseEquation(s);
        }
        
        public Error myError = new Error();
        

        public double NewtonRaphsonImproved(double x)
        {
            double[] equation = this.eq;
            //ecuacion de coeficientes, valor de x
            double xi = 0;

            double fx = this.CalculateEquation(x);
            double pfx = this.CalculateEquation(this.DerivateEquation(), x); //prima
            double ppfx = this.CalculateEquation(this.DerivateEquation(this.DerivateEquation()), x); //biprima

            //pfx = f'(x)
            //ppfx = f''(x)
            //xi+1 = xi - (f(x)f'(x)/ ((f'(x)^2) - f(x)f''(x));           
            xi = x - ((fx * pfx) / ((pfx * pfx) - (fx * ppfx)));

            return xi;
        }//end NewtonRaphsonImproved   


        public double GetRoot(double error, double aprox)
        {            
            //vector de coeficientes, error esperado, primera aproximacion.
            bool raiz = false;//raiz falsa por default            
            double ERP = 100; //default error es 100%            

            while (raiz != true)//mientras no hay raiz:
            {

                myError.Eact = this.NewtonRaphsonImproved(aprox); //si improved esta true, usamos el metodo mejorado.               
                ERP = myError.CalculateError(); //calculamos el error relativo porcentual.

                if (ERP <= error)
                {
                    raiz = true; //tenemos raiz cuando erp <= error esperado                    
                    return myError.Eact;
                }

                myError.Eant = myError.Eact; //la raiz anterior, es la actual.
            }

            return myError.Eact;

        }//end GetRoot

    }

}
