using Academy.Cart.Application.Cart.Commands.CreateCart;
using Academy.Cart.Application.Cart.Commands.UpdateCart;
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


        // Endpoint para el método put para actualizar productos del carrito
        customerGroup.MapPut("updateProducts", UpdateProducts);
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

    // Handler para el método PUT
    private static async Task<IResult> UpdateProducts(
        [FromBody] UpdateCartQuantityCommandRequest request,
        ISender sender,
        CancellationToken cancellationToken)
    {
        var response = await sender.Send(request, cancellationToken);

        if (response == null)
            return Results.NotFound("Product not found in cart");

        return Results.Ok(response);
    }
}