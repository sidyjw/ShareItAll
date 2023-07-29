using SinalingServer.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.MapRazorPages();

app.MapHub<HomeHub>("/home");


app.Run();
