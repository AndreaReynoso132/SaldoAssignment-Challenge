using Microsoft.EntityFrameworkCore;
using SaldoAssignment.ApplicationServices;
using SaldoAssignment.Data; 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregar la configuraci�n de la cadena de conexi�n
builder.Services.AddDbContext<SaldoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar el servicio ISaldoAssignmentService
builder.Services.AddScoped<ISaldoAssignmentService, SaldoAssignmentService>(); // Aqu� agregas el servicio

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
