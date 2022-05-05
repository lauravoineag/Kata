namespace MangaStore.Products;

public class Products
{
    public List<IProduct> AllProducts { get; set; } = new List<IProduct>();
    public void AddProduct(IProduct product)
    {
        AllProducts.Add(product);
    }
    public void RemoveProduct(IProduct product)
    {
        AllProducts.Remove(product);
    }
}