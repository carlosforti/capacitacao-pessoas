namespace CapacitacaoPessoas.Basico.Logica
{
    public class Endereco
    {
        public Endereco(string cep,
            string logradouro,
            string numero,
            string complemento,
            string bairro,
            string cidade,
            string estado)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string Cep { get; }
        public string Logradouro { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }
    }

    /*
     * Um método é um bloco de código que só é executando quando chamado.
     * São usados para executar ações, e também são chamados de funções.
     * Você pode passar dados para ele, que são conhecidos como parâmetros.
     */
    public class Metodos
    {
        /*
         * O método abaixo tem sua assinatura definida da seguinte forma
         * public   bool   ValidarEnderecos1 (Endereco endereco1, Endereco endereco2)
         * |Acesso-|-Tipo-|-----Nome--------|--------------- Parâmetros -------------|
         * Onde:
         * Acesso: define o nível de acesso do método (Ver a classe Classes/Acessos.cs)
         * Tipo: Tipo de retorno do método, podendo ser um tipo primitivo, uma estrutura, ou void
         * Nome: Nome do método, que será usado no momento que for chamado
         * Parâmetros: são os dados que são enviados para o método utilizar
         */
        public bool ValidarEnderecos1(Endereco endereco1, Endereco endereco2)
        {
            var estaValido = true;

            if (string.IsNullOrEmpty(endereco1.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Estado))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Estado))
                estaValido = false;

            return estaValido;
        }

        public bool ValidarEnderecos2(Endereco endereco1, Endereco endereco2)
        {
            var estaValido = true;

            if (!ValidarEndereco(endereco1))
                estaValido = false;

            if (!ValidarEndereco(endereco2))
                estaValido = false;

            return estaValido;
        }

        private bool ValidarEndereco(Endereco endereco)
        {
            var estaValido = true;

            if (string.IsNullOrEmpty(endereco.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Estado))
                estaValido = false;

            return estaValido;
        }
    }
}