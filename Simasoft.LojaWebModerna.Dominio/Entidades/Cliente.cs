using System;
using System.Collections.Generic;
using Flunt.Validations;
using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Cliente: Entidade
    {
        #region Construtores
        //OCP => Aberta para extensão
        protected Cliente() {}

        public Cliente(
                string nome,
                string sobrenome,
                DateTime dataDeNascimento,                
                string email,
                Usuario usuario)
        {                       
            Nome = nome;
            Sobrenome = sobrenome;
            DataDeNascimento = dataDeNascimento;            
            Email = email;
            Usuario = usuario;            

            //Validações
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Nome,"Cliente.Nome","Nome é obrigatório")
                .HasMaxLen(Nome,60,"Cliente.Nome","Nome menor que 60 caracteres")
                .HasMinLen(Nome,3,"Cliente.Nome","O Nome não pode ter menos de 3 letras")
                .IsNotNullOrEmpty(Sobrenome,"Cliente.Sobrenome","Sobrenome é obrigatório")
                .HasMaxLen(Sobrenome,60,"Cliente.Sobrenome","Sobrenome menor que 60 caracteres")
                .HasMinLen(Sobrenome,3,"Cliente.Sobrenome","O Sobrenome não pode ter menos de 3 letras")
                .IsEmail(Email,"Cliente.Email","E-mail é invalido")                
                );
            /*
            if(Nome.Length < 3)
                //throw new Exception("Nome inválido");
                Notifications.Add("Nome","Nome inválido");
            
            if(Sobrenome.Length < 3)
                //throw new Exception("Sobrenome inválido");
                Notifications.Add("Sobrenome","Sobrenome inválido");

            if(Email.Length < 3)
                //throw new Exception("Email inválido");
                Notifications.Add("Email","Email inválido");
                */    
        }
        #endregion

        #region Propriedades
        //OCP => Fechada para Inclusão => usando private set, evita-se que se modifique o valor do campo em tempo de execução       
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }        
        public string Email { get; private set; }        
        public bool EhValida() => Notifications.Count > 0;
        public Usuario Usuario { get; private set; }
        
        #endregion

        #region Métodos
        
        #endregion
        #region Sobrescritas do Papai

        public override string ToString()
        {
            //Interpolação de string => C# 6
           return $"Nome Completo: {Nome} {Sobrenome}, Data de Nascimento: {DataDeNascimento}, Email: {Email}, Usuario: {Usuario}";
        }

        #endregion
    }
}