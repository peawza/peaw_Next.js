using Microsoft.EntityFrameworkCore;

namespace WarehouseSQLDB;

public partial class WarehouseDbContext : DbContext
{
    void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        OnModelCreatingForStoredProcedure(modelBuilder);
    }


}

