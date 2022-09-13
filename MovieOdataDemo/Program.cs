using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using MovieOdataDemo.Databases;
using MovieOdataDemo.Models;
using MovieOdataDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddOData(options =>
{
    options.EnableQueryFeatures().AddRouteComponents("/odata", GetEdmModel());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add scoped services
builder.Services.AddScoped<IMovieService, MovieService>();

// Add database connections
var mysqlString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MysqlContext>(
                options => options.UseMySql(mysqlString, ServerVersion.AutoDetect(mysqlString)));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<Movie>("Movies");
    return builder.GetEdmModel();
}