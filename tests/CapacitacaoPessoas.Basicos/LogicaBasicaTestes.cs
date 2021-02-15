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

        [Fact]
        public void QuantidadePessoasComMaioridade()
        {
            var resultado = logicaBasica.QuantidadePessoasComMaioridade(valores, 18);
            var esperado = 2;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void SomarNumerosImpares()
        {
            var resultado = logicaBasica.SomarNumerosImpares(1, 30);
            var esperado = 225;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void QuantidadeNumerosPares()
        {
            var resultado = logicaBasica.QuantidadeNumerosPares(valores);
            var esperado = 2;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void QuantidadeNumerosImpares()
        {
            var resultado = logicaBasica.QuantidadeNumerosImpares(valores);
            var esperado = 5;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void CalcularDuracaoJogo()
        {
            var resultado = logicaBasica.CalcularDuracaoJogo(19, 2);
            var esperado = 7;

            resultado.Should().Be(esperado);
        }

        [Fact]
        public void CalcularSalario()
        {
            var horasTrabalhadasMes = 181;
            decimal valorHora = 12.50M;

            var resultado = logicaBasica.CalcularSalario(horasTrabalhadasMes, valorHora);
            var esperado = 2393.75M;

            resultado.Should().Be(esperado);
        }
    }
}