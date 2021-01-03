namespace CapacitacaoPessoas.Basico.Exercicios
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, string cidade, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cidade = cidade;
            Email = email;
        }

        public string Nome { get; }
        public string Sobrenome { get; }
        public string Cidade { get; }
        public string Email { get; }
    }

    public class ValidacaoPessoas
    {
        /// <summary>
        /// Dado duas pessoas, validar se as informações delas estão preenchidas
        /// <para>Caso uma delas esteja incorreta, retorna falso</para>
        /// <para>Senão, retorna verdadeiro</para>
        /// </summary>
        /// <param name="pessoaA">Primeira pessoa a ser validada</param>
        /// <param name="pessoaB">Segunda pessoa a ser validada</param>
        /// <returns>Verdadeiro para todas as pessoas corretas, senão falso</returns>
        public bool ValidarPessoas(Pessoa pessoaA, Pessoa pessoaB)
        {
            //TODO: Refatorar o método, a fim de reduzir a complexidade
            bool estaValido = true;

            if (string.IsNullOrWhiteSpace(pessoaA.Nome) || string.IsNullOrWhiteSpace(pessoaA.Sobrenome) ||
                string.IsNullOrWhiteSpace(pessoaA.Cidade) || string.IsNullOrWhiteSpace(pessoaA.Email))
                estaValido = false;

            if (string.IsNullOrWhiteSpace(pessoaB.Nome) || string.IsNullOrWhiteSpace(pessoaB.Sobrenome) ||
                string.IsNullOrWhiteSpace(pessoaB.Cidade) || string.IsNullOrWhiteSpace(pessoaB.Email))
                estaValido = false;

            return estaValido;
        }
    }
}