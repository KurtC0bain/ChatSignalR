using ChatSignalR.SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.UseStaticFiles();
app.UseFileServer();

app.UseRouting();

#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(endpoints => endpoints.MapHub<ChatHub>("/chat"));
#pragma warning restore ASP0014 

app.Run();
