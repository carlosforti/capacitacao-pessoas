namespace CapacitacaoPessoas.Basico.Classes
{
    ///<summary>
    ///Esta classe herda da classe ClasseBasica.
    ///<para>Com isso, todas as propriedade e métodos já existem nela, sem a necessidade de se declarara novamente</para> 
    ///</summary>
    public class ClasseHeradada : SuperClasse
    {
        ///<summary>
        ///Novo método declarado na classe, usando um que existe na classe básica.
        ///</summary>
        public string ExibirValoresHeranca()
        {
            return this.ExibirValores();
        }
    }
}