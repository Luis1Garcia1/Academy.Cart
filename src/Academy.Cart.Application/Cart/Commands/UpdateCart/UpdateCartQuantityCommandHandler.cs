using Academy.Cart.Domain.Shared;
using MediatR;

namespace Academy.Cart.Application.Cart.Commands.UpdateCart;

public class UpdateCartQuantityCommandHandler : IRequestHandler<UpdateCartQuantityCommand, Result<UpdateCartQuantityCommandResponse>>
{
    public Task<Result<UpdateCartQuantityCommandResponse>> Handle(UpdateCartQuantityCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
