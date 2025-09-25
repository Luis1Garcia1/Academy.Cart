using Academy.Cart.Domain.Shared;
using MediatR;

namespace Academy.Cart.Application.Cart.Commands.CreateCart;

public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, Result<CreateCartCommandResponse>>
{
    public Task<Result<CreateCartCommandResponse>> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}