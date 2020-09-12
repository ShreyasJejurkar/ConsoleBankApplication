using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace AlexaBank.ConsoleUI.Application.Accounts.Commands
{
    public class RegisterAccountCommand : IRequest
    {
    }

    public class RegisterAccountCommandHandler : IRequestHandler<RegisterAccountCommand>
    {
        public Task<Unit> Handle(RegisterAccountCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}