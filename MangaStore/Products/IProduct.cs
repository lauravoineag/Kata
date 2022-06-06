using Microsoft.VisualBasic.CompilerServices;

namespace MangaStore;

public interface IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Discount { get; set; }
}   
 