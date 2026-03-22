using JasperFx;
using JasperFx.CodeGeneration;
using Wolverine;
using Wolverine.RoutingSlip;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRoutingSlipCore();

builder.UseWolverine(options =>
{
    options.UseRoutingSlip();
    options.CodeGeneration.TypeLoadMode = TypeLoadMode.Static;
});

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { name = "Wolverine.RoutingSlip.Sample.Api" }));

app.RunJasperFxCommands(args);
