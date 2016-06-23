using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    class deBase32aDecimal
    {
        
        static public int deBase32aBase10(string elNumero)

        {
            char[] Palabra = elNumero.ToCharArray();
            int resultado = 0;
            uint contador = 0;

            for (int i = Palabra.Length - 1; i > -1; i--, contador++)
            {
                int coeficiente = char_to_int(Palabra[i]);
                int base_mult = IntPow(32, contador); 
                resultado += (coeficiente * base_mult);
            }
            return (resultado);
        }

        public static int char_to_int(char c)
        {
            int intval = (int)c;
            int ret = 0;

            if ((intval >= 48) && (intval <= 57))
            {
                /* Un # */
                ret = (int)(intval - 48);
            }
            else if ((intval >= 65) && (intval <= 90))
            {
                /* Una letra */
                ret = (int)(intval - 55);
            }

            return ret;
        }


        public static int IntPow(int x, uint pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

    }

}

