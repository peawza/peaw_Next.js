using Microsoft.EntityFrameworkCore;
using static BusinessSQLDB.Models.StoredProcedure.TMS050Models;

namespace BusinessSQLDB;


public partial class MSDBContext
{
    void OnModelCreatingForTMS050(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<stp_TMS050_GetCombo_ContainerType_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_ContainerType_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_Contact_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_Contact_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_Destination_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_Destination_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_JobType_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_JobType_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_LoadingType_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_LoadingType_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_Message_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_Message_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetCombo_TransportCompany_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetCombo_TransportCompany_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetParkingStatus_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetParkingStatus_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetParkingWaiting_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetParkingWaiting_Result");
        });

        modelBuilder.Entity<stp_TMS050_GetSummaryParkingStatus_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_GetSummaryParkingStatus_Result");
        });

        modelBuilder.Entity<stp_TMS050_Insert_TelephoneTruck_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_Insert_TelephoneTruck_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_InsertSendSMS_History_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_InsertSendSMS_History_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_InsertWaitingList_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_InsertWaitingList_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_UpdateParkingAll_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingAll_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_UpdateParkingAllEmpty_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingAllEmpty_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_UpdateParkingByLot_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingByLot_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_UpdateParkingEmptyAll_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingEmptyAll_Criteria");
        });

        modelBuilder.Entity<stp_TMS050_UpdateParkingEmptyByLot_Criteria>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingEmptyByLot_Criteria");
        });
        modelBuilder.Entity<sp_TMS050_GetParkingLotLocation_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS050_GetParkingLotLocation_Result");
        });

        modelBuilder.Entity<sp_TMS050_GetParkingLotStatus_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("sp_TMS050_GetParkingLotStatus_Result");
        });

        modelBuilder.Entity<stp_TMS050_CancelWaitingList_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_CancelWaitingList_Result");
        });
        modelBuilder.Entity<stp_TMS050_UpdateParkingEmptyByLot_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_UpdateParkingEmptyByLot_Result");
        });

        modelBuilder.Entity<stp_TMS050_Insert_ParkingWaitingList_Result>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("stp_TMS050_Insert_ParkingWaitingList_Result");
        });


    }




}

