using System;
using How_To.Areas.Identity.Data;
using How_To.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(How_To.Areas.Identity.IdentityHostingStartup))]
namespace How_To.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<How_ToContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("How_ToContextConnection")));

                services.AddDefaultIdentity<HowToUser>(
                    options => {

                        options.SignIn.RequireConfirmedAccount = false;
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequiredLength = 1;
                        options.Password.RequireDigit = false;

                    })
                    .AddEntityFrameworkStores<How_ToContext>();
            });
        }
    }
}