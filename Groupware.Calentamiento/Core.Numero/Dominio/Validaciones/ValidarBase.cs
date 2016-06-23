using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool LaBaseEstaEnElIntervaloCorrecto (int laBase)
        {
            bool resultado=false;
            string especiales = "0204081632";

            if ((2 <= laBase) & (laBase <= 32))
            {
                for (int i = 0; i <= 10; i = i + 2)
                {
                    string cespecial = especiales.Substring(i, 2);

                    if (laBase == Int32.Parse(cespecial))
                    {
                        resultado = true;
                        break;
                    }
                }
            }
            else
            {
                resultado = false;
            }            

            return (resultado);
        }

        public bool LasDosBasesSonIguales (Numero elPrimerNumero, Numero elSegundoNumero)
        {
            bool resultado;
            resultado = (elPrimerNumero.laBase == elSegundoNumero.laBase);
            return (resultado);
        }
    }
}
