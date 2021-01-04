using CapacitacaoPessoas.Basico.Classes;

namespace CapacitacaoPessoas.Console
{
    public class AcessosChildConsole: Acessos
    {
        public AcessosChildConsole()
        {
            base.MetodoProtected();
            base.MetodoPublic();
            base.MetodoProtectedInternal();
        }
    }
}