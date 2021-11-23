using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticaJigsaw.Areas.Identity.Data;
using PracticaJigsaw.Data;

[assembly: HostingStartup(typeof(PracticaJigsaw.Areas.Identity.IdentityHostingStartup))]
namespace PracticaJigsaw.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PracticaJigsawContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccessDb")));

                services.AddDefaultIdentity<JigsawUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 0;
                })
                    .AddEntityFrameworkStores<PracticaJigsawContext>();
                services.ConfigureApplicationCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromDays(10);
                });
            });
        }
    }
}