using BusinessAPI;
using BusinessSQLDB;
using Microsoft.EntityFrameworkCore;
using Utils;
using WarehouseSQLDB;

var builder = WebApplication.CreateBuilder(args);

StartupAPIMicoService.StartupCreateBuilder(builder);

/* --- DB Conneted Config--- */

var connectionString =
    builder.Configuration.GetConnectionString("DBConnection");

var warehouseConnectionString =
    builder.Configuration.GetConnectionString("WarehouseConnection");

builder.Services.AddDbContext<MSDBContext>(options =>
                options.UseSqlServer(connectionString));

builder.Services.AddDbContext<WarehouseDbContext>(options =>
                options.UseSqlServer(warehouseConnectionString));



/* --- Add Repository & Service ---*/
StartupService.InitialService(builder.Services);


//Add AutoMapper
builder.Services.AddAutoMapper(typeof(Program));


/* --- Add SetupHttpClient ---*/

SetupHttpClient.InitialService(builder);



/* --- Add Worker ---*/

builder.Services.AddHostedService<TmsQueueSqlDependencyWorker>();


var app = builder.Build();
StartupAPIMicoService.StartupCreateApplication(builder, app);



app.Run();
