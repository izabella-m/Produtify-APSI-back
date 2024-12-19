namespace ApiProdutify.Product;

public record AddProductRequest(string Name, float Price, string Description, float PromotionalPrice, string Category, int Stock, string RandomCode);

    
