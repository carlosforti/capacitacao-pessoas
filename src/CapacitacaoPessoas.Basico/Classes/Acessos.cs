namespace CapacitacaoPessoas.Basico.Classes
{
    /*
     * Modificadores de acessos usados em C#
     * Public: pode ser acessado em qualquer parte do código do assembly(1), ou de outro assembly que o referencie
     * Private: código que só pode ser acessado de dentro da mesma classe ou struct
     * Protected: código que só pode ser acessado de dentro da mesma classe, ou de alguma classe que a herde
     * Internal: código que pode ser acessado de dentro do assembly, mas não por outros assemblies
     */
    public class Acessos
    {
        public void MetodoPublic()
        {
            return;
        }

        protected void MetodoProtected()
        {
            return;
        }

        private void MetodoPrivate()
        {
            return;
        }

        internal void MetodoInternal()
        {
            return;
        }

        protected internal void MetodoProtectedInternal()
        {
            return;
        }

        private protected void MetodoPrivateInternal()
        {
            return;
        }
    }
}