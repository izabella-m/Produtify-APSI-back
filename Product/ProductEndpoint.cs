using ApiProdutify.Data;

namespace ApiProdutify.Product;

public static class ProductEndpoint
{
    public static void AddProductEndpoint(this WebApplication app)
    {
        
        // endpointProdutos.MapPost()
        
        // app.MapGet("produtos", () => new Product(name: "camisa"));
        var endpointProdutos = app.MapGroup("products");

        // Adicionando um endpoint POST ao grupo
        endpointProdutos.MapPost("",async(AddProductRequest request, AppDbContext context) =>
        {
            var novoproduto = new Product(
                request.Name,
                request.Price,
                request.Description,
                request.PromotionalPrice,
                request.Category,
                request.Stock,
                request.RandomCode
            );
            
            await context.ProductsNew.AddAsync(novoproduto);
            await context.SaveChangesAsync();
            
           // return Results.Ok(new { message = "Produto criado com sucesso!", product });
        });
    } 

}