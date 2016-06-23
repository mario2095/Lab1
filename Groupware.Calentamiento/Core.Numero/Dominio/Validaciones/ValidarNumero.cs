using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        public bool ElNumeroEsValidoEnLaBase (string elNumero, int laBase)
        {
            bool elResultado = true;
            for (int i = 0; (elResultado == true) & (i < elNumero.Length); i++)
            {
                elResultado = ElDigitoEsValidoEnLaBase(elNumero, laBase);
            }
            return (elResultado);
        }

        public bool ElDigitoEsValidoEnLaBase (string elDigito, int laBase)
        {
            bool elResultado=false;

            
            switch (laBase)
            {
                case 2:
                    
                    break;
                case 4:
                    
                    break;
                case 8:
                    
                    break;
                case 16:
                    
                case 32:
                    //elResultado =ValidaBase32.Equals.
                    break;
                default:
                    elResultado = false;
                    break;
            }
            
            return (elResultado);

        }
    }
}
