using System;
using System.Collections.Generic;
using Flunt.Validations;
using Simasoft.LojaWebModerna.KernelCompartilhado;
using Simasoft.LojaWebModerna.Dominio.ObjetosDeValor;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Cliente: Entidade
    {
        #region Construtores
        //OCP => Aberta para extensão
        protected Cliente() {}

        public Cliente(
                Nome nome,
                DateTime dataDeNascimento,                
                Email email,
                Documento documento,
                Usuario usuario)
        {                       
            Nome = nome;            
            DataDeNascimento = dataDeNascimento;            
            Email = email;
            Documento = documento;
            Usuario = usuario;            

            //Validações
            /* AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Nome,"Cliente.Nome","Nome é obrigatório")
                .HasMaxLen(Nome,60,"Cliente.Nome","Nome menor que 60 caracteres")
                .HasMinLen(Nome,3,"Cliente.Nome","O Nome não pode ter menos de 3 letras")                
                .IsEmail(Email,"Cliente.Email","E-mail é invalido")                
                );             */
        }
        #endregion

        #region Propriedades
        //OCP => Fechada para Inclusão => usando private set, evita-se que se modifique o valor do campo em tempo de execução       
        public Nome Nome { get; private set; }        
        public DateTime DataDeNascimento { get; private set; }        
        public Email Email { get; private set; }        
        public Documento Documento { get; private set; }
        public bool EhValida() => Notifications.Count > 0;
        public Usuario Usuario { get; private set; }
        
        #endregion

        #region Métodos
        
        #endregion
        #region Sobrescritas do Papai

        public override string ToString()
        {
            //Interpolação de string => C# 6
           return $"Nome Completo: {Nome.ToString()}, Data de Nascimento: {DataDeNascimento}, Email: {Email.ToString()}, Usuario: {Usuario}";
        }

        #endregion
    }
}