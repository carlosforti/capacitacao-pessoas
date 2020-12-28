namespace CapacitacaoPessoas.Basico.Tipos
{
    /// <summary>
    /// Tipos de dados utilizados em C#
    /// <para>Referência: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types</para>
    /// </summary>
    public class Tipos
    {
        /// <summary>
        /// Tipo inteiro com sinal
        /// <para>Varia entre -2.147.483.648 a 2.147.483.647</para>
        /// </summary>
        private int valorInteiro;

        /// <summary>
        /// Tipo inteiro com sinal
        /// <para>Varia entre -2.147.483.648 a 2.147.483.647</para>
        /// </summary>
        public int ValorInteiro
        {
            get { return valorInteiro; }
            set { valorInteiro = value; }
        }

        /// <summary>
        /// Tipo decimal com sinal
        /// <para>Varia entre ±1.0x10^28 to ±7.9228x10^28</para>
        /// </summary>
        private decimal valorDecimal;

        /// <summary>
        /// Tipo decimal com sinal
        /// <para>Varia entre ±1.0x10^28 to ±7.9228x10^28</para>
        /// </summary>
        public decimal ValorDecimal
        {
            get { return valorDecimal; }
            set { valorDecimal = value; }
        }

        /// <summary>
        /// Tipo booleano (verdadeiro / falso)
        /// </summary>
        private bool valorBooleano;

        /// <summary>
        /// Tipo booleano (verdadeiro / falso)
        /// </summary>
        public bool ValorBooleano
        {
            get { return valorBooleano; }
            set { valorBooleano = value; }
        }

        /// <summary>
        /// Tipo string (texto)
        /// </summary>
        private string valorString;

        /// <summary>
        /// Tipo string (texto)
        /// </summary>
        public string ValorString
        {
            get { return valorString; }
            set { valorString = value; }
        }
    }
}