using Microsoft.EntityFrameworkCore;
using static BusinessAPI.Model.WarehouseModels;

namespace WarehouseSQLDB;


public partial class WarehouseDbContext
{
    void OnModelCreatingForStoredProcedure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_UACJ_TMS_DeliveryPlan_Getdatda_Result");
        });

        //sp_UACJ_TMS_QueueManagement_Getdatda_Result

        modelBuilder.Entity<sp_UACJ_TMS_QueueManagement_Getdatda_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_UACJ_TMS_QueueManagement_Getdatda_Result");
        });

        modelBuilder.Entity<sp_common_LoadDC_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("ssp_common_LoadDC_Result");
        });

        modelBuilder.Entity<sp_UACJRPT_ShippingNote_GetData_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_UACJRPT_ShippingNote_GetData_Result");
        });
    }




}

