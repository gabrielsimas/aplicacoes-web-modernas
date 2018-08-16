using Simasoft.LojaWebModerna.KernelCompartilhado;

namespace Simasoft.LojaWebModerna.Dominio.Entidades 
{
    public class Produto: Entidade
    {
        public Produto(string titulo, decimal preco, string imagem, int quantidadeEmEstoque)
        {
            Titulo = titulo;
            Preco = preco;
            Imagem = imagem;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public string Titulo { get; private set; }
        public decimal Preco { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        public void DiminuirQuantidade(int quantidade)
        {
            if(QuantidadeEmEstoque <= quantidade)
                QuantidadeEmEstoque -= quantidade;
        }
    }
}