using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using DevPortfolioApi.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = "Data Source=portfolio.db";
builder.Services.AddDbContext<PortfolioDbContext>(options =>
    options.UseSqlite(connectionString));
var app = builder.Build();

// Enable Swagger for testing
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware
// app.UseHttpsRedirection(); // Optional if you're not setting up HTTPS yet
app.UseAuthorization();

app.MapControllers(); // This is what hooks up [ApiController]-based controllers

app.Run();
