using Microsoft.EntityFrameworkCore;
using SunOut_ERP_Backend.DataAccess;
using SunOut_ERP_Backend.DataAccess.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SunOutDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SunOutDb")));
builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("AllowOrigin", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

app.UseCors("AllowOrigin");
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.UseHttpsRedirection();
app.UseAuthorization();

app.Run();