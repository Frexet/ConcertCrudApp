using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int numberToGuess = 87; 
app.MapGet("/guess/{input:int}", (int input) =>
{
    if (input < numberToGuess) 
        return "To Low, Try Again!";
    else if (input > numberToGuess) 
        return "To High, Try Again";
    else 
        return $"Right number Congrats, {input} is correct!";
});

app.MapGet("/collection", () =>
{
    var myCollection = new List<string> { "Apple", "Banana", "Cherry", "Grape" };
    string jsonResponse = JsonSerializer.Serialize(myCollection);
    return jsonResponse;
});

app.MapGet("/greeting", () =>
{
    return "Welcome to my first ASP.NET Core-applikation!";
});

app.Run();