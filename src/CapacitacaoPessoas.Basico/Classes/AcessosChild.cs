namespace CapacitacaoPessoas.Basico.Classes
{
    public class AcessosChild: Acessos
    {
        public AcessosChild()
        {
            base.MetodoInternal();
            base.MetodoProtected();
            base.MetodoPublic();
            base.MetodoPrivateInternal();
            base.MetodoProtectedInternal();
        }
    }
}