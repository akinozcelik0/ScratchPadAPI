using Microsoft.EntityFrameworkCore;
using NotDefteriAPI.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
// Add services to the container.
var cs = builder.Configuration.GetConnectionString("UygulamaDbContext");
builder.Services.AddDbContext<UygulamaDbContext>(o => o.UseSqlServer(cs));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();
