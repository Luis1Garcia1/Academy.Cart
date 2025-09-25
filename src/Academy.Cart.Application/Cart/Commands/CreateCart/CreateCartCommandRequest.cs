namespace Academy.Cart.Application.Cart.Commands.CreateCart;

public class CreateCartCommandRequest
{
    public int CartId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
}
