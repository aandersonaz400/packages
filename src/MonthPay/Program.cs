var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/report", () => Newtonsoft.Json.JsonConvert
    .SerializeObject(new { Month = "2026-10", Runs = 1 }));

app.Run();

