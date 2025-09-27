namespace Academy.Cart.Application.Cart.Commands.UpdateCart;

public class UpdateCartQuantityCommandResponse
{
    public int ProductId { get; set; }
    public decimal Subtotal { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public decimal Discount { get; set; }
    public DateTime? LimitDate { get; set; }
    public decimal UnitPrice { get; set; }
}
