using System;
using Flunt.Notifications;
using Simasoft.LojaWebModerna.Dominio.Coandos.Resultados;
using Simasoft.LojaWebModerna.Dominio.Comandos.Entradas;
using Simasoft.LojaWebModerna.Dominio.Entidades;
using Simasoft.LojaWebModerna.Dominio.ObjetosDeValor;
using Simasoft.LojaWebModerna.Dominio.Repositorios;
using Simasoft.LojaWebModerna.Dominio.Servicos;
using Simasoft.LojaWebModerna.KernelCompartilhado.Comandos;

namespace Simasoft.LojaWebModerna.Dominio.Comandos.Manipuladores
{
    public class ManipuladorDeComandosDoCliente : Notifiable, 
        IManipuladorDeComandos<ComandoRegistrarCliente>
    {
        private readonly IRepositorioCliente _repositorioCliente; 
        private readonly IServicoEmail _servicoEmail;

        public IResultadoComando Manipula(ComandoRegistrarCliente comando)
        {                                                
            //Passo 1.Verificar se o CPF já existe
            if (_repositorioCliente.DocumentoExiste(comando.Documento))
            {
                AddNotification("Documento","Este CPF já está em uso!");
                return null; //ARGH!!!!TROCAR POR NULL OBJECT
            }
            //Passe 2. Caso o cliente não exista
            //TODO: Aplicar Object Callisthenics
            var nome = new Nome(comando.PrimeiroNome, comando.Sobrenome);
            var documento = new Documento(comando.Documento);
            var email = new Email(comando.Email);
            var usuario = new Usuario(comando.NomeUsuario, comando.Senha, comando.ConfirmarSenha);
            var cliente = new Cliente(nome,new DateTime(1982,06,26),email,documento,usuario);

            //TODO: Passe 3. Adicionar Domain Validations

             //Passo 4. Inserir no Banco
             if (Valid)
                _repositorioCliente.Salvar(cliente);

            //Passo 5. Enviar e-mail
            _servicoEmail.Enviar(
                cliente.Nome.ToString(),
                cliente.Email.Endereco,
                "Bem vindo a Loja Web Moderna!","Corpo da Mensagem");
            
            //Passe 6
            return new ResultadoComandoRegistrarCliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome.ToString()
            };

        }        
    }
}