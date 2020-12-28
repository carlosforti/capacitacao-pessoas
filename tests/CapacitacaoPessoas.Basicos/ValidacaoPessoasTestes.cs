using CapacitacaoPessoas.Basico.Exercicios;
using FluentAssertions;
using Xunit;

namespace CapacitacaoPessoas.Basicos.Tests
{
    public class ValidacaoPessoasTestes
    {
        [Fact]
        public void ValidarPessoas_DeveRetornarFalso_QuandoPessoaIncompleta()
        {
            var pessoaA = new Pessoa("José", "Silva", "São Paulo/SP", "josesilva@josesilva.com.br");
            var pessoaB = new Pessoa("João", "", "", "");

            var validarPessoas = new ValidacaoPessoas();

            var resultado = validarPessoas.ValidarPessoas(pessoaA, pessoaB);

            resultado.Should().BeFalse();
        }

        [Fact]
        public void ValidarPessoas_DeveRetornarVerdadeiro_QuandoPessoasCompletas()
        {
            var pessoaA = new Pessoa("José", "Silva", "São Paulo/SP", "josesilva@josesilva.com.br");
            var pessoaB = new Pessoa("José", "Silva", "São Paulo/SP", "josesilva@josesilva.com.br");

            var validarPessoas = new ValidacaoPessoas();

            var resultado = validarPessoas.ValidarPessoas(pessoaA, pessoaB);

            resultado.Should().BeTrue();
        }
    }
}