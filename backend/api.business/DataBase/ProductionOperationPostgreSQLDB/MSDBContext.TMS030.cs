using Microsoft.EntityFrameworkCore;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;
using static BusinessSQLDB.Models.StoredProcedure.TMS030Models;

namespace BusinessSQLDB;


public partial class MSDBContext
{
    void OnModelCreatingForTMS030(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<sp_TMS030_GetCombo_Customer_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS030_GetCombo_Customer_Result");
        });

        modelBuilder.Entity<sp_TMS030_GetCombo_TransportCompany_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS030_GetCombo_TransportCompany_Result");
        });

        modelBuilder.Entity<sp_TMS030_GetCombo_JobType_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS030_GetCombo_JobType_Result");
        });

        modelBuilder.Entity<sp_TMS030_GetCombo_JobStatus_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS030_GetCombo_JobStatus_Result");
        });


    }




}

