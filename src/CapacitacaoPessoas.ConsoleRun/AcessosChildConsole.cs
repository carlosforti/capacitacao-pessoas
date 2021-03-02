using CapacitacaoPessoas.Basico.Classes;

namespace CapacitacaoPessoas.ConsoleRun
{
    public class AcessosChildConsole : Acessos
    {
        public AcessosChildConsole()
        {
            base.MetodoProtected();
            base.MetodoPublic();
            base.MetodoProtectedInternal();
        }
    }
}