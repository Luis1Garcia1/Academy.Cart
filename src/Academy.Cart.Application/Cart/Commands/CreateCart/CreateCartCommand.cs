using Academy.Cart.Domain.Shared;
using MediatR;

namespace Academy.Cart.Application.Cart.Commands.CreateCart;

public sealed record CreateCartCommand(CreateCartCommandRequest request) : IRequest<Result<CreateCartCommandResponse>>;