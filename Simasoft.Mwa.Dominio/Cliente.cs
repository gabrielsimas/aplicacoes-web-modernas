using System;

namespace Simasoft.Mwa.Dominio
{
    public class Cliente
    {
        public Cliente(string nome)
        {            
            Nome = nome;
        }
        public int Id { get; set; }    
        public string Nome { get; set; }   
    }
}
