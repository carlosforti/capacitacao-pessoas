using System.Linq;

namespace src.CapacitacaoPessoas.Basico.Metodos
{
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class Metodos
    {
        public bool ValidarEnderecos1(Endereco endereco1, Endereco endereco2)
        {
            var estaValido = true;

            if (string.IsNullOrEmpty(endereco1.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco1.Estado))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco2.Estado))
                estaValido = false;

            return estaValido;
        }

        public bool ValidarEnderecos2(Endereco endereco1, Endereco endereco2)
        {
            var estaValido = true;

            if (!ValidarEndereco(endereco1))
                estaValido = false;

            if (!ValidarEndereco(endereco2))
                estaValido = false;

            return estaValido;
        }

        private bool ValidarEndereco(Endereco endereco)
        {
            var estaValido = true;

            if (string.IsNullOrEmpty(endereco.Cep))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Logradouro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Numero))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Bairro))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Cidade))
                estaValido = false;

            if (string.IsNullOrEmpty(endereco.Estado))
                estaValido = false;

            return estaValido;
        }
    }
}