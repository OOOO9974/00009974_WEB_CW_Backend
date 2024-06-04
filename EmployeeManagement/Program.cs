using EmployeeManagement.DbContexts;
using EmployeeManagement.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddPolicy(name: "FrontendUI",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }
));

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("EmployeeManagement9974DB")    
));

builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//< CORS >

app.UseCors("FrontendUI");

//</ CORS >

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
