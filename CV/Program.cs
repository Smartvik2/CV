using CV.Data;
using CV.Interface;
using CV.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --------------------
// Database
// --------------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --------------------
// Services
// --------------------
builder.Services.AddSingleton<ICvService, CvService>();
builder.Services.AddTransient<ITaxCalculatorService, TaxCalculatorService>();
builder.Services.AddScoped<IGalleryService, GalleryService>();

// --------------------
// MVC + Controllers
// --------------------
builder.Services.AddControllersWithViews();

// --------------------
// Swagger/OpenAPI
// --------------------
builder.Services.AddEndpointsApiExplorer();       // required for Swagger
builder.Services.AddSwaggerGen();                 // registers ISwaggerProvider

var app = builder.Build();

// --------------------
// Middleware
// --------------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Swagger must come after builder.Build() and before MapControllers
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CV API V1");
    c.RoutePrefix = "swagger";  // Swagger available at /swagger
});

app.UseAuthorization();

// --------------------
// Routes
// --------------------
// MVC routes (Views)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// API routes (Controllers only)
app.MapControllers();

app.Run();
