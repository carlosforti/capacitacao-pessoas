using System;
using CapacitacaoPessoas.Basico.Classes;
using CapacitacaoPessoas.Basico.EstruturasCondicionaisIteracao;
using CapacitacaoPessoas.Basico.InterfacesEClasses;
using CapacitacaoPessoas.Basico.Logica;
using CapacitacaoPessoas.Basico.LogicaBooleana;
using Microsoft.Extensions.DependencyInjection;

namespace CapacitacaoPessoas.ConsoleRun
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

            Console.WriteLine("Condicionais");
            var condicionais = new Condicionais();
            condicionais.UsandoIf(1, 2);
            condicionais.UsandoIfElse(1, 2);
            condicionais.OperadorTernario(1, 2);
            Console.WriteLine("=".PadLeft(80, '='));

            Console.WriteLine("Iterações");
            var iteracoes = new Iteracao();
            Console.WriteLine("While");
            iteracoes.UsandoWhile();
            Console.WriteLine();
            Console.WriteLine("Do...While");
            iteracoes.UsandoDoWhile();
            Console.WriteLine();
            Console.WriteLine("For");
            iteracoes.UsandoFor();
            Console.WriteLine();
            Console.WriteLine("ForEach");
            iteracoes.UsandoForEach();
            Console.WriteLine("=".PadLeft(80, '='));
            Console.WriteLine();

            #endregion

            #region Lógica Booleana

            Console.WriteLine("Lógica booleana");
            var logicaBooleana = new LogicaBooleana();
            Console.WriteLine("And");
            logicaBooleana.OperadorAnd();
            Console.WriteLine();
            Console.WriteLine("Or");
            logicaBooleana.OperadorOr();
            Console.WriteLine();
            Console.WriteLine("Xor");
            logicaBooleana.OperadorXor();
            Console.WriteLine();
            Console.WriteLine("Not");
            logicaBooleana.OperadorNot();
            Console.WriteLine("=".PadLeft(80, '='));
            Console.WriteLine();

            #endregion

            #region Herança

            Console.WriteLine("Herança");
            var superClasse = new SuperClasse(1, "String");
            var classeHeradada = new ClasseHeradada
            {
                ValorInteiro = 100,
                ValorString = "Herança"
            };

            Console.WriteLine(superClasse.ExibirValores());
            Console.WriteLine(classeHeradada.ExibirValores());
            Console.WriteLine(classeHeradada.ExibirValoresHeranca());
            Console.WriteLine("=".PadLeft(80, '='));
            Console.WriteLine();

            #endregion

            #region Classe usando interface (Injeção de Dependência)

            Console.WriteLine("Injeção de dependência");
            var interface1 = serviceProvider.GetService<IClasseComInterface>();
            if (interface1 != null)
            {
                interface1.Nome = "Carlos";
                interface1.Sobrenome = "Forti";
                Console.WriteLine(interface1.NomeCompleto());
                Console.WriteLine("=".PadLeft(80, '='));
            }

            #endregion

            #region Métodos

            var endereco1 = new Endereco("12345678", "Rua das Flores", "100", null, "Limoeiro", "São Paulo", "SP");
            var endereco2 = new Endereco("12345678", "Rua das Flores", "1000", null, "Limoeiro", "São Paulo", "SP");

            var metodos = new Metodos();
            var resultado1 = metodos.ValidarEnderecos1(endereco1, endereco2);
            var resultado2 = metodos.ValidarEnderecos2(endereco1, endereco2);

            Console.WriteLine($"Resultado1: {resultado1}");
            Console.WriteLine($"Resultado2: {resultado2}");

            #endregion
        }
    }
}