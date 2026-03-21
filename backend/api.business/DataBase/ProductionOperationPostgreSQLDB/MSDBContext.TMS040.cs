using Microsoft.EntityFrameworkCore;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;
using static BusinessSQLDB.Models.StoredProcedure.TMS040Models;

namespace BusinessSQLDB;


public partial class MSDBContext
{
    void OnModelCreatingForTMS040(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<sp_TMS040_GetQueueMonitoring_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS040_GetQueueMonitoring_Result");
        });


    }

}

