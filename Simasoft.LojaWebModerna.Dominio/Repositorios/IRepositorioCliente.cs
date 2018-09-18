using System;
using Simasoft.LojaWebModerna.Dominio.Entidades;

namespace Simasoft.LojaWebModerna.Dominio.Repositorios
{
    public interface IRepositorioCliente
    {
        Cliente ListaPor(Guid id); 
        Cliente ListaPor(string documento); 
        Cliente ListaPorIdUsuario(Guid idUsuario);

        void Atualizar(Cliente cliente);
        bool DocumentoExiste(string documento);
        void Salvar(Cliente cliente);
    }
}