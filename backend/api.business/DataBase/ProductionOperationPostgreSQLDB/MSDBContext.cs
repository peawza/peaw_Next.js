using BusinessSQLDB.Models.MesSystem;
using Microsoft.EntityFrameworkCore;

namespace BusinessSQLDB;

public partial class MSDBContext : DbContext
{
    public MSDBContext(DbContextOptions<MSDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ParkingSlot> ParkingSlots { get; set; }

    public virtual DbSet<TbApiSmsLog> TbApiSmsLogs { get; set; }

    public virtual DbSet<TbDepartment> TbDepartments { get; set; }

    public virtual DbSet<TbGroupPermission> TbGroupPermissions { get; set; }

    public virtual DbSet<TbLoginOtp> TbLoginOtps { get; set; }

    public virtual DbSet<TbPasswordHistory> TbPasswordHistories { get; set; }

    public virtual DbSet<TbPosition> TbPositions { get; set; }

    public virtual DbSet<TbRole> TbRoles { get; set; }

    public virtual DbSet<TbRoleClaim> TbRoleClaims { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserClaim> TbUserClaims { get; set; }

    public virtual DbSet<TbUserInfo> TbUserInfos { get; set; }

    public virtual DbSet<TbUserLogin> TbUserLogins { get; set; }

    public virtual DbSet<TbUserRole> TbUserRoles { get; set; }

    public virtual DbSet<TbUserToken> TbUserTokens { get; set; }

    public virtual DbSet<TbmMiscellaneousCode> TbmMiscellaneousCodes { get; set; }

    public virtual DbSet<TbmMiscellaneousType> TbmMiscellaneousTypes { get; set; }

    public virtual DbSet<TbmParkingLotLocation> TbmParkingLotLocations { get; set; }

    public virtual DbSet<TbmParkingLotStatus> TbmParkingLotStatuses { get; set; }

    public virtual DbSet<TbmParkingWaitingList> TbmParkingWaitingLists { get; set; }

    public virtual DbSet<TbmParkingWaitingListCancel> TbmParkingWaitingListCancels { get; set; }

    public virtual DbSet<TbmShippingCustomer> TbmShippingCustomers { get; set; }

    public virtual DbSet<TbmTelephoneTruck> TbmTelephoneTrucks { get; set; }

    public virtual DbSet<TbmTransportCompany> TbmTransportCompanies { get; set; }

    public virtual DbSet<TbmTruckCompany> TbmTruckCompanies { get; set; }

    public virtual DbSet<TbtParkingLotHistory> TbtParkingLotHistories { get; set; }

    public virtual DbSet<TbtQueueMonitoring> TbtQueueMonitorings { get; set; }

    public virtual DbSet<TbtSendSmshistory> TbtSendSmshistories { get; set; }

    public virtual DbSet<TsImportLog> TsImportLogs { get; set; }

    public virtual DbSet<TsImportLogDetail> TsImportLogDetails { get; set; }

    public virtual DbSet<TsLocalizedMessage> TsLocalizedMessages { get; set; }

    public virtual DbSet<TsLocalizedResource> TsLocalizedResources { get; set; }

    public virtual DbSet<TsModule> TsModules { get; set; }

    public virtual DbSet<TsScreen> TsScreens { get; set; }

    public virtual DbSet<TsScreenFunction> TsScreenFunctions { get; set; }

    public virtual DbSet<TsSubModule> TsSubModules { get; set; }

    public virtual DbSet<TsSystemConfig> TsSystemConfigs { get; set; }

    public virtual DbSet<TsUrlconfig> TsUrlconfigs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParkingSlot>(entity =>
        {
            entity.HasKey(e => e.SlotId).HasName("PK__ParkingS__0A124AAF6B2FA938");

            entity.ToTable("ParkingSlot");

            entity.Property(e => e.AreaGroup).HasMaxLength(50);
            entity.Property(e => e.ColorHex)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Height).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ParkingId).HasColumnName("ParkingID");
            entity.Property(e => e.Rotation).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.X).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Y).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<TbApiSmsLog>(entity =>
        {
            entity.ToTable("tb_API_SMS_Logs");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.RequsestJson)
                .IsUnicode(false)
                .HasColumnName("RequsestJSON");
            entity.Property(e => e.ResponseJson)
                .IsUnicode(false)
                .HasColumnName("ResponseJSON");
            entity.Property(e => e.ResponseStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<TbDepartment>(entity =>
        {
            entity.ToTable("tb_Department");

            entity.HasIndex(e => e.DepartmentCode, "IX_tb_Department_DepartmentCode").IsUnique();
        });

        modelBuilder.Entity<TbGroupPermission>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.ScreenId });

