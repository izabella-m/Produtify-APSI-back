using ApiProdutify.Data;
using ApiProdutify.Product;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext>();

// Configurando CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy
            .AllowAnyOrigin() // Permitir qualquer origem (Frontend)
            .AllowAnyMethod() // Permitir qualquer método HTTP
            .AllowAnyHeader(); // Permitir quaisquer cabeçalhos
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Ativando a política de CORS
app.UseCors("AllowAllOrigins");

// Configurando as rotas
app.AddProductEndpoint();

app.Run();