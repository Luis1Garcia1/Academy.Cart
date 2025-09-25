using Academy.Cart.Application.Cart.Commands.CreateCart;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Academy.Cart.Presentation.Modules;

public static class CartModules
{
    private const string BASE_URL = "api/v1/cart/";
    public static void AddCustomerModules(this IEndpointRouteBuilder app)
    {
        var customerGroup = app.MapGroup(BASE_URL);

        customerGroup.MapPost("", CreateCustomer);
    }

    private static async Task<IResult> CreateCustomer(
        [FromBody] CreateCartCommandRequest request,
        ISender sender,
        CancellationToken cancellationToken)
    {
        var command = new CreateCartCommand(request);
        var result = await sender.Send(command, cancellationToken);

        if (result.Value == null)
            return Results.Content("Unable to create cart");

        return Results.Created($"{BASE_URL}{result.Value.CartId}", result.Value);
    }
}