            entity.ToTable("tb_GroupPermission");
        });

        modelBuilder.Entity<TbLoginOtp>(entity =>
        {
            entity.HasKey(e => e.OtpId);

            entity.ToTable("tb_LoginOtp");

            entity.Property(e => e.OtpId).ValueGeneratedNever();
            entity.Property(e => e.Channel).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LoginIdentifier).HasMaxLength(100);
            entity.Property(e => e.OtpCodeHash).HasMaxLength(200);
            entity.Property(e => e.ReferenceNo).HasMaxLength(50);
            entity.Property(e => e.RequestIp).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UserAgent).HasMaxLength(256);
        });

        modelBuilder.Entity<TbPasswordHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.HistoryId });

            entity.ToTable("tb_PasswordHistory");

            entity.Property(e => e.Id).HasComment("User ID (Main Key)");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.TbPasswordHistories).HasForeignKey(d => d.Id);
        });

        modelBuilder.Entity<TbPosition>(entity =>
        {
            entity.ToTable("tb_Position");

            entity.HasIndex(e => e.PositionCode, "IX_tb_Position_PositionCode").IsUnique();
        });

        modelBuilder.Entity<TbRole>(entity =>
        {
            entity.ToTable("tb_Role");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.DeletedBy).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Discriminator).HasMaxLength(21);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
        });

        modelBuilder.Entity<TbRoleClaim>(entity =>
        {
            entity.ToTable("tb_RoleClaim");

            entity.HasIndex(e => e.RoleId, "IX_tb_RoleClaim_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.TbRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.ToTable("tb_User");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Otplogin).HasColumnName("OTPLogin");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<TbUserClaim>(entity =>
        {
            entity.ToTable("tb_UserClaim");

            entity.HasIndex(e => e.UserId, "IX_tb_UserClaim_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.TbUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbUserInfo>(entity =>
        {
            entity.ToTable("tb_UserInfo");

            entity.Property(e => e.Id).HasComment("User ID (Main Key)");
            entity.Property(e => e.CreateDate).HasComment("Create Date");
            entity.Property(e => e.CreatedBy).HasComment("Create By");
            entity.Property(e => e.DepartmentCode).HasComment("Department Code login");
            entity.Property(e => e.EmployeeCode).HasComment("Employee Code");
            entity.Property(e => e.FirstName).HasComment("First Name");
            entity.Property(e => e.LanguageCode).HasComment("Language Code login");
            entity.Property(e => e.LastName).HasComment("Last Name");
            entity.Property(e => e.PositionCode).HasComment("Position Code login");
            entity.Property(e => e.Remark).HasComment("Remark, more note.");
            entity.Property(e => e.UpdateDate).HasComment("Update Date");
            entity.Property(e => e.UpdatedBy).HasComment("Update By");
            entity.Property(e => e.UserName).HasComment("UserName");
        });

        modelBuilder.Entity<TbUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("tb_UserLogin");

            entity.HasIndex(e => e.UserId, "IX_tb_UserLogin_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.TbUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.ToTable("tb_UserRole");

            entity.HasIndex(e => e.RoleId, "IX_tb_UserRole_RoleId");

            entity.Property(e => e.Discriminator).HasMaxLength(34);

            entity.HasOne(d => d.Role).WithMany(p => p.TbUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.TbUserRoles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("tb_UserToken");

            entity.HasOne(d => d.User).WithMany(p => p.TbUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbmMiscellaneousCode>(entity =>
        {
            entity.HasKey(e => new { e.MiscTypeCode, e.MiscCode });

            entity.ToTable("tbm_MiscellaneousCode");

            entity.Property(e => e.MiscTypeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MiscCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .HasDefaultValue("SYSTEM");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InactiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.MiscName).HasMaxLength(100);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(255)
                .HasDefaultValue("System");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Value1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Value2)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmMiscellaneousType>(entity =>
        {
            entity.HasKey(e => e.MiscTypeCode);

            entity.ToTable("tbm_MiscellaneousType");

            entity.Property(e => e.MiscTypeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MiscTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmParkingLotLocation>(entity =>
        {
            entity.HasKey(e => e.SlotId).HasName("PK__tbm_Park__0A124AAFFE99A49F");

            entity.ToTable("tbm_ParkingLotLocation");

            entity.Property(e => e.AreaGroup).HasMaxLength(50);
            entity.Property(e => e.ColorHex)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Height).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ParkingId).HasColumnName("ParkingID");
            entity.Property(e => e.Rotation).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.X).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Y).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<TbmParkingLotStatus>(entity =>
        {
            entity.HasKey(e => e.ParkingId).HasName("PK_tbm_ParkingLotStatus_1");

            entity.ToTable("tbm_ParkingLotStatus");

            entity.Property(e => e.ParkingId)
                .ValueGeneratedNever()
                .HasColumnName("ParkingID");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentSms)
                .HasMaxLength(500)
                .HasColumnName("CurrentSMS");
            entity.Property(e => e.FromParkingId).HasColumnName("FromParkingID");
            entity.Property(e => e.LastSendSns)
                .HasColumnType("datetime")
                .HasColumnName("LastSendSNS");
            entity.Property(e => e.LoadingId).HasColumnName("LoadingID");
            entity.Property(e => e.ParkingStampDatetime).HasMaxLength(50);
            entity.Property(e => e.ParkingTime).HasColumnType("datetime");
            entity.Property(e => e.ParkingTruckNo).HasMaxLength(10);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TelephoneNo).HasMaxLength(50);
            entity.Property(e => e.ToParkingId).HasColumnName("ToParkingID");
            entity.Property(e => e.TransportCompanyId).HasColumnName("TransportCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmParkingWaitingList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbm_ParkingWaitingList_1");

            entity.ToTable("tbm_ParkingWaitingList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentSms)
                .HasMaxLength(500)
                .HasColumnName("CurrentSMS");
            entity.Property(e => e.FromParkingId).HasColumnName("FromParkingID");
            entity.Property(e => e.LastSendSns)
                .HasColumnType("datetime")
                .HasColumnName("LastSendSNS");
            entity.Property(e => e.LoadingId).HasColumnName("LoadingID");
            entity.Property(e => e.ParkingId).HasColumnName("ParkingID");
            entity.Property(e => e.ParkingStampDatetime).HasMaxLength(50);
            entity.Property(e => e.ParkingTime).HasColumnType("datetime");
            entity.Property(e => e.ParkingTruckNo).HasMaxLength(10);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TelephoneNo).HasMaxLength(20);
            entity.Property(e => e.ToParkingId).HasColumnName("ToParkingID");
            entity.Property(e => e.TransportCompanyId).HasColumnName("TransportCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmParkingWaitingListCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbm_ParkingWaitingList_Cancel");

            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime).HasColumnType("datetime");
            entity.Property(e => e.CurrentSms)
                .HasMaxLength(500)
                .HasColumnName("CurrentSMS");
            entity.Property(e => e.FromParkingId).HasColumnName("FromParkingID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastSendSns)
                .HasColumnType("datetime")
                .HasColumnName("LastSendSNS");
            entity.Property(e => e.LoadingId).HasColumnName("LoadingID");
            entity.Property(e => e.ParkingId).HasColumnName("ParkingID");
            entity.Property(e => e.ParkingStampDatetime).HasMaxLength(50);
            entity.Property(e => e.ParkingTime).HasColumnType("datetime");
            entity.Property(e => e.ParkingTruckNo).HasMaxLength(10);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TelephoneNo).HasMaxLength(20);
            entity.Property(e => e.ToParkingId).HasColumnName("ToParkingID");
            entity.Property(e => e.TransportCompanyId).HasColumnName("TransportCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmShippingCustomer>(entity =>
        {
            entity.HasKey(e => e.ShippingCustomerId);

            entity.ToTable("tbm_ShippingCustomer");

            entity.Property(e => e.ShippingCustomerId)
                .ValueGeneratedNever()
                .HasColumnName("ShippingCustomerID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.ShippingCustomerCode).HasMaxLength(100);
            entity.Property(e => e.ShippingCustomerName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmTelephoneTruck>(entity =>
        {
            entity.HasKey(e => e.TruckNo);

            entity.ToTable("tbm_TelephoneTruck");

            entity.Property(e => e.TruckNo).HasMaxLength(20);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.TelephoneNo).HasMaxLength(50);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmTransportCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("tbm_TransportCompany");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmTruckCompany>(entity =>
        {
            entity.HasKey(e => e.TruckCompanyId);

            entity.ToTable("tbm_TruckCompany");

            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.TruckCompanyCode).HasMaxLength(15);
            entity.Property(e => e.TruckCompanyLongName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtParkingLotHistory>(entity =>
        {
            entity.ToTable("tbt_ParkingLotHistory");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FinishDatetime).HasColumnType("datetime");
            entity.Property(e => e.LoadingId).HasColumnName("LoadingID");
            entity.Property(e => e.LocationFrom).HasMaxLength(50);
            entity.Property(e => e.LocationTo).HasMaxLength(50);
            entity.Property(e => e.ParkingDatetime).HasColumnType("datetime");
            entity.Property(e => e.ParkingId).HasColumnName("ParkingID");
            entity.Property(e => e.ParkingStampDatetime).HasMaxLength(50);
            entity.Property(e => e.ParkingTruckNo).HasMaxLength(10);
            entity.Property(e => e.TransportCompanyId).HasColumnName("TransportCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtQueueMonitoring>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_QueueMonitoringNe");

            entity.ToTable("tbt_QueueMonitoring");

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasColumnName("RecordID");
            entity.Property(e => e.AreaCode).HasMaxLength(20);
            entity.Property(e => e.CheckInDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GateCode).HasMaxLength(20);
            entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");
            entity.Property(e => e.JobTypeName).HasMaxLength(20);
            entity.Property(e => e.LoadingNo).HasMaxLength(20);
            entity.Property(e => e.LoadingSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ShipFromName).HasMaxLength(100);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.ShippingCustomerName).HasMaxLength(100);
            entity.Property(e => e.ShippingNoteNo).HasMaxLength(20);
            entity.Property(e => e.ShiptFromId).HasColumnName("ShiptFromID");
            entity.Property(e => e.ShiptToCode).HasMaxLength(20);
            entity.Property(e => e.ShiptToId).HasColumnName("ShiptToID");
            entity.Property(e => e.ShiptToName).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName).HasMaxLength(100);
            entity.Property(e => e.TransportSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TripNoText).HasMaxLength(20);
            entity.Property(e => e.TruckNo).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtSendSmshistory>(entity =>
        {
            entity.ToTable("tbt_SendSMSHistory");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Contact).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.ParkingStampDatetime).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Sms)
                .HasMaxLength(500)
                .HasColumnName("SMS");
            entity.Property(e => e.TelephoneNo).HasMaxLength(20);
            entity.Property(e => e.TruckNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TsImportLog>(entity =>
        {
            entity.HasKey(e => e.JobLogId);

            entity.ToTable("ts_ImportLog");

            entity.Property(e => e.JobLogId).HasMaxLength(40);
            entity.Property(e => e.FileFolder).HasMaxLength(255);
            entity.Property(e => e.FtpServername).HasMaxLength(100);
            entity.Property(e => e.InterfaceCode).HasMaxLength(20);
            entity.Property(e => e.InterfaceFilename).HasMaxLength(255);
            entity.Property(e => e.InterfaceName).HasMaxLength(100);
            entity.Property(e => e.JobStatus).HasMaxLength(100);
            entity.Property(e => e.ProcessBy).HasMaxLength(50);
        });

        modelBuilder.Entity<TsImportLogDetail>(entity =>
        {
            entity.ToTable("ts_ImportLogDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ErrorDetail).HasMaxLength(255);
            entity.Property(e => e.JobLogId).HasMaxLength(40);
        });

        modelBuilder.Entity<TsLocalizedMessage>(entity =>
        {
            entity.HasKey(e => new { e.MessageCode, e.MessageType });

            entity.ToTable("ts_LocalizedMessages");

            entity.Property(e => e.MessageCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageNameEn)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MessageNameEN");
            entity.Property(e => e.MessageNameTh)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MessageNameTH");
            entity.Property(e => e.Remark)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TsLocalizedResource>(entity =>
        {
            entity.HasKey(e => new { e.ScreenCode, e.ObjectId });

            entity.ToTable("ts_LocalizedResources");

            entity.Property(e => e.ScreenCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ObjectID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.ResourcesEn)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ResourcesEN");
            entity.Property(e => e.ResourcesTh)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ResourcesTH");
        });

        modelBuilder.Entity<TsModule>(entity =>
        {
            entity.ToTable("ts_Module");

            entity.Property(e => e.IconClass).HasMaxLength(50);
            entity.Property(e => e.ModuleCode).HasMaxLength(50);
            entity.Property(e => e.ModuleNameEn)
                .HasMaxLength(100)
                .HasColumnName("ModuleNameEN");
            entity.Property(e => e.ModuleNameTh)
                .HasMaxLength(100)
                .HasColumnName("ModuleNameTH");
        });

        modelBuilder.Entity<TsScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenId);

            entity.ToTable("ts_Screen");

            entity.Property(e => e.ScreenId).HasMaxLength(50);
            entity.Property(e => e.IconClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModuleCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameTh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NameTH");
            entity.Property(e => e.PageTitleNameEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PageTitleNameEN");
            entity.Property(e => e.PageTitleNameTh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PageTitleNameTH");
            entity.Property(e => e.SubModuleCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupportDeviceType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TsScreenFunction>(entity =>
        {
            entity.HasKey(e => e.FunctionId);

            entity.ToTable("ts_ScreenFunction");

            entity.Property(e => e.FunctionName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TsSubModule>(entity =>
        {
            entity.ToTable("ts_SubModule");

            entity.Property(e => e.IconClass).HasMaxLength(50);
            entity.Property(e => e.SubModuleCode).HasMaxLength(50);
            entity.Property(e => e.SubModuleNameEn)
                .HasMaxLength(100)
                .HasColumnName("SubModuleNameEN");
            entity.Property(e => e.SubModuleNameTh)
                .HasMaxLength(100)
                .HasColumnName("SubModuleNameTH");
        });

        modelBuilder.Entity<TsSystemConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigCode);

            entity.ToTable("ts_SystemConfig");

            entity.Property(e => e.ConfigCode).HasMaxLength(50);
            entity.Property(e => e.ConfigDesc).HasMaxLength(255);
            entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TsUrlconfig>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ts_URLConfig");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.UpdateUserId)
                .HasMaxLength(50)
                .HasColumnName("UpdateUserID");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("URL");
        });

        OnModelCreatingPartial(modelBuilder);
    }


}
