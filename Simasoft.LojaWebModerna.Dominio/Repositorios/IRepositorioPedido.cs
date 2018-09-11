using Simasoft.LojaWebModerna.Dominio.Entidades;

namespace Simasoft.LojaWebModerna.Dominio.Repositorios
{
    public interface IRepositorioPedido
    {
        void Salvar(Pedido pedido);
    }
}