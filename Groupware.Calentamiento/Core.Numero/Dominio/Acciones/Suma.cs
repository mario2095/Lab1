using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Suma
    {
        public Numero Operar (Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado = null;
            var validarBases = new Validaciones.ValidarBase();
            if (validarBases.LasDosBasesSonIguales (elPrimerNumero, elSegundoNumero))
            { 
                double elResultadoNumerico = (elPrimerNumero.elNumeroEnDecimal + elSegundoNumero.elNumeroEnDecimal);
                resultado= new Numero(elResultadoNumerico.ToString(), elPrimerNumero.laBase);
            }
            return (resultado);

        }
    }
}
