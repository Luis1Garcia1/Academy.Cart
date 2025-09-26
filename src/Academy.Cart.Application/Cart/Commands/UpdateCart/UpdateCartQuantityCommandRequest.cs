namespace Academy.Cart.Application.Cart.Commands.UpdateCart;

public class UpdateCartQuantityCommandRequest
{
    public int productId {  get; set; }
    public int quantity { get; set; }
    public int userId { get; set; }

}
