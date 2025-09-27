using Academy.Cart.Domain.Shared;
using MediatR;

namespace Academy.Cart.Application.Cart.Commands.UpdateCart;

public sealed record UpdateCartQuantityCommand(UpdateCartQuantityCommandRequest Request) : IRequest<Result<UpdateCartQuantityCommandResponse>>;
