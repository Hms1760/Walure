var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Ensure HTTPS is enabled

// Serve static files from wwwroot
app.UseStaticFiles();

// Serve the default file (index.html) from wwwroot
app.UseDefaultFiles();  // This enables the index.html to be served at the root URL

app.UseAuthorization();
app.MapControllers();

app.Run();
