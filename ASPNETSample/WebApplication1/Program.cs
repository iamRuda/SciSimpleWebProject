var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", async context =>
{
    var path = Path.Combine(app.Environment.ContentRootPath, "templates", "index.html");
    var html = await File.ReadAllTextAsync(path);
    await context.Response.WriteAsync(html);
});
app.Run();
