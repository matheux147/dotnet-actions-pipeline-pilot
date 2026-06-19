var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args); 

var app = builder.Build(); 

app.MapGet("/", () => "Pipeline funcionando! Teste em develop novamente");

app.Run(); 