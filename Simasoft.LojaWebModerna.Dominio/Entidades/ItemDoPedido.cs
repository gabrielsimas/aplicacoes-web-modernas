using Flunt.Validations;
using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades
{
    public class ItemDoPedido: Entidade
    {
        public ItemDoPedido(Produto produto, int quantidade, decimal preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;

            AddNotifications(new Contract()
                .Requires()               
                .IsGreaterThan(Quantidade,1,"ItemDoPedido.Quantidade","A quantidade deve ser maior que 0.")
                .IsGreaterThan(produto.QuantidadeEmEstoque, Quantidade + 1,null,$"Não temos tantos {produto.Titulo} em estoque")
                );

                Produto.DiminuirQuantidade(Quantidade);
        }

        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        public decimal Total() => Preco * Quantidade;
    }
}