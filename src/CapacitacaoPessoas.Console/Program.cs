using CapacitacaoPessoas.Basico.Classes;
using CapacitacaoPessoas.Basico.EstruturasCondicionaisIteracao;
using CapacitacaoPessoas.Basico.InterfacesEClasses;
using CapacitacaoPessoas.Basico.Logica;
using CapacitacaoPessoas.Basico.LogicaBooleana;
using Microsoft.Extensions.DependencyInjection;
using Csl = System.Console;

namespace CapacitacaoPessoas.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IClasseComInterface, ClasseComInterface>()
                .BuildServiceProvider();

            var acessos = new Acessos();
            acessos.MetodoPublic();

            var acessosChild = new AcessosChildConsole();
            acessosChild.MetodoPublic();

            #region Condicionais e Iteracao

            Csl.WriteLine("Condicionais");
            var condicionais = new Condicionais();
            condicionais.UsandoIf(1, 2);
            condicionais.UsandoIfElse(1, 2);
            condicionais.OperadorTernario(1, 2);
            Csl.WriteLine("=".PadLeft(80, '='));

            Csl.WriteLine("Iterações");
            var iteracoes = new Iteracao();
            Csl.WriteLine("While");
            iteracoes.UsandoWhile();
            Csl.WriteLine();
            Csl.WriteLine("Do...While");
            iteracoes.UsandoDoWhile();
            Csl.WriteLine();
            Csl.WriteLine("For");
            iteracoes.UsandoFor();
            Csl.WriteLine();
            Csl.WriteLine("ForEach");
            iteracoes.UsandoForEach();
            Csl.WriteLine("=".PadLeft(80, '='));
            Csl.WriteLine();

            #endregion

            #region Lógica Booleana

            Csl.WriteLine("Lógica booleana");
            var logicaBooleana = new LogicaBooleana();
            Csl.WriteLine("And");
            logicaBooleana.OperadorAnd();
            Csl.WriteLine();
            Csl.WriteLine("Or");
            logicaBooleana.OperadorOr();
            Csl.WriteLine();
            Csl.WriteLine("Xor");
            logicaBooleana.OperadorXor();
            Csl.WriteLine();
            Csl.WriteLine("Not");
            logicaBooleana.OperadorNot();
            Csl.WriteLine("=".PadLeft(80, '='));
            Csl.WriteLine();

            #endregion

            #region Herança

            Csl.WriteLine("Herança");
            var superClasse = new SuperClasse(1, "String");
            var classeHeradada = new ClasseHeradada
            {
                ValorInteiro = 100,
                ValorString = "Herança"
            };

            Csl.WriteLine(superClasse.ExibirValores());
            Csl.WriteLine(classeHeradada.ExibirValores());
            Csl.WriteLine(classeHeradada.ExibirValoresHeranca());
            Csl.WriteLine("=".PadLeft(80, '='));
            Csl.WriteLine();

            #endregion

            #region Classe usando interface (Injeção de Dependência)

            Csl.WriteLine("Injeção de dependência");
            var interface1 = serviceProvider.GetService<IClasseComInterface>();
            if (interface1 != null)
            {
                interface1.Nome = "Carlos";
                interface1.Sobrenome = "Forti";
                Csl.WriteLine(interface1.NomeCompleto());
                Csl.WriteLine("=".PadLeft(80, '='));   
            }

            #endregion

            #region Métodos

            var endereco1 = new Endereco("12345678", "Rua das Flores", "100", null, "Limoeiro", "São Paulo", "SP");
            var endereco2 = new Endereco("12345678", "Rua das Flores", "1000", null, "Limoeiro", "São Paulo", "SP");

            var metodos = new Metodos();
            var resultado1 = metodos.ValidarEnderecos1(endereco1, endereco2);
            var resultado2 = metodos.ValidarEnderecos2(endereco1, endereco2);

            Csl.WriteLine($"Resultado1: {resultado1}");
            Csl.WriteLine($"Resultado2: {resultado2}");
            
            #endregion
        }
    }
}