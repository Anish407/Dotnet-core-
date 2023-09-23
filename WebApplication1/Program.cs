using WebApplication1.DI;
using WebApplication1.MIddlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1 object is created for the entire lifetime of the application
builder.Services.AddSingleton<ISample, Sample3>();

// 1 object is created for a request
builder.Services.AddScoped<ISample, Sample3>();

// a new object is created every time we inject ISample
builder.Services.AddTransient<ISample, Sample2>();


builder.Services.AddTransient<IDIExample, DIExample>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
