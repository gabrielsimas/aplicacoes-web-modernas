using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using Simasoft.LojaWebModerna.Dominio.Enums;
using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Pedido: Entidade
    {
        private readonly IList<ItemDoPedido> _itens;

        public Pedido(Cliente cliente, decimal taxaDeEntrega, decimal desconto)
        {
            Cliente = cliente;
            DataDeCriacao = DateTime.Now;
            Numero = Guid.NewGuid().ToString().Substring(0,8).ToUpper();
            Estado = EEstadoDoPedido.Criado;
            _itens = new List<ItemDoPedido>();
            TaxaDeEntrega = taxaDeEntrega;
            Desconto = desconto;   

            AddNotifications(new Contract()
                    .Requires()
                    .IsGreaterThan(TaxaDeEntrega,0,"Pedido.TaxaDeEntrega",null)
                    .IsGreaterThan(TaxaDeEntrega,-1,"Pedido.TaxaDeEntrega",null)
            );         
        }
        
        public DateTime DataDeCriacao { get; private set; }
        public string Numero { get; private set; }
        public EEstadoDoPedido Estado { get; private set; }
        public decimal TaxaDeEntrega { get; private set; }
        public decimal Desconto { get; private set; }
        public Cliente Cliente { get; private set; }
        public IReadOnlyCollection<ItemDoPedido> Itens => _itens.ToArray();

        public decimal Subtotal() => Itens.Sum(x => x.Total());
        public decimal Total => (Subtotal() + TaxaDeEntrega) - Desconto;

        public void AdicionarItem(ItemDoPedido item) {
            AddNotifications(item.Notifications);
            if (item.Valid)
                _itens.Add(item);
        }

        public void Registrar()
        {

        }
    }
}