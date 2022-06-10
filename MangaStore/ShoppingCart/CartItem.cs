namespace MangaStore.ShoppingCart;

public class CartItem
{
    public IProduct Product { get; set; }
    public int Quantity { get; set; }


    public CartItem(IProduct product)
    {
        Product = product;
        Quantity = 1;
    }

    public double CalculateItem()
    {
        var discountPrice = Product.Price - Product.Price * (Product.Discount/100);
        return Product.Price * Quantity - discountPrice;
    }
    
}
