namespace Simasoft.LojaWebModerna.KernelCompartilhado.Comandos
{
    public interface IManipuladorDeComandos<T> where T: IComando
    {
        void Manipula(T comando);
    }
}