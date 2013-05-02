using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorClass
{
    public class Error
    {
        public double Eact { get; set; }
        public double Eant { get; set; }
        public double error;

        public Error() { }

        public Error(double a, double b)
        {
            this.Eant = a;
            this.Eact = b;
        }


        public void SetErrors(double a, double b)
        {
            this.Eant = a;
            this.Eact = b;
        }

        public double CalculateError()
        {

            //aproximacion actual, aproximacion anterior.
            double ERP = 0;

            if (this.Eact == this.Eant)
            {
                return 0; //no calcules si son los mismos valores.
            }
            else
            {
                if (this.Eact == 0) { this.Eact = 0.0000001; } //por si division entre 0...
                ERP = Math.Abs((this.Eact - this.Eant) / this.Eact);

            }
            return ERP * 100;
        } //end CalculateError


    }
}
