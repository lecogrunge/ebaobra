using EbaObra.Shared.Commands;

namespace EbaObra.Domain.Commands
{
    public abstract class CommandResponse : ICommandResponse
    {
        public CommandResponse()
        {

        }
        public CommandResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}