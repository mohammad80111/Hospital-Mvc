using Hospital_Mvc_.Controllers;
using Hospital_Mvc_.Repositry;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Hospital_Mvc_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //
            builder.Services.AddDbContext<ApplicationDbContext>(Options=>Options.UseSqlServer(
                builder.Configuration.GetConnectionString("Hospi")
                ));

            //
            builder.Services.AddTransient<IDoctorRepositry,DoctorRepositry>();
            builder.Services.AddTransient<IPatientRepositry, PatientRepositry>();
            builder.Services.AddTransient<IMedicineRepositry, MedicineRepositry>();



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