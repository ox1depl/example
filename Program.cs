var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseAuthorization();
app.MapControllers();

app.MapGet("/health", () => new { status = "healthy", timestamp = DateTime.UtcNow });

app.MapGet("/", () => "Mikoshi is one of Saburo Arasaki's main projects. It is a data fortress located in the part of cyberspace controlled by the Arasaka corporation, with servers located on orbital stations around Earth. It contains digitized personalities of clients of the 'Secure Your Soul' program, as well as victims obtained through Soulkiller.");

app.Run(); 