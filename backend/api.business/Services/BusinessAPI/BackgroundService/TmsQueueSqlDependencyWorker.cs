using BusinessSQLDB;
using BusinessSQLDB.Models.MesSystem;
using Microsoft.EntityFrameworkCore;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using WarehouseSQLDB;
using WarehouseSQLDB.Models.Tables;

public class TmsQueueSqlDependencyWorker : BackgroundService
{
    private readonly ILogger<TmsQueueSqlDependencyWorker> _logger;
    private readonly IConfiguration _configuration;
    private readonly IServiceScopeFactory _scopeFactory;

    private SqlTableDependency<TbItfTmsQueueManagement>? _tableDependency;

    public TmsQueueSqlDependencyWorker(
        ILogger<TmsQueueSqlDependencyWorker> logger,
        IConfiguration configuration,
        IServiceScopeFactory scopeFactory)
    {
        _logger = logger;
        _configuration = configuration;
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Starting SqlTableDependency for tb_Itf_TMS_QueueManagement...");

        var connectionString = _configuration.GetConnectionString("WarehouseConnection");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            _logger.LogError("Connection string 'WarehouseConnection' is not configured.");
            Console.WriteLine("ERROR: Connection string 'WarehouseConnection' is empty or missing.");
            return;
        }

        var mapper = new ModelToTableMapper<TbItfTmsQueueManagement>();
        mapper.AddMapping(x => x.RecordId, "RecordID");
        mapper.AddMapping(x => x.TruckNo, "TruckNo");
        mapper.AddMapping(x => x.LoadingSeq, "LoadingSeq");
        mapper.AddMapping(x => x.TransportSeq, "TransportSeq");
        mapper.AddMapping(x => x.LoadingNo, "LoadingNo");
        mapper.AddMapping(x => x.ShippingNoteNo, "ShippingNoteNo");
        mapper.AddMapping(x => x.JobTypeId, "JobTypeID");
        mapper.AddMapping(x => x.JobTypeName, "JobTypeName");
        mapper.AddMapping(x => x.ShippingCustomerId, "ShippingCustomerID");
        mapper.AddMapping(x => x.ShippingCustomerName, "ShippingCustomerName");
        mapper.AddMapping(x => x.ShiptFromId, "ShiptFromID");
        mapper.AddMapping(x => x.ShipFromName, "ShipFromName");
        mapper.AddMapping(x => x.ShiptToId, "ShiptToID");
        mapper.AddMapping(x => x.ShiptToName, "ShiptToName");
        mapper.AddMapping(x => x.AreaCode, "AreaCode");
        mapper.AddMapping(x => x.GateCode, "GateCode");
        mapper.AddMapping(x => x.CheckInDate, "CheckInDate");
        mapper.AddMapping(x => x.StatusId, "StatusID");
        mapper.AddMapping(x => x.StatusName, "StatusName");
        mapper.AddMapping(x => x.CreateDate, "CreateDate");
        mapper.AddMapping(x => x.FinalTruckFlag, "FinalTruckFlag");
        mapper.AddMapping(x => x.TripNo, "TripNo");
        mapper.AddMapping(x => x.TripNoText, "TripNoText");
        //mapper.AddMapping(x => x.ShiptToCode, "ShiptToCode");
        //ShiptToCode



        // ให้ worker ค้างอยู่จนกว่าจะถูกยกเลิก
        try
        {
            // 1) เคลียร์ของค้างใน tb_Itf_TMS_QueueManagement ก่อน
            await ProcessExistingRecordsAsync(stoppingToken);

            // 2) แล้วค่อย start table dependency รอ event ใหม่
            _tableDependency = new SqlTableDependency<TbItfTmsQueueManagement>(
                connectionString,
                tableName: "tb_Itf_TMS_QueueManagement",
                schemaName: "dbo",
                mapper: mapper
            );

            _tableDependency.OnChanged += TableDependency_OnChanged;
            _tableDependency.OnError += TableDependency_OnError;

            _tableDependency.Start();
            await Task.Delay(Timeout.Infinite, stoppingToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while stopping SqlTableDependency");
            // ignore
        }
        finally
        {
            try
            {
                _logger.LogInformation("Stopping SqlTableDependency...");
                _tableDependency?.Stop();
                _tableDependency?.Dispose();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while stopping SqlTableDependency");
            }
        }
    }

