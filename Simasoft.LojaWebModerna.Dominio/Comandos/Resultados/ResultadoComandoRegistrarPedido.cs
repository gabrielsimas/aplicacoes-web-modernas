using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos.Resultados
{
    public class ResultadoComandoRegistrarPedido: IResultadoComando
    {
        public ResultadoComandoRegistrarPedido(string number)
        {
            Number = number;
        }

        public ResultadoComandoRegistrarPedido()
        { }
        public string Number { get; set; }

        public void oferenda()
        {
            throw new System.NotImplementedException();
        }
    }
}