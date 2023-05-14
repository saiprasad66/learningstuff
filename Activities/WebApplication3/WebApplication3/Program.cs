using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductContext>(options => options.UseInMemoryDatabase("ProductList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
//configure the http verbs
app.MapGet("/", () => "HelloWorld");
app.MapGet("/products/complete", async (ProductContext pc) =>
await pc.products.ToListAsync());
app.MapGet("/products/{id}", async (int id, ProductContext pc) =>
await pc.products.FindAsync(id));
app.MapPost("/products", async (Product p, ProductContext pc) =>
{
    pc.products.Add(p);
    await pc.SaveChangesAsync();
});
app.MapPut("/product{id}", async (int id, Product p, ProductContext pc) =>
{
    var ids = await pc.products.FindAsync(id);
    if (ids is null) return Results.NotFound();
    ids.Name = p.Name;
    ids.price = p.price;
    await pc.SaveChangesAsync();
    return Results.NoContent();
});
app.MapDelete("/product/{id}", async(int id,ProductContext pc)=>
{
    if (await pc.products.FindAsync(id) is Product p)
    {
        pc.products.Remove(p);
        await pc.SaveChangesAsync();


    }
    Results.NotFound();

});



app.Run();
 class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int price { get; set; }
}

class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> products { get; set; }
}

