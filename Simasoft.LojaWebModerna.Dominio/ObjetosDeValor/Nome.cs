using Flunt.Validations;

namespace Simasoft.LojaWebModerna.Dominio.ObjetosDeValor
{
    public class Nome
    {
        protected Nome() { }

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            /* new ValidationContract<Nome>(this)
                .IsRequired(x => x.PrimeiroNome, "Nome é obrigatório")
                .HasMaxLenght(x => x.PrimeiroNome, 60)
                .HasMinLenght(x => x.PrimeiroNome, 3)
                .IsRequired(x => x.Sobrenome, "Sobrenome é obrigatório")
                .HasMaxLenght(x => x.Sobrenome, 60)
                .HasMinLenght(x => x.Sobrenome, 3); */
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}
