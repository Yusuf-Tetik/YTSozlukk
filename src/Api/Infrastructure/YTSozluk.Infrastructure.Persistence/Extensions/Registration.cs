using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTSozluk.Infrastructure.Persistence.Context;

namespace YTSozluk.Infrastructure.Persistence.Extensions;

public static class Registration
{
    public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<YTSozlukContext>(conf =>
        {
            var connStr = configuration["YTSozlukDbConnectionString"].ToString();
            conf.UseSqlServer(connStr, opt =>
            {
                opt.EnableRetryOnFailure();
            });

        });


        return services;
    }
}
