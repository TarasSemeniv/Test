var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/api/say", () => Results.Ok("Say Hello"));
app.MapGet("/api/dontsay", () => Results.Ok("Don't say hello"));

app.Run();
