namespace Simasoft.LojaWebModerna.KernelCompartilhado.Comandos
{
    public interface IManipuladorDeComandos<T> where T: IComando
    {
        IResultadoComando Manipula(T comando);
    }
}