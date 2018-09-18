using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos.Entradas
{
    public class ComandoRegistrarCliente : IComando
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public void oferenda()
        {
            throw new System.NotImplementedException();
        }
    }
}