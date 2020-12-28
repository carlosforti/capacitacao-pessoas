using CapacitacaoPessoas.Basico.Exercicios;

using FluentAssertions;

using Xunit;

namespace CapacitacaoPessoas.Basicos.Tests
{
    public class LogicaBasicaTestes
    {
        private readonly int[] valores = new[] { 51, 23, 14, 13, 1, 3, 10 };
        private readonly LogicaBasica logicaBasica = new LogicaBasica();

        [Fact]
        public void EncontrarMaior()
        {
            var resultado = logicaBasica.EncontrarMaiorValor(valores);
            var esperado = 51;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void EncontrarMenor()
        {
            var resultado = logicaBasica.EncontrarMenorValor(valores);
            var esperado = 1;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void SomarValores()
        {
            var resultado = logicaBasica.SomarValores(valores);
            var esperado = 115;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void SubtrairValores()
        {
            var resultado = logicaBasica.SubtrairValores(valores);
            var esperado = -13;

            resultado.Should().Be(esperado);
        }
    }
}