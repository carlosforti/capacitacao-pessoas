namespace CapacitacaoPessoas.Basico.InterfacesEClasses
{
    ///<summary>
    /// Uma interface é usada para definir métodos e/ou propriedades para serem implementados em uma class
    ///<para>Na convenção de nomeclatura da linguagem, a interface começa com um "I"</para>
    ///<para>Referência: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/interfaces/</para>
    ///</summary>
    public interface IClasseComInterface
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Sobrenome { get; set; }
        System.DateTime DataNascimento { get; set; }
        string NomeCompleto();
        int Idade();
    }
}