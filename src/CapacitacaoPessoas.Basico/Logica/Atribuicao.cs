namespace CapacitacaoPessoas.Basico.Logica
{
    /*
     * Atribuição é quando definimos um valor para um campo ou variável
     */
    public class Atribuicao
    {
        private readonly int valorInteiro;
        private readonly string valorString;

        public Atribuicao(int valorInteiro, string valorString)
        {
            //Atribuição de um valor string
            this.valorString = valorString;
            // Atribuição de um valor inteiro
            this.valorInteiro = valorInteiro;

            // Declaração de uma variável
            int valorInteiro2;
            // Atribuição de um valor para a variável
            valorInteiro2 = 10;
        }
    }
}