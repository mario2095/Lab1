using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    class deDecimalaBase32
    {

        static public string deBase10aBase32(int elNumero)

        {
            int i = 1, j, temp = 0;
            char[] hexadecimalNum = new char[100];
            char temp1;
            string resultado = "";
            while (elNumero != 0)
            {
                temp = elNumero % 32;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNum[i++] = temp1;
                elNumero = elNumero / 32;
            }
            
            for (j = i - 1; j > 0; j--)
                resultado =resultado+(hexadecimalNum[j]);
            return (resultado);
        }

       
    }
}
