using EbaObra.Shared.Commands;

namespace EbaObra.Shared.IHandlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResponse Handler(T command);
    }
}