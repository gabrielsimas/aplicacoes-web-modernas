using System;
using System.Collections.Generic;
using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos.Entradas
{
    public class ComandoRegistrarPedido: IComando
    {
        public Guid Cliente { get; set; }
        public decimal TaxaDeEntrega { get; set; }
        public decimal Desconto { get; set; }
        public IEnumerable<ComandoAdicionaItemNoPedido> Itens { get; set; }

        //Oferenda para acalmar o compilador do dotnet.
        //Tive de arriar um método para que o dotnet reconhecesse a Interface IComando
        public void oferenda()
        {
            throw new NotImplementedException();
        }
    }
}