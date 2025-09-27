using Microsoft.EntityFrameworkCore;
using TaskList.Data;
using TaskList.Interfaces;
using TaskList.Repositories;
using TaskList.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<ITask, TaskRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.LicenseKey = "eyJhbGciOiJSUzI1NiIsImtpZCI6Ikx1Y2t5UGVubnlTb2Z0d2FyZUxpY2Vuc2VLZXkvYmJiMTNhY2I1OTkwNGQ4OWI0Y2IxYzg1ZjA4OGNjZjkiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2x1Y2t5cGVubnlzb2Z0d2FyZS5jb20iLCJhdWQiOiJMdWNreVBlbm55U29mdHdhcmUiLCJleHAiOiIxNzkwMzgwODAwIiwiaWF0IjoiMTc1ODkyOTg3MCIsImFjY291bnRfaWQiOiIwMTk5ODg2MzA4NTQ3NDIzYTEyODAxMzUwMDRiMDI4MiIsImN1c3RvbWVyX2lkIjoiY3RtXzAxazY0NjdxeHIwZGs3NHEyNnE2NDNlYXZwIiwic3ViX2lkIjoiLSIsImVkaXRpb24iOiIwIiwidHlwZSI6IjIifQ.gq6lJsGm5ECWCxrLNrr6-3E5BBaksonqTQ3sGsTJg_l2fA7kXpQSGTDAbU-WzvLDTK-k7jZNMdBQQnPsr1aY5NdFRI_cg6_nZ3ZBxwyreBof8eumWvTL5R3i-JD4JTcx45xRSaXsijB-7BbNmmxftOc5NafxsKYgwPPFA7u1j8nwWWSyE-pXNO65xSa5u5qhubHE1RciVaMzecjRy-_6eOlhb-raI4G2DIfgTXXlkMX6IWIsYDObWEzg5I0bJzg88VnYP5nsNEaor9fzfesYIS_Ho-bP12umTl7vQQPkrXeUc-o83jgrBJX9rjWNejrY3ELwXytgtXJW0sE0kUgKQA";
    cfg.AddProfile(typeof(UserGet));
    cfg.AddProfile(typeof(TaskGet));
});

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
