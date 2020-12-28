using System;

namespace CapacitacaoPessoas.Basico.InterfacesEClasses
{
    ///<summary>
    /// Implementação da inteface IClasseComInterface
    ///</summary>
    public class ClasseComInterface : IClasseComInterface
    {
        public int Id { get ; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }

        public string NomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}