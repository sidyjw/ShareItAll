using SinalingServer.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddRazorPages();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()//Depois mudar isso
                .AllowAnyHeader()
                .WithMethods("GET", "POST")
                .AllowCredentials();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.MapRazorPages();


app.UseCors();
app.MapHub<HomeHub>("/home");


app.Run("http://0.0.0.0:5500");
