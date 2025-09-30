using Invoicer.Api.Services;
using Microsoft.EntityFrameworkCore;
using Invoicer.Api.App;

var builder = WebApplication.CreateBuilder(args);

// Database
builder.Services.AddDbContext<InvoicerContext>( options =>
    options.UseNpgsql( builder.Configuration.GetConnectionString( "DefaultConnection" ) ) );

builder.Services.AddControllers();
builder.Services.AddApplicationServices();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cors
builder.Services.AddCors( options =>
{
    options.AddPolicy( "AllowBlazor",
        policy => policy.WithOrigins( "https://localhost:7044" )
                        .AllowAnyHeader()
                        .AllowAnyMethod() );
} );

var app = builder.Build();

// Setup dev tools
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    DbInitializer.Initialize( services.GetRequiredService<InvoicerContext>() );
}

app.UseCors( "AllowBlazor" );
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
