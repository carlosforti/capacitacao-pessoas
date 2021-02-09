﻿using System;
using System.Linq;

namespace CapacitacaoPessoas.Basico.Exercicios
{
    //Implementar os quatro métodos
    public class LogicaBasica
    {
        /// <summary>
        /// Encontrar o maior valor encontrado em um array
        /// </summary>
        /// <param name="valores">Array de inteiros para a pesquisa</param>
        /// <returns>Maior valor encontrado</returns>
        public int EncontrarMaiorValor(int[] valores)
        {
            int maiorValor = 0;
            int index = 0;

            while (index < valores.Length)
            {
                int valor = valores[index];

                if (valor > maiorValor)
                    maiorValor = valor;

                index = index + 1;
            }

            return maiorValor;

        }

        /// <summary>
        /// Encontrar o menor valor encontrado em um array
        /// </summary>
        /// <param name="valores">Array de inteiros para a pesquisa</param>
        /// <returns>Menor valor encontrado</returns>
        public int EncontrarMenorValor(int[] valores)
        {
            int menorValor = 999999;

            for (int index = 0; index < valores.Length; index++)
            {
                int valor = valores[index];

                if (valor < menorValor)
                    menorValor = valor;
            }
            return menorValor;
        }

        /// <summary>
        /// Retorna a soma dos valores de um array
        /// </summary>
        /// <param name="valores">Array de inteiro com valores para a soma</param>
        /// <returns>Soma dos valores do array</returns>
        public int SomarValores(int[] valores)
        {
            int somarValores = 0;

            for (int index = 0; index < valores.Length; index++)
            {
                int valor = valores[index];

                somarValores += valor;
            }
            return somarValores;
        }

        /// <summary>
        /// Retorna a subtração dos valores do array
        /// <para>Ex.: valor[0] - valor[1] - valor[2]</para>
        /// </summary>
        /// <param name="valores">Array de inteiros com os valores para a subtracao</param>
        /// <returns>Subtração dos valores do array</returns>
        public int SubtrairValores(int[] valores)
        {
            int resultado = valores[0];


            for (int contador = 1; contador < valores.Length; contador++)
            {
                resultado = resultado - valores[contador];
            }
            return resultado;

            

        }
    }
}