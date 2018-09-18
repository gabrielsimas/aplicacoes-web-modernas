using System;
using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Usuario: Entidade
    {
        #region Construtores
        public Usuario(string nomeDeUsuario, string senha, string confirmarSenha)
        {               
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha; //TODO: Utilizar o método de criptografia         
            Ativo = true;

            //TODO: Adicionar validação das senhas via Domain Validation            
        }
        #endregion

        #region Propriedades
        
        public string NomeDeUsuario { get; private set; }
        public string Senha { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region Métodos
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        //TODO: Criar método para criptografia de senhas

        #endregion 
        
    }
}