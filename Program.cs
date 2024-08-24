using Biblioteca_Virtual.Data;
using Biblioteca_Virtual.Reposit�rio;
using Biblioteca_Virtual.Reposit�rio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Virtual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configura��o do banco de dados MySQL.
            builder.Services.AddDbContext<ContextDb>(options =>
            {
                options.UseMySql(
                    builder.Configuration.GetConnectionString("Database"),
                    new MySqlServerVersion(new Version(8, 0, 21))
                );
            });

            // Inje��o de depend�ncia
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            builder.Services.AddScoped<ILivroRepositorio, LivroRepositorio>();
            builder.Services.AddScoped<IEmprestimoRepositorio, EmprestimoRepositorio>();

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
        }
    }
}
