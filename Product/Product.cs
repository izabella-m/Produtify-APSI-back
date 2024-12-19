namespace ApiProdutify.Product;

public class Product
{
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public float Price { get; private set; }
    public string Description { get; private set; }
    public float PromotionalPrice { get; private set; }
    public string Category { get; private set; }
    public int Stock { get; private set; }
    public string RandomCode { get; private set; }

    public Product(string name, float price, string description, float promotionalPrice, string category, int stock, string randomCode)
    {
        Name = name;
        Price = price;
        Description = description;
        PromotionalPrice = promotionalPrice;
        Category = category;
        Stock = stock;
        RandomCode = randomCode;
        Id = Guid.NewGuid();
    }

}