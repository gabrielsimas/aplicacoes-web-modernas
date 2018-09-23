using Flunt.Notifications;
using Simasoft.LojaWebModerna.Dominio.Comandos.Entradas;
using Simasoft.LojaWebModerna.Dominio.Comandos.Resultados;
using Simasoft.LojaWebModerna.Dominio.Entidades;
using Simasoft.LojaWebModerna.Dominio.Repositorios;
using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos.Manipuladores
{
    public class ManipuladorDePedidos : Notifiable,
        IManipuladorDeComandos<ComandoRegistrarPedido>
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IRepositorioPedido _repositorioPedido;
        
        public ManipuladorDePedidos(IRepositorioCliente repositorioCliente, IRepositorioProduto repositorioProduto, IRepositorioPedido repositorioPedido)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioProduto = repositorioProduto;
            _repositorioPedido = repositorioPedido;
        }
        
        public IResultadoComando Manipula(ComandoRegistrarPedido comando)
        {
            var cliente = _repositorioCliente.ListaPor(comando.Cliente);
            var pedido = new Pedido(cliente,comando.TaxaDeEntrega,comando.Desconto);

            foreach(ComandoAdicionaItemNoPedido item in comando.Itens)
            {
                Produto produto = _repositorioProduto.Listar(item.Produto);
                pedido.AdicionarItem(new ItemDoPedido(produto,item.Quantidade,10));
            }

            //Adiciona as notificações do Pedido no Handler
            AddNotifications(pedido.Notifications);

            if(pedido.Valid)
                _repositorioPedido.Salvar(pedido);
            
            return new ResultadoComandoRegistrarPedido(pedido.Numero);

        }
    }
}