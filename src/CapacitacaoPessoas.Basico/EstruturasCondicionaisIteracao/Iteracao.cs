using Csl = System.Console;

namespace CapacitacaoPessoas.Basico.EstruturasCondicionaisIteracao
{
    public class Iteracao
    {
        private readonly int[] valores = new[] { 1, 2, 3, 4, 5, 6, 7 };

        public void UsandoWhile()
        {
            var index = 0;

            while (index < valores.Length)
            {
                var valor = valores[index];
                Csl.WriteLine(valor * 2);
                index++;
            }
        }

        public void UsandoDoWhile()
        {
            var index = 0;

            do
            {
                var valor = valores[index];
                Csl.WriteLine(valor * 2);
                index++;
            } while (index < valores.Length);
        }

        public void UsandoFor()
        {
            for (var index = 0; index < valores.Length; index++)
            {
                Csl.WriteLine(valores[index] * 2);
            }
        }

        public void UsandoForEach()
        {
            foreach (var valor in valores)
            {
                Csl.WriteLine(valor * 2);
            }
        }
    }
}