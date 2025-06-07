var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to listen on port 8080
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(8080); // HTTP
});

var app = builder.Build();

// Serve HTML with large font
app.MapGet("/", () => Results.Content(
    "<!DOCTYPE html>" +
    "<html>" +
    "<head><title>Hello</title></head>" +
    "<body style='display:flex;justify-content:center;align-items:center;height:100vh;margin:0;'>" +
    "<h1 style='font-size:72px;'>Hello, World!</h1>" +
    "</body>" +
    "</html>", 
    "text/html"));

app.Run();
