using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraBasica
    {
        /// <summary>
        /// Soma o primeiro valor com o segundo valor
        /// </summary>
        /// <param name="numero1">primeiro valor</param>
        /// <param name="numero2">segundo valor</param>
        /// <returns>soma dos valores</returns>
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        /// <summary>
        /// Subtrai do primeiro valor o segundo valor
        /// </summary>
        /// <param name="numero1">primeiro valor</param>
        /// <param name="numero2">segundo valor</param>
        /// <returns>diferenca dos valores</returns>
        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        
        /// <summary>
        /// Multiplica o primeiro valor pelo segundo valor
        /// </summary>
        /// <param name="numero1">primeiro valor</param>
        /// <param name="numero2">segundo valor</param>
        /// <returns>Multiplicacao dos valores</returns>
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        /// <summary>
        /// Divide o primeiro valor pelo segundo valor
        /// </summary>
        /// <param name="numero1">primeiro valor</param>
        /// <param name="numero2">segundo valor</param>
        /// <returns>Divisao dos valores</returns>
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        /// <summary>
        /// Divide o primeiro valor pelo segundo valor
        /// </summary>
        /// <param name="numero1">primeiro valor</param>
        /// <param name="numero2">segundo valor</param>
        /// <returns>O resto da divisao dos valores</returns>
        public int CalcularResto(int numero1, int numero2)
        {
            return numero1 % numero2;
        }
    }
}