using CapacitacaoPessoas.Basico.Exercicios;
using FluentAssertions;
using Xunit;

namespace CapacitacaoPessoas.Basicos.Tests
{
    public class EstruturasRepeticaoTestes
    {
        private readonly int[] valores = new[] { 3, 18, 10, 33, 7, 50, 6 };
        private readonly EstruturasRepeticao estruturaRepeticao = new EstruturasRepeticao();

        [Fact]
        public void QuantidadePessoasComMaioridade()
        {
            var resultado = estruturaRepeticao.QuantidadePessoasComMaioridade(valores, 18);
            var esperado = 3;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void SomarNumerosImpares()
        {
            var resultado = estruturaRepeticao.SomarNumerosImpares(1, 30);
            var esperado = 184;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void QuantidadeNumerosPares()
        {
            var resultado = estruturaRepeticao.QuantidadeNumerosPares(valores);
            var esperado = 4;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void QuantidadeNumerosImpares()
        {
            var resultado = estruturaRepeticao.QuantidadeNumerosImpares(valores);
            var esperado = 3;

            resultado.Should().Be(esperado);
        }
    }
}