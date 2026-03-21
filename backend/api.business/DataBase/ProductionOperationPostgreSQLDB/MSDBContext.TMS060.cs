using Microsoft.EntityFrameworkCore;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;
using static BusinessSQLDB.Models.StoredProcedure.TMS060Models;

namespace BusinessSQLDB;


public partial class MSDBContext
{
    void OnModelCreatingForTMS060(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<stp_TMS060_GetParkingLotHistory_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS060_GetParkingLotHistory_Result");
        });


    }

}

