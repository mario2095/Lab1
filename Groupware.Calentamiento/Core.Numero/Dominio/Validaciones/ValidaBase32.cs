using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidaBase32
    {
        public bool ElNumeroEsBase32(string elNumero)
        {
            string especiales = "wxyzWXYZ";
            bool elResultado = true;
            for (int i = 0; i <= elNumero.Length + 2; i++)
            {
                string cespecial = especiales.Substring(i, 1);
                int encontro = elNumero.IndexOf(cespecial);
                if (encontro >= 0)
                {
                    elResultado = false;
                }
            }
            return (elResultado);
        }
    }
}
