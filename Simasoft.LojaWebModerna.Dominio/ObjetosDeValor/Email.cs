using Flunt.Validations;

namespace Simasoft.LojaWebModerna.Dominio.ObjetosDeValor
{
    public class Email
    {
        protected Email() { }
        public Email(string endereco)
        {
            Endereco = endereco;

            /* new ValidationContract<Email>(this)
                .IsEmail(x => x.Address, "E-mail inválido"); */
        }

        public string Endereco { get; private set; }
    }
}
