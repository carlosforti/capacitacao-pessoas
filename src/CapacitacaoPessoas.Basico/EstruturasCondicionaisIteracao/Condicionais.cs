using Csl = System.Console;

namespace CapacitacaoPessoas.Basico.EstruturasCondicionaisIteracao
{
    public class Condicionais
    {
        public void UsandoIfElse(int valor1, int valor2)
        {
            if (valor1 > valor2)
                Csl.WriteLine($"{valor1} é maior que {valor2}");
            else if (valor2 > valor1)
                Csl.WriteLine($"{valor2} é maior que {valor1}");
            else if (valor1 == valor2)
                Csl.WriteLine($"{valor2} é igual a {valor1}");
        }

        public void UsandoIf(int valor1, int valor2)
        {
            if (valor1 > valor2)
                Csl.WriteLine($"{valor1} é maior que {valor2}");
            if (valor2 > valor1)
                Csl.WriteLine($"{valor2} é maior que {valor1}");
            if (valor1 == valor2)
                Csl.WriteLine($"{valor2} é igual a {valor1}");
        }

        public void OperadorTernario(int valor1, int valor2)
        {
            var maior = valor1 > valor2 ? valor1 : valor2;
            Csl.WriteLine($"O maior valor é {maior}");
        }
    }
}