namespace CapacitacaoPessoas.Basico.Classes
{
    /// <summary>
    /// Classe com as estruturas básicas
    /// </summary>
    public class SuperClasse
    {
        //Esta é a declaração de um campo dentro da classe
        private int valorInteiro;

        /// <summary>
        /// Esta é uma propriedade de valor do tipo inteiro, permitindo o acesso ao campo valorInteiro
        /// </summary>
        public int ValorInteiro
        {
            get { return valorInteiro; }
            set { valorInteiro = value; }
        }

        ///<summary>
        /// Esta é uma propriedade apenas para leitura, e seu valor não pode ser modificado.
        ///<summary>
        public string ValorStringReadOnly { get { return valorInteiro.ToString(); } }

        /// <summary>
        /// Esta é uma propriedade do tipo auto-property, sem a necessidade de um campo
        /// </summary>
        public string ValorString { get; set; }
        
        /// <summary>
        /// Construtor da classe, com os parâmetros necessários para a construção das propriedades já preenchidas
        /// </summary>
        /// <param name="valorInteiro">Valor a ser atribuido ao campo valorInteiro</param>
        /// <param name="valorString">Valor a ser atrubuido ao parâmetro ValorString</param>
        public SuperClasse(int valorInteiro, string valorString)
        {
            this.valorInteiro = valorInteiro;
            this.ValorString = valorString;
        }

        /// <summary>
        /// Construtor da classe, sem parâmetros
        /// </summary>
        public SuperClasse()
        {
            var acessos = new Acessos();
            acessos.MetodoInternal();
            acessos.MetodoPublic();
            acessos.MetodoProtectedInternal();

            var acessosChild = new AcessosChild();
            acessosChild.MetodoInternal();
            acessosChild.MetodoPublic();
            acessosChild.MetodoProtectedInternal();
        }

        ///<summary>
        /// Declaraçao de um método na classe
        ///</summary>
        public string ExibirValores(){
            return $@"
            ValorInteiro: {valorInteiro}
            ValorString: {ValorString}";
        }
    }
}