

using BusinessAPI.Repositories;
using BusinessAPI.Services;

namespace BusinessAPI
{
    public class StartupService
    {
        public static void InitialService(IServiceCollection services)
        {

            /* --- Services --- */

            services.AddTransient<ICommonRepository, CommonRepository>();
            services.AddTransient<IWarehouseRepository, WarehouseRepository>();
            services.AddTransient<ITMS030Repositories, TMS030Repositories>();
            services.AddTransient<ITMS050Repositories, TMS050Repositories>();
            services.AddTransient<ITMS040Repositories, TMS040Repositories>();
            services.AddTransient<ITMS060Repositories, TMS060Repositories>();


            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IWhrehouseService, WhrehouseService>();
            services.AddTransient<ITMS030Service, TMS030Service>();
            services.AddTransient<ITMS050Service, TMS050Service>();
            services.AddTransient<ITMS040Service, TMS040Service>();
            services.AddTransient<ITMS060Service, TMS060Service>();
        }
    }
}
