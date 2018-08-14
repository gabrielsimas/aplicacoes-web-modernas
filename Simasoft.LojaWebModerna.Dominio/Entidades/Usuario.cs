using System;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Usuario
    {
        #region Construtores
        public Usuario(Guid id, string nomeDeUsuario, string senha)
        {
            Id = id;
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha;            
        }
        #endregion

        #region Propriedades

        public Guid Id { get; private set; }
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