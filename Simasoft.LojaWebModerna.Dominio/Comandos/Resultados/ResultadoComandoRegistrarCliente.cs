using System;
using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Coandos.Resultados
{
    public class ResultadoComandoRegistrarCliente : IResultadoComando
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}