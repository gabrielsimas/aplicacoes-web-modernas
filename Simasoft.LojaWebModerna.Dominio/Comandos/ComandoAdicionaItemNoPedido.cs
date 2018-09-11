using System;
using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos
{
    public class ComandoAdicionaItemNoPedido: IComando
    {
        public Guid Produto { get; set; }
        public int Quantidade { get; set; }

        //Oferenda para acalmar o compilador do dotnet.
        //Tive de arriar um método para que o dotnet reconhecesse a Interface IComando
        public void oferenda()
        {
            throw new NotImplementedException();
        }
    }
}