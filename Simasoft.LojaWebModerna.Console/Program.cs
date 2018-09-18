using System;
using System.Collections.Generic;
using Simasoft.LojaWebModerna.Dominio.Comandos;
using Simasoft.LojaWebModerna.Dominio.Comandos.Entradas;
using Simasoft.LojaWebModerna.Dominio.Comandos.Manipuladores;
using Simasoft.LojaWebModerna.Dominio.Entidades;
using Simasoft.LojaWebModerna.Dominio.ObjetosDeValor;
using Simasoft.LojaWebModerna.Dominio.Repositorios;

namespace Simasoft.LojaWebModerna.Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var comando = new ComandoRegistrarPedido
            {
                Cliente = Guid.NewGuid(),
                TaxaDeEntrega = 9,
                Desconto = 30,
                Itens = new List<ComandoAdicionaItemNoPedido>
                {
                    new ComandoAdicionaItemNoPedido
                    {
                        Produto =  Guid.NewGuid(),
                        Quantidade = 3
                    }
                }
            };

            GerarPedido(
                new RepositorioFalsoCliente(),
                new RepositorioFalsoProduto(),
                new RepositorioFalsoPedido(),
                comando);
            System.Console.ReadKey();
        }
        
        static void GerarPedido(
            IRepositorioCliente repositorioCliente,
            IRepositorioProduto repositorioProduto,
            IRepositorioPedido repositorioPedido,
            ComandoRegistrarPedido comando)
        {
            ManipuladorDePedidos manipuladorDePedidos = new ManipuladorDePedidos(
                repositorioCliente,
                repositorioProduto,
                repositorioPedido);
            manipuladorDePedidos.Manipula(comando);            

            if (manipuladorDePedidos.Valid)
                System.Console.WriteLine("Pedido cadastrado com sucesso!");
        }


    }

    class RepositorioFalsoProduto : IRepositorioProduto
    {
        public Produto Listar(Guid id)
        {
            return new Produto("Mouse", 299, "", 50);
        }

        public IEnumerable<Produto> Listar(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }

    class RepositorioFalsoCliente : IRepositorioCliente
    {
        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool DocumentoExiste(string documento)
        {
            throw new NotImplementedException();
        }

        public Cliente ListaPor(Guid id)
        {
            return null;
        }

        public Cliente ListaPor(string documento)
        {
            throw new NotImplementedException();
        }

        public Cliente ListaPorIdUsuario(Guid idUsuario)
        {
            return new Cliente(
                new Nome("André", "Baltieri"),
                DateTime.Now,
                new Email("andrebaltieri@hotmail.com"),
                new Documento("72546524135"),
                new Usuario("andrebaltieri","","")
            );
        }

        public void Salvar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        /* public void Update(Customer customer)
        {
            
        } */
    }

    class RepositorioFalsoPedido : IRepositorioPedido
    {
        public void Salvar(Pedido pedido)
        {
            throw new NotImplementedException();
        }        
    }
}
