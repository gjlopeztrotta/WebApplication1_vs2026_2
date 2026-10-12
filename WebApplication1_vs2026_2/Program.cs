using WebApplication1_vs2026_2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<RepositoryVehicle>();
builder.Services.AddScoped<RepositoryTax>();
builder.Services.AddScoped<RepositoryAccesories>();
builder.Services.AddScoped<RepositoryCustomer>();
builder.Services.AddScoped<RepositoryOffer>();
builder.Services.AddScoped<RepositoryIEM>();
builder.Services.AddHttpClient();

var app = builder.Build();

app.MapControllers();
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.Run();

