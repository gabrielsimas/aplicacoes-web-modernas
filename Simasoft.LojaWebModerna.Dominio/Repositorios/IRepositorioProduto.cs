using System;
using System.Collections.Generic;
using Simasoft.LojaWebModerna.Dominio.Entidades;

namespace Simasoft.LojaWebModerna.Dominio.Repositorios
{
    public interface IRepositorioProduto
    {
         Produto Listar(Guid idProduto);
         IEnumerable<Produto> Listar(List<Guid> ids);
    }
}