namespace Simasoft.LojaWebModerna.Dominio.Servicos
{
    public interface IServicoEmail
    {
        void Enviar(string para,string paraEmail,string assunto, string corpo);
    }
}