using DependencyInjectionAndMiddleware.Repo;
using DependencyInjectionAndMiddleware.Repo.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//registering IMovieRepo  interface
//Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
builder.Services.AddTransient<IMovieRepo, MovieRepo>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
