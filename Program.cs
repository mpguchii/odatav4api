using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Sap.Data.Hana;
using ODataNetCore.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:5000");

// Add services
builder.Services.AddControllers()
    .AddOData(opt => opt
        .AddRouteComponents("odata", GetEdmModel())
        .Select()
        .Expand()
        .Filter()
        .OrderBy()
        .SetMaxTop(10000)
        .Count()
    ).AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null; 
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

builder.Services.AddScoped<HanaConnection>(sp =>
    new HanaConnection(builder.Configuration.GetConnectionString("Hana")));

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());
app.Run();

static IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<Customer>("Customers");
    builder.EntitySet<OrderDashboard>("OrderDashboard");
    builder.EntitySet<Plant>("Plants");
    builder.EntitySet<CustomerOrders>("CustomerOrders");
    return builder.GetEdmModel();
}