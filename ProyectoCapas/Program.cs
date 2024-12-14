using Microsoft.EntityFrameworkCore;
using ProyectoCapas.BLL;
using ProyectoCapas.DAL;
using ProyectoCapas.DAL.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuración del DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Agregar servicios a la colección
builder.Services.AddControllersWithViews();

// Registrar dependencias con ciclos de vida consistentes
builder.Services.AddScoped<IProductoRepository, ProductoRepositorio>();
builder.Services.AddScoped<ProductoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Producto}/{action=Index}/{id?}");

app.Run();