    private void TableDependency_OnError(
        object? sender,
        TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
    {
        _logger.LogError(e.Error, "SqlTableDependency error");
        Console.WriteLine($"[ERROR] {e.Error.Message}");
    }

    private void TableDependency_OnChanged(
        object? sender,
        RecordChangedEventArgs<TbItfTmsQueueManagement> e)
    {
        if (e.ChangeType != ChangeType.Insert)
            return;

        // อย่า await ใน event handler โดยตรง → แยกเป็น Task
        _ = HandleInsertAsync(e.Entity);
    }

    private async Task ProcessExistingRecordsAsync(CancellationToken stoppingToken)
    {
        try
        {
            using var scope = _scopeFactory.CreateScope();
            var warehouseDbContext = scope.ServiceProvider.GetRequiredService<WarehouseDbContext>();

            // ดึงข้อมูลที่ยังค้างอยู่ใน tb_Itf_TMS_QueueManagement
            var pendingList = await warehouseDbContext.Set<TbItfTmsQueueManagement>()
                .AsNoTracking()
                .OrderBy(q => q.RecordId)  // จะเอา order อื่นก็ปรับได้
                .ToListAsync(stoppingToken);

            _logger.LogInformation("Found {Count} existing rows in tb_Itf_TMS_QueueManagement to process.", pendingList.Count);

            foreach (var row in pendingList)
            {
                if (stoppingToken.IsCancellationRequested)
                    break;

                // ใช้ logic เดิมที่เขียนไว้แล้ว
                await HandleInsertAsync(row);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while processing existing records from tb_Itf_TMS_QueueManagement");
            //Console.WriteLine($"[ERROR ProcessExistingRecordsAsync] {ex.Message}");
        }
    }


    private async Task HandleInsertAsync(TbItfTmsQueueManagement x)
    {
        try
        {
            //Console.WriteLine("==================================================");
            //Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] INSERT DETECTED");
            //Console.WriteLine($"RecordId           : {x.RecordId}");
            //Console.WriteLine($"TruckNo            : {x.TruckNo}");
            //Console.WriteLine($"LoadingSeq         : {x.LoadingSeq}");
            //Console.WriteLine($"TransportSeq       : {x.TransportSeq}");
            //Console.WriteLine($"LoadingNo          : {x.LoadingNo}");
            //Console.WriteLine($"ShippingNoteNo     : {x.ShippingNoteNo}");
            //Console.WriteLine($"JobTypeId          : {x.JobTypeId}");
            //Console.WriteLine($"JobTypeName        : {x.JobTypeName}");
            //Console.WriteLine($"ShippingCustomerId : {x.ShippingCustomerId}");
            //Console.WriteLine($"ShippingCustName   : {x.ShippingCustomerName}");
            //Console.WriteLine($"ShiptFromId        : {x.ShiptFromId}");
            //Console.WriteLine($"ShipFromName       : {x.ShipFromName}");
            //Console.WriteLine($"ShiptToId          : {x.ShiptToId}");
            //Console.WriteLine($"ShiptToName        : {x.ShiptToName}");
            //Console.WriteLine($"AreaCode           : {x.AreaCode}");
            //Console.WriteLine($"GateCode           : {x.GateCode}");
            //Console.WriteLine($"CheckInDate        : {x.CheckInDate}");
            //Console.WriteLine($"StatusId           : {x.StatusId}");
            //Console.WriteLine($"StatusName         : {x.StatusName}");
            //Console.WriteLine($"CreateDate         : {x.CreateDate}");
            //Console.WriteLine($"FinalTruckFlag     : {x.FinalTruckFlag}");
            //Console.WriteLine("==================================================");

            using var scope = _scopeFactory.CreateScope();
            var _msdbcontext = scope.ServiceProvider.GetRequiredService<MSDBContext>();
            var _warehouseDbContext = scope.ServiceProvider.GetRequiredService<WarehouseDbContext>();

            var dtForShip = x.CheckInDate ?? x.CreateDate ?? DateTime.Now;

            var model = new TbtQueueMonitoring
            {
                RecordId = x.RecordId,
                TruckNo = x.TruckNo,
                LoadingSeq = x.LoadingSeq,
                TransportSeq = x.TransportSeq,
                LoadingNo = x.LoadingNo,
                ShippingNoteNo = x.ShippingNoteNo,
                JobTypeId = x.JobTypeId,
                JobTypeName = x.JobTypeName,
                ShippingCustomerId = x.ShippingCustomerId,
                ShippingCustomerName = x.ShippingCustomerName,
                ShiptFromId = x.ShiptFromId,
                ShipFromName = x.ShipFromName,
                ShiptToId = x.ShiptToId,
                ShiptToName = x.ShiptToName,
                AreaCode = x.AreaCode,
                GateCode = x.GateCode,
                CheckInDate = x.CheckInDate,
                StatusId = x.StatusId,
                StatusName = x.StatusName,
                CreateDate = x.CreateDate,
                FinalTruckFlag = x.FinalTruckFlag,
                TripNo = x.TripNo,
                TripNoText = x.TripNoText,
                ShiptToCode = x.ShiptToCode
            };

            var existing = await _msdbcontext.Set<TbtQueueMonitoring>().FindAsync(model.RecordId);


            if (existing != null)
            {
                _msdbcontext.Set<TbtQueueMonitoring>().Remove(existing);
                await _msdbcontext.SaveChangesAsync(); // กัน key ชน (โดยเฉพาะถ้า RecordId เป็น PK)
            }

            _msdbcontext.Set<TbtQueueMonitoring>().Add(model);
            //if (existing == null)
            //{

            //    _msdbcontext.Set<TbtQueueMonitoring>().Add(model);
            //}
            //else
            //{
            //    _msdbcontext.Entry(existing).CurrentValues.SetValues(model);
            //}

            await _msdbcontext.SaveChangesAsync();

            // ลบ record ที่ถูก process แล้วออกจาก tb_Itf_TMS_QueueManagement
            await _warehouseDbContext.Set<TbItfTmsQueueManagement>()
                .Where(q => q.RecordId == x.RecordId)
                .ExecuteDeleteAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in HandleInsertAsync");
            Console.WriteLine($"[ERROR OnChanged] {ex.Message}");
        }
    }
}
