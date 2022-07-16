using Christ3D.Application;
using Christ3D.Application.Interfaces;
using Christ3D.Application.Services;
using Christ3D.Domain.Interfaces;
using Christ3D.Infrastruct.Data.Context;
using Christ3D.Infrastruct.Data.DataRepository;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//数据库连接地址写入
builder.Services.AddDbContext<StudyContext>(options => {

    options.UseMySql(builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Get<string>(), ServerVersion.Create(8,0,22, ServerType.MySql));
});

builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile));

builder.Services.AddScoped<IStudentAppService, StudentAppService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
