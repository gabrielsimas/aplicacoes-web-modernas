using System;
using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Usuario: Entidade
    {
        #region Construtores
        public Usuario(string nomeDeUsuario, string senha)
        {            
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha;            
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

        #endregion 
        
    }
}