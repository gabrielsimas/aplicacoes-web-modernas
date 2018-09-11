using System;
using Simasoft.LojaWebModerna.Dominio.Entidades;

namespace Simasoft.LojaWebModerna.Dominio.Repositorios
{
    public interface IRepositorioCliente
    {
        Cliente ListaPor(Guid id); 
        Cliente ListaPorIdUsuario(Guid idUsuario);
    }
}