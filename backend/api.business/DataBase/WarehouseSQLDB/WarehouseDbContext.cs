using Microsoft.EntityFrameworkCore;
using WarehouseSQLDB.Models.Tables;

namespace WarehouseSQLDB;

public partial class WarehouseDbContext : DbContext
{
    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbGroupMapping> TbGroupMappings { get; set; }

    public virtual DbSet<TbItfChangeStatus> TbItfChangeStatuses { get; set; }

    public virtual DbSet<TbItfTmsQueueManagement> TbItfTmsQueueManagements { get; set; }

    public virtual DbSet<TbItfTmsQueueManagementBk> TbItfTmsQueueManagementBks { get; set; }

    public virtual DbSet<TbItfUacjMetaDatum> TbItfUacjMetaData { get; set; }

    public virtual DbSet<TbItfUacjPackingResult> TbItfUacjPackingResults { get; set; }

    public virtual DbSet<TbItfUacjPackingResultBk> TbItfUacjPackingResultBks { get; set; }

    public virtual DbSet<TbItfUacjProductInventoryDisposal> TbItfUacjProductInventoryDisposals { get; set; }

    public virtual DbSet<TbItfUacjProductInventoryDisposalBk> TbItfUacjProductInventoryDisposalBks { get; set; }

    public virtual DbSet<TbItfUacjProductInventoryStatus> TbItfUacjProductInventoryStatuses { get; set; }

    public virtual DbSet<TbItfUacjProductInventoryStatusBk> TbItfUacjProductInventoryStatusBks { get; set; }

    public virtual DbSet<TbItfUacjRawdataBk> TbItfUacjRawdataBks { get; set; }

    public virtual DbSet<TbItfUacjRawdataBk2> TbItfUacjRawdataBk2s { get; set; }

    public virtual DbSet<TbItfUacjRawdataBk3> TbItfUacjRawdataBk3s { get; set; }

    public virtual DbSet<TbItfUacjRawdatum> TbItfUacjRawdata { get; set; }

    public virtual DbSet<TbItfUacjSalesOrder> TbItfUacjSalesOrders { get; set; }

    public virtual DbSet<TbItfUacjSalesOrderBk> TbItfUacjSalesOrderBks { get; set; }

    public virtual DbSet<TbItfUacjTransfer> TbItfUacjTransfers { get; set; }

    public virtual DbSet<TbItfUacjTransferBk> TbItfUacjTransferBks { get; set; }

    public virtual DbSet<TbLang> TbLangs { get; set; }

    public virtual DbSet<TbLangCtrl> TbLangCtrls { get; set; }

    public virtual DbSet<TbLangMap> TbLangMaps { get; set; }

    public virtual DbSet<TbScreen> TbScreens { get; set; }

    public virtual DbSet<TbScreensControl> TbScreensControls { get; set; }

    public virtual DbSet<TbSecurityMatch> TbSecurityMatches { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserGroup> TbUserGroups { get; set; }

    public virtual DbSet<TbUserWebMapping> TbUserWebMappings { get; set; }

    public virtual DbSet<TbaUserRegistration> TbaUserRegistrations { get; set; }

    public virtual DbSet<TbmAllocatePriority> TbmAllocatePriorities { get; set; }

    public virtual DbSet<TbmClassification> TbmClassifications { get; set; }

    public virtual DbSet<TbmCostTransport> TbmCostTransports { get; set; }

    public virtual DbSet<TbmCustShippingCustMapping> TbmCustShippingCustMappings { get; set; }

    public virtual DbSet<TbmCustomer> TbmCustomers { get; set; }

    public virtual DbSet<TbmCustomerPortMapping> TbmCustomerPortMappings { get; set; }

    public virtual DbSet<TbmDccodeMapping> TbmDccodeMappings { get; set; }

    public virtual DbSet<TbmDccustomerMapping> TbmDccustomerMappings { get; set; }

    public virtual DbSet<TbmDcwhmapping> TbmDcwhmappings { get; set; }

    public virtual DbSet<TbmDeadStock> TbmDeadStocks { get; set; }

    public virtual DbSet<TbmDefaultInitialTransitZone> TbmDefaultInitialTransitZones { get; set; }

    public virtual DbSet<TbmDistributionCenter> TbmDistributionCenters { get; set; }

    public virtual DbSet<TbmFinalDestination> TbmFinalDestinations { get; set; }

    public virtual DbSet<TbmJobCategory> TbmJobCategories { get; set; }

    public virtual DbSet<TbmJobType> TbmJobTypes { get; set; }

    public virtual DbSet<TbmKanbanStatus> TbmKanbanStatuses { get; set; }

    public virtual DbSet<TbmLocation> TbmLocations { get; set; }

    public virtual DbSet<TbmLocationLayout> TbmLocationLayouts { get; set; }

    public virtual DbSet<TbmLogoImage> TbmLogoImages { get; set; }

    public virtual DbSet<TbmMisc> TbmMiscs { get; set; }

    public virtual DbSet<TbmOtp> TbmOtps { get; set; }

    public virtual DbSet<TbmPackage> TbmPackages { get; set; }

    public virtual DbSet<TbmPackageOutbound> TbmPackageOutbounds { get; set; }

    public virtual DbSet<TbmPlant> TbmPlants { get; set; }

    public virtual DbSet<TbmPlantMapping> TbmPlantMappings { get; set; }

    public virtual DbSet<TbmPort> TbmPorts { get; set; }

    public virtual DbSet<TbmProduct> TbmProducts { get; set; }

    public virtual DbSet<TbmProductCondition> TbmProductConditions { get; set; }

    public virtual DbSet<TbmProductConditionMapping> TbmProductConditionMappings { get; set; }

    public virtual DbSet<TbmProductDefaultUnit> TbmProductDefaultUnits { get; set; }

    public virtual DbSet<TbmProductDefaultZoneTransit> TbmProductDefaultZoneTransits { get; set; }

    public virtual DbSet<TbmProductDetail> TbmProductDetails { get; set; }

    public virtual DbSet<TbmProductHandingCharge> TbmProductHandingCharges { get; set; }

    public virtual DbSet<TbmProductNotification> TbmProductNotifications { get; set; }

    public virtual DbSet<TbmProductVoid> TbmProductVoids { get; set; }

    public virtual DbSet<TbmRoute> TbmRoutes { get; set; }

    public virtual DbSet<TbmRouteD> TbmRouteDs { get; set; }

    public virtual DbSet<TbmShippingArea> TbmShippingAreas { get; set; }

    public virtual DbSet<TbmShippingContainer> TbmShippingContainers { get; set; }

    public virtual DbSet<TbmShippingCustomer> TbmShippingCustomers { get; set; }

    public virtual DbSet<TbmSloc> TbmSlocs { get; set; }

    public virtual DbSet<TbmSlocPlantDcmapping> TbmSlocPlantDcmappings { get; set; }

    public virtual DbSet<TbmSubTypeOfGood> TbmSubTypeOfGoods { get; set; }

    public virtual DbSet<TbmSupplier> TbmSuppliers { get; set; }

    public virtual DbSet<TbmTariffType> TbmTariffTypes { get; set; }

    public virtual DbSet<TbmTransportFeeOption> TbmTransportFeeOptions { get; set; }

    public virtual DbSet<TbmTransportType> TbmTransportTypes { get; set; }

    public virtual DbSet<TbmTransportUnStaffingCharge> TbmTransportUnStaffingCharges { get; set; }

    public virtual DbSet<TbmTruckAllocatePlan> TbmTruckAllocatePlans { get; set; }

    public virtual DbSet<TbmTruckCompany> TbmTruckCompanies { get; set; }

    public virtual DbSet<TbmTruckMaster> TbmTruckMasters { get; set; }

    public virtual DbSet<TbmTruckTransportTypeMapping> TbmTruckTransportTypeMappings { get; set; }

    public virtual DbSet<TbmTypeOfGood> TbmTypeOfGoods { get; set; }

    public virtual DbSet<TbmTypeOfUnit> TbmTypeOfUnits { get; set; }

    public virtual DbSet<TbmWarehouseType> TbmWarehouseTypes { get; set; }

    public virtual DbSet<TbmWorkMethod> TbmWorkMethods { get; set; }

    public virtual DbSet<TbmWorkMethodSetting> TbmWorkMethodSettings { get; set; }

    public virtual DbSet<TbmZone> TbmZones { get; set; }

    public virtual DbSet<TbmZoneCapacityMaster> TbmZoneCapacityMasters { get; set; }

    public virtual DbSet<TbmZoneCustomerMapping> TbmZoneCustomerMappings { get; set; }

    public virtual DbSet<TbmZoneUserMapping> TbmZoneUserMappings { get; set; }

    public virtual DbSet<TbsAcJobNoRunning> TbsAcJobNoRunnings { get; set; }

    public virtual DbSet<TbsAlphabetValue> TbsAlphabetValues { get; set; }

    public virtual DbSet<TbsAmphur> TbsAmphurs { get; set; }

    public virtual DbSet<TbsControlBag> TbsControlBags { get; set; }

    public virtual DbSet<TbsControlLot> TbsControlLots { get; set; }

    public virtual DbSet<TbsControlMixLot> TbsControlMixLots { get; set; }

    public virtual DbSet<TbsControlPack> TbsControlPacks { get; set; }

    public virtual DbSet<TbsControlPallet> TbsControlPallets { get; set; }

    public virtual DbSet<TbsControlPicking> TbsControlPickings { get; set; }

    public virtual DbSet<TbsControlSerial> TbsControlSerials { get; set; }

    public virtual DbSet<TbsControlShelfLife> TbsControlShelfLives { get; set; }

    public virtual DbSet<TbsControlVoid> TbsControlVoids { get; set; }

    public virtual DbSet<TbsDateDailyPost> TbsDateDailyPosts { get; set; }

    public virtual DbSet<TbsDistrictOld> TbsDistrictOlds { get; set; }

    public virtual DbSet<TbsDocType> TbsDocTypes { get; set; }

    public virtual DbSet<TbsFileType> TbsFileTypes { get; set; }

    public virtual DbSet<TbsGenerateDocumentNo> TbsGenerateDocumentNos { get; set; }

    public virtual DbSet<TbsItemExpiredType> TbsItemExpiredTypes { get; set; }

    public virtual DbSet<TbsLocationType> TbsLocationTypes { get; set; }

    public virtual DbSet<TbsModule> TbsModules { get; set; }

    public virtual DbSet<TbsNotificationItem> TbsNotificationItems { get; set; }

    public virtual DbSet<TbsOrderPattern> TbsOrderPatterns { get; set; }

    public virtual DbSet<TbsOrorderType> TbsOrorderTypes { get; set; }

    public virtual DbSet<TbsOtpmaster> TbsOtpmasters { get; set; }

    public virtual DbSet<TbsPalletType> TbsPalletTypes { get; set; }

    public virtual DbSet<TbsPoorderType> TbsPoorderTypes { get; set; }

    public virtual DbSet<TbsPortClassification> TbsPortClassifications { get; set; }

    public virtual DbSet<TbsProvince> TbsProvinces { get; set; }

    public virtual DbSet<TbsRankAging> TbsRankAgings { get; set; }

    public virtual DbSet<TbsRegion> TbsRegions { get; set; }

    public virtual DbSet<TbsReport> TbsReports { get; set; }

    public virtual DbSet<TbsReportConfig> TbsReportConfigs { get; set; }

    public virtual DbSet<TbsReportParam> TbsReportParams { get; set; }

    public virtual DbSet<TbsReportParamD> TbsReportParamDs { get; set; }

    public virtual DbSet<TbsReportParamH> TbsReportParamHs { get; set; }

    public virtual DbSet<TbsRunningNoDetail> TbsRunningNoDetails { get; set; }

    public virtual DbSet<TbsRunningNoHeader> TbsRunningNoHeaders { get; set; }

    public virtual DbSet<TbsScanType> TbsScanTypes { get; set; }

    public virtual DbSet<TbsStatus> TbsStatuses { get; set; }

    public virtual DbSet<TbsSystemConfig> TbsSystemConfigs { get; set; }

    public virtual DbSet<TbsUnitConvertTable> TbsUnitConvertTables { get; set; }

    public virtual DbSet<TbtAutobookProcess> TbtAutobookProcesses { get; set; }

    public virtual DbSet<TbtBillingCostForIncomingCharge> TbtBillingCostForIncomingCharges { get; set; }

    public virtual DbSet<TbtBillingCostForOutgoingCharge> TbtBillingCostForOutgoingCharges { get; set; }

    public virtual DbSet<TbtBillingDataForChargeSummarize> TbtBillingDataForChargeSummarizes { get; set; }

    public virtual DbSet<TbtBillingDataForEstimateValue> TbtBillingDataForEstimateValues { get; set; }

    public virtual DbSet<TbtBillingDataForMovement> TbtBillingDataForMovements { get; set; }

    public virtual DbSet<TbtBillingDataForOtherCharge> TbtBillingDataForOtherCharges { get; set; }

    public virtual DbSet<TbtBillingDataForPicking> TbtBillingDataForPickings { get; set; }

    public virtual DbSet<TbtBillingDataForReceiving> TbtBillingDataForReceivings { get; set; }

    public virtual DbSet<TbtBillingDataForShipping> TbtBillingDataForShippings { get; set; }

    public virtual DbSet<TbtBillingDataForStock> TbtBillingDataForStocks { get; set; }

    public virtual DbSet<TbtBillingDataForStockRecShip> TbtBillingDataForStockRecShips { get; set; }

    public virtual DbSet<TbtBillingDataForTransitCharge> TbtBillingDataForTransitCharges { get; set; }

    public virtual DbSet<TbtBillingDataForTransportCharge> TbtBillingDataForTransportCharges { get; set; }

    public virtual DbSet<TbtBillingDataForTransportChargeReceive> TbtBillingDataForTransportChargeReceives { get; set; }

    public virtual DbSet<TbtBillingDataForUnstaffing> TbtBillingDataForUnstaffings { get; set; }

    public virtual DbSet<TbtBillingPalletMapping> TbtBillingPalletMappings { get; set; }

    public virtual DbSet<TbtChangeLocation> TbtChangeLocations { get; set; }

    public virtual DbSet<TbtChangeLocationHistory> TbtChangeLocationHistories { get; set; }

    public virtual DbSet<TbtChangeLocationPhotoDetail> TbtChangeLocationPhotoDetails { get; set; }

    public virtual DbSet<TbtChangeLocationPhotoHeader> TbtChangeLocationPhotoHeaders { get; set; }

    public virtual DbSet<TbtDailyPosted> TbtDailyPosteds { get; set; }

    public virtual DbSet<TbtDailyPostedForBilling> TbtDailyPostedForBillings { get; set; }

    public virtual DbSet<TbtDailySummarized> TbtDailySummarizeds { get; set; }

    public virtual DbSet<TbtDcReport> TbtDcReports { get; set; }

    public virtual DbSet<TbtDeliveryNoteShipmentOrder> TbtDeliveryNoteShipmentOrders { get; set; }

    public virtual DbSet<TbtDeliveryNoteShipmentOrdersDetail> TbtDeliveryNoteShipmentOrdersDetails { get; set; }

    public virtual DbSet<TbtEmptyShipmentGroup> TbtEmptyShipmentGroups { get; set; }

    public virtual DbSet<TbtFastLoadDetail> TbtFastLoadDetails { get; set; }

    public virtual DbSet<TbtFastLoadHeader> TbtFastLoadHeaders { get; set; }

    public virtual DbSet<TbtGiserialCaptureD> TbtGiserialCaptureDs { get; set; }

    public virtual DbSet<TbtGiserialCaptureH> TbtGiserialCaptureHs { get; set; }

    public virtual DbSet<TbtGivoidCaptureD> TbtGivoidCaptureDs { get; set; }

    public virtual DbSet<TbtGivoidCaptureH> TbtGivoidCaptureHs { get; set; }

    public virtual DbSet<TbtImportRmStockHistory> TbtImportRmStockHistories { get; set; }

    public virtual DbSet<TbtInfCmstrackingReq> TbtInfCmstrackingReqs { get; set; }

    public virtual DbSet<TbtInfRetry> TbtInfRetries { get; set; }

    public virtual DbSet<TbtInfUnloadDatum> TbtInfUnloadData { get; set; }

    public virtual DbSet<TbtInterfaceLog> TbtInterfaceLogs { get; set; }

    public virtual DbSet<TbtInterfaceMasterLog> TbtInterfaceMasterLogs { get; set; }

    public virtual DbSet<TbtInterfaceOrderRetrieve> TbtInterfaceOrderRetrieves { get; set; }

    public virtual DbSet<TbtInterfacePack> TbtInterfacePacks { get; set; }

    public virtual DbSet<TbtInterfacePackingResult> TbtInterfacePackingResults { get; set; }

    public virtual DbSet<TbtInterfacePackingResultBk> TbtInterfacePackingResultBks { get; set; }

    public virtual DbSet<TbtInterfacePick> TbtInterfacePicks { get; set; }

    public virtual DbSet<TbtInterfaceProductInventoryDisposal> TbtInterfaceProductInventoryDisposals { get; set; }

    public virtual DbSet<TbtInterfaceProductInventoryStatus> TbtInterfaceProductInventoryStatuses { get; set; }

    public virtual DbSet<TbtInterfaceSalesOrder> TbtInterfaceSalesOrders { get; set; }

    public virtual DbSet<TbtInterfaceSalesOrderBk> TbtInterfaceSalesOrderBks { get; set; }

    public virtual DbSet<TbtInterfaceShipment> TbtInterfaceShipments { get; set; }

    public virtual DbSet<TbtInterfaceStatus> TbtInterfaceStatuses { get; set; }

    public virtual DbSet<TbtInterfaceStatusHistory> TbtInterfaceStatusHistories { get; set; }

    public virtual DbSet<TbtInterfaceTm> TbtInterfaceTms { get; set; }

    public virtual DbSet<TbtInterfaceTmsdetail> TbtInterfaceTmsdetails { get; set; }

    public virtual DbSet<TbtInterfaceToSap> TbtInterfaceToSaps { get; set; }

    public virtual DbSet<TbtInterfaceToSapBk> TbtInterfaceToSapBks { get; set; }

    public virtual DbSet<TbtInterfaceToThact660> TbtInterfaceToThact660s { get; set; }

    public virtual DbSet<TbtInterfaceToThact660Bk> TbtInterfaceToThact660Bks { get; set; }

    public virtual DbSet<TbtInterfaceToThact670> TbtInterfaceToThact670s { get; set; }

    public virtual DbSet<TbtInterfaceToThact670Bk> TbtInterfaceToThact670Bks { get; set; }

    public virtual DbSet<TbtInterfaceToThact690> TbtInterfaceToThact690s { get; set; }

    public virtual DbSet<TbtInterfaceToThact690Bk> TbtInterfaceToThact690Bks { get; set; }

    public virtual DbSet<TbtInterfaceTransfer> TbtInterfaceTransfers { get; set; }

    public virtual DbSet<TbtInterfaceTransferBk> TbtInterfaceTransferBks { get; set; }

    public virtual DbSet<TbtKanbanConfirmation> TbtKanbanConfirmations { get; set; }

    public virtual DbSet<TbtKanbanRegisterDetail> TbtKanbanRegisterDetails { get; set; }

    public virtual DbSet<TbtKanbanRegisterHeader> TbtKanbanRegisterHeaders { get; set; }

    public virtual DbSet<TbtKanbanSuggestLocation> TbtKanbanSuggestLocations { get; set; }

    public virtual DbSet<TbtMonthlyPosted> TbtMonthlyPosteds { get; set; }

    public virtual DbSet<TbtMonthlyUpdateSetting> TbtMonthlyUpdateSettings { get; set; }

    public virtual DbSet<TbtMovementTran> TbtMovementTrans { get; set; }

    public virtual DbSet<TbtMovementTransSummaryMonthly> TbtMovementTransSummaryMonthlies { get; set; }

    public virtual DbSet<TbtOmsdeliveryDetail> TbtOmsdeliveryDetails { get; set; }

    public virtual DbSet<TbtOmsdeliveryHeader> TbtOmsdeliveryHeaders { get; set; }

    public virtual DbSet<TbtOmsdeliveryOrderItemsDetail> TbtOmsdeliveryOrderItemsDetails { get; set; }

    public virtual DbSet<TbtOmsmasterDataTmp> TbtOmsmasterDataTmps { get; set; }

    public virtual DbSet<TbtOmsmasterDatum> TbtOmsmasterData { get; set; }

    public virtual DbSet<TbtOrderCancelReceiveHistory> TbtOrderCancelReceiveHistories { get; set; }

    public virtual DbSet<TbtOrderCancelShipHistory> TbtOrderCancelShipHistories { get; set; }

    public virtual DbSet<TbtOrderRefreshReceiveHistory> TbtOrderRefreshReceiveHistories { get; set; }

    public virtual DbSet<TbtOrderRefreshShipHistory> TbtOrderRefreshShipHistories { get; set; }

    public virtual DbSet<TbtPacking> TbtPackings { get; set; }

    public virtual DbSet<TbtPackingD> TbtPackingDs { get; set; }

    public virtual DbSet<TbtPackingDamageVoid> TbtPackingDamageVoids { get; set; }

    public virtual DbSet<TbtPackingSerialMapping> TbtPackingSerialMappings { get; set; }

    public virtual DbSet<TbtPackingServiceMapping> TbtPackingServiceMappings { get; set; }

    public virtual DbSet<TbtPackingVoid> TbtPackingVoids { get; set; }

    public virtual DbSet<TbtPalletMapping> TbtPalletMappings { get; set; }

    public virtual DbSet<TbtPalletMappingLog> TbtPalletMappingLogs { get; set; }

    public virtual DbSet<TbtPalletMovement> TbtPalletMovements { get; set; }

    public virtual DbSet<TbtPickingConfirmDestinationPallet> TbtPickingConfirmDestinationPallets { get; set; }

    public virtual DbSet<TbtPickingDetail> TbtPickingDetails { get; set; }

    public virtual DbSet<TbtPickingDetailConfirmed> TbtPickingDetailConfirmeds { get; set; }

    public virtual DbSet<TbtPickingDetailSerialD> TbtPickingDetailSerialDs { get; set; }

    public virtual DbSet<TbtPickingDetailSerialH> TbtPickingDetailSerialHs { get; set; }

    public virtual DbSet<TbtPickingDetailVoidD> TbtPickingDetailVoidDs { get; set; }

    public virtual DbSet<TbtPickingDetailVoidH> TbtPickingDetailVoidHs { get; set; }

    public virtual DbSet<TbtPickingHeader> TbtPickingHeaders { get; set; }

    public virtual DbSet<TbtPickingServiceMapping> TbtPickingServiceMappings { get; set; }

    public virtual DbSet<TbtPoinformation> TbtPoinformations { get; set; }

    public virtual DbSet<TbtPoinformationDetail> TbtPoinformationDetails { get; set; }

    public virtual DbSet<TbtProductTag> TbtProductTags { get; set; }

    public virtual DbSet<TbtReceivingConfirmed> TbtReceivingConfirmeds { get; set; }

    public virtual DbSet<TbtReceivingConfirmedByHandy> TbtReceivingConfirmedByHandies { get; set; }

    public virtual DbSet<TbtReceivingConfirmedTemp> TbtReceivingConfirmedTemps { get; set; }

    public virtual DbSet<TbtReceivingHistory> TbtReceivingHistories { get; set; }

    public virtual DbSet<TbtReceivingInstructionCoa> TbtReceivingInstructionCoas { get; set; }

    public virtual DbSet<TbtReceivingInstructionDetail> TbtReceivingInstructionDetails { get; set; }

    public virtual DbSet<TbtReceivingInstructionDetailItemRefer> TbtReceivingInstructionDetailItemRefers { get; set; }

    public virtual DbSet<TbtReceivingInstructionDetailRefer> TbtReceivingInstructionDetailRefers { get; set; }

    public virtual DbSet<TbtReceivingInstructionHeader> TbtReceivingInstructionHeaders { get; set; }

    public virtual DbSet<TbtReceivingInstructionHeaderRefer> TbtReceivingInstructionHeaderRefers { get; set; }

    public virtual DbSet<TbtReceivingOtherCharge> TbtReceivingOtherCharges { get; set; }

    public virtual DbSet<TbtReceivingPhotoDetail> TbtReceivingPhotoDetails { get; set; }

    public virtual DbSet<TbtReceivingPhotoHeader> TbtReceivingPhotoHeaders { get; set; }

    public virtual DbSet<TbtReceivingStatus> TbtReceivingStatuses { get; set; }

    public virtual DbSet<TbtReceivingTransportation> TbtReceivingTransportations { get; set; }

    public virtual DbSet<TbtReportChangeLocation> TbtReportChangeLocations { get; set; }

    public virtual DbSet<TbtReportConfirmReceiving> TbtReportConfirmReceivings { get; set; }

    public virtual DbSet<TbtReportCorrectionOfInventory> TbtReportCorrectionOfInventories { get; set; }

    public virtual DbSet<TbtReportProofListforReceiving> TbtReportProofListforReceivings { get; set; }

    public virtual DbSet<TbtReportProofListforShipping> TbtReportProofListforShippings { get; set; }

    public virtual DbSet<TbtReturnPickingConfirmed> TbtReturnPickingConfirmeds { get; set; }

    public virtual DbSet<TbtReturnPickingDetail> TbtReturnPickingDetails { get; set; }

    public virtual DbSet<TbtRouteCountingDetail> TbtRouteCountingDetails { get; set; }

    public virtual DbSet<TbtRouteCountingHeader> TbtRouteCountingHeaders { get; set; }

    public virtual DbSet<TbtShipNoteInformation> TbtShipNoteInformations { get; set; }

    public virtual DbSet<TbtShippingAndDeliveryReport> TbtShippingAndDeliveryReports { get; set; }

    public virtual DbSet<TbtShippingDeliveryPlanDetail> TbtShippingDeliveryPlanDetails { get; set; }

    public virtual DbSet<TbtShippingDeliveryPlanHeader> TbtShippingDeliveryPlanHeaders { get; set; }

    public virtual DbSet<TbtShippingDeliveryPlanLot> TbtShippingDeliveryPlanLots { get; set; }

    public virtual DbSet<TbtShippingDeliveryPlanPicNotuse> TbtShippingDeliveryPlanPicNotuses { get; set; }

    public virtual DbSet<TbtShippingDeliverySchedule> TbtShippingDeliverySchedules { get; set; }

    public virtual DbSet<TbtShippingHistory> TbtShippingHistories { get; set; }

    public virtual DbSet<TbtShippingInstruction> TbtShippingInstructions { get; set; }

    public virtual DbSet<TbtShippingInterfaceHeader> TbtShippingInterfaceHeaders { get; set; }

    public virtual DbSet<TbtShippingLoadingDetail> TbtShippingLoadingDetails { get; set; }

    public virtual DbSet<TbtShippingLoadingHeader> TbtShippingLoadingHeaders { get; set; }

    public virtual DbSet<TbtShippingOrderManualDetail> TbtShippingOrderManualDetails { get; set; }

    public virtual DbSet<TbtShippingOrderManualHeader> TbtShippingOrderManualHeaders { get; set; }

    public virtual DbSet<TbtShippingOtherCharge> TbtShippingOtherCharges { get; set; }

    public virtual DbSet<TbtShippingPlanInfo> TbtShippingPlanInfos { get; set; }

    public virtual DbSet<TbtShippingPlanSalesOrder> TbtShippingPlanSalesOrders { get; set; }

    public virtual DbSet<TbtShippingPlanTransfer> TbtShippingPlanTransfers { get; set; }

    public virtual DbSet<TbtShippingStatus> TbtShippingStatuses { get; set; }

    public virtual DbSet<TbtShippingTransportFee> TbtShippingTransportFees { get; set; }

    public virtual DbSet<TbtShippingTransportation> TbtShippingTransportations { get; set; }

    public virtual DbSet<TbtSmsSendLog> TbtSmsSendLogs { get; set; }

    public virtual DbSet<TbtSpaceUtilizationSnapshot> TbtSpaceUtilizationSnapshots { get; set; }

    public virtual DbSet<TbtStockByLocation> TbtStockByLocations { get; set; }

    public virtual DbSet<TbtStockCountingDetail> TbtStockCountingDetails { get; set; }

    public virtual DbSet<TbtStockCountingDetailBySticker> TbtStockCountingDetailByStickers { get; set; }

    public virtual DbSet<TbtStockCountingHeader> TbtStockCountingHeaders { get; set; }

    public virtual DbSet<TbtStockMovement> TbtStockMovements { get; set; }

    public virtual DbSet<TbtStockMovementShipbyhandy> TbtStockMovementShipbyhandies { get; set; }

    public virtual DbSet<TbtStockOfClient> TbtStockOfClients { get; set; }

    public virtual DbSet<TbtStockPosted> TbtStockPosteds { get; set; }

    public virtual DbSet<TbtStockShippingPosted> TbtStockShippingPosteds { get; set; }

    public virtual DbSet<TbtStockTakingHistory> TbtStockTakingHistories { get; set; }

    public virtual DbSet<TbtSuggestPickingLocation> TbtSuggestPickingLocations { get; set; }

    public virtual DbSet<TbtSuggestResourceManagementDetail> TbtSuggestResourceManagementDetails { get; set; }

    public virtual DbSet<TbtSuggestResourceManagementHeader> TbtSuggestResourceManagementHeaders { get; set; }

    public virtual DbSet<TbtSuggestTransitLocation> TbtSuggestTransitLocations { get; set; }

    public virtual DbSet<TbtTagmapping> TbtTagmappings { get; set; }

    public virtual DbSet<TbtTagmappingCoilNo> TbtTagmappingCoilNos { get; set; }

    public virtual DbSet<TbtTagmappingRm> TbtTagmappingRms { get; set; }

    public virtual DbSet<TbtTagmappingTemp> TbtTagmappingTemps { get; set; }

    public virtual DbSet<TbtTmsCheckInLog> TbtTmsCheckInLogs { get; set; }

    public virtual DbSet<TbtTmsdeliveryService> TbtTmsdeliveryServices { get; set; }

    public virtual DbSet<TbtTmsshipmentLeg> TbtTmsshipmentLegs { get; set; }

    public virtual DbSet<TbtTmsshipmentLoadStopList> TbtTmsshipmentLoadStopLists { get; set; }

    public virtual DbSet<TbtTmsshipmentService> TbtTmsshipmentServices { get; set; }

    public virtual DbSet<TbtTransferWarehouseDetail> TbtTransferWarehouseDetails { get; set; }

    public virtual DbSet<TbtTransferWarehouseMapping> TbtTransferWarehouseMappings { get; set; }

    public virtual DbSet<TbtTransitConfirmed> TbtTransitConfirmeds { get; set; }

    public virtual DbSet<TbtTransitInstruction> TbtTransitInstructions { get; set; }

    public virtual DbSet<TbtTransitInstructionItem> TbtTransitInstructionItems { get; set; }

    public virtual DbSet<TmpFinal1> TmpFinal1s { get; set; }

    public virtual DbSet<TmpFinal2> TmpFinal2s { get; set; }

    public virtual DbSet<TmpFinal3> TmpFinal3s { get; set; }

    public virtual DbSet<TmpFinaltransaction> TmpFinaltransactions { get; set; }

    public virtual DbSet<TmpInitialInvenW3> TmpInitialInvenW3s { get; set; }

    public virtual DbSet<TmpLangMapSpaceUtilization> TmpLangMapSpaceUtilizations { get; set; }

    public virtual DbSet<TmpScreenLangSpaceUtilization> TmpScreenLangSpaceUtilizations { get; set; }

    public virtual DbSet<TmpShipmentDetail> TmpShipmentDetails { get; set; }

    public virtual DbSet<TmpShipmentDetailsTruckBooking> TmpShipmentDetailsTruckBookings { get; set; }

    public virtual DbSet<TmpWhgraph> TmpWhgraphs { get; set; }

    public virtual DbSet<TmpWhtable> TmpWhtables { get; set; }

    public virtual DbSet<VInterfaceEventName> VInterfaceEventNames { get; set; }

    public virtual DbSet<VMultilang> VMultilangs { get; set; }

    public virtual DbSet<VReceiveReport> VReceiveReports { get; set; }

    public virtual DbSet<VStockbylocation> VStockbylocations { get; set; }

    public virtual DbSet<VThact660Export> VThact660Exports { get; set; }

    public virtual DbSet<VThact670Export> VThact670Exports { get; set; }

    public virtual DbSet<VThact690Export> VThact690Exports { get; set; }

    public virtual DbSet<VThactInterfaceExportAll> VThactInterfaceExportAlls { get; set; }

    public virtual DbSet<VwCustomer> VwCustomers { get; set; }

    public virtual DbSet<VwFinalDestination> VwFinalDestinations { get; set; }

    public virtual DbSet<VwProductControlVoid> VwProductControlVoids { get; set; }

    public virtual DbSet<VwProductControlVoidName> VwProductControlVoidNames { get; set; }

    public virtual DbSet<VwProductControlVoidNameShort> VwProductControlVoidNameShorts { get; set; }

    public virtual DbSet<VwReportItemStatusGroup> VwReportItemStatusGroups { get; set; }

    public virtual DbSet<VwReportItemStatusGroupMapping> VwReportItemStatusGroupMappings { get; set; }

    public virtual DbSet<VwShippingInfoSummary> VwShippingInfoSummaries { get; set; }

    public virtual DbSet<VwStockActual> VwStockActuals { get; set; }

    public virtual DbSet<VwTest> VwTests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbGroupMapping>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Groupid }).HasName("PK_tb_UserMatch");

            entity.ToTable("tb_GroupMapping");

            entity.Property(e => e.Userid)
                .HasMaxLength(15)
                .HasComment("User ID")
                .HasColumnName("USERID");
            entity.Property(e => e.Groupid)
                .HasComment("Group ID")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("GROUPID");

            entity.HasOne(d => d.Group).WithMany(p => p.TbGroupMappings)
                .HasForeignKey(d => d.Groupid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_GroupMapping_tb_UserGroups");
        });

        modelBuilder.Entity<TbItfChangeStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_ITF_ChangeStatus");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.AdjustmentQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.Dccode)
                .HasMaxLength(20)
                .HasColumnName("DCCode");
            entity.Property(e => e.LocationCode).HasMaxLength(17);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.Ownercode).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.Plant).HasMaxLength(10);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductConditionCode).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ResultQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SlipNo).HasMaxLength(100);
            entity.Property(e => e.Sloc).HasMaxLength(10);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbItfTmsQueueManagement>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tb_Itf_TMS_QueueManagement", tb =>
                {
                    tb.HasTrigger("tr_dbo_tb_Itf_TMS_QueueManagement_9dc11370-2b1b-4953-aa3d-64626f9412a6_Sender");
                    tb.HasTrigger("tr_dbo_tb_Itf_TMS_QueueManagement_dd4d4aa2-cc8c-4b44-8b8b-684c504a5947_Sender");
                });

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
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
            entity.Property(e => e.StatusId)
                .HasComment("1 = Arrival Yard , ")
                .HasColumnName("StatusID");
            entity.Property(e => e.StatusName).HasMaxLength(100);
            entity.Property(e => e.TransportSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TripNoText).HasMaxLength(20);
            entity.Property(e => e.TruckNo).HasMaxLength(20);
        });

        modelBuilder.Entity<TbItfTmsQueueManagementBk>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tb_Itf_TMS_QueueManagement_BK");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
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

        modelBuilder.Entity<TbItfUacjMetaDatum>(entity =>
        {
            entity.HasKey(e => e.InfSeq).HasName("PK_tb_Itf_Thact_MetaData");

            entity.ToTable("tb_Itf_UACJ_MetaData");

            entity.Property(e => e.InfSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Inf_Seq");
            entity.Property(e => e.Column1).HasMaxLength(200);
            entity.Property(e => e.Column10).HasMaxLength(200);
            entity.Property(e => e.Column11).HasMaxLength(200);
            entity.Property(e => e.Column12).HasMaxLength(200);
            entity.Property(e => e.Column13).HasMaxLength(200);
            entity.Property(e => e.Column14).HasMaxLength(200);
            entity.Property(e => e.Column15).HasMaxLength(200);
            entity.Property(e => e.Column16).HasMaxLength(200);
            entity.Property(e => e.Column17).HasMaxLength(200);
            entity.Property(e => e.Column18).HasMaxLength(200);
            entity.Property(e => e.Column19).HasMaxLength(200);
            entity.Property(e => e.Column2).HasMaxLength(200);
            entity.Property(e => e.Column20).HasMaxLength(200);
            entity.Property(e => e.Column21).HasMaxLength(200);
            entity.Property(e => e.Column22).HasMaxLength(200);
            entity.Property(e => e.Column23).HasMaxLength(200);
            entity.Property(e => e.Column24).HasMaxLength(200);
            entity.Property(e => e.Column25).HasMaxLength(200);
            entity.Property(e => e.Column26).HasMaxLength(200);
            entity.Property(e => e.Column27).HasMaxLength(200);
            entity.Property(e => e.Column28).HasMaxLength(200);
            entity.Property(e => e.Column29).HasMaxLength(200);
            entity.Property(e => e.Column3).HasMaxLength(200);
            entity.Property(e => e.Column30).HasMaxLength(200);
            entity.Property(e => e.Column31).HasMaxLength(200);
            entity.Property(e => e.Column32).HasMaxLength(200);
            entity.Property(e => e.Column33).HasMaxLength(200);
            entity.Property(e => e.Column34).HasMaxLength(200);
            entity.Property(e => e.Column35).HasMaxLength(200);
            entity.Property(e => e.Column36).HasMaxLength(200);
            entity.Property(e => e.Column37).HasMaxLength(200);
            entity.Property(e => e.Column38).HasMaxLength(200);
            entity.Property(e => e.Column39).HasMaxLength(200);
            entity.Property(e => e.Column4).HasMaxLength(200);
            entity.Property(e => e.Column40).HasMaxLength(200);
            entity.Property(e => e.Column41).HasMaxLength(200);
            entity.Property(e => e.Column42).HasMaxLength(200);
            entity.Property(e => e.Column43).HasMaxLength(200);
            entity.Property(e => e.Column44).HasMaxLength(200);
            entity.Property(e => e.Column45).HasMaxLength(200);
            entity.Property(e => e.Column46).HasMaxLength(200);
            entity.Property(e => e.Column47).HasMaxLength(200);
            entity.Property(e => e.Column48).HasMaxLength(200);
            entity.Property(e => e.Column49).HasMaxLength(200);
            entity.Property(e => e.Column5).HasMaxLength(200);
            entity.Property(e => e.Column50).HasMaxLength(200);
            entity.Property(e => e.Column51).HasMaxLength(200);
            entity.Property(e => e.Column52).HasMaxLength(200);
            entity.Property(e => e.Column53).HasMaxLength(200);
            entity.Property(e => e.Column54).HasMaxLength(200);
            entity.Property(e => e.Column55).HasMaxLength(200);
            entity.Property(e => e.Column56).HasMaxLength(200);
            entity.Property(e => e.Column57).HasMaxLength(200);
            entity.Property(e => e.Column58).HasMaxLength(200);
            entity.Property(e => e.Column59).HasMaxLength(200);
            entity.Property(e => e.Column6).HasMaxLength(200);
            entity.Property(e => e.Column60).HasMaxLength(200);
            entity.Property(e => e.Column7).HasMaxLength(200);
            entity.Property(e => e.Column8).HasMaxLength(200);
            entity.Property(e => e.Column9).HasMaxLength(200);
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
        });

        modelBuilder.Entity<TbItfUacjPackingResult>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_PackingResult");

            entity.ToTable("tb_Itf_UACJ_PackingResult");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.CoilAxisVerticalHorizontalDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilAxis_VerticalHorizontal_Division");
            entity.Property(e => e.CoilNo)
                .HasMaxLength(100)
                .HasColumnName("Coil_No");
            entity.Property(e => e.CoilWindingUnwindingDirectionDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilWinding_UnwindingDirection_Division");
            entity.Property(e => e.ConsumerDisplaySizeTextKana)
                .HasMaxLength(100)
                .HasColumnName("ConsumerDisplaySize_Text_KANA");
            entity.Property(e => e.ConsumerItemCode)
                .HasMaxLength(100)
                .HasColumnName("ConsumerItem_Code");
            entity.Property(e => e.ConsumerName)
                .HasMaxLength(100)
                .HasColumnName("Consumer_Name");
            entity.Property(e => e.ConsumerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("ConsumerOrder_No");
            entity.Property(e => e.ConsumerProductNameHalfWidth)
                .HasMaxLength(100)
                .HasColumnName("ConsumerProduct_Name_HalfWidth");
            entity.Property(e => e.CustomerItemCode)
                .HasMaxLength(100)
                .HasColumnName("CustomerItem_Code");
            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("CustomerOrder_No");
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("ExternalAlloy_Name");
            entity.Property(e => e.InHouseAlloyCode)
                .HasMaxLength(100)
                .HasColumnName("InHouseAlloy_Code");
            entity.Property(e => e.IndividualPackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Quantity");
            entity.Property(e => e.IndividualPackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Weight_Net");
            entity.Property(e => e.IntermediateFinalPackageDivision)
                .HasMaxLength(100)
                .HasColumnName("IntermediateFinal_Package_Division");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(100)
                .HasColumnName("Item_No");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasColumnName("Lot_No");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingInstruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingQuality_Type");
            entity.Property(e => e.OddStackCount)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Count");
            entity.Property(e => e.OddStackHeight)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Height");
            entity.Property(e => e.OddStackRows)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Rows");
            entity.Property(e => e.PackageCount)
                .HasMaxLength(100)
                .HasColumnName("Package_Count");
            entity.Property(e => e.PackageDetailsQuantity)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Quantity");
            entity.Property(e => e.PackageDetailsTrackingNo)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Tracking_No");
            entity.Property(e => e.PackageDetailsWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Weight_Net");
            entity.Property(e => e.PackageNo)
                .HasMaxLength(100)
                .HasColumnName("Package_No");
            entity.Property(e => e.PackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageWeightGloss)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Gloss");
            entity.Property(e => e.PackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Net");
            entity.Property(e => e.PalletNo)
                .HasMaxLength(100)
                .HasColumnName("Pallet_No");
            entity.Property(e => e.PddNo)
                .HasMaxLength(100)
                .HasColumnName("PDD_No");
            entity.Property(e => e.ProductInventoryStatus)
                .HasMaxLength(100)
                .HasColumnName("ProductInventory_Status");
            entity.Property(e => e.ProductInventoryStatusChangeDate)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Date");
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeEmployee_Name");
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeReason_Comment");
            entity.Property(e => e.ProductInventoryStatusChangeTime)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Time");
            entity.Property(e => e.ProductInventoryStatusSettingDivision)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_SettingDivision");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("ProductName_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Length");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Width");
            entity.Property(e => e.ProductTypeCode)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Code");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Name");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(100)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.QualityTypeForConsumerDisplay)
                .HasMaxLength(100)
                .HasColumnName("QualityType_ForConsumerDisplay");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StackCount)
                .HasMaxLength(100)
                .HasColumnName("Stack_Count");
            entity.Property(e => e.StackHeight)
                .HasMaxLength(100)
                .HasColumnName("Stack_Height");
            entity.Property(e => e.StackRows)
                .HasMaxLength(100)
                .HasColumnName("Stack_Rows");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode)
                .HasMaxLength(100)
                .HasColumnName("SurfaceTreatment_AuxiliaryCode");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbItfUacjPackingResultBk>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_PackingResult_BK");

            entity.ToTable("tb_Itf_UACJ_PackingResult_BK");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.CoilAxisVerticalHorizontalDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilAxis_VerticalHorizontal_Division");
            entity.Property(e => e.CoilNo)
                .HasMaxLength(100)
                .HasColumnName("Coil_No");
            entity.Property(e => e.CoilWindingUnwindingDirectionDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilWinding_UnwindingDirection_Division");
            entity.Property(e => e.ConsumerDisplaySizeTextKana)
                .HasMaxLength(100)
                .HasColumnName("ConsumerDisplaySize_Text_KANA");
            entity.Property(e => e.ConsumerItemCode)
                .HasMaxLength(100)
                .HasColumnName("ConsumerItem_Code");
            entity.Property(e => e.ConsumerName)
                .HasMaxLength(100)
                .HasColumnName("Consumer_Name");
            entity.Property(e => e.ConsumerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("ConsumerOrder_No");
            entity.Property(e => e.ConsumerProductNameHalfWidth)
                .HasMaxLength(100)
                .HasColumnName("ConsumerProduct_Name_HalfWidth");
            entity.Property(e => e.CustomerItemCode)
                .HasMaxLength(100)
                .HasColumnName("CustomerItem_Code");
            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("CustomerOrder_No");
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("ExternalAlloy_Name");
            entity.Property(e => e.InHouseAlloyCode)
                .HasMaxLength(100)
                .HasColumnName("InHouseAlloy_Code");
            entity.Property(e => e.IndividualPackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Quantity");
            entity.Property(e => e.IndividualPackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Weight_Net");
            entity.Property(e => e.IntermediateFinalPackageDivision)
                .HasMaxLength(100)
                .HasColumnName("IntermediateFinal_Package_Division");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(100)
                .HasColumnName("Item_No");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasColumnName("Lot_No");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingInstruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingQuality_Type");
            entity.Property(e => e.OddStackCount)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Count");
            entity.Property(e => e.OddStackHeight)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Height");
            entity.Property(e => e.OddStackRows)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Rows");
            entity.Property(e => e.PackageCount)
                .HasMaxLength(100)
                .HasColumnName("Package_Count");
            entity.Property(e => e.PackageDetailsQuantity)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Quantity");
            entity.Property(e => e.PackageDetailsTrackingNo)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Tracking_No");
            entity.Property(e => e.PackageDetailsWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Weight_Net");
            entity.Property(e => e.PackageNo)
                .HasMaxLength(100)
                .HasColumnName("Package_No");
            entity.Property(e => e.PackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageWeightGloss)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Gloss");
            entity.Property(e => e.PackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Net");
            entity.Property(e => e.PalletNo)
                .HasMaxLength(100)
                .HasColumnName("Pallet_No");
            entity.Property(e => e.PddNo)
                .HasMaxLength(100)
                .HasColumnName("PDD_No");
            entity.Property(e => e.ProductInventoryStatus)
                .HasMaxLength(100)
                .HasColumnName("ProductInventory_Status");
            entity.Property(e => e.ProductInventoryStatusChangeDate)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Date");
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeEmployee_Name");
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeReason_Comment");
            entity.Property(e => e.ProductInventoryStatusChangeTime)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Time");
            entity.Property(e => e.ProductInventoryStatusSettingDivision)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_SettingDivision");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("ProductName_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Length");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Width");
            entity.Property(e => e.ProductTypeCode)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Code");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Name");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(100)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.QualityTypeForConsumerDisplay)
                .HasMaxLength(100)
                .HasColumnName("QualityType_ForConsumerDisplay");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StackCount)
                .HasMaxLength(100)
                .HasColumnName("Stack_Count");
            entity.Property(e => e.StackHeight)
                .HasMaxLength(100)
                .HasColumnName("Stack_Height");
            entity.Property(e => e.StackRows)
                .HasMaxLength(100)
                .HasColumnName("Stack_Rows");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode)
                .HasMaxLength(100)
                .HasColumnName("SurfaceTreatment_AuxiliaryCode");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbItfUacjProductInventoryDisposal>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo });

            entity.ToTable("tb_itf_UACJ_Product_InventoryDisposal");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.DispensingActionClassification).HasMaxLength(100);
            entity.Property(e => e.DispensingDate).HasMaxLength(100);
            entity.Property(e => e.DispensingReasonComment).HasMaxLength(100);
            entity.Property(e => e.DispensingStaffName).HasMaxLength(100);
            entity.Property(e => e.DispensingTime).HasMaxLength(100);
            entity.Property(e => e.PackagingNumber).HasMaxLength(100);
            entity.Property(e => e.RedBlackClassification).HasMaxLength(100);
        });

        modelBuilder.Entity<TbItfUacjProductInventoryDisposalBk>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo });

            entity.ToTable("tb_itf_UACJ_Product_InventoryDisposal_BK");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.DispensingActionClassification).HasMaxLength(100);
            entity.Property(e => e.DispensingDate).HasMaxLength(100);
            entity.Property(e => e.DispensingReasonComment).HasMaxLength(100);
            entity.Property(e => e.DispensingStaffName).HasMaxLength(100);
            entity.Property(e => e.DispensingTime).HasMaxLength(100);
            entity.Property(e => e.PackagingNumber).HasMaxLength(100);
            entity.Property(e => e.RedBlackClassification).HasMaxLength(100);
        });

        modelBuilder.Entity<TbItfUacjProductInventoryStatus>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_itf_Thact_Product_Status");

            entity.ToTable("tb_itf_UACJ_Product_InventoryStatus");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.PackingNumber).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatus).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeDate).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeTime).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusSettingDivision).HasMaxLength(100);
            entity.Property(e => e.RedBlackDivision).HasMaxLength(100);
        });

        modelBuilder.Entity<TbItfUacjProductInventoryStatusBk>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_itf_Thact_Product_Status_BK");

            entity.ToTable("tb_itf_UACJ_Product_InventoryStatus_BK");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.PackingNumber).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatus).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeDate).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeTime).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusSettingDivision).HasMaxLength(100);
            entity.Property(e => e.RedBlackDivision).HasMaxLength(100);
        });

        modelBuilder.Entity<TbItfUacjRawdataBk>(entity =>
        {
            entity.HasKey(e => e.InfSeq).HasName("PK_tb_Rawdata_UACJ_BK");

            entity.ToTable("tb_Itf_UACJ_Rawdata_BK");

            entity.Property(e => e.InfSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Inf_Seq");
            entity.Property(e => e.InfData).HasColumnName("Inf_Data");
            entity.Property(e => e.InfDataSource).HasColumnName("Inf_Data_Source");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfFlag).HasColumnName("Inf_Flag");
            entity.Property(e => e.InfNo).HasColumnName("Inf_No");
        });

        modelBuilder.Entity<TbItfUacjRawdataBk2>(entity =>
        {
            entity.HasKey(e => e.InfSeq).HasName("PK_tb_Rawdata_UACJBK2");

            entity.ToTable("tb_Itf_UACJ_Rawdata_BK2");

            entity.Property(e => e.InfSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Inf_Seq");
            entity.Property(e => e.InfData).HasColumnName("Inf_Data");
            entity.Property(e => e.InfDataSource).HasColumnName("Inf_Data_Source");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfFlag).HasColumnName("Inf_Flag");
            entity.Property(e => e.InfNo).HasColumnName("Inf_No");
        });

        modelBuilder.Entity<TbItfUacjRawdataBk3>(entity =>
        {
            entity.HasKey(e => e.InfSeq).HasName("PK_tb_Rawdata_UACJBK3");

            entity.ToTable("tb_Itf_UACJ_Rawdata_BK3");

            entity.Property(e => e.InfSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Inf_Seq");
            entity.Property(e => e.InfData).HasColumnName("Inf_Data");
            entity.Property(e => e.InfDataSource).HasColumnName("Inf_Data_Source");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfFlag).HasColumnName("Inf_Flag");
            entity.Property(e => e.InfNo).HasColumnName("Inf_No");
        });

        modelBuilder.Entity<TbItfUacjRawdatum>(entity =>
        {
            entity.HasKey(e => e.InfSeq);

            entity.ToTable("tb_Itf_UACJ_Rawdata");

            entity.Property(e => e.InfSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Inf_Seq");
            entity.Property(e => e.InfData).HasColumnName("Inf_Data");
            entity.Property(e => e.InfDataSource).HasColumnName("Inf_Data_Source");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfFlag).HasColumnName("Inf_Flag");
            entity.Property(e => e.InfNo).HasColumnName("Inf_No");
        });

        modelBuilder.Entity<TbItfUacjSalesOrder>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_SalesOrder");

            entity.ToTable("tb_Itf_UACJ_SalesOrder");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.CoilAxisDivision)
                .HasMaxLength(100)
                .HasColumnName("Coil_Axis_Division");
            entity.Property(e => e.CustomerCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_CD");
            entity.Property(e => e.CustomerDisplaySizeText)
                .HasMaxLength(100)
                .HasColumnName("Customer_Display_Size_Text");
            entity.Property(e => e.CustomerItemCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_Item_CD");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerProductName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Product_Name");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.DeliveryDestinationName)
                .HasMaxLength(200)
                .HasColumnName("Delivery_Destination_Name");
            entity.Property(e => e.DeliveryTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_End");
            entity.Property(e => e.DeliveryTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_Start");
            entity.Property(e => e.DestinationCode)
                .HasMaxLength(100)
                .HasColumnName("Destination_Code");
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("External_Alloy_Name");
            entity.Property(e => e.InOutFactorCd)
                .HasMaxLength(100)
                .HasColumnName("In_Out_Factor_CD");
            entity.Property(e => e.InternalAlloyCd)
                .HasMaxLength(100)
                .HasColumnName("Internal_Alloy_CD");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(100)
                .HasColumnName("Item_No");
            entity.Property(e => e.LoadingInstructionTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_End");
            entity.Property(e => e.LoadingInstructionTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_Start");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasColumnName("LOT_No");
            entity.Property(e => e.LotNoFirstSixDigits)
                .HasMaxLength(100)
                .HasColumnName("LOT_No_First_Six_Digits");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Instruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Quality_Type");
            entity.Property(e => e.OrdererAddress)
                .HasMaxLength(200)
                .HasColumnName("Orderer_Address");
            entity.Property(e => e.OrdererCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_CD");
            entity.Property(e => e.OrdererItemCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Item_CD");
            entity.Property(e => e.OrdererName)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Name");
            entity.Property(e => e.OrdererPhoneNumber)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Phone_Number");
            entity.Property(e => e.PackingNo)
                .HasMaxLength(100)
                .HasColumnName("Packing_No");
            entity.Property(e => e.PddNo)
                .HasMaxLength(100)
                .HasColumnName("PDD_No");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("Product_Name_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Length");
            entity.Property(e => e.ProductSizeShape)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Shape");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Width");
            entity.Property(e => e.ProductTypeCd)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_CD");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_Name");
            entity.Property(e => e.QualityTypeForCustomer)
                .HasMaxLength(100)
                .HasColumnName("Quality_Type_For_Customer");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.ShipmentInstructionComment)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Comment");
            entity.Property(e => e.ShipmentInstructionDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Date");
            entity.Property(e => e.ShipmentInstructionDetailNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Detail_No");
            entity.Property(e => e.ShipmentInstructionEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Employee_Name");
            entity.Property(e => e.ShipmentInstructionInputDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Date");
            entity.Property(e => e.ShipmentInstructionInputTime)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Time");
            entity.Property(e => e.ShipmentInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_No");
            entity.Property(e => e.ShipmentInstructionPackingQty)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Packing_Qty");
            entity.Property(e => e.ShipmentInstructionPattern)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Pattern");
            entity.Property(e => e.ShipmentInstructionWeight)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMax)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Max");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMin)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Min");
            entity.Property(e => e.ShipperWarehouseCd)
                .HasMaxLength(100)
                .HasColumnName("Shipper_Warehouse_CD");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.SurfaceTreatmentSubCd)
                .HasMaxLength(100)
                .HasColumnName("Surface_Treatment_Sub_CD");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbItfUacjSalesOrderBk>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_SalesOrder_BK");

            entity.ToTable("tb_Itf_UACJ_SalesOrder_BK");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.CoilAxisDivision)
                .HasMaxLength(100)
                .HasColumnName("Coil_Axis_Division");
            entity.Property(e => e.CustomerCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_CD");
            entity.Property(e => e.CustomerDisplaySizeText)
                .HasMaxLength(100)
                .HasColumnName("Customer_Display_Size_Text");
            entity.Property(e => e.CustomerItemCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_Item_CD");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerProductName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Product_Name");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.DeliveryDestinationName)
                .HasMaxLength(200)
                .HasColumnName("Delivery_Destination_Name");
            entity.Property(e => e.DeliveryTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_End");
            entity.Property(e => e.DeliveryTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_Start");
            entity.Property(e => e.DestinationCode)
                .HasMaxLength(100)
                .HasColumnName("Destination_Code");
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("External_Alloy_Name");
            entity.Property(e => e.InOutFactorCd)
                .HasMaxLength(100)
                .HasColumnName("In_Out_Factor_CD");
            entity.Property(e => e.InternalAlloyCd)
                .HasMaxLength(100)
                .HasColumnName("Internal_Alloy_CD");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(100)
                .HasColumnName("Item_No");
            entity.Property(e => e.LoadingInstructionTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_End");
            entity.Property(e => e.LoadingInstructionTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_Start");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasColumnName("LOT_No");
            entity.Property(e => e.LotNoFirstSixDigits)
                .HasMaxLength(100)
                .HasColumnName("LOT_No_First_Six_Digits");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Instruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Quality_Type");
            entity.Property(e => e.OrdererAddress)
                .HasMaxLength(200)
                .HasColumnName("Orderer_Address");
            entity.Property(e => e.OrdererCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_CD");
            entity.Property(e => e.OrdererItemCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Item_CD");
            entity.Property(e => e.OrdererName)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Name");
            entity.Property(e => e.OrdererPhoneNumber)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Phone_Number");
            entity.Property(e => e.PackingNo)
                .HasMaxLength(100)
                .HasColumnName("Packing_No");
            entity.Property(e => e.PddNo)
                .HasMaxLength(100)
                .HasColumnName("PDD_No");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("Product_Name_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Length");
            entity.Property(e => e.ProductSizeShape)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Shape");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Width");
            entity.Property(e => e.ProductTypeCd)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_CD");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_Name");
            entity.Property(e => e.QualityTypeForCustomer)
                .HasMaxLength(100)
                .HasColumnName("Quality_Type_For_Customer");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.ShipmentInstructionComment)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Comment");
            entity.Property(e => e.ShipmentInstructionDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Date");
            entity.Property(e => e.ShipmentInstructionDetailNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Detail_No");
            entity.Property(e => e.ShipmentInstructionEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Employee_Name");
            entity.Property(e => e.ShipmentInstructionInputDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Date");
            entity.Property(e => e.ShipmentInstructionInputTime)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Time");
            entity.Property(e => e.ShipmentInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_No");
            entity.Property(e => e.ShipmentInstructionPackingQty)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Packing_Qty");
            entity.Property(e => e.ShipmentInstructionPattern)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Pattern");
            entity.Property(e => e.ShipmentInstructionWeight)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMax)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Max");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMin)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Min");
            entity.Property(e => e.ShipperWarehouseCd)
                .HasMaxLength(100)
                .HasColumnName("Shipper_Warehouse_CD");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.SurfaceTreatmentSubCd)
                .HasMaxLength(100)
                .HasColumnName("Surface_Treatment_Sub_CD");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbItfUacjTransfer>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_MoveOrder");

            entity.ToTable("tb_Itf_UACJ_Transfer");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.CoilVerticalHorizontalAxisCategory).HasMaxLength(100);
            entity.Property(e => e.CustomerDisplaySizeTextKana).HasMaxLength(100);
            entity.Property(e => e.CustomerItemCode).HasMaxLength(100);
            entity.Property(e => e.CustomerItemNameHalfwidth).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasMaxLength(100);
            entity.Property(e => e.DeliveryEndTime).HasMaxLength(100);
            entity.Property(e => e.DeliveryStartTime).HasMaxLength(100);
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.InventoryMovementReasonCode).HasMaxLength(100);
            entity.Property(e => e.InventoryTransferInstructionPattern).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionEndTime).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionStartTime).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.LotnoFirst6DigitsSpecification)
                .HasMaxLength(100)
                .HasColumnName("LOTNoFirst6DigitsSpecification");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.OrdererItemCode).HasMaxLength(100);
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputStaffName).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputTime).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNoDetailNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionPackingQuantity).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionRemarksComment).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionWeight).HasMaxLength(100);
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode).HasMaxLength(100);
        });

        modelBuilder.Entity<TbItfUacjTransferBk>(entity =>
        {
            entity.HasKey(e => new { e.InfFileName, e.InfDate, e.InfTransNo }).HasName("PK_tb_Itf_Thact_MoveOrder_BK");

            entity.ToTable("tb_Itf_UACJ_Transfer_BK");

            entity.Property(e => e.InfFileName)
                .HasMaxLength(50)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfDate)
                .HasColumnType("datetime")
                .HasColumnName("Inf_Date");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.CoilVerticalHorizontalAxisCategory).HasMaxLength(100);
            entity.Property(e => e.CustomerDisplaySizeTextKana).HasMaxLength(100);
            entity.Property(e => e.CustomerItemCode).HasMaxLength(100);
            entity.Property(e => e.CustomerItemNameHalfwidth).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasMaxLength(100);
            entity.Property(e => e.DeliveryEndTime).HasMaxLength(100);
            entity.Property(e => e.DeliveryStartTime).HasMaxLength(100);
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.InventoryMovementReasonCode).HasMaxLength(100);
            entity.Property(e => e.InventoryTransferInstructionPattern).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionEndTime).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionStartTime).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.LotnoFirst6DigitsSpecification)
                .HasMaxLength(100)
                .HasColumnName("LOTNoFirst6DigitsSpecification");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.OrdererItemCode).HasMaxLength(100);
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputStaffName).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputTime).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNoDetailNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionPackingQuantity).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionRemarksComment).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionWeight).HasMaxLength(100);
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode).HasMaxLength(100);
        });

        modelBuilder.Entity<TbLang>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.ToTable("tb_Lang");

            entity.Property(e => e.LangId)
                .HasMaxLength(50)
                .HasColumnName("Lang_ID");
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<TbLangCtrl>(entity =>
        {
            entity.HasKey(e => e.MapId).HasName("PK_TB_LANGCTRL");

            entity.ToTable("tb_LangCTRL");

            entity.Property(e => e.MapId).HasColumnName("MAP_ID");
            entity.Property(e => e.CtrlId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CTRL_ID");
            entity.Property(e => e.CtrlType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTRL_TYPE");
            entity.Property(e => e.FormId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_ID");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.Origin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGIN");
        });

        modelBuilder.Entity<TbLangMap>(entity =>
        {
            entity.HasKey(e => new { e.MapId, e.LangId });

            entity.ToTable("tb_LangMAP");

            entity.Property(e => e.MapId).HasColumnName("MAP_ID");
            entity.Property(e => e.LangId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LANG_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LangWord)
                .HasMaxLength(500)
                .HasColumnName("LANG_WORD");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
        });

        modelBuilder.Entity<TbScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenId);

            entity.ToTable("tb_Screens");

            entity.Property(e => e.ScreenId)
                .ValueGeneratedNever()
                .HasComment("ID of Screen")
                .HasColumnName("ScreenID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Class name (Class name is defined by application)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the screen is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("admin")
                .HasComment("User who create the screen");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Screen name which is displayed on screen caption");
            entity.Property(e => e.MenuGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PictureName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the screen is latest updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Last user who update  the screen");
        });

        modelBuilder.Entity<TbScreensControl>(entity =>
        {
            entity.HasKey(e => new { e.ScreenId, e.UserId, e.Ipaddress }).HasName("PK_tb_ScreenControl");

            entity.ToTable("tb_ScreensControl");

            entity.Property(e => e.ScreenId)
                .HasMaxLength(50)
                .HasComment("ID of Screen")
                .HasColumnName("ScreenID");
            entity.Property(e => e.UserId)
                .HasMaxLength(15)
                .HasComment("ID of user logged in")
                .HasColumnName("UserID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .HasColumnName("IPaddress");
            entity.Property(e => e.LastResponse)
                .HasComment("Last response time the user make any action to the screen")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbSecurityMatch>(entity =>
        {
            entity.HasKey(e => e.Securityid);

            entity.ToTable("tb_SecurityMatch");

            entity.Property(e => e.Securityid)
                .ValueGeneratedOnAdd()
                .HasComment("ID of security")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("SECURITYID");
            entity.Property(e => e.Createdate)
                .HasComment("Date/ Time when the security setting is created")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createuser)
                .HasMaxLength(50)
                .HasComment("User who create the security setting")
                .HasColumnName("CREATEUSER");
            entity.Property(e => e.Groupid)
                .HasComment("ID of group of user")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("GROUPID");
            entity.Property(e => e.Permission)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Permission setting of each user")
                .HasColumnName("PERMISSION");
            entity.Property(e => e.Screenid)
                .HasComment("ID of screen")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("SCREENID");
            entity.Property(e => e.Updatedate)
                .HasComment("Date/ Time when the security setting is updated")
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Updateuser)
                .HasMaxLength(50)
                .HasComment("User who update  the security setting")
                .HasColumnName("UPDATEUSER");
            entity.Property(e => e.Userid)
                .HasMaxLength(15)
                .HasComment("ID of user")
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tb_User");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasComment("ID of user")
                .HasColumnName("UserID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasComment("Address");
            entity.Property(e => e.AuthenOtp)
                .HasDefaultValue(0)
                .HasColumnName("AuthenOTP");
            entity.Property(e => e.CreateDate)
                .HasComment("Date/ Time when the user is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("User who create the user");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DomainIpaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DomainIPAddress");
            entity.Property(e => e.DomainName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasComment("Email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasComment("First name");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasComment("Last Name");
            entity.Property(e => e.LineToken).HasMaxLength(100);
            entity.Property(e => e.LoginType)
                .HasDefaultValue(1)
                .HasComment("1 = Database; 2 = AD Server");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasComment("Mobile phone No.");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasComment("Password");
            entity.Property(e => e.RunningId)
                .ValueGeneratedOnAdd()
                .HasComment("Identity column")
                .HasColumnName("RunningID");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasComment("Telephone No.");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/ Time when the user is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the user");
            entity.Property(e => e.UserCode).HasMaxLength(500);
        });

        modelBuilder.Entity<TbUserGroup>(entity =>
        {
            entity.HasKey(e => e.Groupid).HasName("PK_Tb_Groups");

            entity.ToTable("tb_UserGroups");

            entity.Property(e => e.Groupid)
                .ValueGeneratedOnAdd()
                .HasComment("ID of User Groups")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("GROUPID");
            entity.Property(e => e.Createdate)
                .HasComment("Date/ Time when the group is created")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createuser)
                .HasMaxLength(50)
                .HasComment("User who create the group")
                .HasColumnName("CREATEUSER");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasComment("Group description")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Groupname)
                .HasMaxLength(50)
                .HasComment("Group name")
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.Updatedate)
                .HasComment("Date/ Time when the group is updated")
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Updateuser)
                .HasMaxLength(50)
                .HasComment("User who update the group")
                .HasColumnName("UPDATEUSER");
        });

        modelBuilder.Entity<TbUserWebMapping>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Dcid });

            entity.ToTable("tb_UserWebMapping");

            entity.Property(e => e.UserId)
                .HasMaxLength(15)
                .HasComment("ID of user")
                .HasColumnName("UserID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of DC")
                .HasColumnName("DCID");
            entity.Property(e => e.CreateDate)
                .HasComment("Date/ Time when the user is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(15)
                .HasDefaultValueSql("((0))")
                .HasComment("User who create the user");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/ Time when the user is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(15)
                .HasComment("User who update the user");
        });

        modelBuilder.Entity<TbaUserRegistration>(entity =>
        {
            entity.HasKey(e => e.Token).HasName("PK_tb_UserRegistration");

            entity.ToTable("tba_UserRegistration");

            entity.Property(e => e.Token).HasMaxLength(100);
            entity.Property(e => e.ComputerName).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.UserLogin).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmAllocatePriority>(entity =>
        {
            entity.HasKey(e => e.PriorityId);

            entity.ToTable("tbm_AllocatePriority");

            entity.Property(e => e.PriorityId)
                .ValueGeneratedNever()
                .HasColumnName("PriorityID");
            entity.Property(e => e.PriorityCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmClassification>(entity =>
        {
            entity.HasKey(e => e.ClassificationId);

            entity.ToTable("tbm_Classification");

            entity.Property(e => e.ClassificationId)
                .HasComment("ID of Classification")
                .HasColumnName("ClassificationID");
            entity.Property(e => e.ClassificationCode)
                .HasMaxLength(30)
                .HasComment("Classification Code");
            entity.Property(e => e.ClassificationName)
                .HasMaxLength(100)
                .HasComment("Classification Name");
            entity.Property(e => e.CreateDate)
                .HasComment("Date/ Time when the classification is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the classification");
            entity.Property(e => e.DeleteFlag).HasComment("Flag indicate the record is deleted");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("Remark");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/ Time when the classification is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the classification");
        });

        modelBuilder.Entity<TbmCostTransport>(entity =>
        {
            entity.HasKey(e => new { e.DeliveryId, e.TransportTypeId });

            entity.ToTable("tbm_CostTransport");

            entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Truck Company is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Truck Company");
            entity.Property(e => e.DeleteFlag)
                .HasDefaultValue(0)
                .HasComment("Delete Flag");
            entity.Property(e => e.KusuharaBowin)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("KUSUHARA_Bowin");
            entity.Property(e => e.KusuharaLcb)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("KUSUHARA_LCB");
            entity.Property(e => e.KusuharaNslt)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("KUSUHARA_NSLT");
            entity.Property(e => e.KusuharaUacj)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("KUSUHARA_UACJ");
            entity.Property(e => e.KusuharaYusen)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("KUSUHARA_Yusen");
            entity.Property(e => e.SankyuBowin)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("SANKYU_Bowin");
            entity.Property(e => e.SankyuNslt)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("SANKYU_NSLT");
            entity.Property(e => e.SankyuSankyu)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("SANKYU_Sankyu");
            entity.Property(e => e.SankyuUacj)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("SANKYU_UACJ");
            entity.Property(e => e.SankyuYusen)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("SANKYU_Yusen");
            entity.Property(e => e.SuzuyoBowin)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Suzuyo_Bowin");
            entity.Property(e => e.SuzuyoLcb)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Suzuyo_LCB");
            entity.Property(e => e.SuzuyoNslt)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Suzuyo_NSLT");
            entity.Property(e => e.SuzuyoUacj)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Suzuyo_UACJ");
            entity.Property(e => e.SuzuyoYusen)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Suzuyo_Yusen");
            entity.Property(e => e.TrancyBowin)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TRANCY_Bowin");
            entity.Property(e => e.TrancyLcb)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TRANCY_LCB");
            entity.Property(e => e.TrancyNslt)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TRANCY_NSLT");
            entity.Property(e => e.TrancyUacj)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TRANCY_UACJ");
            entity.Property(e => e.TrancyYusen)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TRANCY_Yusen");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Truck Company is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Truck Company");
            entity.Property(e => e.YusenBowin)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Yusen_Bowin");
            entity.Property(e => e.YusenLcb)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Yusen_LCB");
            entity.Property(e => e.YusenNslt)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Yusen_NSLT");
            entity.Property(e => e.YusenUacj)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Yusen_UACJ");
            entity.Property(e => e.YusenYusen)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("Yusen_Yusen");
        });

        modelBuilder.Entity<TbmCustShippingCustMapping>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.ShippingCustomerId });

            entity.ToTable("tbm_CustShippingCustMapping");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
        });

        modelBuilder.Entity<TbmCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_tbm_Client");

            entity.ToTable("tbm_Customer");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Customer")
                .HasColumnName("CustomerID");
            entity.Property(e => e.AllowEditDeleteInfplan).HasColumnName("AllowEditDeleteINFPlan");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(100)
                .HasComment("Type of business");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasComment("City");
            entity.Property(e => e.ContactName1)
                .HasMaxLength(100)
                .HasComment("Contact Name 1");
            entity.Property(e => e.ContactName2)
                .HasMaxLength(100)
                .HasComment("Contact Name 2");
            entity.Property(e => e.ContactName3)
                .HasMaxLength(100)
                .HasComment("Contact Name 3");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasComment("Country");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date/ Time when Client is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create  the Client");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(200)
                .HasComment("Customer Address");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasComment("Customer Code");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasComment("Customer Name");
            entity.Property(e => e.DefaultReceivingDateType).HasComment("1: Plan\r\n2: Actual");
            entity.Property(e => e.DeleteFlag).HasComment("Flag indicate the record is deleted");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasComment("Email Address");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .HasComment("Ext");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasComment("Fax No.");
            entity.Property(e => e.IsSystem)
                .HasDefaultValue((byte)0)
                .HasColumnName("isSystem");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasComment("Mobile No.");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasComment("Telephone No.");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .HasComment("Postal Code");
            entity.Property(e => e.StateOrProvince)
                .HasMaxLength(50)
                .HasComment("State or Province");
            entity.Property(e => e.Tuprefix)
                .HasMaxLength(50)
                .HasComment("Prefix of TU number in SAP plan report")
                .HasColumnName("TUPrefix");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/ Time when Client is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Client");
        });

        modelBuilder.Entity<TbmCustomerPortMapping>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.PortId });

            entity.ToTable("tbm_CustomerPortMapping");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.PortId).HasColumnName("PortID");
        });

        modelBuilder.Entity<TbmDccodeMapping>(entity =>
        {
            entity.HasKey(e => new { e.RubixDccode, e.SapDccode });

            entity.ToTable("tbm_DCCodeMapping");

            entity.Property(e => e.RubixDccode)
                .HasMaxLength(50)
                .HasColumnName("RubixDCCode");
            entity.Property(e => e.SapDccode)
                .HasMaxLength(50)
                .HasColumnName("SapDCCode");
        });

        modelBuilder.Entity<TbmDccustomerMapping>(entity =>
        {
            entity.HasKey(e => new { e.Dcid, e.CustomerId });

            entity.ToTable("tbm_DCCustomerMapping");

            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
        });

        modelBuilder.Entity<TbmDcwhmapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbm_DCWHMapping");

            entity.Property(e => e.Dccode)
                .HasMaxLength(20)
                .HasColumnName("DCCode");
            entity.Property(e => e.Whas400)
                .HasMaxLength(1)
                .HasColumnName("WHAS400");
            entity.Property(e => e.Whas400name)
                .HasMaxLength(50)
                .HasColumnName("WHAS400Name");
        });

        modelBuilder.Entity<TbmDeadStock>(entity =>
        {
            entity.HasKey(e => e.CodeName).HasName("PK_tbm_DeadStockDeleteCriteriaSetting");

            entity.ToTable("tbm_DeadStock");

            entity.Property(e => e.CodeName)
                .HasMaxLength(50)
                .HasDefaultValue("DeadStockSetting")
                .HasComment("The Code Name must be fixed.");
            entity.Property(e => e.CodeDescription)
                .HasMaxLength(1000)
                .HasComment("Code Description");
            entity.Property(e => e.CreateDate)
                .HasComment("Date when the criteria is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the criteria");
            entity.Property(e => e.DatabaseName).HasMaxLength(100);
            entity.Property(e => e.EmptyStockDay).HasComment("Number of days to indicate that the stock is dead");
            entity.Property(e => e.ExpBillingCostDay).HasComment("Expire day of Billing Cost");
            entity.Property(e => e.ExpBillingDataDay).HasComment("Expire day of Billing Data");
            entity.Property(e => e.ExpHistoryDay).HasComment("Expire day of History ");
            entity.Property(e => e.ExpReceiveCompleteDay).HasComment("Expire day of completed receiving");
            entity.Property(e => e.ExpReceiveIncompleteDay).HasComment("Expire day of incompleted receiving");
            entity.Property(e => e.ExpSerialDataDay).HasComment("Expire day of Serial No. to delete");
            entity.Property(e => e.ExpShippingCompleteDay).HasComment("Expire day of completed shipping");
            entity.Property(e => e.ExpShippingIncompleteDay).HasComment("Expire day of incompleted shipping");
            entity.Property(e => e.ExpStockTaking).HasComment("Expire day of StockTaking delete");
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.ServerName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the criteria is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who last update the criteria");
        });

        modelBuilder.Entity<TbmDefaultInitialTransitZone>(entity =>
        {
            entity.HasKey(e => new { e.Dccode, e.OwnerCode, e.ZoneCode, e.ProductConditionCode, e.TypeOfGoodsCode });

            entity.ToTable("tbm_DefaultInitialTransitZone");

            entity.Property(e => e.Dccode)
                .HasMaxLength(50)
                .HasColumnName("DCCode");
            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.ZoneCode).HasMaxLength(3);
            entity.Property(e => e.ProductConditionCode).HasMaxLength(10);
            entity.Property(e => e.TypeOfGoodsCode)
                .HasMaxLength(50)
                .HasDefaultValue("DUMMY");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmDistributionCenter>(entity =>
        {
            entity.HasKey(e => e.Dcid);

            entity.ToTable("tbm_DistributionCenter");

            entity.Property(e => e.Dcid)
                .HasComment("ID of DC")
                .HasColumnName("DCID");
            entity.Property(e => e.AddreId)
                .HasMaxLength(100)
                .HasColumnName("ADDRE_ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(200)
                .HasComment("DC Address");
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .HasComment("DC Address");
            entity.Property(e => e.ContactName1).HasMaxLength(100);
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.ControlPackId)
                .HasDefaultValue(1)
                .HasColumnName("ControlPackID");
            entity.Property(e => e.ControlPalletId).HasColumnName("ControlPalletID");
            entity.Property(e => e.ControlQcpickId).HasColumnName("ControlQCPickID");
            entity.Property(e => e.ControlResourceId).HasColumnName("ControlResourceID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the DC is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the DC");
            entity.Property(e => e.DcaliasCode)
                .HasMaxLength(10)
                .HasColumnName("DCAliasCODE");
            entity.Property(e => e.Dccode)
                .HasMaxLength(20)
                .HasComment("Distribution Center Code (Abbreviation)")
                .HasColumnName("DCCode");
            entity.Property(e => e.DclongName)
                .HasMaxLength(40)
                .HasComment("Distribution Center Long Name")
                .HasColumnName("DCLongName");
            entity.Property(e => e.DefaultDamageRouteCode).HasMaxLength(40);
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .HasComment("Extension");
            entity.Property(e => e.ExternalDivisionFlag)
                .HasDefaultValue(false)
                .HasComment("0 : Internal DC , 1 : External DC");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasComment("Fax No");
            entity.Property(e => e.InChargeEmail).HasMaxLength(500);
            entity.Property(e => e.Latitude).HasColumnType("numeric(11, 7)");
            entity.Property(e => e.Longitude).HasColumnType("numeric(11, 7)");
            entity.Property(e => e.MaxCapacity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaxM2).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaxM3).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasComment("Mobile No.");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasComment("Phone No");
            entity.Property(e => e.Plant)
                .HasMaxLength(50)
                .HasColumnName("PLANT");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.Sloc)
                .HasMaxLength(50)
                .HasColumnName("SLOC");
            entity.Property(e => e.StagingLocationCode).HasMaxLength(20);
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the DC is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the DC");
            entity.Property(e => e.WhtypeId).HasColumnName("WHTypeID");
        });

        modelBuilder.Entity<TbmFinalDestination>(entity =>
        {
            entity.HasKey(e => e.FinalDestinationId);

            entity.ToTable("tbm_FinalDestination");

            entity.Property(e => e.FinalDestinationId)
                .HasComment("ID of Final Destination")
                .HasColumnName("FinalDestinationID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasComment("City");
            entity.Property(e => e.ContactName1)
                .HasMaxLength(100)
                .HasComment("Contact Name");
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasComment("Country");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Final Destination is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Final Destination");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DeleteFlag)
                .HasDefaultValue(0)
                .HasComment("Delete Flag");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasComment("Extension No.");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasComment("Fax No.");
            entity.Property(e => e.FinalDestinationAddress)
                .HasMaxLength(500)
                .HasComment("Final Destination Address 1");
            entity.Property(e => e.FinalDestinationCode)
                .HasMaxLength(100)
                .HasComment("Final Destination Code");
            entity.Property(e => e.FinalDestinationDetail)
                .HasMaxLength(500)
                .HasComment("Detail of FinalDestination");
            entity.Property(e => e.FinalDestinationLongName)
                .HasMaxLength(250)
                .HasComment("Final Destination Long Name 1");
            entity.Property(e => e.ImageFile).HasColumnType("image");
            entity.Property(e => e.IsSystem)
                .HasDefaultValue((byte)0)
                .HasColumnName("isSystem");
            entity.Property(e => e.Km)
                .HasComment("Distance of Final Destination (Unit is Kilo Metre)")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KM");
            entity.Property(e => e.LeadTimeDays).HasComment("Lead Time (Unit is days)");
            entity.Property(e => e.LeadTimeHr)
                .HasMaxLength(5)
                .HasComment("Lead Time (Unit is hours))");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasComment("Mobile No.");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasComment("Phone No.");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .HasComment("Postal Code");
            entity.Property(e => e.RecipientType).HasMaxLength(20);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.StateOrProvince)
                .HasMaxLength(50)
                .HasComment("State/Province");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Final Destination is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Final Destination");
        });

        modelBuilder.Entity<TbmJobCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("tbm_JobCategory");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TbmJobType>(entity =>
        {
            entity.HasKey(e => e.JobTypeId);

            entity.ToTable("tbm_JobType");

            entity.Property(e => e.JobTypeId)
                .ValueGeneratedNever()
                .HasColumnName("JobTypeID");
            entity.Property(e => e.JobTypeCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmKanbanStatus>(entity =>
        {
            entity.HasKey(e => e.KanbanStatusId);

            entity.ToTable("tbm_KanbanStatus");

            entity.Property(e => e.KanbanStatusId).HasColumnName("KanbanStatusID");
            entity.Property(e => e.KanbanStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("tbm_Location");

            entity.Property(e => e.LocationId)
                .HasComment("ID of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.CapacityUnitId).HasColumnName("CapacityUnitID");
            entity.Property(e => e.ControlMixLotId).HasColumnName("ControlMixLotID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when Location is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Location");
            entity.Property(e => e.CustomLocationCode).HasMaxLength(10);
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.FullCapacityFlag).HasComment("0 = Not Full , 1 = Full");
            entity.Property(e => e.LayoutId).HasColumnName("LayoutID");
            entity.Property(e => e.Level).HasMaxLength(2);
            entity.Property(e => e.LocationCode)
                .HasMaxLength(17)
                .HasComment("Zone + '-' + Floor + '-' + Rack (S1,S2,S3)");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .HasComment("Location Name");
            entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            entity.Property(e => e.MaxCapacity).HasColumnType("numeric(19, 5)");
            entity.Property(e => e.MaxM2).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.MaxM3)
                .HasComment("Max Valume(M3) of the Location")
                .HasColumnType("numeric(19, 5)");
            entity.Property(e => e.MovementTypeId).HasColumnName("MovementTypeID");
            entity.Property(e => e.PickingPriority).HasComment("Priority when Picking");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition ('A' = Good, 'D' = Damage , ... )")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.RackNo)
                .HasMaxLength(5)
                .HasComment("Rack No (Information)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Location is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Location");
            entity.Property(e => e.ZoneId)
                .HasComment("ID of Zone")
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbmLocationLayout>(entity =>
        {
            entity.HasKey(e => e.LayoutId);

            entity.ToTable("tbm_Location_Layout");

            entity.Property(e => e.LayoutId).HasColumnName("LayoutID");
            entity.Property(e => e.CaptionPosition)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Height).HasComment("millimeter");
            entity.Property(e => e.LocationLayoutCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocationLayoutName).HasMaxLength(100);
            entity.Property(e => e.PositionX).HasComment("pixel");
            entity.Property(e => e.PositionY).HasComment("pixel");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasComment("millimeter");
        });

        modelBuilder.Entity<TbmLogoImage>(entity =>
        {
            entity.HasKey(e => e.LogoId);

            entity.ToTable("tbm_LogoImage");

            entity.Property(e => e.LogoId)
                .ValueGeneratedNever()
                .HasColumnName("LogoID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmMisc>(entity =>
        {
            entity.HasKey(e => new { e.PropertyField, e.PropertyId });

            entity.ToTable("tbm_misc");

            entity.Property(e => e.PropertyField).HasMaxLength(100);
            entity.Property(e => e.PropertyId).HasColumnName("PropertyID");
            entity.Property(e => e.PropertyCode).HasMaxLength(100);
            entity.Property(e => e.PropertyDescription).HasMaxLength(500);
            entity.Property(e => e.PropertyName).HasMaxLength(200);
        });

        modelBuilder.Entity<TbmOtp>(entity =>
        {
            entity.ToTable("tbm_otp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Otpcode)
                .HasMaxLength(6)
                .HasColumnName("OTPCODE");
            entity.Property(e => e.Otpexpired)
                .HasColumnType("datetime")
                .HasColumnName("OTPEXPIRED");
            entity.Property(e => e.Usercode)
                .HasMaxLength(50)
                .HasColumnName("USERCODE");
        });

        modelBuilder.Entity<TbmPackage>(entity =>
        {
            entity.HasKey(e => e.PackageId);

            entity.ToTable("tbm_Package");

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.PackageCode).HasMaxLength(50);
            entity.Property(e => e.PackageName).HasMaxLength(100);
            entity.Property(e => e.Remark).HasMaxLength(2550);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmPackageOutbound>(entity =>
        {
            entity.HasKey(e => e.PackageId);

            entity.ToTable("tbm_PackageOutbound");

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.PackageCode).HasMaxLength(12);
            entity.Property(e => e.PackageName).HasMaxLength(100);
            entity.Property(e => e.Remark).HasMaxLength(2550);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmPlant>(entity =>
        {
            entity.HasKey(e => new { e.OwnerCode, e.PlantCode });

            entity.ToTable("tbm_Plant");

            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.PlantCode).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.PlantName).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbmPlantMapping>(entity =>
        {
            entity.HasKey(e => new { e.Plant, e.Dccode, e.OwnerCode });

            entity.ToTable("tbm_PlantMapping");

            entity.Property(e => e.Plant)
                .HasMaxLength(8)
                .HasColumnName("PLANT");
            entity.Property(e => e.Dccode)
                .HasMaxLength(50)
                .HasColumnName("DCCode");
            entity.Property(e => e.OwnerCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmPort>(entity =>
        {
            entity.HasKey(e => e.PortId).HasName("PK_tbm_PortOfDischarge");

            entity.ToTable("tbm_Port");

            entity.Property(e => e.PortId)
                .HasComment("ID of Port")
                .HasColumnName("PortID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(4)
                .HasComment("Country Code (Ex. TH)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Port is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Port");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.LeadTimeDays).HasComment("Lead time with unit in day");
            entity.Property(e => e.LeadTimeHr)
                .HasMaxLength(5)
                .HasComment("Lead time in HH:MM ");
            entity.Property(e => e.PortAddress)
                .HasMaxLength(100)
                .HasComment("Port Address 1 ");
            entity.Property(e => e.PortClassification)
                .HasDefaultValue(1)
                .HasComment("0 = Loading Only , 1 = Discharge Only , 2 = Both loading and discharging");
            entity.Property(e => e.PortCode)
                .HasMaxLength(20)
                .HasComment("Port Code");
            entity.Property(e => e.PortLongName)
                .HasMaxLength(100)
                .HasComment("Port name");
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Port is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Port");
        });

        modelBuilder.Entity<TbmProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_tbm_Model");

            entity.ToTable("tbm_Product");

            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.AccpacLocation).HasMaxLength(50);
            entity.Property(e => e.AlloyCode)
                .HasMaxLength(50)
                .HasColumnName("Alloy_Code");
            entity.Property(e => e.ClassificationId)
                .HasComment("ID of Classification")
                .HasColumnName("ClassificationID");
            entity.Property(e => e.ControlLotId).HasColumnName("ControlLotID");
            entity.Property(e => e.ControlPalletId).HasColumnName("ControlPalletID");
            entity.Property(e => e.ControlPickingId).HasColumnName("ControlPickingID");
            entity.Property(e => e.ControlSerialId).HasColumnName("ControlSerialID");
            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Model is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Model");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.EstimateValue)
                .HasComment("Estimate value (unit is Baht)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.FreeOfCharge).HasComment("Number of days for free of charge (unit is day)");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.ImageFile).HasColumnType("image");
            entity.Property(e => e.ItemExpiredTypeId)
                .HasComment("1 = AfterProduction, 2=  AfterRcv, 3 = FollowCOA")
                .HasColumnName("ItemExpiredTypeID");
            entity.Property(e => e.KanbanControl).HasComment("0 = Not control by Kanban , 1 = Control by Kanban");
            entity.Property(e => e.LotControl).HasComment("0 = Not control by Lot , 1 = Control by Lot");
            entity.Property(e => e.Maker).HasMaxLength(100);
            entity.Property(e => e.MaxStoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MovementTypeId).HasColumnName("MovementTypeID");
            entity.Property(e => e.NeedQc).HasColumnName("NeedQC");
            entity.Property(e => e.PalletTypeId).HasColumnName("PalletTypeID");
            entity.Property(e => e.PrefixDomestic).HasMaxLength(50);
            entity.Property(e => e.PrefixExport).HasMaxLength(50);
            entity.Property(e => e.PrefixImport).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ProductBarCode).HasMaxLength(100);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(100)
                .HasComment("Model Code used in Thailand");
            entity.Property(e => e.ProductLongName)
                .HasMaxLength(320)
                .HasComment("Model Long Name");
            entity.Property(e => e.ProductMask)
                .HasMaxLength(10)
                .HasComment("Model Mask");
            entity.Property(e => e.QualityType)
                .HasMaxLength(50)
                .HasColumnName("Quality_Type");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("Model Remark");
            entity.Property(e => e.SafetyStock).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ScanType).HasComment("0 = Double Scan, 1 = Single Scan");
            entity.Property(e => e.SerialLength)
                .HasDefaultValue(0)
                .HasComment("Lenght of Serial");
            entity.Property(e => e.SerialMask)
                .HasMaxLength(10)
                .HasComment("Serial Mask");
            entity.Property(e => e.ShelfLife).HasComment("int");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(50)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.SizeLength)
                .HasMaxLength(50)
                .HasColumnName("Size_Length");
            entity.Property(e => e.SizeThickness)
                .HasMaxLength(50)
                .HasColumnName("Size_Thickness");
            entity.Property(e => e.SizeWidth)
                .HasMaxLength(50)
                .HasColumnName("Size_Width");
            entity.Property(e => e.Sloccontrol).HasColumnName("SLOCControl");
            entity.Property(e => e.SpecialBarcode).HasMaxLength(10);
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.SyncDate).HasMaxLength(10);
            entity.Property(e => e.TypeOfGoodsId)
                .HasComment("ID of Goods Type")
                .HasColumnName("TypeOfGoodsID");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Model is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Model");
        });

        modelBuilder.Entity<TbmProductCondition>(entity =>
        {
            entity.HasKey(e => e.ProductConditionId).HasName("PK_tbs_ProductCondition");

            entity.ToTable("tbm_ProductCondition");

            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.AcerallowReconcileFlg)
                .HasDefaultValue(0)
                .HasColumnName("ACERAllowReconcileFlg");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Product Condition is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Product Condition ");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.LocationGroup).HasMaxLength(20);
            entity.Property(e => e.ProductConditionCode)
                .HasMaxLength(20)
                .HasComment("Product Condition Code");
            entity.Property(e => e.ProductConditionName)
                .HasMaxLength(20)
                .HasComment("Product Condition Name");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Product Condition is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Product Condition ");
        });

        modelBuilder.Entity<TbmProductConditionMapping>(entity =>
        {
            entity.HasKey(e => new { e.ClassificationCode, e.ProductConditionCode }).HasName("PK__tbm_Prod__0B4634DAFD01E2A7");

            entity.ToTable("tbm_ProductConditionMapping");

            entity.Property(e => e.ClassificationCode).HasMaxLength(60);
            entity.Property(e => e.ProductConditionCode).HasMaxLength(40);
        });

        modelBuilder.Entity<TbmProductDefaultUnit>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.PackageId });

            entity.ToTable("tbm_ProductDefaultUnit");

            entity.Property(e => e.ProductId)
                .HasComment("ID of Product")
                .HasColumnName("ProductID");
            entity.Property(e => e.PackageId)
                .HasComment("ID of Package Type")
                .HasColumnName("PackageID");
            entity.Property(e => e.BarcodeofUnitLevel1).HasMaxLength(100);
            entity.Property(e => e.BarcodeofUnitLevel2).HasMaxLength(100);
            entity.Property(e => e.BarcodeofUnitLevel3).HasMaxLength(100);
            entity.Property(e => e.BarcodeofUnitLevel4).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.M3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NetWeight)
                .HasComment("Weight of Product only (Kgs.)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumberOfUnitLevel2)
                .HasComment("Number per Type of Units Level 2")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumberOfUnitLevel3)
                .HasComment("Number per Type of Units Level 3")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumberOfUnitLevel4)
                .HasComment("Number per Type of Units Level 4")
                .HasColumnType("numeric(18, 5)");
            entity.Property(e => e.RptTypeOfUnitLevel1)
                .HasComment("0=not show unit, 1=show unit")
                .HasColumnName("rptTypeOfUnitLevel1");
            entity.Property(e => e.RptTypeOfUnitLevel2)
                .HasComment("0=not show unit, 1=show unit")
                .HasColumnName("rptTypeOfUnitLevel2");
            entity.Property(e => e.RptTypeOfUnitLevel3)
                .HasComment("0=not show unit, 1=show unit")
                .HasColumnName("rptTypeOfUnitLevel3");
            entity.Property(e => e.RptTypeOfUnitLevel4)
                .HasComment("0=not show unit, 1=show unit")
                .HasColumnName("rptTypeOfUnitLevel4");
            entity.Property(e => e.TypeOfUnitInventory).HasComment("ID of Units Type in Inventory");
            entity.Property(e => e.TypeOfUnitLevel1).HasComment("ID of Units Type Level 1");
            entity.Property(e => e.TypeOfUnitLevel2).HasComment("ID of Units Type Level 2");
            entity.Property(e => e.TypeOfUnitLevel3).HasComment("ID of Units Type Level 3");
            entity.Property(e => e.TypeOfUnitLevel4).HasComment("ID of Units Type Level 4");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.VolumeOfUnitLevel1)
                .HasComment("Volume (M3) per Type of Units Level 1")
                .HasColumnType("numeric(19, 5)");
        });

        modelBuilder.Entity<TbmProductDefaultZoneTransit>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.ProductConditionId, e.ZoneId, e.LocationId });

            entity.ToTable("tbm_ProductDefaultZoneTransit");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmProductDetail>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.Plant }).HasName("PK_tbt_product_detail");

            entity.ToTable("tbm_Product_Detail");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Countryoforigin)
                .HasMaxLength(3)
                .HasColumnName("COUNTRYOFORIGIN");
            entity.Property(e => e.Hierachyfirst3char)
                .HasMaxLength(3)
                .HasColumnName("HIERACHYFIRST3CHAR");
            entity.Property(e => e.Materialgroup2)
                .HasMaxLength(3)
                .HasColumnName("MATERIALGROUP2");
            entity.Property(e => e.Materialgroup3)
                .HasMaxLength(3)
                .HasColumnName("MATERIALGROUP3");
            entity.Property(e => e.Materialgroup4)
                .HasMaxLength(3)
                .HasColumnName("MATERIALGROUP4");
            entity.Property(e => e.Materialtype)
                .HasMaxLength(10)
                .HasColumnName("MATERIALTYPE");
            entity.Property(e => e.Sku)
                .HasMaxLength(18)
                .HasColumnName("SKU");
            entity.Property(e => e.Skudescription)
                .HasMaxLength(100)
                .HasColumnName("SKUDESCRIPTION");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stc)
                .HasMaxLength(30)
                .HasColumnName("STC");
            entity.Property(e => e.Uom)
                .HasMaxLength(3)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<TbmProductHandingCharge>(entity =>
        {
            entity.HasKey(e => e.SeqNo);

            entity.ToTable("tbm_ProductHandingCharge");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.IncomingCharge)
                .HasComment("Charge for Incoming")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OutgoingCharge)
                .HasComment("Charge for Outgoing")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PackageId)
                .HasComment("ID of Package Type")
                .HasColumnName("PackageID");
            entity.Property(e => e.PickingCharge)
                .HasComment("Charge for Picking")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Product")
                .HasColumnName("ProductID");
            entity.Property(e => e.Status).HasDefaultValue((short)1);
            entity.Property(e => e.TransitCharge)
                .HasComment("Charge for Transit")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TypeOfUnitIncoming).HasComment("ID of Units Type for Incoming Charge");
            entity.Property(e => e.TypeOfUnitOutgoing).HasComment("ID of Units Type for Outgoing Charge");
            entity.Property(e => e.TypeOfUnitPicking).HasComment("ID of Units Type for Picking Charge");
            entity.Property(e => e.TypeOfUnitTransit).HasComment("ID of Units Type for Transit Charge");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.VoidCharge).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TbmProductNotification>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.NotificationItemId });

            entity.ToTable("tbm_ProductNotification");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.NotificationItemId).HasColumnName("NotificationItemID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmProductVoid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbm_ProductVoid");

            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmRoute>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK_tbm_Route_1");

            entity.ToTable("tbm_Route");

            entity.Property(e => e.RouteId)
                .ValueGeneratedNever()
                .HasColumnName("RouteID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RouteCode).HasMaxLength(20);
            entity.Property(e => e.RouteName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmRouteD>(entity =>
        {
            entity.HasKey(e => new { e.RouteId, e.SequenceNo });

            entity.ToTable("tbm_RouteD");

            entity.Property(e => e.RouteId).HasColumnName("RouteID");
            entity.Property(e => e.AmphurId).HasColumnName("AmphurID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.FinalDestinationId).HasColumnName("FinalDestinationID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

            entity.HasOne(d => d.FinalDestination).WithMany(p => p.TbmRouteDs)
                .HasForeignKey(d => d.FinalDestinationId)
                .HasConstraintName("FK_tbm_RouteD_tbm_FinalDestination");
        });

        modelBuilder.Entity<TbmShippingArea>(entity =>
        {
            entity.HasKey(e => e.ShippingAreaId);

            entity.ToTable("tbm_ShippingArea");

            entity.Property(e => e.ShippingAreaId)
                .HasComment("ID of Shipping Yard")
                .HasColumnName("ShippingAreaID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Shipping Yard is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Shipping Yard");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Distribution Center")
                .HasColumnName("DCID");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.ShippingAreaCode)
                .HasMaxLength(20)
                .HasComment("Shipping Yard Code");
            entity.Property(e => e.ShippingAreaName)
                .HasMaxLength(50)
                .HasComment("Shipping Yard Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Shipping Yard is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Shipping Yard");
        });

        modelBuilder.Entity<TbmShippingContainer>(entity =>
        {
            entity.ToTable("tbm_ShippingContainer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContainerNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingNo).HasMaxLength(50);
            entity.Property(e => e.ShippingQty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbmShippingCustomer>(entity =>
        {
            entity.HasKey(e => e.ShippingCustomerId).HasName("PK_tbm_Owner");

            entity.ToTable("tbm_ShippingCustomer");

            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.BusinessType).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactName1).HasMaxLength(100);
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.Extension).HasMaxLength(10);
            entity.Property(e => e.FaxNo).HasMaxLength(50);
            entity.Property(e => e.IsSystem)
                .HasDefaultValue((byte)0)
                .HasColumnName("isSystem");
            entity.Property(e => e.Latitude).HasColumnType("numeric(11, 7)");
            entity.Property(e => e.Longitude).HasColumnType("numeric(11, 7)");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.ShippingCustomerCode).HasMaxLength(100);
            entity.Property(e => e.ShippingCustomerName).HasMaxLength(100);
            entity.Property(e => e.StateOrProvince).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmSloc>(entity =>
        {
            entity.HasKey(e => new { e.OwnerCode, e.Sloc });

            entity.ToTable("tbm_SLOC");

            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.AllowReconcileFlg).HasDefaultValue(1);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmSlocPlantDcmapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbm_SlocPlantDCMapping");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Plant).HasMaxLength(10);
            entity.Property(e => e.Sloc).HasMaxLength(10);
        });

        modelBuilder.Entity<TbmSubTypeOfGood>(entity =>
        {
            entity.HasKey(e => e.SubTypeOfGoodsId);

            entity.ToTable("tbm_SubTypeOfGoods");

            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.SubTypeOfGoodsCode).HasMaxLength(25);
            entity.Property(e => e.SubTypeOfGoodsName).HasMaxLength(100);
            entity.Property(e => e.TypeOfGoodsId).HasColumnName("TypeOfGoodsID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId);

            entity.ToTable("tbm_Supplier");

            entity.Property(e => e.SupplierId)
                .HasComment("ID of Supplier")
                .HasColumnName("SupplierID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasComment("City of Supplier");
            entity.Property(e => e.ContactName1)
                .HasMaxLength(100)
                .HasComment("Contact Name");
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasComment("Country of Supplier");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Supplier is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Supplier");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasComment("Email Address of Supplier");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .HasComment("Extension");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasComment("Fax No");
            entity.Property(e => e.IsSystem)
                .HasDefaultValue((byte)0)
                .HasColumnName("isSystem");
            entity.Property(e => e.Km)
                .HasComment("KM")
                .HasColumnName("KM");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasComment("Phone no");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .HasComment("Postal Code");
            entity.Property(e => e.RecordId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("ID FROM AS400(TDK)")
                .HasColumnName("RecordID");
            entity.Property(e => e.StateOrProvince)
                .HasMaxLength(50)
                .HasComment("State or Province of Supplier");
            entity.Property(e => e.SupplierAddress1)
                .HasMaxLength(200)
                .HasComment("Supplier Address");
            entity.Property(e => e.SupplierAddress2)
                .HasMaxLength(200)
                .HasComment("Supplier Address");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .HasComment("Supplier Code");
            entity.Property(e => e.SupplierLongName)
                .HasMaxLength(100)
                .HasComment("Supplier Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Supplier  is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Supplier");
        });

        modelBuilder.Entity<TbmTariffType>(entity =>
        {
            entity.HasKey(e => e.TariffTypeId);

            entity.ToTable("tbm_TariffType");

            entity.Property(e => e.TariffTypeId)
                .ValueGeneratedNever()
                .HasColumnName("Tariff_TypeID");
            entity.Property(e => e.TariffTypeName)
                .HasMaxLength(50)
                .HasColumnName("Tariff_TypeName");
        });

        modelBuilder.Entity<TbmTransportFeeOption>(entity =>
        {
            entity.HasKey(e => e.TransportFeeOptionId).HasName("PK_tbt_TransportFee_Option");

            entity.ToTable("tbm_TransportFee_Option");

            entity.Property(e => e.TransportFeeOptionId)
                .ValueGeneratedNever()
                .HasColumnName("Transport_Fee_OptionID");
            entity.Property(e => e.TransportFeeOptionCode)
                .HasMaxLength(50)
                .HasColumnName("Transport_Fee_OptionCode");
        });

        modelBuilder.Entity<TbmTransportType>(entity =>
        {
            entity.HasKey(e => e.TransportTypeId);

            entity.ToTable("tbm_TransportType");

            entity.Property(e => e.TransportTypeId)
                .HasComment("ID of Container Size")
                .HasColumnName("TransportTypeID");
            entity.Property(e => e.ContainerWeight)
                .HasComment("Container weight")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date/ Time when the Container Size is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Container Size");
            entity.Property(e => e.DeleteFlag).HasComment("Flag indicate the record is deleted (1 = deleted)");
            entity.Property(e => e.Height).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Length).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaxM2)
                .HasComment("Max volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.MaxM3)
                .HasComment("Max volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark or description");
            entity.Property(e => e.SortingId).HasColumnName("SortingID");
            entity.Property(e => e.TransportTypeCode)
                .HasMaxLength(20)
                .HasComment("Container Size Code");
            entity.Property(e => e.TransportTypeName)
                .HasMaxLength(50)
                .HasComment("Container Size Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/ Time when the Container Size is updated	")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who udpate the Container Size");
            entity.Property(e => e.Width).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TbmTransportUnStaffingCharge>(entity =>
        {
            entity.HasKey(e => e.TransportUnstaffingId).HasName("PK_tbm_TransportCharge");

            entity.ToTable("tbm_TransportUnStaffingCharge");

            entity.Property(e => e.TransportUnstaffingId).HasColumnName("TransportUnstaffingID");
            entity.Property(e => e.Charge).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Distribution Center")
                .HasColumnName("DCID");
            entity.Property(e => e.EffectiveDate).HasComment("Effective date of charge");
            entity.Property(e => e.FinalDestinationId)
                .HasComment("ID of Final Destination (Unstaffing ID = 0)")
                .HasColumnName("FinalDestinationID");
            entity.Property(e => e.FuelPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.TransportTypeId)
                .HasComment("ID of Transportation")
                .HasColumnName("TransportTypeID");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmTruckAllocatePlan>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbm_TruckAllocatePlan");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CapacityQty)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("Capacity_Qty");
            entity.Property(e => e.CoilQty).HasColumnName("Coil_Qty");
            entity.Property(e => e.ConditionName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.JobTypeCode).HasMaxLength(50);
            entity.Property(e => e.LoadEfficiency)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("Load_Efficiency");
            entity.Property(e => e.PriorityCode).HasMaxLength(50);
            entity.Property(e => e.ProductAlloy)
                .HasMaxLength(50)
                .HasColumnName("Product_Alloy");
            entity.Property(e => e.ProductTemper)
                .HasMaxLength(50)
                .HasColumnName("Product_Temper");
            entity.Property(e => e.ProductThickness)
                .HasMaxLength(50)
                .HasColumnName("Product_Thickness");
            entity.Property(e => e.ProductVariety)
                .HasMaxLength(50)
                .HasColumnName("Product_Variety");
            entity.Property(e => e.ProductWidth)
                .HasMaxLength(50)
                .HasColumnName("Product_Width");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.TransportTypeId)
                .HasComment("ID of Container Size")
                .HasColumnName("TransportTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmTruckCompany>(entity =>
        {
            entity.HasKey(e => e.TruckCompanyId).HasName("PK_tbm_TrackCompany");

            entity.ToTable("tbm_TruckCompany");

            entity.Property(e => e.TruckCompanyId)
                .HasComment("ID of Truck Company")
                .HasColumnName("TruckCompanyID");
            entity.Property(e => e.ContactName1)
                .HasMaxLength(100)
                .HasComment("Contact Name");
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Truck Company is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Truck Company");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .HasComment("Extension");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasComment("Fax No");
            entity.Property(e => e.FuleRate).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasComment("Phone No");
            entity.Property(e => e.TruckCompanyAddress)
                .HasMaxLength(200)
                .HasComment("Truck Company Address");
            entity.Property(e => e.TruckCompanyCode)
                .HasMaxLength(15)
                .HasComment("Truck Company Code");
            entity.Property(e => e.TruckCompanyLongName)
                .HasMaxLength(100)
                .HasComment("Truck Company Long Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Truck Company is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Truck Company");
        });

        modelBuilder.Entity<TbmTruckMaster>(entity =>
        {
            entity.HasKey(e => e.TruckId);

            entity.ToTable("tbm_TruckMaster");

            entity.Property(e => e.TruckId).HasColumnName("TruckID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DriverName)
                .HasMaxLength(50)
                .HasColumnName("Driver_Name");
            entity.Property(e => e.MaxWeight)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("Max_Weight");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasColumnName("Phone_No");
            entity.Property(e => e.SubContactName)
                .HasMaxLength(20)
                .HasColumnName("SubContact_Name");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.TruckNo).HasMaxLength(10);
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbmTruckTransportTypeMapping>(entity =>
        {
            entity.HasKey(e => new { e.TruckCompanyId, e.TransportTypeId });

            entity.ToTable("tbm_TruckTransportTypeMapping");

            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
        });

        modelBuilder.Entity<TbmTypeOfGood>(entity =>
        {
            entity.HasKey(e => e.TypeOfGoodsId);

            entity.ToTable("tbm_TypeOfGoods");

            entity.Property(e => e.TypeOfGoodsId)
                .HasComment("ID of Goods Type")
                .HasColumnName("TypeOfGoodsID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Type of Goods  is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Type of Goods");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.TypeOfGoodsCode)
                .HasMaxLength(50)
                .HasComment("Goods Type Code");
            entity.Property(e => e.TypeOfGoodsName)
                .HasMaxLength(100)
                .HasComment("Goods Type Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Type of Goods  is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Type of Goods");
        });

        modelBuilder.Entity<TbmTypeOfUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.ToTable("tbm_TypeOfUnit");

            entity.Property(e => e.UnitId)
                .HasComment("ID of Unit Type")
                .HasColumnName("UnitID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Type of Unit is Created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Type of Unit");
            entity.Property(e => e.DeleteFlag).HasComment("Delect Flag");
            entity.Property(e => e.Remark)
                .HasMaxLength(2550)
                .HasComment("Remark");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .HasComment("Unit Type Code");
            entity.Property(e => e.UnitName)
                .HasMaxLength(100)
                .HasComment("Unit Type Name");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Type of Unit is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Type of Unit");
        });

        modelBuilder.Entity<TbmWarehouseType>(entity =>
        {
            entity.HasKey(e => e.WhtypeId);

            entity.ToTable("tbm_WarehouseType");

            entity.Property(e => e.WhtypeId)
                .ValueGeneratedNever()
                .HasColumnName("WHTypeID");
            entity.Property(e => e.WhtypeCode)
                .HasMaxLength(20)
                .HasColumnName("WHTypeCode");
        });

        modelBuilder.Entity<TbmWorkMethod>(entity =>
        {
            entity.HasKey(e => e.WorkMethodId);

            entity.ToTable("tbm_WorkMethod");

            entity.Property(e => e.WorkMethodId)
                .HasComment("ID of Work Method")
                .HasColumnName("WorkMethodID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Work Method is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("User who create the Work Method");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Description");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Work Method is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("User who update the Work Method");
            entity.Property(e => e.WorkMethodCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Work Method Code");
            entity.Property(e => e.WorkMethodName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Work Method Name");
        });

        modelBuilder.Entity<TbmWorkMethodSetting>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.WorkMethodId, e.ModuleId }).HasName("PK_tbm_WorkMethodSetting_1");

            entity.ToTable("tbm_WorkMethodSetting");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Distribution Center")
                .HasColumnName("DCID");
            entity.Property(e => e.WorkMethodId)
                .HasComment("ID of Work Method")
                .HasColumnName("WorkMethodID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the DC is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);

            entity.HasOne(d => d.WorkMethod).WithMany(p => p.TbmWorkMethodSettings)
                .HasForeignKey(d => d.WorkMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbm_WorkMethodSetting_tbm_WorkMethod");
        });

        modelBuilder.Entity<TbmZone>(entity =>
        {
            entity.HasKey(e => e.ZoneId);

            entity.ToTable("tbm_Zone");

            entity.Property(e => e.ZoneId)
                .HasComment("ID of Zone")
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Zone is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Zone");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Distribution Center")
                .HasColumnName("DCID");
            entity.Property(e => e.DeleteFlag).HasComment("Delete Flag");
            entity.Property(e => e.Floor)
                .HasDefaultValue(1)
                .HasComment("Floor");
            entity.Property(e => e.LocationMoreOnePalletFlag)
                .HasDefaultValue(false)
                .HasComment("0: 1 Location วางได้หลาย Unit , 1: 1 Location วางได้แค่ Unit เดียว");
            entity.Property(e => e.MaxCapacity).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MaxCapacityPerPallet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MaxM2).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Stack).HasDefaultValue(1);
            entity.Property(e => e.StorageLocation).HasMaxLength(4);
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Zone is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Zone");
            entity.Property(e => e.ZoneCategoryId).HasColumnName("ZoneCategoryID");
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(3)
                .HasComment("Zone Code");
            entity.Property(e => e.ZoneColor)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.ZoneName)
                .HasMaxLength(50)
                .HasComment("Zone Name");
        });

        modelBuilder.Entity<TbmZoneCapacityMaster>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbm_ZoneCapacity_Master");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LaneName).HasMaxLength(50);
            entity.Property(e => e.OnFloorCapacity)
                .HasDefaultValue(0)
                .HasColumnName("OnFloor_Capacity");
            entity.Property(e => e.StackCapacity)
                .HasDefaultValue(0)
                .HasColumnName("Stack_Capacity");
            entity.Property(e => e.TotalCapacity)
                .HasDefaultValue(0)
                .HasColumnName("Total_Capacity");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbmZoneCustomerMapping>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.CustomerId });

            entity.ToTable("tbm_ZoneCustomerMapping");

            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbmZoneUserMapping>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.UserId });

            entity.ToTable("tbm_ZoneUserMapping");

            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsAcJobNoRunning>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbs_AC_JobNo_Running");

            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .HasColumnName("Invoice_No");
            entity.Property(e => e.RunningNo).HasColumnName("Running_No");
        });

        modelBuilder.Entity<TbsAlphabetValue>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_AlphabetValues");

            entity.ToTable("tbs_AlphabetValues");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.AlphabetString).HasMaxLength(10);
        });

        modelBuilder.Entity<TbsAmphur>(entity =>
        {
            entity.HasKey(e => e.AmphurId);

            entity.ToTable("tbs_Amphur");

            entity.Property(e => e.AmphurId)
                .ValueGeneratedNever()
                .HasColumnName("AmphurID");
            entity.Property(e => e.AmphurName).HasMaxLength(100);
            entity.Property(e => e.AmphurNameEng).HasMaxLength(100);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<TbsControlBag>(entity =>
        {
            entity.HasKey(e => e.ControlBagId);

            entity.ToTable("tbs_ControlBag");

            entity.Property(e => e.ControlBagId)
                .ValueGeneratedNever()
                .HasColumnName("ControlBagID");
            entity.Property(e => e.ControlBagName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlLot>(entity =>
        {
            entity.HasKey(e => e.ControlLotId);

            entity.ToTable("tbs_ControlLot");

            entity.Property(e => e.ControlLotId)
                .ValueGeneratedNever()
                .HasColumnName("ControlLotID");
            entity.Property(e => e.ControlLotName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlMixLot>(entity =>
        {
            entity.HasKey(e => e.ControlMixLotId);

            entity.ToTable("tbs_ControlMixLot");

            entity.Property(e => e.ControlMixLotId)
                .ValueGeneratedNever()
                .HasColumnName("ControlMixLotID");
            entity.Property(e => e.ControlMixLotName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlPack>(entity =>
        {
            entity.HasKey(e => e.ControlPackId);

            entity.ToTable("tbs_ControlPack");

            entity.Property(e => e.ControlPackId)
                .ValueGeneratedNever()
                .HasColumnName("ControlPackID");
            entity.Property(e => e.ControlPackName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlPallet>(entity =>
        {
            entity.HasKey(e => e.ControlPalletId);

            entity.ToTable("tbs_ControlPallet");

            entity.Property(e => e.ControlPalletId)
                .ValueGeneratedNever()
                .HasColumnName("ControlPalletID");
            entity.Property(e => e.ControlPalletName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlPicking>(entity =>
        {
            entity.HasKey(e => e.ControlPickingId);

            entity.ToTable("tbs_ControlPicking");

            entity.Property(e => e.ControlPickingId)
                .ValueGeneratedNever()
                .HasColumnName("ControlPickingID");
            entity.Property(e => e.ControlPickingName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlSerial>(entity =>
        {
            entity.HasKey(e => e.ControlSerialId);

            entity.ToTable("tbs_ControlSerial");

            entity.Property(e => e.ControlSerialId)
                .ValueGeneratedNever()
                .HasColumnName("ControlSerialID");
            entity.Property(e => e.ControlSerialName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlShelfLife>(entity =>
        {
            entity.HasKey(e => e.ControlShelfLifeId);

            entity.ToTable("tbs_ControlShelfLife");

            entity.Property(e => e.ControlShelfLifeId)
                .ValueGeneratedNever()
                .HasColumnName("ControlShelfLifeID");
            entity.Property(e => e.ControlShelfLifeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsControlVoid>(entity =>
        {
            entity.HasKey(e => e.ControlVoidId);

            entity.ToTable("tbs_ControlVoid");

            entity.Property(e => e.ControlVoidId)
                .ValueGeneratedNever()
                .HasColumnName("ControlVoidID");
            entity.Property(e => e.CanDuplicate).HasComment("Can duplicate in Void Type");
            entity.Property(e => e.ControlVoidName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsDateDailyPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbs_DateDailyPost");

            entity.Property(e => e.MaxDateDailyPost)
                .HasComment("Max Date of Daily Post")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbsDistrictOld>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceId, e.DistrictId }).HasName("PK_tbs_District");

            entity.ToTable("tbs_District_Old");

            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DistrictNameEn)
                .HasMaxLength(100)
                .HasColumnName("DistrictNameEN");
            entity.Property(e => e.DistrictNameTh)
                .HasMaxLength(100)
                .HasColumnName("DistrictNameTH");
        });

        modelBuilder.Entity<TbsDocType>(entity =>
        {
            entity.HasKey(e => e.DocTypeId);

            entity.ToTable("tbs_DocType");

            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocTypeCode).HasMaxLength(10);
            entity.Property(e => e.DocTypeDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsFileType>(entity =>
        {
            entity.HasKey(e => e.FileTypeId);

            entity.ToTable("tbs_FileType");

            entity.Property(e => e.FileTypeId)
                .ValueGeneratedNever()
                .HasColumnName("FileTypeID");
            entity.Property(e => e.FileTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsGenerateDocumentNo>(entity =>
        {
            entity.HasKey(e => e.DocNoCode);

            entity.ToTable("tbs_GenerateDocumentNo");

            entity.Property(e => e.DocNoCode)
                .HasMaxLength(50)
                .HasComment("Code of Document No(primary Key)");
            entity.Property(e => e.DocNoDescription)
                .HasMaxLength(500)
                .HasComment("Description of that ID");
            entity.Property(e => e.IncrementStep).HasComment("Increment Step");
            entity.Property(e => e.LastUpdate)
                .HasComment("Last Update Date")
                .HasColumnType("datetime");
            entity.Property(e => e.LeadingText)
                .HasMaxLength(50)
                .HasComment("Leading Text");
            entity.Property(e => e.PresentNo).HasComment("Present No");
            entity.Property(e => e.RunningDigit)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TbsItemExpiredType>(entity =>
        {
            entity.HasKey(e => e.ItemExpiredTypeId);

            entity.ToTable("tbs_ItemExpiredType");

            entity.Property(e => e.ItemExpiredTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ItemExpiredTypeID");
            entity.Property(e => e.ItemExpiredTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsLocationType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbs_LocationType");

            entity.Property(e => e.AlwaysShow).HasDefaultValue((byte)0);
            entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            entity.Property(e => e.LocationTypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<TbsModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK_tbs_module");

            entity.ToTable("tbs_Module");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbsNotificationItem>(entity =>
        {
            entity.HasKey(e => e.NotificationItemId).HasName("PK_tbs_NotificationItemID");

            entity.ToTable("tbs_NotificationItem");

            entity.Property(e => e.NotificationItemId)
                .ValueGeneratedNever()
                .HasColumnName("NotificationItemID");
            entity.Property(e => e.NotificationIcon).HasMaxLength(50);
            entity.Property(e => e.NotificationItemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsOrderPattern>(entity =>
        {
            entity.HasKey(e => e.OrderPatternId);

            entity.ToTable("tbs_OrderPattern");

            entity.Property(e => e.OrderPatternId)
                .ValueGeneratedNever()
                .HasColumnName("OrderPatternID");
            entity.Property(e => e.OrderPatternName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsOrorderType>(entity =>
        {
            entity.HasKey(e => e.OrderTypeId);

            entity.ToTable("tbs_OROrderType");

            entity.Property(e => e.OrderTypeId)
                .ValueGeneratedNever()
                .HasColumnName("OrderTypeID");
            entity.Property(e => e.OrderTypeDesc).HasMaxLength(100);
            entity.Property(e => e.OrderTypeName).HasMaxLength(50);
            entity.Property(e => e.OwnerCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsOtpmaster>(entity =>
        {
            entity.HasKey(e => e.Otpid);

            entity.ToTable("tbs_OTPMaster");

            entity.Property(e => e.Otpid)
                .ValueGeneratedNever()
                .HasColumnName("OTPID");
            entity.Property(e => e.Otpname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("OTPNAME");
        });

        modelBuilder.Entity<TbsPalletType>(entity =>
        {
            entity.HasKey(e => e.PalletTypeId);

            entity.ToTable("tbs_PalletType");

            entity.Property(e => e.PalletTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PalletTypeID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.PalletTypeName).HasMaxLength(50);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<TbsPoorderType>(entity =>
        {
            entity.HasKey(e => new { e.OwnerCode, e.OrderTypeId });

            entity.ToTable("tbs_POOrderType");

            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            entity.Property(e => e.OrderTypeDesc).HasMaxLength(100);
            entity.Property(e => e.OrderTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsPortClassification>(entity =>
        {
            entity.HasKey(e => e.PortClassificationId);

            entity.ToTable("tbs_PortClassification");

            entity.Property(e => e.PortClassificationId)
                .ValueGeneratedNever()
                .HasComment("ID of Port Classification")
                .HasColumnName("PortClassificationID");
            entity.Property(e => e.PortClassificationName)
                .HasMaxLength(50)
                .HasComment("Port Classification Name");
        });

        modelBuilder.Entity<TbsProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId);

            entity.ToTable("tbs_Province");

            entity.Property(e => e.ProvinceId)
                .ValueGeneratedNever()
                .HasColumnName("ProvinceID");
            entity.Property(e => e.ProvinceName).HasMaxLength(100);
            entity.Property(e => e.ProvinceNameEng).HasMaxLength(100);
            entity.Property(e => e.RegionCode).HasMaxLength(30);
        });

        modelBuilder.Entity<TbsRankAging>(entity =>
        {
            entity.HasKey(e => e.RankAgingId);

            entity.ToTable("tbs_RankAging");

            entity.Property(e => e.RankAgingId)
                .ValueGeneratedNever()
                .HasColumnName("RankAgingID");
            entity.Property(e => e.RankAgingName).HasMaxLength(20);
        });

        modelBuilder.Entity<TbsRegion>(entity =>
        {
            entity.HasKey(e => e.RegionCode);

            entity.ToTable("tbs_Region");

            entity.Property(e => e.RegionCode).ValueGeneratedNever();
            entity.Property(e => e.CountryCode).HasMaxLength(5);
            entity.Property(e => e.RegionName).HasMaxLength(30);
        });

        modelBuilder.Entity<TbsReport>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("tbs_Report");

            entity.Property(e => e.ReportId)
                .ValueGeneratedNever()
                .HasColumnName("ReportID");
            entity.Property(e => e.ReportCode).HasMaxLength(50);
            entity.Property(e => e.ReportName).HasMaxLength(100);
        });

        modelBuilder.Entity<TbsReportConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("tbs_ReportConfig");

            entity.Property(e => e.ConfigId)
                .HasMaxLength(10)
                .HasColumnName("ConfigID");
            entity.Property(e => e.ConfigValue).HasMaxLength(100);
        });

        modelBuilder.Entity<TbsReportParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbs_ReportParam");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.MailReceiver).HasMaxLength(1000);
            entity.Property(e => e.ParamName).HasMaxLength(100);
            entity.Property(e => e.ParamValue).HasMaxLength(100);
            entity.Property(e => e.RptName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsReportParamD>(entity =>
        {
            entity.HasKey(e => new { e.CriteriaId, e.RptName, e.CustomerId, e.ParamName });

            entity.ToTable("tbs_ReportParamD");

            entity.Property(e => e.CriteriaId).HasColumnName("CriteriaID");
            entity.Property(e => e.RptName).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ParamName).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.ParamValue).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsReportParamH>(entity =>
        {
            entity.HasKey(e => new { e.CriteriaId, e.RptName, e.CustomerId });

            entity.ToTable("tbs_ReportParamH");

            entity.Property(e => e.CriteriaId).HasColumnName("CriteriaID");
            entity.Property(e => e.RptName).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.EmailBody).HasMaxLength(200);
            entity.Property(e => e.MailReceiver).HasMaxLength(1000);
            entity.Property(e => e.SubJectMail).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbsRunningNoDetail>(entity =>
        {
            entity.HasKey(e => new { e.RunningCode, e.RunningPeriod }).HasName("PK__tbs_Runn__9507D4C60B6C16A1");

            entity.ToTable("tbs_RunningNoDetail");

            entity.Property(e => e.RunningCode).HasMaxLength(100);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbsRunningNoHeader>(entity =>
        {
            entity.HasKey(e => e.RunningCode).HasName("PK__tbs_Runn__E2437DEF88B389FB");

            entity.ToTable("tbs_RunningNoHeader");

            entity.Property(e => e.RunningCode).HasMaxLength(100);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LeadingText).HasMaxLength(100);
            entity.Property(e => e.RunningDescription).HasMaxLength(1000);
            entity.Property(e => e.RunningDigit).HasMaxLength(20);
        });

        modelBuilder.Entity<TbsScanType>(entity =>
        {
            entity.HasKey(e => e.ScanTypeId);

            entity.ToTable("tbs_ScanType");

            entity.Property(e => e.ScanTypeId)
                .ValueGeneratedNever()
                .HasComment("ID of Scan Type")
                .HasColumnName("ScanTypeID");
            entity.Property(e => e.ScanTypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Scan Type Name");
        });

        modelBuilder.Entity<TbsStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("tbs_Status");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasComment("ID of Status")
                .HasColumnName("StatusID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Status Name");
        });

        modelBuilder.Entity<TbsSystemConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("tbs_SystemConfig");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("ConfigID");
            entity.Property(e => e.ConfigItem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConfigValue)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.IsSystem).HasComment("0 = No; 1 = Yes");
        });

        modelBuilder.Entity<TbsUnitConvertTable>(entity =>
        {
            entity.HasKey(e => new { e.FromUnitId, e.ToUnitId });

            entity.ToTable("tbs_UnitConvertTable");

            entity.Property(e => e.FromUnitId).HasColumnName("FromUnitID");
            entity.Property(e => e.ToUnitId).HasColumnName("ToUnitID");
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<TbtAutobookProcess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ProcessSeq });

            entity.ToTable("tbt_AutobookProcess");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.EndProcess).HasColumnType("datetime");
            entity.Property(e => e.Ilabel)
                .HasMaxLength(200)
                .HasColumnName("ILabel");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.StartProcess).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtBillingCostForIncomingCharge>(entity =>
        {
            entity.HasKey(e => new { e.TransactionDate, e.CustomerId, e.Dcid, e.ProductId, e.PalletNo, e.LotNo }).HasName("PK_tbt_BillingCostForIncoming");

            entity.ToTable("tbt_BillingCostForIncomingCharge");

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivingVolume).HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<TbtBillingCostForOutgoingCharge>(entity =>
        {
            entity.HasKey(e => new { e.TransactionDate, e.CustomerId, e.Dcid, e.ProductId, e.PalletNo });

            entity.ToTable("tbt_BillingCostForOutgoingCharge");

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ShippingVolumn).HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<TbtBillingDataForChargeSummarize>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate });

            entity.ToTable("tbt_BillingDataForChargeSummarize");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.IncomingCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomingChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomingUnitId).HasColumnName("IncomingUnitID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.OtherCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherUnitId).HasColumnName("OtherUnitID");
            entity.Property(e => e.OutgoingCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OutgoingChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OutgoingUnitId).HasColumnName("OutgoingUnitID");
            entity.Property(e => e.PickingCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PickingChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PickingUnitId).HasColumnName("PickingUnitID");
            entity.Property(e => e.TransitCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransitChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransitUnitId).HasColumnName("TransitUnitID");
            entity.Property(e => e.TransportCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportUnitId).HasColumnName("TransportUnitID");
            entity.Property(e => e.UnstaffingCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnstaffingChargeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnstaffingUnitId).HasColumnName("UnstaffingUnitID");
        });

        modelBuilder.Entity<TbtBillingDataForEstimateValue>(entity =>
        {
            entity.HasKey(e => new { e.TransactionDate, e.Dcid, e.CustomerId, e.ProductId }).HasName("PK_tbt_BillingDataForEstimate");

            entity.ToTable("tbt_BillingDataForEstimateValue");

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Volume).HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<TbtBillingDataForMovement>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.PalletNo, e.LotNo });

            entity.ToTable("tbt_BillingDataForMovement");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.Balance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockQty).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtBillingDataForOtherCharge>(entity =>
        {
            entity.HasKey(e => new { e.SlipNo, e.Installment, e.TransactionDate, e.OtherChargeId });

            entity.ToTable("tbt_BillingDataForOtherCharge");

            entity.Property(e => e.SlipNo)
                .HasMaxLength(50)
                .HasComment("ReceivingNo. Or ShippingNo.");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.OtherChargeId).HasColumnName("OtherChargeID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasComment("Receiving=0, Shipping=1");
        });

        modelBuilder.Entity<TbtBillingDataForPicking>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo }).HasName("PK_tbt_BillingDataForPicking_1");

            entity.ToTable("tbt_BillingDataForPicking");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.Installment).HasDefaultValue(1);
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.PickingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TbtBillingDataForReceiving>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ReceivingNo, e.Installment, e.LineNo, e.LotNo });

            entity.ToTable("tbt_BillingDataForReceiving");

            entity.Property(e => e.CustomerId)
                .HasComment("This table is use for tbt_BillingCostForIncomingCharge")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Transaction Date/Time")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(50)
                .HasComment("Slip No.");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment");
            entity.Property(e => e.LotNo).HasMaxLength(200);
            entity.Property(e => e.InvoiceNo).HasMaxLength(300);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Last Update Date/Time")
                .HasColumnType("datetime");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivingQty)
                .HasComment("Receiving Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivingVolume)
                .HasComment("Receiving Quantity * Unit Volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.TypeOfUnitQty).HasComment("Type of Unit (as Unit of Picking Charge)");
        });

        modelBuilder.Entity<TbtBillingDataForShipping>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo }).HasName("PK_tbt_BillingDataForShipping_2");

            entity.ToTable("tbt_BillingDataForShipping");

            entity.Property(e => e.CustomerId)
                .HasComment("This table is use for tbt_BillingCostForOutgoingCharge")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ShippingVolumn).HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<TbtBillingDataForStock>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.ProductConditionId, e.LocationId, e.PalletNo });

            entity.ToTable("tbt_BillingDataForStock");

            entity.Property(e => e.CustomerId)
                .HasComment("Using Movement & Inventory Checking List report")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Stock Date (Process run everyday)")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.OpenningVolume)
                .HasComment("(M3)")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.StockQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockVolume)
                .HasComment("(M3)")
                .HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<TbtBillingDataForStockRecShip>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.LocationId, e.PalletNo, e.LotNo });

            entity.ToTable("tbt_BillingDataForStockRecShip");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.Balance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(300);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockQty).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtBillingDataForTransitCharge>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.ProductConditionId, e.PalletNo, e.LotNo }).HasName("PK_tbt_BillingDataForShipping");

            entity.ToTable("tbt_BillingDataForTransitCharge");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("TransitDate")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Last Update Date/Time")
                .HasColumnType("datetime");
            entity.Property(e => e.OpenningVolume)
                .HasComment("Stock Openning Volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.StockQty)
                .HasComment("Stock Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockVolume)
                .HasComment("Stock Quantity * Unit Volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.TransitCost).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TbtBillingDataForTransportCharge>(entity =>
        {
            entity.HasKey(e => new { e.TransportationDate, e.CustomerId, e.Dcid, e.FinalDestinationId, e.TransportTypeId });

            entity.ToTable("tbt_BillingDataForTransportCharge");

            entity.Property(e => e.TransportationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.FinalDestinationId).HasColumnName("FinalDestinationID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.TransportAmount)
                .HasComment("select SUM(TransportCharge) AS TransportAmount from tbt_ShippingTransportation group by TransportTypeID\r\n-- join tbt_ShippingInstruction")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Trips).HasComment("select TransportTypeID,count(TransportTypeID) AS trip from tbt_ShippingTransportation group by TransportTypeID\r\n-- join tbt_ShippingInstruction");
        });

        modelBuilder.Entity<TbtBillingDataForTransportChargeReceive>(entity =>
        {
            entity.HasKey(e => new { e.TransportationDate, e.CustomerId, e.Dcid, e.TransportTypeId });

            entity.ToTable("tbt_BillingDataForTransportChargeReceive");

            entity.Property(e => e.TransportationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceiveQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(50)
                .HasComment("Slip No.");
            entity.Property(e => e.TransportAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbtBillingDataForUnstaffing>(entity =>
        {
            entity.HasKey(e => new { e.TransactionDate, e.ReceivingNo, e.Installment, e.TransportTypeId }).HasName("PK_tbt_BillingDataForUnstaffing_1");

            entity.ToTable("tbt_BillingDataForUnstaffing");

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo).HasMaxLength(50);
            entity.Property(e => e.Installment).HasDefaultValue(1);
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.Amount)
                .HasComment("Summary by backend process")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Qty).HasComment("Count(TransportTypeID) on ReceivingNo by backend process");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbtBillingPalletMapping>(entity =>
        {
            entity.HasKey(e => new { e.PalletNo, e.PalletNoRef });

            entity.ToTable("tbt_BillingPalletMapping");

            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.PalletNoRef).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtChangeLocation>(entity =>
        {
            entity.HasKey(e => e.ChangeLocationId);

            entity.ToTable("tbt_ChangeLocation");

            entity.Property(e => e.ChangeLocationId).HasColumnName("ChangeLocationID");
            entity.Property(e => e.ChangedDate).HasColumnType("datetime");
            entity.Property(e => e.ChangedUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.FromDcid).HasColumnName("FromDCID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.FromProductConditionId).HasColumnName("FromProductConditionID");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(50)
                .HasColumnName("StickerUID");
            entity.Property(e => e.ToDcid).HasColumnName("ToDCID");
            entity.Property(e => e.ToLocationId).HasColumnName("ToLocationID");
            entity.Property(e => e.ToProductConditionId).HasColumnName("ToProductConditionID");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtChangeLocationHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_ChangeLocationHistory");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(50);
            entity.Property(e => e.ChangeStatus).HasComment("0: Success , 1: Cancel by User , 2: Cancel by allocation");
            entity.Property(e => e.ChangedDate).HasColumnType("datetime");
            entity.Property(e => e.ChangedUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.FromProductConditionId).HasColumnName("FromProductConditionID");
            entity.Property(e => e.HtconfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("HTConfirmDate");
            entity.Property(e => e.HtconfirmUser)
                .HasMaxLength(50)
                .HasColumnName("HTConfirmUser");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.SlipNo).HasMaxLength(100);
            entity.Property(e => e.ToLocationId).HasColumnName("ToLocationID");
            entity.Property(e => e.ToProductConditionId).HasColumnName("ToProductConditionID");
        });

        modelBuilder.Entity<TbtChangeLocationPhotoDetail>(entity =>
        {
            entity.HasKey(e => new { e.PhotoHeaderId, e.PhotoSeq }).HasName("PK__tbt_Chan__FD6CEE453F3DD336");

            entity.ToTable("tbt_ChangeLocationPhotoDetail");

            entity.Property(e => e.PhotoHeaderId).HasColumnName("PhotoHeaderID");
            entity.Property(e => e.PhotoFullPath).HasMaxLength(500);
        });

        modelBuilder.Entity<TbtChangeLocationPhotoHeader>(entity =>
        {
            entity.HasKey(e => e.PhotoHeaderId).HasName("PK__tbt_Chan__4A936BFD79ACDFD7");

            entity.ToTable("tbt_ChangeLocationPhotoHeader");

            entity.HasIndex(e => e.SlipNo, "UQ__tbt_Chan__1B2EB74BE4492FFC").IsUnique();

            entity.Property(e => e.PhotoHeaderId)
                .ValueGeneratedNever()
                .HasColumnName("PhotoHeaderID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(200);
            entity.Property(e => e.Opinion).HasMaxLength(500);
            entity.Property(e => e.PhotoDescription).HasMaxLength(500);
            entity.Property(e => e.SlipNo).HasMaxLength(200);
        });

        modelBuilder.Entity<TbtDailyPosted>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.ProductConditionId }).HasName("PK_tbt_DailyPosted_1");

            entity.ToTable("tbt_DailyPosted");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Customer")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Transaction Date")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.AdjustQtyNegative)
                .HasComment("Adjust Quantity (Negative)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.AdjustQtyPositive)
                .HasComment("Adjust Quantity (Positive)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HoldQty)
                .HasComment("Hold Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InventoryQty)
                .HasComment("Inventory after confirm storing and before picking")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PickingQty)
                .HasComment("Picking Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PostAdjustQty)
                .HasComment("Update by ESTS010 (Inventory Adjustment). \r\nOld field is KejobeAdjustQty")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivingQty)
                .HasComment("Receiving Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingQty)
                .HasComment("Shipping Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockBalance)
                .HasComment("StockBalance = Inv + Receiving - Shipping")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockActualQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockHoldQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockPickingQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockReceiveQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockShippingQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SumStockTransitEntryQty)
                .HasDefaultValue(0m)
                .HasComment("SumStockTransitQty")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitEntryQty)
                .HasComment("Entry Quantity. Old field is TransitQty.")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitQty)
                .HasComment("Transit Quantity (Storing Quantity)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransportationQty)
                .HasComment("Transportation Quantity")
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtDailyPostedForBilling>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate, e.ProductId, e.ProductConditionId, e.PalletNo, e.LotNo }).HasName("PK_tbt_DailyPostedForBilling_1");

            entity.ToTable("tbt_DailyPostedForBilling");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Customer")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Transaction Date")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.AdjustMinus).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ChangeLocation).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InventoryQty)
                .HasComment("Inventory after confirm storing and before picking")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PickingQty)
                .HasComment("Picking Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivingQty)
                .HasComment("Receiving Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReferenceSlipNo).HasMaxLength(50);
            entity.Property(e => e.ShippingQty)
                .HasComment("Shipping Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TransitQty)
                .HasComment("Transit Quantity (Storing Quantity)")
                .HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<TbtDailySummarized>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.TransactionDate });

            entity.ToTable("tbt_DailySummarized");

            entity.Property(e => e.CustomerId)
                .HasComment("ID of Customer")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Transaction Date")
                .HasColumnType("datetime");
            entity.Property(e => e.InventoryNoOfProduct)
                .HasDefaultValue(0m)
                .HasComment("Number of Product (Inventory). Old field is InventoryNoOfModel.")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PickingNoOfProduct)
                .HasDefaultValue(0m)
                .HasComment("Number of Product (Picking). Old field is PickingNoOfModel")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PickingNoOfSlip)
                .HasDefaultValue(0m)
                .HasComment("Number of Slip (Picking)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivingNoOfProduct)
                .HasDefaultValue(0m)
                .HasComment("Number of Product (Receiving). Old field is ReceivingNoOfModel")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivingNoOfSlip)
                .HasDefaultValue(0m)
                .HasComment("Number of Slip (Receiving)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingNoOfProduct)
                .HasDefaultValue(0m)
                .HasComment("Number of Product (Shipping). Old field is ShippingNoOfModel.")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingNoOfSlip)
                .HasDefaultValue(0m)
                .HasComment("Number of Slip (Shipping)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingTransports)
                .HasDefaultValue(0m)
                .HasComment("Old field is ShippingContainers.")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitNoOfProduct)
                .HasDefaultValue(0m)
                .HasComment("Number of Product (Storing) , StoringNoOfModel")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitNoOfSlip)
                .HasDefaultValue(0m)
                .HasComment("Number of Slip (Storing) ,StoringNoOfSlip")
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtDcReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_DC_Report");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.LdLegDetlId).HasColumnName("LD_LEG_DETL_ID");
            entity.Property(e => e.LdLegId)
                .HasMaxLength(50)
                .HasColumnName("LD_LEG_ID");
            entity.Property(e => e.M3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PackShippingMark).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.ShiptoAddress).HasMaxLength(500);
            entity.Property(e => e.ShiptoCode).HasMaxLength(100);
            entity.Property(e => e.ShiptoDestinationId).HasColumnName("ShiptoDestinationID");
            entity.Property(e => e.ShiptoLongName).HasMaxLength(250);
            entity.Property(e => e.ShiptoPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShpmItmId).HasColumnName("SHPM_ITM_ID");
            entity.Property(e => e.Sku)
                .HasMaxLength(200)
                .HasColumnName("SKU");
        });

        modelBuilder.Entity<TbtDeliveryNoteShipmentOrder>(entity =>
        {
            entity.HasKey(e => new { e.Sapdn, e.Plant });

            entity.ToTable("tbt_DeliveryNoteShipmentOrders");

            entity.Property(e => e.Sapdn)
                .HasMaxLength(100)
                .HasColumnName("SAPDN");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Consolidationflag)
                .HasMaxLength(72)
                .HasColumnName("CONSOLIDATIONFLAG");
            entity.Property(e => e.ControlPackId).HasColumnName("ControlPackID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Distributionchannel)
                .HasMaxLength(2)
                .HasColumnName("DISTRIBUTIONCHANNEL");
            entity.Property(e => e.Forwardingagent)
                .HasMaxLength(10)
                .HasColumnName("FORWARDINGAGENT");
            entity.Property(e => e.Freightterms)
                .HasMaxLength(10)
                .HasColumnName("FREIGHTTERMS");
            entity.Property(e => e.Inco1)
                .HasMaxLength(3)
                .HasColumnName("INCO1");
            entity.Property(e => e.Inco2)
                .HasMaxLength(28)
                .HasColumnName("INCO2");
            entity.Property(e => e.Instructionsto3pl1)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONSTO3PL1");
            entity.Property(e => e.Instructionsto3pl2)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONSTO3PL2");
            entity.Property(e => e.Instructionsto3pl3)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONSTO3PL3");
            entity.Property(e => e.Instructionsto3pl4)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONSTO3PL4");
            entity.Property(e => e.Modeoftransportation)
                .HasMaxLength(20)
                .HasColumnName("MODEOFTRANSPORTATION");
            entity.Property(e => e.Onboarddate)
                .HasMaxLength(12)
                .HasColumnName("ONBOARDDATE");
            entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            entity.Property(e => e.Orderpriority)
                .HasMaxLength(20)
                .HasColumnName("ORDERPRIORITY");
            entity.Property(e => e.Ordertype)
                .HasMaxLength(3)
                .HasColumnName("ORDERTYPE");
            entity.Property(e => e.Packinginstruction1)
                .HasMaxLength(64)
                .HasColumnName("PACKINGINSTRUCTION1");
            entity.Property(e => e.Packinginstruction2)
                .HasMaxLength(64)
                .HasColumnName("PACKINGINSTRUCTION2");
            entity.Property(e => e.Packinginstruction3)
                .HasMaxLength(64)
                .HasColumnName("PACKINGINSTRUCTION3");
            entity.Property(e => e.Packinginstruction4)
                .HasMaxLength(100)
                .HasColumnName("PACKINGINSTRUCTION4");
            entity.Property(e => e.Port)
                .HasMaxLength(20)
                .HasColumnName("PORT");
            entity.Property(e => e.ProcessCompleteFlag).HasDefaultValue(false);
            entity.Property(e => e.Reworkjob)
                .HasMaxLength(64)
                .HasColumnName("REWORKJOB");
            entity.Property(e => e.Salesorganization)
                .HasMaxLength(4)
                .HasColumnName("SALESORGANIZATION");
            entity.Property(e => e.Sapso)
                .HasMaxLength(10)
                .HasColumnName("SAPSO");
            entity.Property(e => e.Shiptocode)
                .HasMaxLength(100)
                .HasColumnName("SHIPTOCODE");
            entity.Property(e => e.Shiptocountrycode)
                .HasMaxLength(3)
                .HasColumnName("SHIPTOCOUNTRYCODE");
            entity.Property(e => e.Shiptopartyname)
                .HasMaxLength(35)
                .HasColumnName("SHIPTOPARTYNAME");
            entity.Property(e => e.Shiptopartyname2)
                .HasMaxLength(35)
                .HasColumnName("SHIPTOPARTYNAME2");
            entity.Property(e => e.Shiptopartyname3)
                .HasMaxLength(35)
                .HasColumnName("SHIPTOPARTYNAME3");
            entity.Property(e => e.Shiptopartyname4)
                .HasMaxLength(35)
                .HasColumnName("SHIPTOPARTYNAME4");
            entity.Property(e => e.Shiptopartystreet)
                .HasMaxLength(35)
                .HasColumnName("SHIPTOPARTYSTREET");
            entity.Property(e => e.Soldtopartycode)
                .HasMaxLength(10)
                .HasColumnName("SOLDTOPARTYCODE");
            entity.Property(e => e.Soldtopartyname)
                .HasMaxLength(35)
                .HasColumnName("SOLDTOPARTYNAME");
            entity.Property(e => e.Soldtopartyname2)
                .HasMaxLength(35)
                .HasColumnName("SOLDTOPARTYNAME2");
            entity.Property(e => e.Soldtopartyname3)
                .HasMaxLength(35)
                .HasColumnName("SOLDTOPARTYNAME3");
            entity.Property(e => e.Soldtopartyname4)
                .HasMaxLength(35)
                .HasColumnName("SOLDTOPARTYNAME4");
            entity.Property(e => e.Soldtopartystreet)
                .HasMaxLength(35)
                .HasColumnName("SOLDTOPARTYSTREET");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("STATUS");
            entity.Property(e => e.Termsofpayment)
                .HasMaxLength(4)
                .HasColumnName("TERMSOFPAYMENT");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtDeliveryNoteShipmentOrdersDetail>(entity =>
        {
            entity.HasKey(e => new { e.Sapdn, e.Plant, e.Dnlinenumber, e.Sku }).HasName("PK_tbt_DeliveryNoteShipmentOrders_detail");

            entity.ToTable("tbt_DeliveryNoteShipmentOrders_Detail");

            entity.Property(e => e.Sapdn)
                .HasMaxLength(100)
                .HasColumnName("SAPDN");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Dnlinenumber)
                .HasMaxLength(50)
                .HasColumnName("DNLINENUMBER");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .HasColumnName("SKU");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Customerpo)
                .HasMaxLength(20)
                .HasColumnName("CUSTOMERPO");
            entity.Property(e => e.Customerpoline)
                .HasMaxLength(6)
                .HasColumnName("CUSTOMERPOLINE");
            entity.Property(e => e.Customersku)
                .HasMaxLength(35)
                .HasColumnName("CUSTOMERSKU");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Instructionto3pl1)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONTO3PL1");
            entity.Property(e => e.Instructionto3pl2)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONTO3PL2");
            entity.Property(e => e.Instructionto3pl3)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONTO3PL3");
            entity.Property(e => e.Instructionto3pl4)
                .HasMaxLength(64)
                .HasColumnName("INSTRUCTIONTO3PL4");
            entity.Property(e => e.Packingrequirements1)
                .HasMaxLength(64)
                .HasColumnName("PACKINGREQUIREMENTS1");
            entity.Property(e => e.Packingrequirements2)
                .HasMaxLength(64)
                .HasColumnName("PACKINGREQUIREMENTS2");
            entity.Property(e => e.Packingrequirements3)
                .HasMaxLength(64)
                .HasColumnName("PACKINGREQUIREMENTS3");
            entity.Property(e => e.Packingrequirements4)
                .HasMaxLength(64)
                .HasColumnName("PACKINGREQUIREMENTS4");
            entity.Property(e => e.Productcode)
                .HasMaxLength(2)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Rework)
                .HasMaxLength(64)
                .HasColumnName("REWORK");
            entity.Property(e => e.Shipqty)
                .HasMaxLength(10)
                .HasColumnName("SHIPQTY");
            entity.Property(e => e.Skudescription)
                .HasMaxLength(40)
                .HasColumnName("SKUDESCRIPTION");
            entity.Property(e => e.Storagelocation)
                .HasMaxLength(10)
                .HasColumnName("STORAGELOCATION");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtEmptyShipmentGroup>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNoGroup, e.Dcid });

            entity.ToTable("tbt_EmptyShipmentGroup");

            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.RouteId).HasColumnName("RouteID");
        });

        modelBuilder.Entity<TbtFastLoadDetail>(entity =>
        {
            entity.HasKey(e => new { e.FastLoadNo, e.ShipmentNo, e.Installment, e.PackingNo });

            entity.ToTable("tbt_FastLoadDetail");

            entity.Property(e => e.FastLoadNo).HasMaxLength(30);
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PackShippingMark).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtFastLoadHeader>(entity =>
        {
            entity.HasKey(e => e.FastLoadNo);

            entity.ToTable("tbt_FastLoadHeader");

            entity.Property(e => e.FastLoadNo).HasMaxLength(30);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.RegistrationNo).HasMaxLength(20);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtGiserialCaptureD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_GISerialCaptureD");

            entity.Property(e => e.GiserialCaptureId).HasColumnName("GISerialCaptureID");
            entity.Property(e => e.IsExportResult).HasDefaultValue(0);
            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtGiserialCaptureH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_GISerialCaptureH");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GiserialCaptureId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GISerialCaptureID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.WarrantyCode)
                .HasMaxLength(30)
                .HasColumnName("Warranty_code");
        });

        modelBuilder.Entity<TbtGivoidCaptureD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_GIVoidCaptureD");

            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.GivoidCaptureId).HasColumnName("GIVoidCaptureID");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.VoidNo).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtGivoidCaptureH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_GIVoidCaptureH");

            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GivoidCaptureId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GIVoidCaptureID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
        });

        modelBuilder.Entity<TbtImportRmStockHistory>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_ImportRmStock_History");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.ContainerNo).HasMaxLength(50);
            entity.Property(e => e.ContainerType).HasMaxLength(50);
            entity.Property(e => e.GrossWeight).HasMaxLength(50);
            entity.Property(e => e.ImportBy).HasMaxLength(50);
            entity.Property(e => e.ImportDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(100);
            entity.Property(e => e.NetWeight).HasMaxLength(50);
            entity.Property(e => e.PalletBagNo).HasMaxLength(50);
            entity.Property(e => e.QtyBalance).HasMaxLength(50);
            entity.Property(e => e.QtyIn).HasMaxLength(50);
            entity.Property(e => e.QtyOut).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Reweightcompleted)
                .HasMaxLength(100)
                .HasColumnName("REWEIGHTCOMPLETED");
            entity.Property(e => e.RowNumber).HasMaxLength(50);
            entity.Property(e => e.Supplier).HasMaxLength(100);
            entity.Property(e => e.TakeInDate).HasMaxLength(50);
            entity.Property(e => e.TakeOutDate).HasMaxLength(50);
            entity.Property(e => e.ZoneCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtInfCmstrackingReq>(entity =>
        {
            entity.HasKey(e => e.InterfaceId);

            entity.ToTable("tbt_INF_CMSTrackingReq");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Gidate)
                .HasColumnType("datetime")
                .HasColumnName("GIDate");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LoadTms)
                .HasMaxLength(50)
                .HasColumnName("LoadTMS");
            entity.Property(e => e.PoNo).HasMaxLength(50);
            entity.Property(e => e.ReceivingDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtInfRetry>(entity =>
        {
            entity.ToTable("tbt_inf_retry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.ProcessName).HasMaxLength(30);
        });

        modelBuilder.Entity<TbtInfUnloadDatum>(entity =>
        {
            entity.HasKey(e => e.RefId);

            entity.ToTable("tbt_INF_UnloadData");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.FromLocationCode).HasMaxLength(50);
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(50)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.RefDocNo).HasMaxLength(50);
            entity.Property(e => e.SystemLoadId)
                .HasMaxLength(50)
                .HasColumnName("SystemLoadID");
            entity.Property(e => e.SystemShipmentId)
                .HasMaxLength(50)
                .HasColumnName("SystemShipmentID");
            entity.Property(e => e.SystemShipmentLegId)
                .HasMaxLength(50)
                .HasColumnName("SystemShipmentLegID");
        });

        modelBuilder.Entity<TbtInterfaceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_InterfaceLog");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtInterfaceMasterLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__tbt_Inte__5E5499A866C420CB");

            entity.ToTable("tbt_InterfaceMasterLog");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ActionDetail)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ActualTableName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DestinationTableName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SourceTableName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbtInterfaceOrderRetrieve>(entity =>
        {
            entity.HasKey(e => e.RefId).HasName("PK_InterfaceOrderRetrieve");

            entity.ToTable("tbt_InterfaceOrderRetrieve");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DeliveryFromDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeliveryToDateTime).HasColumnType("datetime");
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.PickupFromDateTime).HasColumnType("datetime");
            entity.Property(e => e.PickupToDateTime).HasColumnType("datetime");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(50)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.RefShipmentGroupNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtInterfacePack>(entity =>
        {
            entity.HasKey(e => e.RefId);

            entity.ToTable("tbt_InterfacePack");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.CompletedFlag).HasDefaultValue(true);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(10);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DeliveryType).HasMaxLength(20);
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.MaterialBaseUnit).HasMaxLength(10);
            entity.Property(e => e.MaterialCode).HasMaxLength(12);
            entity.Property(e => e.MaterialFreightGroup).HasMaxLength(8);
            entity.Property(e => e.MaterialGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Reason).HasMaxLength(100);
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(15)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.SoitemNumber).HasColumnName("SOItemNumber");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(12)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.SourceSystemId).HasColumnName("SourceSystemID");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UpdateFlag).HasDefaultValue(false);
            entity.Property(e => e.VolumeUnit).HasMaxLength(10);
            entity.Property(e => e.WeightUnit).HasMaxLength(10);
        });

        modelBuilder.Entity<TbtInterfacePackingResult>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_PackingResult");

            entity.ToTable("tbt_Interface_PackingResult");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CoilAxisVerticalHorizontalDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilAxis_VerticalHorizontal_Division");
            entity.Property(e => e.CoilNo)
                .HasMaxLength(100)
                .HasColumnName("Coil_No");
            entity.Property(e => e.CoilWindingUnwindingDirectionDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilWinding_UnwindingDirection_Division");
            entity.Property(e => e.ConsumerDisplaySizeTextKana)
                .HasMaxLength(100)
                .HasColumnName("ConsumerDisplaySize_Text_KANA");
            entity.Property(e => e.ConsumerItemCode)
                .HasMaxLength(100)
                .HasColumnName("ConsumerItem_Code");
            entity.Property(e => e.ConsumerName)
                .HasMaxLength(100)
                .HasColumnName("Consumer_Name");
            entity.Property(e => e.ConsumerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("ConsumerOrder_No");
            entity.Property(e => e.ConsumerProductNameHalfWidth)
                .HasMaxLength(100)
                .HasColumnName("ConsumerProduct_Name_HalfWidth");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerItemCode)
                .HasMaxLength(100)
                .HasColumnName("CustomerItem_Code");
            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("CustomerOrder_No");
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("ExternalAlloy_Name");
            entity.Property(e => e.InHouseAlloyCode)
                .HasMaxLength(100)
                .HasColumnName("InHouseAlloy_Code");
            entity.Property(e => e.IndividualPackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Quantity");
            entity.Property(e => e.IndividualPackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Weight_Net");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.IntermediateFinalPackageDivision)
                .HasMaxLength(100)
                .HasColumnName("IntermediateFinal_Package_Division");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingInstruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingQuality_Type");
            entity.Property(e => e.OddStackCount)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Count");
            entity.Property(e => e.OddStackHeight)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Height");
            entity.Property(e => e.OddStackRows)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Rows");
            entity.Property(e => e.PackageCount)
                .HasMaxLength(100)
                .HasColumnName("Package_Count");
            entity.Property(e => e.PackageDetailsQuantity)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Quantity");
            entity.Property(e => e.PackageDetailsTrackingNo)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Tracking_No");
            entity.Property(e => e.PackageDetailsWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Weight_Net");
            entity.Property(e => e.PackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageWeightGloss)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Gloss");
            entity.Property(e => e.PackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Net");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.PalletNo)
                .HasMaxLength(100)
                .HasColumnName("Pallet_No");
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductInventoryStatus)
                .HasMaxLength(100)
                .HasColumnName("ProductInventory_Status");
            entity.Property(e => e.ProductInventoryStatusChangeDate)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Date");
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeEmployee_Name");
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeReason_Comment");
            entity.Property(e => e.ProductInventoryStatusChangeTime)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Time");
            entity.Property(e => e.ProductInventoryStatusSettingDivision)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_SettingDivision");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("ProductName_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Length");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Width");
            entity.Property(e => e.ProductTypeCode)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Code");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Name");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(100)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.QualityTypeForConsumerDisplay)
                .HasMaxLength(100)
                .HasColumnName("QualityType_ForConsumerDisplay");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StackCount)
                .HasMaxLength(100)
                .HasColumnName("Stack_Count");
            entity.Property(e => e.StackHeight)
                .HasMaxLength(100)
                .HasColumnName("Stack_Height");
            entity.Property(e => e.StackRows)
                .HasMaxLength(100)
                .HasColumnName("Stack_Rows");
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode)
                .HasMaxLength(100)
                .HasColumnName("SurfaceTreatment_AuxiliaryCode");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbtInterfacePackingResultBk>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_PackingResult_BK");

            entity.ToTable("tbt_Interface_PackingResult_BK");

            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CoilAxisVerticalHorizontalDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilAxis_VerticalHorizontal_Division");
            entity.Property(e => e.CoilNo)
                .HasMaxLength(100)
                .HasColumnName("Coil_No");
            entity.Property(e => e.CoilWindingUnwindingDirectionDivision)
                .HasMaxLength(100)
                .HasColumnName("CoilWinding_UnwindingDirection_Division");
            entity.Property(e => e.ConsumerDisplaySizeTextKana)
                .HasMaxLength(100)
                .HasColumnName("ConsumerDisplaySize_Text_KANA");
            entity.Property(e => e.ConsumerItemCode)
                .HasMaxLength(100)
                .HasColumnName("ConsumerItem_Code");
            entity.Property(e => e.ConsumerName)
                .HasMaxLength(100)
                .HasColumnName("Consumer_Name");
            entity.Property(e => e.ConsumerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("ConsumerOrder_No");
            entity.Property(e => e.ConsumerProductNameHalfWidth)
                .HasMaxLength(100)
                .HasColumnName("ConsumerProduct_Name_HalfWidth");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerItemCode)
                .HasMaxLength(100)
                .HasColumnName("CustomerItem_Code");
            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(100)
                .HasColumnName("CustomerOrder_No");
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("ExternalAlloy_Name");
            entity.Property(e => e.InHouseAlloyCode)
                .HasMaxLength(100)
                .HasColumnName("InHouseAlloy_Code");
            entity.Property(e => e.IndividualPackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Quantity");
            entity.Property(e => e.IndividualPackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("IndividualPackage_Weight_Net");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.IntermediateFinalPackageDivision)
                .HasMaxLength(100)
                .HasColumnName("IntermediateFinal_Package_Division");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingInstruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("ManufacturingQuality_Type");
            entity.Property(e => e.OddStackCount)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Count");
            entity.Property(e => e.OddStackHeight)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Height");
            entity.Property(e => e.OddStackRows)
                .HasMaxLength(100)
                .HasColumnName("OddStack_Rows");
            entity.Property(e => e.PackageCount)
                .HasMaxLength(100)
                .HasColumnName("Package_Count");
            entity.Property(e => e.PackageDetailsQuantity)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Quantity");
            entity.Property(e => e.PackageDetailsTrackingNo)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Tracking_No");
            entity.Property(e => e.PackageDetailsWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageDetails_Weight_Net");
            entity.Property(e => e.PackageQuantity)
                .HasMaxLength(100)
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageWeightGloss)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Gloss");
            entity.Property(e => e.PackageWeightNet)
                .HasMaxLength(100)
                .HasColumnName("PackageWeight_Net");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.PalletNo)
                .HasMaxLength(100)
                .HasColumnName("Pallet_No");
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductInventoryStatus)
                .HasMaxLength(100)
                .HasColumnName("ProductInventory_Status");
            entity.Property(e => e.ProductInventoryStatusChangeDate)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Date");
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeEmployee_Name");
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_ChangeReason_Comment");
            entity.Property(e => e.ProductInventoryStatusChangeTime)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_Change_Time");
            entity.Property(e => e.ProductInventoryStatusSettingDivision)
                .HasMaxLength(100)
                .HasColumnName("ProductInventoryStatus_SettingDivision");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("ProductName_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Length");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("ProductSize_Width");
            entity.Property(e => e.ProductTypeCode)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Code");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("ProductType_Name");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(100)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.QualityTypeForConsumerDisplay)
                .HasMaxLength(100)
                .HasColumnName("QualityType_ForConsumerDisplay");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StackCount)
                .HasMaxLength(100)
                .HasColumnName("Stack_Count");
            entity.Property(e => e.StackHeight)
                .HasMaxLength(100)
                .HasColumnName("Stack_Height");
            entity.Property(e => e.StackRows)
                .HasMaxLength(100)
                .HasColumnName("Stack_Rows");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode)
                .HasMaxLength(100)
                .HasColumnName("SurfaceTreatment_AuxiliaryCode");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbtInterfacePick>(entity =>
        {
            entity.HasKey(e => e.RefId).HasName("PK_tbt_InterfacePick_1");

            entity.ToTable("tbt_InterfacePick");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.CustomerCode).HasMaxLength(10);
            entity.Property(e => e.DeliveryType).HasMaxLength(20);
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.Reason).HasMaxLength(1000);
            entity.Property(e => e.RefDocNo).HasMaxLength(60);
            entity.Property(e => e.SoitemNumber).HasColumnName("SOItemNumber");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(12)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtInterfaceProductInventoryDisposal>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_Stock_Product_InventoryDisposal");

            entity.ToTable("tbt_Interface_Product_InventoryDisposal");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DispensingActionClassification).HasMaxLength(100);
            entity.Property(e => e.DispensingDate).HasMaxLength(100);
            entity.Property(e => e.DispensingReasonComment).HasMaxLength(100);
            entity.Property(e => e.DispensingStaffName).HasMaxLength(100);
            entity.Property(e => e.DispensingTime).HasMaxLength(100);
            entity.Property(e => e.PackagingNumber).HasMaxLength(100);
            entity.Property(e => e.RedBlackClassification).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtInterfaceProductInventoryStatus>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_Stock_Product_InventoryStatus");

            entity.ToTable("tbt_Interface_Product_InventoryStatus");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PackingNumber).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatus).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeDate).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeEmployeeName).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeReasonComment).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusChangeTime).HasMaxLength(100);
            entity.Property(e => e.ProductInventoryStatusSettingDivision).HasMaxLength(100);
            entity.Property(e => e.RedBlackDivision).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtInterfaceSalesOrder>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_Stock_SalesOrder");

            entity.ToTable("tbt_Interface_SalesOrder");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CoilAxisDivision)
                .HasMaxLength(100)
                .HasColumnName("Coil_Axis_Division");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_CD");
            entity.Property(e => e.CustomerDisplaySizeText)
                .HasMaxLength(100)
                .HasColumnName("Customer_Display_Size_Text");
            entity.Property(e => e.CustomerItemCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_Item_CD");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerProductName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Product_Name");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.DeliveryDestinationName)
                .HasMaxLength(200)
                .HasColumnName("Delivery_Destination_Name");
            entity.Property(e => e.DeliveryTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_End");
            entity.Property(e => e.DeliveryTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_Start");
            entity.Property(e => e.DestinationCode)
                .HasMaxLength(100)
                .HasColumnName("Destination_Code");
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("External_Alloy_Name");
            entity.Property(e => e.InOutFactorCd)
                .HasMaxLength(100)
                .HasColumnName("In_Out_Factor_CD");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.InternalAlloyCd)
                .HasMaxLength(100)
                .HasColumnName("Internal_Alloy_CD");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_End");
            entity.Property(e => e.LoadingInstructionTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_Start");
            entity.Property(e => e.LotNoFirstSixDigits)
                .HasMaxLength(100)
                .HasColumnName("LOT_No_First_Six_Digits");
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Instruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Quality_Type");
            entity.Property(e => e.OrdererAddress)
                .HasMaxLength(200)
                .HasColumnName("Orderer_Address");
            entity.Property(e => e.OrdererCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_CD");
            entity.Property(e => e.OrdererItemCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Item_CD");
            entity.Property(e => e.OrdererName)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Name");
            entity.Property(e => e.OrdererPhoneNumber)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Phone_Number");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("Product_Name_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Length");
            entity.Property(e => e.ProductSizeShape)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Shape");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Width");
            entity.Property(e => e.ProductTypeCd)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_CD");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_Name");
            entity.Property(e => e.QualityTypeForCustomer)
                .HasMaxLength(100)
                .HasColumnName("Quality_Type_For_Customer");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.ShipmentInstructionComment)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Comment");
            entity.Property(e => e.ShipmentInstructionDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Date");
            entity.Property(e => e.ShipmentInstructionDetailNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Detail_No");
            entity.Property(e => e.ShipmentInstructionEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Employee_Name");
            entity.Property(e => e.ShipmentInstructionInputDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Date");
            entity.Property(e => e.ShipmentInstructionInputTime)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Time");
            entity.Property(e => e.ShipmentInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_No");
            entity.Property(e => e.ShipmentInstructionPackingQty)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Packing_Qty");
            entity.Property(e => e.ShipmentInstructionPattern)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Pattern");
            entity.Property(e => e.ShipmentInstructionWeight)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMax)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Max");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMin)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Min");
            entity.Property(e => e.ShipperWarehouseCd)
                .HasMaxLength(100)
                .HasColumnName("Shipper_Warehouse_CD");
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentSubCd)
                .HasMaxLength(100)
                .HasColumnName("Surface_Treatment_Sub_CD");
            entity.Property(e => e.TransferTypeId)
                .HasComment("1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory")
                .HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbtInterfaceSalesOrderBk>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_Stock_SalesOrder_BK");

            entity.ToTable("tbt_Interface_SalesOrder_BK");

            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CoilAxisDivision)
                .HasMaxLength(100)
                .HasColumnName("Coil_Axis_Division");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_CD");
            entity.Property(e => e.CustomerDisplaySizeText)
                .HasMaxLength(100)
                .HasColumnName("Customer_Display_Size_Text");
            entity.Property(e => e.CustomerItemCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_Item_CD");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerProductName)
                .HasMaxLength(100)
                .HasColumnName("Customer_Product_Name");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.DeliveryDestinationName)
                .HasMaxLength(200)
                .HasColumnName("Delivery_Destination_Name");
            entity.Property(e => e.DeliveryTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_End");
            entity.Property(e => e.DeliveryTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Time_Start");
            entity.Property(e => e.DestinationCode)
                .HasMaxLength(100)
                .HasColumnName("Destination_Code");
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName)
                .HasMaxLength(100)
                .HasColumnName("External_Alloy_Name");
            entity.Property(e => e.InOutFactorCd)
                .HasMaxLength(100)
                .HasColumnName("In_Out_Factor_CD");
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.InternalAlloyCd)
                .HasMaxLength(100)
                .HasColumnName("Internal_Alloy_CD");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionTimeEnd)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_End");
            entity.Property(e => e.LoadingInstructionTimeStart)
                .HasMaxLength(100)
                .HasColumnName("Loading_Instruction_Time_Start");
            entity.Property(e => e.LotNoFirstSixDigits)
                .HasMaxLength(100)
                .HasColumnName("LOT_No_First_Six_Digits");
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Instruction_No");
            entity.Property(e => e.ManufacturingQualityType)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Quality_Type");
            entity.Property(e => e.OrdererAddress)
                .HasMaxLength(200)
                .HasColumnName("Orderer_Address");
            entity.Property(e => e.OrdererCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_CD");
            entity.Property(e => e.OrdererItemCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Item_CD");
            entity.Property(e => e.OrdererName)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Name");
            entity.Property(e => e.OrdererPhoneNumber)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Phone_Number");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductNameEdited)
                .HasMaxLength(100)
                .HasColumnName("Product_Name_Edited");
            entity.Property(e => e.ProductSizeLength)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Length");
            entity.Property(e => e.ProductSizeShape)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Shape");
            entity.Property(e => e.ProductSizeThickness)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Thickness");
            entity.Property(e => e.ProductSizeWidth)
                .HasMaxLength(100)
                .HasColumnName("Product_Size_Width");
            entity.Property(e => e.ProductTypeCd)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_CD");
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(100)
                .HasColumnName("Product_Type_Name");
            entity.Property(e => e.QualityTypeForCustomer)
                .HasMaxLength(100)
                .HasColumnName("Quality_Type_For_Customer");
            entity.Property(e => e.RedBlackDivision)
                .HasMaxLength(100)
                .HasColumnName("RedBlack_Division");
            entity.Property(e => e.ShipmentInstructionComment)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Comment");
            entity.Property(e => e.ShipmentInstructionDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Date");
            entity.Property(e => e.ShipmentInstructionDetailNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Detail_No");
            entity.Property(e => e.ShipmentInstructionEmployeeName)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Employee_Name");
            entity.Property(e => e.ShipmentInstructionInputDate)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Date");
            entity.Property(e => e.ShipmentInstructionInputTime)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Input_Time");
            entity.Property(e => e.ShipmentInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_No");
            entity.Property(e => e.ShipmentInstructionPackingQty)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Packing_Qty");
            entity.Property(e => e.ShipmentInstructionPattern)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Pattern");
            entity.Property(e => e.ShipmentInstructionWeight)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMax)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Max");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMin)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Min");
            entity.Property(e => e.ShipperWarehouseCd)
                .HasMaxLength(100)
                .HasColumnName("Shipper_Warehouse_CD");
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.SizeEdited)
                .HasMaxLength(100)
                .HasColumnName("Size_Edited");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentSubCd)
                .HasMaxLength(100)
                .HasColumnName("Surface_Treatment_Sub_CD");
            entity.Property(e => e.TransferTypeId).HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbtInterfaceShipment>(entity =>
        {
            entity.HasKey(e => e.InterfaceShipmentId);

            entity.ToTable("tbt_InterfaceShipments");

            entity.Property(e => e.InterfaceShipmentId).HasColumnName("InterfaceShipmentID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.DestinationCode).HasMaxLength(50);
            entity.Property(e => e.DestinationName).HasMaxLength(100);
            entity.Property(e => e.OriginCode).HasMaxLength(50);
            entity.Property(e => e.OriginName).HasMaxLength(100);
            entity.Property(e => e.RegisTrantionNo).HasMaxLength(50);
            entity.Property(e => e.ShipmentDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.TruckCompanyCode).HasMaxLength(50);
            entity.Property(e => e.TruckType).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtInterfaceStatus>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceTypeId, e.InterfaceTransactionId });

            entity.ToTable("tbt_InterfaceStatus");

            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.InterfaceTransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InterfaceTransactionID");
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(10);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.EventName).HasMaxLength(40);
            entity.Property(e => e.FileNameInf).HasMaxLength(100);
            entity.Property(e => e.IssueDateTime).HasColumnType("datetime");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.MaterialCode).HasMaxLength(12);
            entity.Property(e => e.OnProcessUser).HasMaxLength(50);
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.RawData).HasMaxLength(4000);
            entity.Property(e => e.RefDocNo).HasMaxLength(2000);
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.Result).HasMaxLength(2000);
            entity.Property(e => e.Soitem).HasColumnName("SOItem");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(12)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystemId).HasColumnName("SourceSystemID");
            entity.Property(e => e.WarehouseCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtInterfaceStatusHistory>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceTypeId, e.InterfaceTransactionId });

            entity.ToTable("tbt_InterfaceStatusHistory");

            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.InterfaceTransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InterfaceTransactionID");
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(10);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.EventName).HasMaxLength(40);
            entity.Property(e => e.IssueDateTime).HasColumnType("datetime");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.MaterialCode).HasMaxLength(12);
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.RefDocNo).HasMaxLength(60);
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.Result).HasMaxLength(2000);
            entity.Property(e => e.Soitem).HasColumnName("SOItem");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(12)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystemId).HasColumnName("SourceSystemID");
            entity.Property(e => e.WarehouseCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtInterfaceTm>(entity =>
        {
            entity.HasKey(e => e.RefId);

            entity.ToTable("tbt_InterfaceTMS");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.RefDocNo).HasMaxLength(50);
            entity.Property(e => e.RequestDateTime).HasColumnType("datetime");
            entity.Property(e => e.SystemLoadId)
                .HasMaxLength(20)
                .HasColumnName("SystemLoadID");
            entity.Property(e => e.SystemPlanId)
                .HasMaxLength(20)
                .HasColumnName("SystemPlanID");
        });

        modelBuilder.Entity<TbtInterfaceTmsdetail>(entity =>
        {
            entity.HasKey(e => new { e.RefId, e.InterfaceTypeId, e.RefDocNo, e.RefDnno });

            entity.ToTable("tbt_InterfaceTMSDetail");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
            entity.Property(e => e.RefDocNo).HasMaxLength(50);
            entity.Property(e => e.RefDnno)
                .HasMaxLength(50)
                .HasColumnName("RefDNNo");
            entity.Property(e => e.FlagType).HasMaxLength(2);
            entity.Property(e => e.FromLocationCode).HasMaxLength(50);
            entity.Property(e => e.SystemLoadId)
                .HasMaxLength(50)
                .HasColumnName("SystemLoadID");
            entity.Property(e => e.SystemShipmentId)
                .HasMaxLength(50)
                .HasColumnName("SystemShipmentID");
            entity.Property(e => e.SystemShipmentLegId)
                .HasMaxLength(50)
                .HasColumnName("SystemShipmentLegID");
            entity.Property(e => e.ToLocationCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtInterfaceToSap>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_Interface_toSAP");

            entity.ToTable("tbt_Interface_to_SAP");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ActualThickness)
                .HasMaxLength(50)
                .HasColumnName("Actual_thickness");
            entity.Property(e => e.BareWeight)
                .HasMaxLength(50)
                .HasColumnName("Bare_Weight");
            entity.Property(e => e.BookingNumber)
                .HasMaxLength(50)
                .HasColumnName("Booking_Number");
            entity.Property(e => e.CoilNetWeightPerLot)
                .HasMaxLength(50)
                .HasColumnName("Coil_Net_Weight_Per_Lot");
            entity.Property(e => e.CoilNumber)
                .HasMaxLength(50)
                .HasColumnName("Coil_Number");
            entity.Property(e => e.CoilQuantity)
                .HasMaxLength(50)
                .HasColumnName("Coil_Quantity");
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(50)
                .HasColumnName("Container_Number");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerMaterial)
                .HasMaxLength(50)
                .HasColumnName("Customer_Material");
            entity.Property(e => e.DeliveryFrom)
                .HasMaxLength(50)
                .HasColumnName("Delivery_From");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(50)
                .HasColumnName("Gross_Weight");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .HasColumnName("Lot_Number");
            entity.Property(e => e.MfgDate)
                .HasMaxLength(50)
                .HasColumnName("MFG_Date");
            entity.Property(e => e.NetWeightPerPacking)
                .HasMaxLength(50)
                .HasColumnName("Net_Weight_Per_Packing");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.PrintDirectionNumber)
                .HasMaxLength(50)
                .HasColumnName("Print_Direction_Number");
            entity.Property(e => e.SheetNetWeightPerLot)
                .HasMaxLength(50)
                .HasColumnName("Sheet_Net_Weight_Per_Lot");
            entity.Property(e => e.SheetQuantity)
                .HasMaxLength(50)
                .HasColumnName("Sheet_Quantity");
            entity.Property(e => e.ShippedDate)
                .HasMaxLength(50)
                .HasColumnName("Shipped_Date");
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.ShippingNoteStatus).HasMaxLength(50);
            entity.Property(e => e.ShippingOrderDate)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Order_Date");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(50)
                .HasColumnName("WorkOrderID");
        });

        modelBuilder.Entity<TbtInterfaceToSapBk>(entity =>
        {
            entity.ToTable("tbt_Interface_to_SAP_BK");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ActualThickness)
                .HasMaxLength(50)
                .HasColumnName("Actual_thickness");
            entity.Property(e => e.BareWeight)
                .HasMaxLength(50)
                .HasColumnName("Bare_Weight");
            entity.Property(e => e.BookingNumber)
                .HasMaxLength(50)
                .HasColumnName("Booking_Number");
            entity.Property(e => e.CoilNetWeightPerLot)
                .HasMaxLength(50)
                .HasColumnName("Coil_Net_Weight_Per_Lot");
            entity.Property(e => e.CoilNumber)
                .HasMaxLength(50)
                .HasColumnName("Coil_Number");
            entity.Property(e => e.CoilQuantity)
                .HasMaxLength(50)
                .HasColumnName("Coil_Quantity");
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(50)
                .HasColumnName("Container_Number");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerMaterial)
                .HasMaxLength(50)
                .HasColumnName("Customer_Material");
            entity.Property(e => e.DeliveryFrom)
                .HasMaxLength(50)
                .HasColumnName("Delivery_From");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(50)
                .HasColumnName("Gross_Weight");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .HasColumnName("Lot_Number");
            entity.Property(e => e.MfgDate)
                .HasMaxLength(50)
                .HasColumnName("MFG_Date");
            entity.Property(e => e.NetWeightPerPacking)
                .HasMaxLength(50)
                .HasColumnName("Net_Weight_Per_Packing");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.PrintDirectionNumber)
                .HasMaxLength(50)
                .HasColumnName("Print_Direction_Number");
            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.SheetNetWeightPerLot)
                .HasMaxLength(50)
                .HasColumnName("Sheet_Net_Weight_Per_Lot");
            entity.Property(e => e.SheetQuantity)
                .HasMaxLength(50)
                .HasColumnName("Sheet_Quantity");
            entity.Property(e => e.ShippedDate)
                .HasMaxLength(50)
                .HasColumnName("Shipped_Date");
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.ShippingNoteStatus).HasMaxLength(50);
            entity.Property(e => e.ShippingOrderDate)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Order_Date");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(50)
                .HasColumnName("WorkOrderID");
        });

        modelBuilder.Entity<TbtInterfaceToThact660>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_Interface_to_THACT_660");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameTransfer)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Transfer");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.ReceivingLocationCode)
                .HasMaxLength(50)
                .HasColumnName("Receiving_Location_Code");
            entity.Property(e => e.RedBlackCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.TemporaryPackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Temporary_Packing_Number");
            entity.Property(e => e.TransferDate)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date");
            entity.Property(e => e.TransferDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date_Confirm");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time");
            entity.Property(e => e.TransferTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceToThact660Bk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbt_Interface_to_THACT_660_BK_1");

            entity.ToTable("tbt_Interface_to_THACT_660_BK");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameTransfer)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Transfer");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.ReceivingLocationCode)
                .HasMaxLength(50)
                .HasColumnName("Receiving_Location_Code");
            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.RedBlackCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.TemporaryPackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Temporary_Packing_Number");
            entity.Property(e => e.TransferDate)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date");
            entity.Property(e => e.TransferDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date_Confirm");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time");
            entity.Property(e => e.TransferTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceToThact670>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_Interface_to_THACT_670");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(50)
                .HasColumnName("Container_Number");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameVanning)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Vanning");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.VanningDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Vanning_Date_Confirm");
            entity.Property(e => e.VanningTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Vanning_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceToThact670Bk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbt_Interface_to_THACT_670_BK_1");

            entity.ToTable("tbt_Interface_to_THACT_670_BK");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(50)
                .HasColumnName("Container_Number");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameVanning)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Vanning");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.VanningDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Vanning_Date_Confirm");
            entity.Property(e => e.VanningTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Vanning_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceToThact690>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_Interface_to_THACT_690");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameTransfer)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Transfer");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.RedBlackCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.ShippingStatus)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Status");
            entity.Property(e => e.TransferDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date_Confirm");
            entity.Property(e => e.TransferTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceToThact690Bk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbt_Interface_to_THACT_690_BK_1");

            entity.ToTable("tbt_Interface_to_THACT_690_BK");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeNameTransfer)
                .HasMaxLength(50)
                .HasColumnName("EmployeeName_Transfer");
            entity.Property(e => e.PackingNumber)
                .HasMaxLength(50)
                .HasColumnName("Packing_Number");
            entity.Property(e => e.RecordId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.RedBlackCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShippingNoteNumber)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Note_Number");
            entity.Property(e => e.ShippingStatus)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Status");
            entity.Property(e => e.TransferDateConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Date_Confirm");
            entity.Property(e => e.TransferTimeConfirm)
                .HasMaxLength(50)
                .HasColumnName("Transfer_Time_Confirm");
        });

        modelBuilder.Entity<TbtInterfaceTransfer>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_StockTransfers_1");

            entity.ToTable("tbt_Interface_Transfer");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.CoilVerticalHorizontalAxisCategory).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerDisplaySizeTextKana).HasMaxLength(100);
            entity.Property(e => e.CustomerItemCode).HasMaxLength(100);
            entity.Property(e => e.CustomerItemNameHalfwidth).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasMaxLength(100);
            entity.Property(e => e.DeliveryEndTime).HasMaxLength(100);
            entity.Property(e => e.DeliveryStartTime).HasMaxLength(100);
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.InventoryMovementReasonCode).HasMaxLength(100);
            entity.Property(e => e.InventoryTransferInstructionPattern).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionEndTime).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionStartTime).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.LotnoFirst6DigitsSpecification)
                .HasMaxLength(100)
                .HasColumnName("LOTNoFirst6DigitsSpecification");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.OrdererItemCode).HasMaxLength(100);
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputStaffName).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputTime).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNoDetailNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionRemarksComment).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionWeight).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode).HasMaxLength(100);
            entity.Property(e => e.TransferTypeId)
                .HasComment("1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory")
                .HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtInterfaceTransferBk>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_StockTransfers_BK");

            entity.ToTable("tbt_Interface_Transfer_BK");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.CoilVerticalHorizontalAxisCategory).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerDisplaySizeTextKana).HasMaxLength(100);
            entity.Property(e => e.CustomerItemCode).HasMaxLength(100);
            entity.Property(e => e.CustomerItemNameHalfwidth).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasMaxLength(100);
            entity.Property(e => e.DeliveryEndTime).HasMaxLength(100);
            entity.Property(e => e.DeliveryStartTime).HasMaxLength(100);
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ErrorDetail).HasMaxLength(500);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.InfFileName)
                .HasMaxLength(100)
                .HasColumnName("Inf_FileName");
            entity.Property(e => e.InfTransNo)
                .HasMaxLength(50)
                .HasColumnName("Inf_TransNo");
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.InventoryMovementReasonCode).HasMaxLength(100);
            entity.Property(e => e.InventoryTransferInstructionPattern).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionEndTime).HasMaxLength(100);
            entity.Property(e => e.LoadingInstructionStartTime).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.LotnoFirst6DigitsSpecification)
                .HasMaxLength(100)
                .HasColumnName("LOTNoFirst6DigitsSpecification");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.OrdererItemCode).HasMaxLength(100);
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.RedBlackCategory).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputDate).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputStaffName).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionInputTime).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionNoDetailNo).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionRemarksComment).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionWeight).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SurfaceTreatmentAuxiliaryCode).HasMaxLength(100);
            entity.Property(e => e.TransferTypeId).HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtKanbanConfirmation>(entity =>
        {
            entity.HasKey(e => e.KanbanConfirmSeqNo);

            entity.ToTable("tbt_KanbanConfirmation");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtKanbanRegisterDetail>(entity =>
        {
            entity.HasKey(e => new { e.KanbanSeqNo, e.KanbanId });

            entity.ToTable("tbt_KanbanRegisterDetail");

            entity.Property(e => e.KanbanId)
                .HasMaxLength(50)
                .HasColumnName("KanbanID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.InventoryQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InventoryUnitId).HasColumnName("InventoryUnitID");
            entity.Property(e => e.KanbanProductCode).HasMaxLength(50);
            entity.Property(e => e.KanbanQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.KanbanUnit)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.KanbanZone).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtKanbanRegisterHeader>(entity =>
        {
            entity.HasKey(e => e.KanbanSeqNo);

            entity.ToTable("tbt_KanbanRegisterHeader");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtKanbanSuggestLocation>(entity =>
        {
            entity.HasKey(e => new { e.KanbanSeqNo, e.LineNo, e.ProductId }).HasName("PK_tbt_KanbanSuggestConfirmed");

            entity.ToTable("tbt_KanbanSuggestLocation");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.PlanQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtMonthlyPosted>(entity =>
        {
            entity.HasKey(e => new { e.MonthValue, e.YearValue, e.CustomerId, e.Dcid, e.ProductId, e.ProductConditionId }).HasName("PK_tbt_MonthlyPost");

            entity.ToTable("tbt_MonthlyPosted");

            entity.Property(e => e.MonthValue).HasComment("Month Value");
            entity.Property(e => e.YearValue).HasComment("Year Value");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.AdjustQty)
                .HasComment("Adjust Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasDefaultValue("system")
                .HasComment("User who fource process");
            entity.Property(e => e.InventoryQty)
                .HasComment("Inventory Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PickingQty)
                .HasComment("Picking Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivingQty)
                .HasComment("Receiving Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingQty)
                .HasComment("Shipping Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockBalance)
                .HasComment("StockBalance = Inv + Receiving - Shipping")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitQty)
                .HasComment("Storing Quantity")
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtMonthlyUpdateSetting>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("tbt_MonthlyUpdateSetting");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .HasComment("Item");
            entity.Property(e => e.MonthValue).HasComment("Month Value");
            entity.Property(e => e.YearValue).HasComment("Year Value");
        });

        modelBuilder.Entity<TbtMovementTran>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_MovementTrans");

            entity.HasIndex(e => e.RefDocNo, "IX_Movement_DocNo");

            entity.HasIndex(e => e.StickerUid, "IX_Movement_Sticker");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.BalanceQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.FromDcid).HasColumnName("FromDCID");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MovementType).HasMaxLength(30);
            entity.Property(e => e.NetWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NetWeightByLot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.OutQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.QtyByLot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.RefChangeDocNo).HasMaxLength(30);
            entity.Property(e => e.RefDocNo).HasMaxLength(30);
            entity.Property(e => e.ShipFromId).HasColumnName("ShipFromID");
            entity.Property(e => e.ShipToId).HasColumnName("ShipToID");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.ToDcid).HasColumnName("ToDCID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtMovementTransSummaryMonthly>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_MovementTransSummaryMonthly");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.BalanceGrossWeight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.BalanceQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.InGrossWeight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.OpeningNetWeight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.OpeningQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.OutGrossWeight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.OutQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.TypeOfGoodsId)
                .HasComment("ID of Goods Type")
                .HasColumnName("TypeOfGoodsID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YearMonth).HasMaxLength(6);
        });

        modelBuilder.Entity<TbtOmsdeliveryDetail>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceId, e.Dnitem }).HasName("PK_tbt_OMSDeliveryDetail_1");

            entity.ToTable("tbt_OMSDeliveryDetail");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerMatCode).HasMaxLength(100);
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.MaterialBaseUnit).HasMaxLength(10);
            entity.Property(e => e.MaterialCode).HasMaxLength(18);
            entity.Property(e => e.MaterialFreightGroup).HasMaxLength(8);
            entity.Property(e => e.MaterialGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialName).HasMaxLength(1000);
            entity.Property(e => e.MaterialNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolumeUnit).HasMaxLength(10);
            entity.Property(e => e.MaterialWeightUnit).HasMaxLength(10);
            entity.Property(e => e.PalletNo)
                .HasMaxLength(100)
                .HasColumnName("palletNo");
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(26)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.ShippingMark).HasMaxLength(50);
            entity.Property(e => e.Soitem).HasColumnName("SOItem");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(24)
                .HasColumnName("SONumber");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VolumeUnit).HasMaxLength(10);
            entity.Property(e => e.WeightUnit).HasMaxLength(10);
        });

        modelBuilder.Entity<TbtOmsdeliveryHeader>(entity =>
        {
            entity.HasKey(e => e.InterfaceId);

            entity.ToTable("tbt_OMSDeliveryHeader");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(200);
            entity.Property(e => e.CustomerName).HasMaxLength(2000);
            entity.Property(e => e.DeliveryType).HasMaxLength(40);
            entity.Property(e => e.DestinationAmphur).HasMaxLength(100);
            entity.Property(e => e.DestinationCode).HasMaxLength(20);
            entity.Property(e => e.DestinationHouseNo).HasMaxLength(30);
            entity.Property(e => e.DestinationLocationType).HasMaxLength(10);
            entity.Property(e => e.DestinationName).HasMaxLength(200);
            entity.Property(e => e.DestinationPostalCode).HasMaxLength(10);
            entity.Property(e => e.DestinationProvince).HasMaxLength(100);
            entity.Property(e => e.DestinationSoi).HasMaxLength(30);
            entity.Property(e => e.DestinationStreet).HasMaxLength(100);
            entity.Property(e => e.EndCustomerCode).HasMaxLength(200);
            entity.Property(e => e.EndCustomerName).HasMaxLength(2000);
            entity.Property(e => e.HaveShippingMark).HasDefaultValue(false);
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.LicensePlate).HasMaxLength(22);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderPatternId).HasColumnName("OrderPatternID");
            entity.Property(e => e.OriginCode).HasMaxLength(20);
            entity.Property(e => e.OriginLocationType).HasMaxLength(10);
            entity.Property(e => e.OriginName).HasMaxLength(200);
            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.OwnerName).HasMaxLength(100);
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(26)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceLevel).HasMaxLength(10);
            entity.Property(e => e.ServiceLevelDescription).HasMaxLength(100);
            entity.Property(e => e.ShipmentMemo).HasMaxLength(1000);
            entity.Property(e => e.ShiptoAmphur).HasMaxLength(100);
            entity.Property(e => e.ShiptoCode).HasMaxLength(200);
            entity.Property(e => e.ShiptoHouseNo).HasMaxLength(30);
            entity.Property(e => e.ShiptoName).HasMaxLength(2000);
            entity.Property(e => e.ShiptoPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShiptoProvince).HasMaxLength(100);
            entity.Property(e => e.ShiptoSoi).HasMaxLength(30);
            entity.Property(e => e.ShiptoStreet).HasMaxLength(100);
            entity.Property(e => e.Sonumber)
                .HasMaxLength(24)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.StockTypeDesc).HasMaxLength(50);
            entity.Property(e => e.TransportModeDesc).HasMaxLength(10);
            entity.Property(e => e.TransportOrderTypeDescription).HasMaxLength(200);
            entity.Property(e => e.TransportOrderTypeId).HasColumnName("TransportOrderTypeID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseLocCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtOmsdeliveryOrderItemsDetail>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_OMSDeliveryOrderItemsDetails");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.PalletId)
                .HasMaxLength(100)
                .HasColumnName("PalletID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(26)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.ShippingMark).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtOmsmasterDataTmp>(entity =>
        {
            entity.HasKey(e => e.InterfaceId);

            entity.ToTable("tbt_OMSMasterData_tmp");

            entity.Property(e => e.InterfaceId)
                .ValueGeneratedNever()
                .HasColumnName("InterfaceID");
            entity.Property(e => e.AmphurCode).HasMaxLength(200);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.ProvinceCode).HasMaxLength(100);
            entity.Property(e => e.ShipToAddress).HasMaxLength(1000);
            entity.Property(e => e.ShipToCode).HasMaxLength(40);
            entity.Property(e => e.ShipToName).HasMaxLength(500);
        });

        modelBuilder.Entity<TbtOmsmasterDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.InterfaceId });

            entity.ToTable("tbt_OMSMasterData");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.AmphurCode).HasMaxLength(200);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.ProvinceCode).HasMaxLength(100);
            entity.Property(e => e.ShipToAddress).HasMaxLength(1000);
            entity.Property(e => e.ShipToCode).HasMaxLength(40);
            entity.Property(e => e.ShipToName).HasMaxLength(500);
        });

        modelBuilder.Entity<TbtOrderCancelReceiveHistory>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_OrderCancelReceiveHistory");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.LastStatusId).HasColumnName("LastStatusID");
            entity.Property(e => e.MovementSeq).HasComment("Step : Receiving Instruction , Stock Hold");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ReceivingNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtOrderCancelShipHistory>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_OrderCancelShipHistory");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.LastStatusId).HasColumnName("LastStatusID");
            entity.Property(e => e.MovementSeq).HasComment("Step : Receiving Instruction , Stock Hold");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtOrderRefreshReceiveHistory>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_OrderRefreshReceiveHistory");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.LastStatusId).HasColumnName("LastStatusID");
            entity.Property(e => e.MovementSeq).HasComment("Step : Receiving Instruction , Stock Hold");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ReceivingNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtOrderRefreshShipHistory>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_tbt_tbt_OrderRefreshShipHistory");

            entity.ToTable("tbt_OrderRefreshShipHistory");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.LastStatusId).HasColumnName("LastStatusID");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtPacking>(entity =>
        {
            entity.HasKey(e => new { e.PackingNo, e.ShipmentNoGroup, e.ShipmentNo, e.Installment, e.PickingNo });

            entity.ToTable("tbt_Packing");

            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(50);
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.BoxNo).HasDefaultValue(0);
            entity.Property(e => e.ConfirmGiflag)
                .HasDefaultValue(0)
                .HasColumnName("ConfirmGIFlag");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.M3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PackShippingMark).HasMaxLength(100);
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.QcpickBy)
                .HasMaxLength(50)
                .HasColumnName("QCPickBy");
            entity.Property(e => e.QcpickDate)
                .HasColumnType("datetime")
                .HasColumnName("QCPickDate");
            entity.Property(e => e.QcpickQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QCPickQty");
            entity.Property(e => e.Sono)
                .HasMaxLength(50)
                .HasColumnName("SONo");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtPackingD>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PackingNo, e.Skubarcode, e.LotNo }).HasName("PK_tbt_PackingD_1");

            entity.ToTable("tbt_PackingD");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(100)
                .HasColumnName("SKUBarcode");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.Notification).HasMaxLength(255);
            entity.Property(e => e.PackQty)
                .HasComment("Unit of tbt_PickingDetail.AssignQty")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.QtyofSku)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("QtyofSKU");
            entity.Property(e => e.UnitofSku).HasColumnName("UnitofSKU");
        });

        modelBuilder.Entity<TbtPackingDamageVoid>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.DamageVoid });

            entity.ToTable("tbt_PackingDamageVoid");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.DamageVoid).HasMaxLength(22);
            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
        });

        modelBuilder.Entity<TbtPackingSerialMapping>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PackingNo, e.Skubarcode, e.SerialNo, e.LotNo });

            entity.ToTable("tbt_PackingSerialMapping");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(100)
                .HasColumnName("SKUBarcode");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.LotNo).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPackingServiceMapping>(entity =>
        {
            entity.HasKey(e => new { e.EffectiveDate, e.PackageId, e.ServiceTypeId, e.PackingNo });

            entity.ToTable("tbt_PackingServiceMapping");

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.ServiceCharge).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtPackingVoid>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PackingNo, e.Skubarcode, e.LotNo, e.VoidNo }).HasName("PK_tbt_PackingVoid_1");

            entity.ToTable("tbt_PackingVoid");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(100)
                .HasColumnName("SKUBarcode");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.VoidNo).HasMaxLength(22);
            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
        });

        modelBuilder.Entity<TbtPalletMapping>(entity =>
        {
            entity.HasKey(e => e.StickerUid);

            entity.ToTable("tbt_PalletMapping");

            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.RouteId).HasColumnName("RouteID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPalletMappingLog>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_Table_1");

            entity.ToTable("tbt_PalletMappingLog");

            entity.Property(e => e.CreateBy).HasMaxLength(200);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtPalletMovement>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_tbt_PalletMappingHistory");

            entity.ToTable("tbt_PalletMovement");

            entity.Property(e => e.Action).HasMaxLength(1000);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPickingConfirmDestinationPallet>(entity =>
        {
            entity.HasKey(e => new { e.LocationId, e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PalletId, e.PickingLineSeq }).HasName("PK_tbt_SuggestPickingDestinationPallet");

            entity.ToTable("tbt_PickingConfirmDestinationPallet");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 8)");
        });

        modelBuilder.Entity<TbtPickingDetail>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo });

            entity.ToTable("tbt_PickingDetail");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No.");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking No.");
            entity.Property(e => e.LineNo).HasComment("Line No.");
            entity.Property(e => e.AcctCd)
                .HasMaxLength(30)
                .HasColumnName("ACCT_CD");
            entity.Property(e => e.AssignQty)
                .HasComment("Assign Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CostDept)
                .HasMaxLength(30)
                .HasColumnName("COST_DEPT");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerOrder).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DamageQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DatasourceFlag)
                .HasDefaultValue(0)
                .HasComment("Shipping Doc can be entried by (0 = import from file, 1 = entry from Screen)");
            entity.Property(e => e.DetailRemark)
                .HasMaxLength(500)
                .HasComment("Detail Remark");
            entity.Property(e => e.DnlineNo)
                .HasMaxLength(6)
                .HasColumnName("DNLineNo");
            entity.Property(e => e.Dnno)
                .HasMaxLength(50)
                .HasColumnName("DNNo");
            entity.Property(e => e.Flgtoas400).HasColumnName("FLGTOAS400");
            entity.Property(e => e.GoodQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Inpackage)
                .HasComment("Quantity of product in one package")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.KeyImportRef).HasMaxLength(50);
            entity.Property(e => e.LoadAction)
                .HasMaxLength(100)
                .HasComment("Load by which screen");
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
            entity.Property(e => e.LoadUser).HasMaxLength(50);
            entity.Property(e => e.LostQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("Lot No.");
            entity.Property(e => e.M3)
                .HasComment("Volume")
                .HasColumnType("decimal(19, 5)");
            entity.Property(e => e.MaterialCode).HasMaxLength(20);
            entity.Property(e => e.MaterialFreightGroup).HasMaxLength(8);
            entity.Property(e => e.MaterialGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolumeUnit).HasMaxLength(40);
            entity.Property(e => e.MaterialWeightUnit).HasMaxLength(40);
            entity.Property(e => e.OrderQty)
                .HasComment("Order Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.Plant)
                .HasMaxLength(30)
                .HasColumnName("PLANT");
            entity.Property(e => e.Pono)
                .HasMaxLength(100)
                .HasComment("Invoice for each Mode (may differ from shipment invoice)")
                .HasColumnName("PONo");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(40)
                .HasComment("Reference No.");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.ShipQty)
                .HasComment("Shipping Quantity")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ShippingMark).HasMaxLength(50);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.Soitem).HasColumnName("SOItem");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(100)
                .HasColumnName("SONumber");
            entity.Property(e => e.SoslineNo)
                .HasMaxLength(10)
                .HasColumnName("SOSLineNo");
            entity.Property(e => e.Sosno)
                .HasMaxLength(50)
                .HasColumnName("SOSNo");
            entity.Property(e => e.ToleranceGireason)
                .HasMaxLength(1000)
                .HasColumnName("ToleranceGIReason");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeOfPackageId).HasColumnName("TypeOfPackageID");
            entity.Property(e => e.UnitOfInpackage).HasComment("Unit of Inpackage");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.Weight)
                .HasComment("Weight")
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtPickingDetailConfirmed>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PickingLineSeq, e.LocationId });

            entity.ToTable("tbt_PickingDetailConfirmed");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No.");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking No.");
            entity.Property(e => e.LineNo).HasComment("Line No.");
            entity.Property(e => e.PickingLineSeq).HasComment("Picking Line Sequence");
            entity.Property(e => e.LocationId)
                .HasComment("ID of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.ConfirmFlag).HasComment("0 : not confirm , 1 : confirmed");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .HasComment("Last Updated By");
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Last Update Date/Time")
                .HasColumnType("datetime");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.PickingQty)
                .HasComment("Picking Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QcpickBy)
                .HasMaxLength(50)
                .HasColumnName("QCPickBy");
            entity.Property(e => e.QcpickDate)
                .HasColumnType("datetime")
                .HasColumnName("QCPickDate");
            entity.Property(e => e.QcpickQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QCPickQty");
            entity.Property(e => e.RemainPack).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RemainPackofInventoryUnit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.ShipQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.StockActualQty)
                .HasComment("Stock Actual Quantity")
                .HasColumnType("numeric(18, 3)");

            entity.HasOne(d => d.TbtPickingDetail).WithMany(p => p.TbtPickingDetailConfirmeds)
                .HasForeignKey(d => new { d.ShipmentNo, d.Installment, d.PickingNo, d.LineNo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_PickingDetailConfirmed_tbt_PickingDetail");
        });

        modelBuilder.Entity<TbtPickingDetailSerialD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_PickingDetailSerialD");

            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.PickingSerialId).HasColumnName("PickingSerialID");
            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPickingDetailSerialH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_PickingDetailSerialH");

            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PickingSerialId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PickingSerialID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.WarrantyCode)
                .HasMaxLength(30)
                .HasColumnName("Warranty_code");
        });

        modelBuilder.Entity<TbtPickingDetailVoidD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_PickingDetailVoidD");

            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.PickingVoidId).HasColumnName("PickingVoidID");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.VoidNo).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPickingDetailVoidH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_PickingDetailVoidH");

            entity.Property(e => e.ControlVoidId).HasColumnName("ControlVoidID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PickingVoidId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PickingVoidID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
        });

        modelBuilder.Entity<TbtPickingHeader>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo });

            entity.ToTable("tbt_PickingHeader");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No.");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking No.");
            entity.Property(e => e.AgentSeal).HasMaxLength(50);
            entity.Property(e => e.CancelPickingFlag)
                .HasDefaultValue(false)
                .HasComment("Canceled all line = 1 , if not = 0");
            entity.Property(e => e.CompleteInfoFlag)
                .HasDefaultValue(false)
                .HasComment("0=Incomplete --> Missing (Truck Company, Transport Type, Transport Charge, Outgoing Charge, Registration No., Container No., Agent's Seal, Inspection Seal)");
            entity.Property(e => e.ControlPackId).HasColumnName("ControlPackID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Picking List is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DoissuedDate)
                .HasComment("PCI Driver Issued Date (dd/mm/yyyy HH:MM )")
                .HasColumnType("datetime")
                .HasColumnName("DOIssuedDate");
            entity.Property(e => e.GenerateDiffDate).HasColumnType("datetime");
            entity.Property(e => e.InspectionSeal).HasMaxLength(50);
            entity.Property(e => e.NumberofDetails).HasComment("Number of Details");
            entity.Property(e => e.PickingCompleteDate)
                .HasComment("Picking Complete Date")
                .HasColumnType("datetime");
            entity.Property(e => e.PickingDate).HasColumnType("datetime");
            entity.Property(e => e.PickingIssuedDate)
                .HasComment("PCI Warehouse Issued Date (dd/mm/yyyy HH:MM)")
                .HasColumnType("datetime");
            entity.Property(e => e.ShippingAreaId).HasColumnName("ShippingAreaID");
            entity.Property(e => e.ShippingResultGenerated).HasDefaultValue(0);
            entity.Property(e => e.Sonumber)
                .HasMaxLength(100)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.StockOutControlFlag).HasComment("0: Normal Stock Picking (Yellow Line) ;1: Shortage Stock Picking (Orange Line)");
            entity.Property(e => e.TransportationDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate)
                .HasComment("User who create the Shipping Advice")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.VanningDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtPickingServiceMapping>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.ServiceOptionTypeId });

            entity.ToTable("tbt_PickingServiceMapping");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.ServiceOptionTypeId).HasColumnName("ServiceOptionTypeID");
        });

        modelBuilder.Entity<TbtPoinformation>(entity =>
        {
            entity.HasKey(e => e.Po);

            entity.ToTable("tbt_POInformation");

            entity.Property(e => e.Po)
                .HasMaxLength(50)
                .HasColumnName("PO");
            entity.Property(e => e.Countryoforigin)
                .HasMaxLength(3)
                .HasColumnName("COUNTRYOFORIGIN");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Purchasinggroup)
                .HasMaxLength(3)
                .HasColumnName("PURCHASINGGROUP");
            entity.Property(e => e.Seller)
                .HasMaxLength(10)
                .HasColumnName("SELLER");
            entity.Property(e => e.Shipfromcity)
                .HasMaxLength(28)
                .HasColumnName("SHIPFROMCITY");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtPoinformationDetail>(entity =>
        {
            entity.HasKey(e => new { e.Po, e.Polineno });

            entity.ToTable("tbt_POInformation_Detail");

            entity.Property(e => e.Po)
                .HasMaxLength(50)
                .HasColumnName("PO");
            entity.Property(e => e.Polineno)
                .HasMaxLength(10)
                .HasColumnName("POLINENO");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Customersku)
                .HasMaxLength(20)
                .HasColumnName("CUSTOMERSKU");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Manufacturersku)
                .HasMaxLength(20)
                .HasColumnName("MANUFACTURERSKU");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Potype)
                .HasMaxLength(1)
                .HasColumnName("POTYPE");
            entity.Property(e => e.Qty)
                .HasMaxLength(10)
                .HasColumnName("QTY");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .HasColumnName("SKU");
            entity.Property(e => e.Storagelocation)
                .HasMaxLength(4)
                .HasColumnName("STORAGELOCATION");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtProductTag>(entity =>
        {
            entity.HasKey(e => new { e.PalletNo, e.ProductId }).HasName("PK_tbm_ProductTag");

            entity.ToTable("tbt_ProductTag");

            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletReference).HasMaxLength(100);
            entity.Property(e => e.PolineNo)
                .HasMaxLength(5)
                .HasColumnName("POLineNo");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingNotificationNo).HasMaxLength(10);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtReceivingConfirmed>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ReceiveSeq });

            entity.ToTable("tbt_ReceivingConfirmed");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.ActuallyReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_ReceivedDate");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

            entity.HasOne(d => d.TbtReceivingInstructionDetail).WithMany(p => p.TbtReceivingConfirmeds)
                .HasForeignKey(d => new { d.ReceivingNo, d.Installment, d.LineNo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_ReceivingConfirmed_tbt_ReceivingInstructionDetail");
        });

        modelBuilder.Entity<TbtReceivingConfirmedByHandy>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ReceivedSeq }).HasName("PK_tbt_ReeceivingConfirmedByHandy");

            entity.ToTable("tbt_ReceivingConfirmedByHandy");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.ActuallyCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_CreateDate");
            entity.Property(e => e.CompleteConfirmedFlag).HasDefaultValue(0);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedQty).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(4)
                .HasComment("4 : RC Instruction, 5 : Incomplete, 6 : Complete (Refer from tbs_Status)")
                .HasColumnName("StatusID");
        });

        modelBuilder.Entity<TbtReceivingConfirmedTemp>(entity =>
        {
            entity.HasKey(e => e.SeqNo).HasName("PK_tbt_ReceivingConfirmedTemp_1");

            entity.ToTable("tbt_ReceivingConfirmedTemp");

            entity.Property(e => e.ActuallyCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_CreateDate");
            entity.Property(e => e.As400qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AS400Qty");
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledFlag).HasDefaultValue((byte)0);
            entity.Property(e => e.CancelledUser).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletBagNo).HasMaxLength(100);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivingNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtReceivingHistory>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo }).HasName("PK_tbt_ReceivingHistory_1");

            entity.ToTable("tbt_ReceivingHistory");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("No. of Slip");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No");
            entity.Property(e => e.LineNo).HasComment("Line No");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when create the Receiving History")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ReceiveQty)
                .HasComment("Receiving Quantity")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ReceivingDate)
                .HasComment("Receiving Date")
                .HasColumnType("datetime");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        });

        modelBuilder.Entity<TbtReceivingInstructionCoa>(entity =>
        {
            entity.HasKey(e => e.CoaId);

            entity.ToTable("tbt_ReceivingInstructionCOA");

            entity.Property(e => e.CoaId).HasColumnName("COA_ID");
            entity.Property(e => e.CoaFileName)
                .HasMaxLength(200)
                .HasColumnName("COA_FileName");
            entity.Property(e => e.ImageFile).HasColumnType("image");
            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("No of Slip");
        });

        modelBuilder.Entity<TbtReceivingInstructionDetail>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo }).HasName("PK_tbt_ReceivingInstructionDetail_1");

            entity.ToTable("tbt_ReceivingInstructionDetail");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("No. of Slip");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No.");
            entity.Property(e => e.LineNo).HasComment("Line No.");
            entity.Property(e => e.ActualLotNo).HasMaxLength(50);
            entity.Property(e => e.ActualProductConditionId).HasColumnName("ActualProductConditionID");
            entity.Property(e => e.ActuallyUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_UpdateDate");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CurrencyCode).HasMaxLength(10);
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DataSourceFlag).HasComment("(0 = From Interface A , 1 = From Screen )");
            entity.Property(e => e.DetailRemark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FlgtoAc)
                .HasMaxLength(10)
                .HasColumnName("FLGToAC");
            entity.Property(e => e.FlgtoAs400).HasColumnName("FLGToAS400");
            entity.Property(e => e.InPackage)
                .HasComment("No. of pieces in one package (Ex. 4 pieces per box)")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InPackageUnitId)
                .HasComment("Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)")
                .HasColumnName("InPackageUnitID");
            entity.Property(e => e.InstructionQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.KeyImportRef).HasMaxLength(50);
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("No of Lot");
            entity.Property(e => e.Mfgdate).HasColumnName("MFGDate");
            entity.Property(e => e.NetWeight)
                .HasComment("Weight of Model ")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PalletNoRef).HasMaxLength(20);
            entity.Property(e => e.Plant).HasMaxLength(50);
            entity.Property(e => e.PolineNo)
                .HasMaxLength(10)
                .HasColumnName("POLineNo");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ProductConditionId)
                .HasComment("ID of Product Condition")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.Qty)
                .HasComment("Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QtyUnitId)
                .HasComment("Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)")
                .HasColumnName("QtyUnitID");
            entity.Property(e => e.ReceiveQty)
                .HasComment("Confirm receive C-5")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(15)
                .HasComment("Reference No.");
            entity.Property(e => e.ShippingNotificationNo).HasMaxLength(10);
            entity.Property(e => e.ShippingNotificationNoLine).HasMaxLength(6);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.SoslineNo)
                .HasMaxLength(10)
                .HasColumnName("SOSLineNo");
            entity.Property(e => e.Sosno)
                .HasMaxLength(50)
                .HasColumnName("SOSNo");
            entity.Property(e => e.ToleranceGrreason)
                .HasMaxLength(1000)
                .HasColumnName("ToleranceGRReason");
            entity.Property(e => e.TypeOfPackageId)
                .HasComment("PackageType; Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)")
                .HasColumnName("TypeOfPackageID");
            entity.Property(e => e.UnitVolume)
                .HasComment("Volume (M3) per PCS")
                .HasColumnType("numeric(19, 5)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtReceivingInstructionDetailItemRefer>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ShippingMark });

            entity.ToTable("tbt_ReceivingInstructionDetailItem_Refer");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.ShippingMark).HasMaxLength(50);
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.PalletNo).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<TbtReceivingInstructionDetailRefer>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo }).HasName("PK_ttbt_ReceivingInstructionDetail_Refer_1");

            entity.ToTable("tbt_ReceivingInstructionDetail_Refer");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.CustomerMatCode).HasMaxLength(100);
            entity.Property(e => e.Dnitem).HasColumnName("DNItem");
            entity.Property(e => e.MaterialBaseUnit).HasMaxLength(10);
            entity.Property(e => e.MaterialCode).HasMaxLength(18);
            entity.Property(e => e.MaterialFreightGroup).HasMaxLength(8);
            entity.Property(e => e.MaterialGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MaterialVolumeUnit).HasMaxLength(10);
            entity.Property(e => e.MaterialWeightUnit).HasMaxLength(10);
            entity.Property(e => e.PalletNo).HasMaxLength(100);
            entity.Property(e => e.ShippingMark).HasMaxLength(50);
            entity.Property(e => e.Soitem).HasColumnName("SOItem");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalNetWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.VolumeUnit).HasMaxLength(10);
            entity.Property(e => e.WeightUnit).HasMaxLength(10);
        });

        modelBuilder.Entity<TbtReceivingInstructionHeader>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment }).HasName("PK_tbt_ReceivingInstructionHeader_1");

            entity.ToTable("tbt_ReceivingInstructionHeader");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("No of Slip");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No.");
            entity.Property(e => e.ActuallyUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_UpdateDate");
            entity.Property(e => e.ArrivalDate)
                .HasComment("Arrival Date")
                .HasColumnType("datetime");
            entity.Property(e => e.CancelSlipFlag)
                .HasDefaultValue(false)
                .HasComment("Canceled all line = 1 , if not = 0");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and Time when create the Receiving Instruction Header")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("ID of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DocRefCreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocRefExpireDate).HasColumnType("datetime");
            entity.Property(e => e.DocRefNo).HasMaxLength(50);
            entity.Property(e => e.DocTypeCode).HasMaxLength(10);
            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.FinalDestinationId).HasColumnName("FinalDestinationID");
            entity.Property(e => e.GenXpgenerated)
                .HasDefaultValue(0)
                .HasColumnName("GenXPGenerated");
            entity.Property(e => e.GenerateDiffDate).HasColumnType("datetime");
            entity.Property(e => e.HaveShippingMark).HasComment("0=GR from OMS, 1=Not GR from OMS (Auto book when receive QTY >= Ship QTY)");
            entity.Property(e => e.ImportGroupNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LicensePlate).HasMaxLength(22);
            entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_No");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.ReceivingResultGenerated).HasDefaultValue(0);
            entity.Property(e => e.RefServiceId).HasColumnName("RefServiceID");
            entity.Property(e => e.RefShiptoAddress).HasMaxLength(500);
            entity.Property(e => e.RefShiptoCode).HasMaxLength(20);
            entity.Property(e => e.RefShiptoId).HasColumnName("RefShiptoID");
            entity.Property(e => e.RefShiptoLongName).HasMaxLength(250);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("Remark");
            entity.Property(e => e.RouteId).HasColumnName("RouteID");
            entity.Property(e => e.ShipmentNoGroupRev)
                .HasMaxLength(50)
                .HasColumnName("ShipmentNoGroup_Rev");
            entity.Property(e => e.SlipCompleteDate)
                .HasComment("Date when complete Slip")
                .HasColumnType("datetime");
            entity.Property(e => e.SlipNo).HasMaxLength(50);
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.SupplierId)
                .HasComment("ID of Supplier")
                .HasColumnName("SupplierID");
            entity.Property(e => e.TransferType).HasComment("1: Import\r\n2: Domestic\r\n3: Transfer Stock");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtReceivingInstructionHeaderRefer>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment }).HasName("PK_tbt_ReceivingInstructionHeader_Refer_1");

            entity.ToTable("tbt_ReceivingInstructionHeader_Refer");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.CustomerCode).HasMaxLength(10);
            entity.Property(e => e.DeliveryType).HasMaxLength(40);
            entity.Property(e => e.DestinationLocationTypeId).HasColumnName("DestinationLocationTypeID");
            entity.Property(e => e.EndCustomerCode).HasMaxLength(100);
            entity.Property(e => e.EndCustomerName).HasMaxLength(1000);
            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.OrderPatternId).HasColumnName("OrderPatternID");
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(60)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOptionTypeId)
                .HasMaxLength(500)
                .HasColumnName("ServiceOptionTypeID");
            entity.Property(e => e.ShipmentMemo).HasMaxLength(1000);
            entity.Property(e => e.ShiptoId).HasColumnName("ShiptoID");
            entity.Property(e => e.Sonumber)
                .HasMaxLength(12)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.TransportOrderTypeId).HasColumnName("TransportOrderTypeID");
        });

        modelBuilder.Entity<TbtReceivingOtherCharge>(entity =>
        {
            entity.HasKey(e => e.OtherChargeId).HasName("PK_tbt_OtherCharge");

            entity.ToTable("tbt_ReceivingOtherCharge");

            entity.Property(e => e.OtherChargeId).HasColumnName("OtherChargeID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(20);
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No.");
            entity.Property(e => e.OtherCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("Document number (receiving no. or shipping no.)");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(20);

            entity.HasOne(d => d.TbtReceivingInstructionHeader).WithMany(p => p.TbtReceivingOtherCharges)
                .HasForeignKey(d => new { d.ReceivingNo, d.Installment })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_ReceivingOtherCharge_tbt_ReceivingInstructionHeader");
        });

        modelBuilder.Entity<TbtReceivingPhotoDetail>(entity =>
        {
            entity.HasKey(e => new { e.PhotoHeaderId, e.PhotoSeq }).HasName("PK__tbt_Rece__FD6CEE45547C20E9");

            entity.ToTable("tbt_ReceivingPhotoDetail");

            entity.Property(e => e.PhotoHeaderId).HasColumnName("PhotoHeaderID");
            entity.Property(e => e.PhotoFullPath).HasMaxLength(500);
        });

        modelBuilder.Entity<TbtReceivingPhotoHeader>(entity =>
        {
            entity.HasKey(e => e.PhotoHeaderId).HasName("PK__tbt_Rece__4A936BFD3A26C06C");

            entity.ToTable("tbt_ReceivingPhotoHeader");

            entity.HasIndex(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ActuallyReceivedDate }, "UQ__tbt_Rece__B66AAB0DA5E140EF").IsUnique();

            entity.Property(e => e.PhotoHeaderId)
                .ValueGeneratedNever()
                .HasColumnName("PhotoHeaderID");
            entity.Property(e => e.ActuallyReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_ReceivedDate");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(200);
            entity.Property(e => e.Opinion).HasMaxLength(500);
            entity.Property(e => e.PhotoDescription).HasMaxLength(500);
            entity.Property(e => e.ReceivingNo).HasMaxLength(44);
        });

        modelBuilder.Entity<TbtReceivingStatus>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo }).HasName("PK_tbt_ReceivingStatus_1");

            entity.ToTable("tbt_ReceivingStatus");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("No of Slip");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No");
            entity.Property(e => e.LineNo).HasComment("Line No");
            entity.Property(e => e.ActuallyReceivingDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_ReceivingDate");
            entity.Property(e => e.ActuallyTransitDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_TransitDate");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.InterfaceReceivedDate)
                .HasComment(" Screen [A-1]")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceivingDate)
                .HasComment("Screen [C-4]")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceivingEntryDate)
                .HasComment("Screen [B-1]")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(2)
                .HasComment("ID of Status")
                .HasColumnName("StatusID");
            entity.Property(e => e.TransitDate)
                .HasComment("Screen [D-1]")
                .HasColumnType("datetime");
            entity.Property(e => e.TransitInstructionIssuedDate)
                .HasComment("Screen [C-2]")
                .HasColumnType("datetime");

            entity.HasOne(d => d.TbtReceivingInstructionDetail).WithOne(p => p.TbtReceivingStatus)
                .HasForeignKey<TbtReceivingStatus>(d => new { d.ReceivingNo, d.Installment, d.LineNo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_ReceivingStatus_tbt_ReceivingInstructionDetail");
        });

        modelBuilder.Entity<TbtReceivingTransportation>(entity =>
        {
            entity.HasKey(e => e.ReceivingTransportId);

            entity.ToTable("tbt_ReceivingTransportation");

            entity.Property(e => e.ReceivingTransportId).HasColumnName("ReceivingTransportID");
            entity.Property(e => e.ActualIn).HasColumnType("datetime");
            entity.Property(e => e.ActualOut).HasColumnType("datetime");
            entity.Property(e => e.ContainerNo).HasMaxLength(30);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(20);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DriverName).HasMaxLength(30);
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No.");
            entity.Property(e => e.PlanIn).HasColumnType("datetime");
            entity.Property(e => e.PlanOut).HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.RegistrationNo).HasMaxLength(30);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.TotalReceiveWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TransportCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.UnstaffingCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(20);

            entity.HasOne(d => d.TbtReceivingInstructionHeader).WithMany(p => p.TbtReceivingTransportations)
                .HasForeignKey(d => new { d.ReceivingNo, d.Installment })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_ReceivingTransportation_tbt_ReceivingInstructionHeader");
        });

        modelBuilder.Entity<TbtReportChangeLocation>(entity =>
        {
            entity.HasKey(e => e.RunningNo).HasName("PK_tbt_ChangeLocationReport");

            entity.ToTable("tbt_ReportChangeLocation");

            entity.Property(e => e.RunningNo).HasComment("");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(100)
                .HasComment("Client Code");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .HasComment("Client Name");
            entity.Property(e => e.CreateDate)
                .HasComment("Date when create the Report Change Location")
                .HasColumnType("datetime");
            entity.Property(e => e.FAfterInventory)
                .HasComment("Quantity after Change Location(From)")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("F_AfterInventory");
            entity.Property(e => e.FLocationCode)
                .HasMaxLength(100)
                .HasComment("Location Code(From)")
                .HasColumnName("F_LocationCode");
            entity.Property(e => e.FLocationName)
                .HasMaxLength(100)
                .HasComment("Location Name(From)")
                .HasColumnName("F_LocationName");
            entity.Property(e => e.FProductCondition)
                .HasMaxLength(100)
                .HasComment("Product Condition(From)")
                .HasColumnName("F_ProductCondition");
            entity.Property(e => e.FQty)
                .HasComment("Quantity(From)")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("F_Qty");
            entity.Property(e => e.FWarehouseCode)
                .HasMaxLength(100)
                .HasComment("Warehouse Code(From)")
                .HasColumnName("F_WarehouseCode");
            entity.Property(e => e.FWarehouseName)
                .HasMaxLength(100)
                .HasComment("Warehouse Name(From)")
                .HasColumnName("F_WarehouseName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasComment("Model Name");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(100)
                .HasComment("Model Code");
            entity.Property(e => e.TAfterInventory)
                .HasComment("Quantity after Change Location(To)")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("T_AfterInventory");
            entity.Property(e => e.TLocationCode)
                .HasMaxLength(100)
                .HasComment("Location Code(To)")
                .HasColumnName("T_LocationCode");
            entity.Property(e => e.TLocationName)
                .HasMaxLength(100)
                .HasComment("Location Name(To)")
                .HasColumnName("T_LocationName");
            entity.Property(e => e.TProductCondition)
                .HasMaxLength(100)
                .HasComment("Product Condition(To)")
                .HasColumnName("T_ProductCondition");
            entity.Property(e => e.TQty)
                .HasComment("Quantity(To)")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("T_Qty");
            entity.Property(e => e.TWarehouseCode)
                .HasMaxLength(100)
                .HasComment("Warehouse Code(To)")
                .HasColumnName("T_WarehouseCode");
            entity.Property(e => e.TWarehouseName)
                .HasMaxLength(100)
                .HasComment("Warehouse Name(To)")
                .HasColumnName("T_WarehouseName");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(100)
                .HasComment("Unique ID")
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<TbtReportConfirmReceiving>(entity =>
        {
            entity.HasKey(e => e.RunningId);

            entity.ToTable("tbt_ReportConfirmReceiving");

            entity.Property(e => e.RunningId).HasColumnName("RunningID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when create the Report Confirm Receiving")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Installment).HasComment("Installment No");
            entity.Property(e => e.LineNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Line No");
            entity.Property(e => e.SlipNo)
                .HasMaxLength(15)
                .HasComment("No of Slip");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(100)
                .HasComment("Unique ID")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when update the Report Confirm Receiving")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtReportCorrectionOfInventory>(entity =>
        {
            entity.HasKey(e => e.RunningNo).HasName("PK_tbt_CorrectionOfInventory");

            entity.ToTable("tbt_ReportCorrectionOfInventory");

            entity.Property(e => e.RunningNo).HasComment("Running No.");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(10)
                .HasComment("Client Code");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .HasComment("Client Name");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date/Time when Insert this Record")
                .HasColumnType("datetime");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasComment("Location Code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .HasComment("Location Name");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasComment("Model Name");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .HasComment("Model Code");
            entity.Property(e => e.ProductConditionCode)
                .HasMaxLength(10)
                .HasComment("Product Condition Code");
            entity.Property(e => e.ProductConditionName)
                .HasMaxLength(100)
                .HasComment("Product Condition Name");
            entity.Property(e => e.QtyAdjustment)
                .HasComment("+/- value of adjustment")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QtyBeforeAdjustment)
                .HasComment("Quantity Before Adjustment")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReasonOfChange)
                .HasMaxLength(500)
                .HasComment("Reason of Change");
            entity.Property(e => e.SlipDivisionCode)
                .HasMaxLength(10)
                .HasComment("Slip Division Code");
            entity.Property(e => e.SlipDivisionName)
                .HasMaxLength(100)
                .HasComment("Slip Division Name");
            entity.Property(e => e.SlipNo)
                .HasMaxLength(20)
                .HasComment("Slip No.");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(100)
                .HasComment("Unique ID")
                .HasColumnName("UniqueID");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(10)
                .HasComment("Warehouse Code");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(100)
                .HasComment("Warehouse Name");
        });

        modelBuilder.Entity<TbtReportProofListforReceiving>(entity =>
        {
            entity.HasKey(e => e.RunningId);

            entity.ToTable("tbt_ReportProofListforReceiving");

            entity.Property(e => e.RunningId)
                .HasComment("ID")
                .HasColumnName("RunningID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date/Time when Insert this record")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.ProofPrintingFlag)
                .HasDefaultValue(1)
                .HasComment("0 = Not printed yet , 1 = Printed yet or exit the screen already");
            entity.Property(e => e.SlipNo)
                .HasMaxLength(15)
                .HasComment("Slip No.");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(100)
                .HasComment("Unique ID")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/Time when Update this record")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtReportProofListforShipping>(entity =>
        {
            entity.HasKey(e => e.RunningId);

            entity.ToTable("tbt_ReportProofListforShipping");

            entity.Property(e => e.RunningId)
                .HasComment("ID")
                .HasColumnName("RunningID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date/Time when Insert this record")
                .HasColumnType("datetime");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(20)
                .HasComment("Picking No.");
            entity.Property(e => e.ProofPrintingFlag).HasComment("0 = Not printed yet , 1 = Printed yet or exit the screen already");
            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(15)
                .HasComment("Shipment No.");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(100)
                .HasComment("Unique ID")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date/Time when Update this record")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtReturnPickingConfirmed>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.ReturnSeq });

            entity.ToTable("tbt_ReturnPickingConfirmed");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.ReturnSeq).ValueGeneratedOnAdd();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtReturnPickingDetail>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.ReturnSeq }).HasName("PK_tbt_ReturnPickingDetail_1");

            entity.ToTable("tbt_ReturnPickingDetail");

            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.ReturnSeq).ValueGeneratedOnAdd();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.OrderQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PackingNo).HasMaxLength(22);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtRouteCountingDetail>(entity =>
        {
            entity.HasKey(e => new { e.RcountNo, e.StickerUid, e.Status });

            entity.ToTable("tbt_RouteCountingDetail");

            entity.Property(e => e.RcountNo)
                .HasMaxLength(30)
                .HasColumnName("RCountNo");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtRouteCountingHeader>(entity =>
        {
            entity.HasKey(e => new { e.Dcid, e.RcountNo, e.RouteId, e.LocationId });

            entity.ToTable("tbt_RouteCountingHeader");

            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.RcountNo)
                .HasMaxLength(30)
                .HasColumnName("RCountNo");
            entity.Property(e => e.RouteId).HasColumnName("RouteID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(1);
        });

        modelBuilder.Entity<TbtShipNoteInformation>(entity =>
        {
            entity.HasKey(e => new { e.Po, e.Polineno, e.Plant, e.Shipnotenumber, e.Shipnotelinenumber });

            entity.ToTable("tbt_ShipNoteInformation");

            entity.Property(e => e.Po)
                .HasMaxLength(50)
                .HasColumnName("PO");
            entity.Property(e => e.Polineno)
                .HasMaxLength(10)
                .HasColumnName("POLINENO");
            entity.Property(e => e.Plant)
                .HasMaxLength(4)
                .HasColumnName("PLANT");
            entity.Property(e => e.Shipnotenumber)
                .HasMaxLength(10)
                .HasColumnName("SHIPNOTENUMBER");
            entity.Property(e => e.Shipnotelinenumber)
                .HasMaxLength(6)
                .HasColumnName("SHIPNOTELINENUMBER");
            entity.Property(e => e.Bol)
                .HasMaxLength(35)
                .HasColumnName("BOL");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Deliveryqty)
                .HasMaxLength(10)
                .HasColumnName("DELIVERYQTY");
            entity.Property(e => e.Externalid)
                .HasMaxLength(35)
                .HasColumnName("EXTERNALID");
            entity.Property(e => e.Meansoftransportid)
                .HasMaxLength(20)
                .HasColumnName("MEANSOFTRANSPORTID");
            entity.Property(e => e.Purchasinggroup)
                .HasMaxLength(3)
                .HasColumnName("PURCHASINGGROUP");
            entity.Property(e => e.Sku)
                .HasMaxLength(18)
                .HasColumnName("SKU");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtShippingAndDeliveryReport>(entity =>
        {
            entity.HasKey(e => e.SeqNo);

            entity.ToTable("tbt_ShippingAndDeliveryReport");

            entity.Property(e => e.BalanceQty).HasColumnType("decimal(25, 6)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReceivingDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo).HasMaxLength(50);
            entity.Property(e => e.ReceivingQty)
                .HasDefaultValue(0.000m)
                .HasColumnType("decimal(25, 6)");
            entity.Property(e => e.ShipQty).HasColumnType("decimal(25, 6)");
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtShippingDeliveryPlanDetail>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_Shipping_DeliveryPlanDetail");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.BookingNo).HasMaxLength(50);
            entity.Property(e => e.CargoDetail).HasMaxLength(500);
            entity.Property(e => e.CustTime).HasMaxLength(50);
            entity.Property(e => e.Cydate)
                .HasColumnType("datetime")
                .HasColumnName("CYDATE");
            entity.Property(e => e.DeliveryDatetime).HasColumnType("datetime");
            entity.Property(e => e.EquipmentDetail).HasMaxLength(500);
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.Gwnet)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("GWNet");
            entity.Property(e => e.JobType).HasMaxLength(50);
            entity.Property(e => e.LoadingDatetime).HasColumnType("datetime");
            entity.Property(e => e.NetWeight).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.Picname)
                .HasMaxLength(50)
                .HasColumnName("PICName");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rntdate)
                .HasColumnType("datetime")
                .HasColumnName("RNTDATE");
            entity.Property(e => e.ShipmentPlanGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.TruckBookingGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TruckBookingGroupID");
            entity.Property(e => e.TruckCompanyId)
                .HasComment("ID of Truck Company")
                .HasColumnName("TruckCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtShippingDeliveryPlanHeader>(entity =>
        {
            entity.HasKey(e => e.ShipmentPlanGroupId);

            entity.ToTable("tbt_Shipping_DeliveryPlanHeader");

            entity.Property(e => e.ShipmentPlanGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(50);
            entity.Property(e => e.DeliverytoId).HasColumnName("DeliverytoID");
            entity.Property(e => e.Eta).HasColumnName("ETA");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.ShipFromId).HasColumnName("ShipFromID");
            entity.Property(e => e.ShiptoId).HasColumnName("ShiptoID");
        });

        modelBuilder.Entity<TbtShippingDeliveryPlanLot>(entity =>
        {
            entity.HasKey(e => e.PlanLotId).HasName("PK__tbt_Ship__29084565C7DB4A46");

            entity.ToTable("tbt_Shipping_DeliveryPlanLot");

            entity.Property(e => e.PlanLotId).HasColumnName("PlanLotID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.NetWeightByLot).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.ShipmentPlanGroupId).HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.TruckBookingGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TruckBookingGroupID");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtShippingDeliveryPlanPicNotuse>(entity =>
        {
            entity.HasKey(e => new { e.RecordId, e.ShipmentPlanGroupId, e.TruckBookingGroupId }).HasName("PK_tbt_Shipping_DeliveryPlan_PIC");

            entity.ToTable("tbt_Shipping_DeliveryPlan_PIC_notuse");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ShipmentPlanGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.TruckBookingGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TruckBookingGroupID");
            entity.Property(e => e.BookingNo).HasMaxLength(50);
            entity.Property(e => e.CargoDetail).HasMaxLength(1000);
            entity.Property(e => e.CustTime).HasMaxLength(50);
            entity.Property(e => e.Cydate).HasColumnName("CYDATE");
            entity.Property(e => e.DeliveryDatetime).HasColumnType("datetime");
            entity.Property(e => e.EquipmentDetail).HasMaxLength(1000);
            entity.Property(e => e.LoadingDatetime).HasColumnType("datetime");
            entity.Property(e => e.Picname)
                .HasMaxLength(50)
                .HasColumnName("PICName");
            entity.Property(e => e.Rntdate).HasColumnName("RNTDATE");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.UpDateBy).HasMaxLength(50);
            entity.Property(e => e.UpDateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtShippingDeliverySchedule>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_Shipping_DeliverySchedule");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverytoId).HasColumnName("DeliverytoID");
            entity.Property(e => e.Eta)
                .HasComment("Date and Time of arrival ")
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasComment("Date and Time of departure")
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FromDcid).HasColumnName("FromDCID");
            entity.Property(e => e.LoadingPlace).HasMaxLength(50);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.OrderMass).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.ProductAlloy).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductTemper).HasMaxLength(50);
            entity.Property(e => e.ProductThickness).HasMaxLength(50);
            entity.Property(e => e.ProductWidth).HasMaxLength(50);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.ShippingCustomerName).HasMaxLength(100);
            entity.Property(e => e.ShiptoId).HasColumnName("ShiptoID");
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.SubTypeOfGoodsName).HasMaxLength(100);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtShippingHistory>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.PickingNo, e.Installment, e.LineNo });

            entity.ToTable("tbt_ShippingHistory");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment Number");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking Number");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No of shipment No.");
            entity.Property(e => e.LineNo).HasComment("Line sequence No.");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Shipping History is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("Id of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id of Distribution Center")
                .HasColumnName("DCID");
            entity.Property(e => e.FinalDestinationId)
                .HasComment("Id of Final Destination")
                .HasColumnName("FinalDestinationID");
            entity.Property(e => e.PortOfDischargeId)
                .HasComment("Id of Port of Discharge")
                .HasColumnName("PortOfDischargeID");
            entity.Property(e => e.ProductId)
                .HasComment("Id of Product")
                .HasColumnName("ProductID");
            entity.Property(e => e.Quantity)
                .HasComment("Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ShippingDate)
                .HasComment("Shipping Date")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtShippingInstruction>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment });

            entity.ToTable("tbt_ShippingInstruction");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No");
            entity.Property(e => e.Installment).HasComment("Installment No of shipment No.");
            entity.Property(e => e.AgentOwner)
                .HasMaxLength(100)
                .HasComment("Agent Owner");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(20)
                .HasComment("Booking No");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("Client ID")
                .HasColumnName("CustomerID");
            entity.Property(e => e.CutDate)
                .HasComment("Cut Date/Time")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliveryType).HasMaxLength(40);
            entity.Property(e => e.DestinationLocationTypeId).HasColumnName("DestinationLocationTypeID");
            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.Eta)
                .HasComment("Date and Time of arrival ")
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasComment("Date and Time of departure")
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.ExportResultDate).HasColumnType("datetime");
            entity.Property(e => e.FinalDestinationId)
                .HasComment("Id of Final Destination")
                .HasColumnName("FinalDestinationID");
            entity.Property(e => e.GiconfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("GIConfirmDate");
            entity.Property(e => e.GiconfirmUser)
                .HasMaxLength(50)
                .HasColumnName("GIConfirmUser");
            entity.Property(e => e.HaveShippingMark).HasComment("0=GR from OMS, 1=Not GR from OMS (Auto book when receive QTY >= Ship QTY)");
            entity.Property(e => e.ImportGroupNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(100)
                .HasComment("Default Invoice for Whole Shipment");
            entity.Property(e => e.LegId).HasColumnName("LegID");
            entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            entity.Property(e => e.PlannerName).HasMaxLength(50);
            entity.Property(e => e.PortOfDischargeId)
                .HasComment("Id of Port of Discharge")
                .HasColumnName("PortOfDischargeID");
            entity.Property(e => e.PortOfLoadingId)
                .HasComment("Id of Port of Loading")
                .HasColumnName("PortOfLoadingID");
            entity.Property(e => e.QcpickConfirmBy)
                .HasMaxLength(50)
                .HasColumnName("QCPickConfirmBy");
            entity.Property(e => e.QcpickConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("QCPickConfirmDate");
            entity.Property(e => e.RefDnnumber)
                .HasMaxLength(100)
                .HasColumnName("RefDNNumber");
            entity.Property(e => e.RefShipmentVersion).HasMaxLength(50);
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("Remark");
            entity.Property(e => e.RouteId).HasColumnName("RouteID");
            entity.Property(e => e.ServiceLevelId).HasColumnName("ServiceLevelID");
            entity.Property(e => e.ShipCompleteDate).HasColumnType("datetime");
            entity.Property(e => e.ShipCompleteFlag)
                .HasDefaultValue(false)
                .HasComment("0:Not Complete, 1:Complete");
            entity.Property(e => e.ShipmentGroupCreateDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentMemo).HasMaxLength(1000);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.ShiptoAddress).HasMaxLength(500);
            entity.Property(e => e.ShiptoCity).HasMaxLength(50);
            entity.Property(e => e.ShiptoCode).HasMaxLength(20);
            entity.Property(e => e.ShiptoCountry).HasMaxLength(50);
            entity.Property(e => e.ShiptoDestinationId).HasColumnName("ShiptoDestinationID");
            entity.Property(e => e.ShiptoDetail).HasMaxLength(500);
            entity.Property(e => e.ShiptoExtension).HasMaxLength(50);
            entity.Property(e => e.ShiptoLongName).HasMaxLength(250);
            entity.Property(e => e.ShiptoMobileNo).HasMaxLength(50);
            entity.Property(e => e.ShiptoPhoneNo).HasMaxLength(50);
            entity.Property(e => e.ShiptoPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShiptoStateOrProvince).HasMaxLength(50);
            entity.Property(e => e.Sonumber)
                .HasMaxLength(100)
                .HasColumnName("SONumber");
            entity.Property(e => e.SourceSystem).HasMaxLength(20);
            entity.Property(e => e.TmsinterfaceId).HasColumnName("TMSInterfaceID");
            entity.Property(e => e.TmsloadId)
                .HasMaxLength(50)
                .HasColumnName("TMSLoadID");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TransferType).HasComment("1: Import\r\n2: Domestic\r\n3: Transfer Stock");
            entity.Property(e => e.TransportOrderTypeId).HasColumnName("TransportOrderTypeID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.VesselName1).HasMaxLength(100);
            entity.Property(e => e.VesselName2).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtShippingInterfaceHeader>(entity =>
        {
            entity.HasKey(e => e.ShippingInterfaceId);

            entity.ToTable("tbt_ShippingInterfaceHeader");

            entity.Property(e => e.ShippingInterfaceId).HasColumnName("ShippingInterfaceID");
            entity.Property(e => e.ConfirmDate).HasColumnType("datetime");
            entity.Property(e => e.ConfirmUser).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(20);
            entity.Property(e => e.CustomerName).HasMaxLength(500);
            entity.Property(e => e.CustomerOrderNo).HasMaxLength(50);
            entity.Property(e => e.DeliveryBy).HasMaxLength(500);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Dodate)
                .HasColumnType("datetime")
                .HasColumnName("DODate");
            entity.Property(e => e.Dono)
                .HasMaxLength(50)
                .HasColumnName("DONo");
            entity.Property(e => e.FinalDestinationCode).HasMaxLength(20);
            entity.Property(e => e.FinalDestinationName).HasMaxLength(500);
            entity.Property(e => e.InvoiceNo).HasMaxLength(20);
            entity.Property(e => e.PickingDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShippingCustomerCode).HasMaxLength(20);
            entity.Property(e => e.ShippingCustomerName).HasMaxLength(500);
            entity.Property(e => e.StatusId)
                .HasComment("0: Not complete\r\n1: Completed")
                .HasColumnName("StatusID");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TransferType).HasComment("1: Import\r\n2: Domestic\r\n3: Transfer Stock");
            entity.Property(e => e.WarehouseCode).HasMaxLength(10);
            entity.Property(e => e.WarehouseName).HasMaxLength(500);
        });

        modelBuilder.Entity<TbtShippingLoadingDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransportSeq, e.LoadingSeq, e.LoadingDetailSeq });

            entity.ToTable("tbt_ShippingLoadingDetail");

            entity.Property(e => e.TransportSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LoadingSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LoadingDetailSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.InBoundBy).HasMaxLength(50);
            entity.Property(e => e.InBoundDate).HasColumnType("datetime");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemSize).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.NetWeightByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.OutBoundBy).HasMaxLength(50);
            entity.Property(e => e.OutBoundDate).HasColumnType("datetime");
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.PackingQty).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.PackingWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.Pddno)
                .HasMaxLength(50)
                .HasColumnName("PDDNo");
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_No");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.QtyByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.RecordIdRefer)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID_Refer");
            entity.Property(e => e.ShippinMarkOutBound).HasMaxLength(50);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(50);
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled")
                .HasColumnName("StatusID");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtShippingLoadingHeader>(entity =>
        {
            entity.HasKey(e => e.LoadingSeq);

            entity.ToTable("tbt_ShippingLoadingHeader");

            entity.Property(e => e.LoadingSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateUpdateStatusByDoc).HasColumnType("datetime");
            entity.Property(e => e.DoorCode).HasMaxLength(20);
            entity.Property(e => e.FromDcid).HasColumnName("FromDCID");
            entity.Property(e => e.InBoundCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");
            entity.Property(e => e.LoadingNo).HasMaxLength(20);
            entity.Property(e => e.LocationType).HasMaxLength(20);
            entity.Property(e => e.OutBoundCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.PhaseCode).HasMaxLength(20);
            entity.Property(e => e.PrintLoadingSheetDate).HasColumnType("datetime");
            entity.Property(e => e.PrintShippingNoteDate).HasColumnType("datetime");
            entity.Property(e => e.ReasonUpdateStatusByDoc).HasMaxLength(1000);
            entity.Property(e => e.SalesinfFlag).HasColumnName("SALESINF_FLAG");
            entity.Property(e => e.ScanInBoundBy).HasMaxLength(20);
            entity.Property(e => e.ScanInBoundCountLogDate).HasColumnType("datetime");
            entity.Property(e => e.ScanInBoundLog).HasMaxLength(500);
            entity.Property(e => e.ScanOutBoundBy).HasMaxLength(20);
            entity.Property(e => e.ScanOutBoundCountLogDate).HasColumnType("datetime");
            entity.Property(e => e.ScanOutBoundLog).HasMaxLength(500);
            entity.Property(e => e.ShipFromId).HasColumnName("ShipFromID");
            entity.Property(e => e.ShipFromPhone).HasMaxLength(100);
            entity.Property(e => e.ShipToAddress).HasMaxLength(200);
            entity.Property(e => e.ShipToDesc).HasMaxLength(200);
            entity.Property(e => e.ShipToName).HasMaxLength(100);
            entity.Property(e => e.ShipToPhone).HasMaxLength(100);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.ShippingNoteNo).HasMaxLength(20);
            entity.Property(e => e.ShippingNotePrintPage).HasComment("Id of Final Destination");
            entity.Property(e => e.ShiptoId)
                .HasComment("Id of Final Destination")
                .HasColumnName("ShiptoID");
            entity.Property(e => e.StatusId)
                .HasComment("1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled")
                .HasColumnName("StatusID");
            entity.Property(e => e.TmsinfFlag).HasColumnName("TMSINF_Flag");
            entity.Property(e => e.ToDcid).HasColumnName("ToDCID");
            entity.Property(e => e.TransportSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UserUpdateStatusByDoc).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtShippingOrderManualDetail>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_ShippingOrderManual_Detail");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CoilNo).HasMaxLength(50);
            entity.Property(e => e.ItemKindCd)
                .HasMaxLength(50)
                .HasColumnName("ItemKind_CD");
            entity.Property(e => e.ItemKindName)
                .HasMaxLength(50)
                .HasColumnName("ItemKind_Name");
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemSizeLength)
                .HasMaxLength(50)
                .HasColumnName("Item_Size_Length");
            entity.Property(e => e.ItemSizeShape)
                .HasMaxLength(50)
                .HasColumnName("Item_Size_Shape");
            entity.Property(e => e.ItemSizeThickness)
                .HasMaxLength(50)
                .HasColumnName("Item_Size_Thickness");
            entity.Property(e => e.ItemSizeWidth)
                .HasMaxLength(50)
                .HasColumnName("Item_Size_Width");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.Po)
                .HasMaxLength(50)
                .HasColumnName("PO");
            entity.Property(e => e.Quantity).HasMaxLength(50);
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<TbtShippingOrderManualHeader>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_ShippingOrderManual_Header");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryTimeFrom)
                .HasMaxLength(100)
                .HasColumnName("DeliveryTime_From");
            entity.Property(e => e.DeliveryTimeTo)
                .HasMaxLength(100)
                .HasColumnName("DeliveryTime_To");
            entity.Property(e => e.HeaderDept)
                .HasMaxLength(100)
                .HasColumnName("Header_Dept");
            entity.Property(e => e.HeaderGrossWeight)
                .HasMaxLength(100)
                .HasColumnName("Header_GrossWeight");
            entity.Property(e => e.HeaderHeight)
                .HasMaxLength(100)
                .HasColumnName("Header_Height");
            entity.Property(e => e.HeaderWidth)
                .HasMaxLength(100)
                .HasColumnName("Header_Width");
            entity.Property(e => e.LoadingTimeFrom)
                .HasMaxLength(100)
                .HasColumnName("LoadingTime_From");
            entity.Property(e => e.LoadingTimeTo)
                .HasMaxLength(100)
                .HasColumnName("LoadingTime_To");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.PackingStyleTypeCode).HasMaxLength(100);
            entity.Property(e => e.RemarkExternal)
                .HasMaxLength(100)
                .HasColumnName("Remark_External");
            entity.Property(e => e.RemarkFromPc)
                .HasMaxLength(100)
                .HasColumnName("Remark_FromPC");
            entity.Property(e => e.RemarkInternal)
                .HasMaxLength(100)
                .HasColumnName("Remark_Internal");
            entity.Property(e => e.ShipFromId)
                .HasMaxLength(100)
                .HasColumnName("ShipFromID");
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShiptoAddress).HasMaxLength(100);
            entity.Property(e => e.ShiptoId)
                .HasMaxLength(100)
                .HasColumnName("ShiptoID");
            entity.Property(e => e.ShiptoPhoneNo).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.TransferTypeId)
                .HasComment("1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory")
                .HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(100);
        });

        modelBuilder.Entity<TbtShippingOtherCharge>(entity =>
        {
            entity.HasKey(e => e.OtherChargeId);

            entity.ToTable("tbt_ShippingOtherCharge");

            entity.Property(e => e.OtherChargeId).HasColumnName("OtherChargeID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(20);
            entity.Property(e => e.OtherCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtShippingPlanInfo>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PKtbt_Shipping_DeliveryPlanInfo");

            entity.ToTable("tbt_ShippingPlanInfo");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Eta).HasColumnName("ETA");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemSize).HasMaxLength(50);
            entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");
            entity.Property(e => e.LocationType).HasMaxLength(20);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.NetWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.PackingQty).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.ShipFromId).HasColumnName("ShipFromID");
            entity.Property(e => e.ShipToAddress).HasMaxLength(200);
            entity.Property(e => e.ShipToName).HasMaxLength(100);
            entity.Property(e => e.ShipmentPlanGroupId).HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
            entity.Property(e => e.ShiptoId).HasColumnName("ShiptoID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.WorkOrderNo).HasMaxLength(20);
        });

        modelBuilder.Entity<TbtShippingPlanSalesOrder>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_ShippingPlan_SalesOrder");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCd)
                .HasMaxLength(100)
                .HasColumnName("Customer_CD");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.DeliveryDestinationName)
                .HasMaxLength(200)
                .HasColumnName("Delivery_Destination_Name");
            entity.Property(e => e.DestinationCode)
                .HasMaxLength(100)
                .HasColumnName("Destination_Code");
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.InOutFactorCd)
                .HasMaxLength(100)
                .HasColumnName("In_Out_Factor_CD");
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.ManufacturingInstructionNo)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Instruction_No");
            entity.Property(e => e.OrdererCd)
                .HasMaxLength(100)
                .HasColumnName("Orderer_CD");
            entity.Property(e => e.OrdererName)
                .HasMaxLength(100)
                .HasColumnName("Orderer_Name");
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.Pddno)
                .HasMaxLength(100)
                .HasColumnName("PDDNo");
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.ShipmentInstructionDate)
                .HasColumnType("datetime")
                .HasColumnName("Shipment_Instruction_Date");
            entity.Property(e => e.ShipmentInstructionPackingQty).HasColumnName("Shipment_Instruction_Packing_Qty");
            entity.Property(e => e.ShipmentInstructionWeight)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Shipment_Instruction_Weight");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMax)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Max");
            entity.Property(e => e.ShipmentInstructionWeightAllowanceMin)
                .HasMaxLength(100)
                .HasColumnName("Shipment_Instruction_Weight_Allowance_Min");
            entity.Property(e => e.ShipperWarehouseCd)
                .HasMaxLength(100)
                .HasColumnName("Shipper_Warehouse_CD");
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TransferTypeId).HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
        });

        modelBuilder.Entity<TbtShippingPlanTransfer>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_ShippingPlan_Transfer");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.EditedItemName).HasMaxLength(100);
            entity.Property(e => e.EditedSize).HasMaxLength(100);
            entity.Property(e => e.ExternalAlloyName).HasMaxLength(100);
            entity.Property(e => e.GradeForCustomerDisplay).HasMaxLength(100);
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(7, 2)");
            entity.Property(e => e.InternalAlloyCode).HasMaxLength(100);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Lotno)
                .HasMaxLength(100)
                .HasColumnName("LOTNo");
            entity.Property(e => e.ManufacturingGrade).HasMaxLength(100);
            entity.Property(e => e.PackingNo).HasMaxLength(100);
            entity.Property(e => e.ProductSizeLength).HasMaxLength(100);
            entity.Property(e => e.ProductSizeThickness).HasMaxLength(100);
            entity.Property(e => e.ProductSizeWidth).HasMaxLength(100);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName).HasMaxLength(100);
            entity.Property(e => e.ReceivingLocationCode).HasMaxLength(100);
            entity.Property(e => e.ShippingInstructionDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingInstructionNo).HasMaxLength(100);
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(100);
            entity.Property(e => e.StatusId)
                .HasComment("1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel")
                .HasColumnName("StatusID");
            entity.Property(e => e.TransferTypeId)
                .HasComment("1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory")
                .HasColumnName("TransferTypeID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtShippingStatus>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.PickingNo, e.Installment, e.LineNo });

            entity.ToTable("tbt_ShippingStatus");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking No");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No of shipment No.");
            entity.Property(e => e.LineNo).HasComment("Line sequence No.");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate)
                .HasComment("Interface Received Date [A-1] / Screen Entry [F-1]")
                .HasColumnType("datetime");
            entity.Property(e => e.PcidriverIssuedDate)
                .HasComment("PCIDriver Issued Date")
                .HasColumnType("datetime")
                .HasColumnName("PCIDriverIssuedDate");
            entity.Property(e => e.PciwarehouseIssuedDate)
                .HasComment("Screen [H-1]")
                .HasColumnType("datetime")
                .HasColumnName("PCIWarehouseIssuedDate");
            entity.Property(e => e.PickingDate)
                .HasComment("Screen [H-2]")
                .HasColumnType("datetime");
            entity.Property(e => e.ShippingDate)
                .HasComment("Screen [I-2]")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(2)
                .HasComment("Id of Status")
                .HasColumnName("StatusID");
            entity.Property(e => e.StockControlDate)
                .HasComment("Screen [G-1]")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtShippingTransportFee>(entity =>
        {
            entity.HasKey(e => new { e.TransportSeq, e.TransportFeeSeq });

            entity.ToTable("tbt_ShippingTransportFee");

            entity.Property(e => e.TransportSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TransportFeeSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ShipFromId).HasColumnName("ShipFromID");
            entity.Property(e => e.ShipFromName).HasMaxLength(100);
            entity.Property(e => e.ShipToId).HasColumnName("ShipToID");
            entity.Property(e => e.ShipToName).HasMaxLength(100);
            entity.Property(e => e.TransportFee).HasColumnType("numeric(11, 2)");
        });

        modelBuilder.Entity<TbtShippingTransportation>(entity =>
        {
            entity.HasKey(e => e.TransportSeq);

            entity.ToTable("tbt_ShippingTransportation");

            entity.Property(e => e.TransportSeq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActualIn).HasColumnType("datetime");
            entity.Property(e => e.ActualOut).HasColumnType("datetime");
            entity.Property(e => e.AllocateDate).HasColumnType("datetime");
            entity.Property(e => e.ArrivalTime).HasMaxLength(10);
            entity.Property(e => e.BookingNo).HasMaxLength(100);
            entity.Property(e => e.ContainerNo).HasMaxLength(100);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date when the Port is created")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(50)
                .HasComment("User who create the Port");
            entity.Property(e => e.DirectionTypeCode).HasMaxLength(50);
            entity.Property(e => e.DriverName).HasMaxLength(100);
            entity.Property(e => e.DriverPhoneNo).HasMaxLength(100);
            entity.Property(e => e.Installment).HasDefaultValue(1);
            entity.Property(e => e.LoadCapacityRate).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OutgoingCharge).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.PlanIn).HasColumnType("datetime");
            entity.Property(e => e.PlanOut).HasColumnType("datetime");
            entity.Property(e => e.RegistrationNo).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RoundTripId)
                .HasMaxLength(50)
                .HasColumnName("RoundTripID");
            entity.Property(e => e.ShipDate).HasColumnType("datetime");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentPlanGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ShipmentPlanGroupID");
            entity.Property(e => e.StatusId)
                .HasComment("1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled")
                .HasColumnName("StatusID");
            entity.Property(e => e.TariffTypeId).HasColumnName("Tariff_TypeID");
            entity.Property(e => e.TmsinfFlag).HasColumnName("TMSINF_Flag");
            entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalLoadWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalShipWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TransportCharge).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TransportFee)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("Transport_Fee");
            entity.Property(e => e.TransportFeeOption1)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("Transport_Fee_Option1");
            entity.Property(e => e.TransportFeeOption2)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("Transport_Fee_Option2");
            entity.Property(e => e.TransportFeeOption3)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("Transport_Fee_Option3");
            entity.Property(e => e.TransportFeeOptionId1).HasColumnName("Transport_Fee_OptionID1");
            entity.Property(e => e.TransportFeeOptionId2).HasColumnName("Transport_Fee_OptionID2");
            entity.Property(e => e.TransportFeeOptionId3).HasColumnName("Transport_Fee_OptionID3");
            entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");
            entity.Property(e => e.TripNoText).HasMaxLength(20);
            entity.Property(e => e.TripTypeId)
                .HasMaxLength(50)
                .HasColumnName("TripTypeID");
            entity.Property(e => e.TruckBookingGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TruckBookingGroupID");
            entity.Property(e => e.TruckCompanyId).HasColumnName("TruckCompanyID");
            entity.Property(e => e.UpdateDate)
                .HasComment("Date when the Port is updated")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(50)
                .HasComment("User who update the Port");

            entity.HasOne(d => d.TruckCompany).WithMany(p => p.TbtShippingTransportations)
                .HasForeignKey(d => d.TruckCompanyId)
                .HasConstraintName("FK_tbt_ShippingTransportation_tbm_TruckCompany");
        });

        modelBuilder.Entity<TbtSmsSendLog>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_SMS_SendLog");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.DriverName).HasMaxLength(50);
            entity.Property(e => e.SendBy).HasMaxLength(50);
            entity.Property(e => e.SendDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Smsmessage)
                .HasMaxLength(1000)
                .HasColumnName("SMSMessage");
            entity.Property(e => e.TelNo).HasMaxLength(50);
            entity.Property(e => e.TruckNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtSpaceUtilizationSnapshot>(entity =>
        {
            entity.HasKey(e => e.SnapshotId);

            entity.ToTable("tbt_SpaceUtilizationSnapshot");

            entity.Property(e => e.SnapshotId).HasColumnName("SnapshotID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.MaxCapacity).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MaxM2).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SubTypeOfGoodsId).HasColumnName("SubTypeOfGoodsID");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeOfGoodsId).HasColumnName("TypeOfGoodsID");
            entity.Property(e => e.YearMonth).HasMaxLength(7);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtStockByLocation>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.Dcid, e.LocationId, e.ProductId, e.ProductConditionId, e.PalletNo, e.LotNo }).HasName("PK_tbt_StockByLocation_1");

            entity.ToTable("tbt_StockByLocation");

            entity.Property(e => e.CustomerId)
                .HasComment("Id of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id Of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.LocationId)
                .HasComment("id of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.ProductId)
                .HasComment("Id of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductConditionId)
                .HasComment("Id of Condition of Product")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.BeginQty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.LastUpdateSince)
                .HasComment("Last Update Date")
                .HasColumnType("datetime");
            entity.Property(e => e.Quantity)
                .HasComment("Quantity")
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtStockCountingDetail>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.LineNo }).HasName("PK_tbt_StockCounting_1");

            entity.ToTable("tbt_StockCountingDetail");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.AdjustedDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustedQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AdjustedUser).HasMaxLength(100);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledUser).HasMaxLength(100);
            entity.Property(e => e.CountedDate).HasColumnType("datetime");
            entity.Property(e => e.CountedQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CountedUser).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.InventoryQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReasonOfAdjustment).HasMaxLength(500);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtStockCountingDetailBySticker>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.ProductId, e.Seq, e.LocationId, e.StickerUid });

            entity.ToTable("tbt_StockCountingDetailBySticker");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Seq)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SEQ");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.AdjustedQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CountedQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InventoryQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(50);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtStockCountingHeader>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tbt_StockCountingHeader");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.AdjustedDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustedUser).HasMaxLength(100);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledUser).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.PlanCountingDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(100);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtStockMovement>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_StockMovement");

            entity.Property(e => e.Seq).HasComment("Sequence No.");
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.ActuallyTransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Actually_TransactionDate");
            entity.Property(e => e.CustomerId)
                .HasComment("Id of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.Installment)
                .HasDefaultValue(1)
                .HasComment("Installment No.");
            entity.Property(e => e.LineNo).HasComment("Line sequence No");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PostFlag).HasComment("-1:Posting ; 0:Not post; 1:Posted ");
            entity.Property(e => e.ProductConditionId)
                .HasComment("Id of Condition of Product")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("Id of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.RecordCancel).HasComment("RecordCancel = 1 , Order Refresh and Order Cancel");
            entity.Property(e => e.ReferenceSlipNo)
                .HasMaxLength(30)
                .HasComment("Receiving number or picking number");
            entity.Property(e => e.StockActual)
                .HasComment("Stock Actual")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockHold)
                .HasComment("Stock Hold")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockPicking)
                .HasComment("Stock Picking")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockReceive)
                .HasComment("Stock Receive")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockShipping)
                .HasComment("Stock Shipping")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockTransit)
                .HasComment("Stock Entry")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockTransportation)
                .HasComment("Stock Transportation")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransactionDate)
                .HasComment("Date of Transaction")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtStockMovementShipbyhandy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_StockMovement_shipbyhandy");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReferenceSlipNo).HasMaxLength(30);
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.StockActual).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockHold).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockPicking).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockReceive).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockShipping).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockTransit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockTransportation).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtStockOfClient>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.WarehouseCode, e.ProductCodeTh, e.ProductConditionCode });

            entity.ToTable("tbt_StockOfClient");

            entity.Property(e => e.ClientCode)
                .HasMaxLength(50)
                .HasComment("Code of Client");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("Code of Warehouse");
            entity.Property(e => e.ProductCodeTh)
                .HasMaxLength(50)
                .HasComment("Code of Model (Thai Code)")
                .HasColumnName("ProductCodeTH");
            entity.Property(e => e.ProductConditionCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Condition of Product Code");
            entity.Property(e => e.CheckingDateTime)
                .HasComment("Checking Datetime ")
                .HasColumnType("datetime");
            entity.Property(e => e.ImportDateTime)
                .HasComment("Datetime of Import")
                .HasColumnType("datetime");
            entity.Property(e => e.Quantity)
                .HasComment("Quantity")
                .HasColumnType("decimal(10, 3)");
        });

        modelBuilder.Entity<TbtStockPosted>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_tbt_PostStock");

            entity.ToTable("tbt_StockPosted");

            entity.Property(e => e.Seq).HasComment("Sequence No.");
            entity.Property(e => e.BalanceQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.BeginQty)
                .HasComment("Stock Transit")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CustomerId)
                .HasComment("Id of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PostDate)
                .HasComment("Post Date")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductConditionId)
                .HasComment("Id of Condition of Product")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("Id of Model")
                .HasColumnName("ProductID");
        });

        modelBuilder.Entity<TbtStockShippingPosted>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tbt_StockShippingPosted");

            entity.Property(e => e.BalanceQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.BeginQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.PostDate).HasColumnType("datetime");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<TbtStockTakingHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbt_StockTakingHistory");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.AdjustmentQty)
                .HasComment("Adjustment Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(100);
            entity.Property(e => e.CustomerId)
                .HasComment("Id Of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id Of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.LineNo).HasComment("Line sequence no.");
            entity.Property(e => e.LocationId)
                .HasComment("Id of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductConditionId)
                .HasComment("Id of Condition of Product")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("Id of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ResultQty)
                .HasComment("Result Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Seq)
                .ValueGeneratedOnAdd()
                .HasComment("Sequence No");
            entity.Property(e => e.SlipNo)
                .HasMaxLength(100)
                .HasComment("Slip No");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.TransactionDate)
                .HasComment("Transaction Date")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(100)
                .HasColumnName("UpdateUSer");
        });

        modelBuilder.Entity<TbtSuggestPickingLocation>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PickingLineSeq });

            entity.ToTable("tbt_SuggestPickingLocation");

            entity.Property(e => e.ShipmentNo)
                .HasMaxLength(22)
                .HasComment("Shipment No");
            entity.Property(e => e.Installment).HasComment("Installment ");
            entity.Property(e => e.PickingNo)
                .HasMaxLength(22)
                .HasComment("Picking No");
            entity.Property(e => e.LineNo).HasComment("Line Sequence no.");
            entity.Property(e => e.IsPicked).HasDefaultValue(0);
            entity.Property(e => e.LocationId)
                .HasComment("ID of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.Lot).HasMaxLength(100);
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .HasColumnName("PalletID");
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.PickingQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.StockQty).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtSuggestResourceManagementDetail>(entity =>
        {
            entity.HasKey(e => new { e.WaveNo, e.ShipmentNo, e.Installment, e.PickingNo, e.LineNo, e.PickingLineSeq }).HasName("PK_tbt_SuggestResourceManagement");

            entity.ToTable("tbt_SuggestResourceManagementDetail");

            entity.Property(e => e.WaveNo).HasMaxLength(30);
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.PickingNo).HasMaxLength(22);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.Wo).HasColumnName("WO");
            entity.Property(e => e.Wt).HasColumnName("WT");
        });

        modelBuilder.Entity<TbtSuggestResourceManagementHeader>(entity =>
        {
            entity.HasKey(e => e.WaveNo).HasName("PK_tbt_SuggestResourceManagementHeader_1");

            entity.ToTable("tbt_SuggestResourceManagementHeader");

            entity.Property(e => e.WaveNo).HasMaxLength(30);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.WaveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbtSuggestTransitLocation>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ReceiveSeq, e.LocationId });

            entity.ToTable("tbt_SuggestTransitLocation");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("Slip No");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.LineNo).HasComment("Line Sequence No");
            entity.Property(e => e.LocationId)
                .HasComment("ID of Location")
                .HasColumnName("LocationID");
            entity.Property(e => e.AllocateQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CustomerId)
                .HasComment("Id of Client ")
                .HasColumnName("CustomerID");
            entity.Property(e => e.IsTransit).HasDefaultValue(0);
        });

        modelBuilder.Entity<TbtTagmapping>(entity =>
        {
            entity.HasKey(e => new { e.StickerUid, e.CustomerId, e.ProductId });

            entity.ToTable("tbt_Tagmapping");

            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BeginQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BoxPlNo).HasMaxLength(50);
            entity.Property(e => e.CheckRouteDate).HasColumnType("datetime");
            entity.Property(e => e.CheckRouteFlag).HasDefaultValue(0);
            entity.Property(e => e.CheckRouteUser).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DocRefNo).HasMaxLength(100);
            entity.Property(e => e.FinalPackageDivision)
                .HasMaxLength(10)
                .HasColumnName("Final_Package_Division");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.LoadingNo).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.Mfgdate).HasColumnName("MFGDate");
            entity.Property(e => e.NetWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.NetWeightByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.PlantCode).HasMaxLength(50);
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_No");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(50)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QtyByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.SoslineNo)
                .HasMaxLength(10)
                .HasColumnName("SOSLineNo");
            entity.Property(e => e.Sosno)
                .HasMaxLength(50)
                .HasColumnName("SOSNo");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TbtTagmappingCoilNo>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tbt_TagmappingCoilNo");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CoilNo).HasMaxLength(10);
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.NetWeightByCoilNo).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTagmappingRm>(entity =>
        {
            entity.HasKey(e => new { e.StickerUid, e.CustomerId, e.ProductId });

            entity.ToTable("tbt_TagmappingRM");

            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BeginQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BoxPlNo).HasMaxLength(50);
            entity.Property(e => e.CheckRouteDate).HasColumnType("datetime");
            entity.Property(e => e.CheckRouteUser).HasMaxLength(50);
            entity.Property(e => e.ContainerNo).HasMaxLength(50);
            entity.Property(e => e.ContainerType).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DocRefNo).HasMaxLength(100);
            entity.Property(e => e.FinalPackageDivision)
                .HasMaxLength(10)
                .HasColumnName("Final_Package_Division");
            entity.Property(e => e.GrossWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LoadingNo).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.Mfgdate).HasColumnName("MFGDate");
            entity.Property(e => e.NetWeight).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.NetWeightByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.PlantCode).HasMaxLength(50);
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_No");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductizationDate)
                .HasMaxLength(50)
                .HasColumnName("Productization_Date");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QtyByLot).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.SoslineNo)
                .HasMaxLength(10)
                .HasColumnName("SOSLineNo");
            entity.Property(e => e.Sosno)
                .HasMaxLength(50)
                .HasColumnName("SOSNo");
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
            entity.Property(e => e.UsageName)
                .HasMaxLength(100)
                .HasColumnName("Usage_Name");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTagmappingTemp>(entity =>
        {
            entity.HasKey(e => new { e.StickerUid, e.ReceivingNo, e.LineNo, e.DocRefNo, e.LotNo });

            entity.ToTable("tbt_Tagmapping_Temp");

            entity.Property(e => e.StickerUid)
                .HasMaxLength(100)
                .HasColumnName("StickerUID");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.DocRefNo).HasMaxLength(100);
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.BoxPlNo).HasMaxLength(50);
            entity.Property(e => e.CheckRouteDate).HasColumnType("datetime");
            entity.Property(e => e.CheckRouteFlag).HasDefaultValue(0);
            entity.Property(e => e.CheckRouteUser).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaxStoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mfgdate).HasColumnName("MFGDate");
            entity.Property(e => e.PalletNo).HasMaxLength(40);
            entity.Property(e => e.PlantCode).HasMaxLength(50);
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_No");
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.Sloc).HasMaxLength(50);
            entity.Property(e => e.Sloccontrol).HasColumnName("SLOCControl");
            entity.Property(e => e.SoslineNo)
                .HasMaxLength(10)
                .HasColumnName("SOSLineNo");
            entity.Property(e => e.Sosno)
                .HasMaxLength(50)
                .HasColumnName("SOSNo");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTmsCheckInLog>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tbt_TMS_CheckInLot");

            entity.ToTable("tbt_TMS_CheckInLog");

            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecordID");
            entity.Property(e => e.ArriveTime).HasColumnType("datetime");
            entity.Property(e => e.CheckInInBound).HasColumnName("CheckIn_InBound");
            entity.Property(e => e.CheckInOutBound).HasColumnName("CheckIn_OutBound");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DriveName).HasMaxLength(50);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasColumnName("Phone_No");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TripNoText).HasMaxLength(20);
            entity.Property(e => e.TruckNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTmsdeliveryService>(entity =>
        {
            entity.HasKey(e => e.InterfaceId);

            entity.ToTable("tbt_TMSDeliveryService");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.BillToCustomerCode).HasMaxLength(16);
            entity.Property(e => e.CommodityCode).HasMaxLength(12);
            entity.Property(e => e.CustomerCode).HasMaxLength(16);
            entity.Property(e => e.DeliveryNo).HasMaxLength(30);
            entity.Property(e => e.DestinationCode).HasMaxLength(16);
            entity.Property(e => e.DestinationName).HasMaxLength(70);
            entity.Property(e => e.DestinationPostalCode).HasMaxLength(12);
            entity.Property(e => e.DestinationStateCode).HasMaxLength(4);
            entity.Property(e => e.DestinationTypeEnumVal).HasMaxLength(4);
            entity.Property(e => e.DivisionCode).HasMaxLength(4);
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventName).HasMaxLength(40);
            entity.Property(e => e.EventUser).HasMaxLength(16);
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FreightTerm).HasMaxLength(12);
            entity.Property(e => e.LogisticsGroup).HasMaxLength(4);
            entity.Property(e => e.OriginCode).HasMaxLength(16);
            entity.Property(e => e.OriginName).HasMaxLength(70);
            entity.Property(e => e.OriginPostalCode).HasMaxLength(12);
            entity.Property(e => e.OriginStateCode).HasMaxLength(4);
            entity.Property(e => e.OriginTypeEnumVal).HasMaxLength(4);
            entity.Property(e => e.Pieces).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PimessageIddestination)
                .HasMaxLength(40)
                .HasColumnName("PIMessageIDDestination");
            entity.Property(e => e.PimessageIdsource)
                .HasMaxLength(40)
                .HasColumnName("PIMessageIDSource");
            entity.Property(e => e.ReasonCode).HasMaxLength(16);
            entity.Property(e => e.ReasonCodeDescription).HasMaxLength(16);
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.VolumeUom)
                .HasMaxLength(10)
                .HasColumnName("VolumeUOM");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.WeightUom)
                .HasMaxLength(10)
                .HasColumnName("WeightUOM");
        });

        modelBuilder.Entity<TbtTmsshipmentLeg>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceId, e.ShipmentNo, e.DeliveryNo, e.ShipmentItinerarySeqNum, e.SystemShipmentLegId });

            entity.ToTable("tbt_TMSShipmentLeg");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(16);
            entity.Property(e => e.DeliveryNo).HasMaxLength(30);
            entity.Property(e => e.SystemShipmentLegId)
                .HasMaxLength(28)
                .HasColumnName("SystemShipmentLegID");
            entity.Property(e => e.DestinationCode).HasMaxLength(16);
            entity.Property(e => e.DestinationName).HasMaxLength(70);
            entity.Property(e => e.DestinationTypeEnumVal).HasMaxLength(4);
            entity.Property(e => e.OrderNo).HasMaxLength(30);
            entity.Property(e => e.OriginCode).HasMaxLength(16);
            entity.Property(e => e.OriginName).HasMaxLength(70);
            entity.Property(e => e.OriginTypeEnumVal).HasMaxLength(4);
        });

        modelBuilder.Entity<TbtTmsshipmentLoadStopList>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceId, e.ShipmentNo, e.SystemStopId });

            entity.ToTable("tbt_TMSShipmentLoadStopList");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.ShipmentNo).HasMaxLength(16);
            entity.Property(e => e.SystemStopId)
                .HasMaxLength(12)
                .HasColumnName("SystemStopID");
            entity.Property(e => e.ComputedArrivalDateTime).HasColumnType("datetime");
            entity.Property(e => e.ComputedDepartureDateTime).HasColumnType("datetime");
            entity.Property(e => e.DroppedPieces).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.DroppedVolume).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.DroppedWeight).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PickedPieces).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PickedVolume).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PickedWeight).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.ShippingLocationCode).HasMaxLength(16);
            entity.Property(e => e.ShippingPointType).HasMaxLength(4);
            entity.Property(e => e.StopShippingLocationName).HasMaxLength(70);
        });

        modelBuilder.Entity<TbtTmsshipmentService>(entity =>
        {
            entity.HasKey(e => e.InterfaceId);

            entity.ToTable("tbt_TMSShipmentService");

            entity.Property(e => e.InterfaceId).HasColumnName("InterfaceID");
            entity.Property(e => e.CarrierCode).HasMaxLength(16);
            entity.Property(e => e.CarrierName).HasMaxLength(70);
            entity.Property(e => e.ChargeAmount).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CurrencyType).HasMaxLength(16);
            entity.Property(e => e.DivisionCode).HasMaxLength(4);
            entity.Property(e => e.DriverCode).HasMaxLength(100);
            entity.Property(e => e.EquipmentType).HasMaxLength(5);
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventName).HasMaxLength(40);
            entity.Property(e => e.EventUser).HasMaxLength(16);
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.LoadPieces).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LoadVolume).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LoadWeight).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LogisticsGroup).HasMaxLength(4);
            entity.Property(e => e.PaymentCurrencyChargeAmount).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PaymentCurrencyType).HasMaxLength(16);
            entity.Property(e => e.PaymentTerm).HasMaxLength(12);
            entity.Property(e => e.PimessageIddestination)
                .HasMaxLength(40)
                .HasColumnName("PIMessageIDDestination");
            entity.Property(e => e.PimessageIdsource)
                .HasMaxLength(40)
                .HasColumnName("PIMessageIDSource");
            entity.Property(e => e.ReasonCode).HasMaxLength(16);
            entity.Property(e => e.ReasonCodeDescription).HasMaxLength(16);
            entity.Property(e => e.ServiceCode).HasMaxLength(16);
            entity.Property(e => e.ShipmentNo).HasMaxLength(16);
            entity.Property(e => e.ShipmentStatus).HasMaxLength(20);
            entity.Property(e => e.SuspendedReasonEnumVal).HasMaxLength(20);
            entity.Property(e => e.TenderLevelEnumVal).HasMaxLength(16);
            entity.Property(e => e.TenderedByUserId)
                .HasMaxLength(16)
                .HasColumnName("TenderedByUserID");
            entity.Property(e => e.TotalDriveDistance).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.TotalDriveTime).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.TrailerNumber).HasMaxLength(100);
            entity.Property(e => e.VolumeUom)
                .HasMaxLength(10)
                .HasColumnName("VolumeUOM");
            entity.Property(e => e.WeightUom)
                .HasMaxLength(10)
                .HasColumnName("WeightUOM");
        });

        modelBuilder.Entity<TbtTransferWarehouseDetail>(entity =>
        {
            entity.HasKey(e => new { e.ShipmentNo, e.PickingNo, e.LineNo });

            entity.ToTable("tbt_TransferWarehouseDetail");

            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.PickingNo).HasMaxLength(50);
            entity.Property(e => e.LineNo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.OldReceivingNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Qty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QtyUnitId).HasColumnName("QtyUnitID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTransferWarehouseMapping>(entity =>
        {
            entity.HasKey(e => e.SeqId).HasName("PK_tbt_TransferWarehouseMapping_");

            entity.ToTable("tbt_TransferWarehouseMapping");

            entity.Property(e => e.SeqId).HasColumnName("SeqID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.IsCancel).HasColumnName("isCancel");
            entity.Property(e => e.PickingNo).HasMaxLength(20);
            entity.Property(e => e.ReceivingNo).HasMaxLength(20);
            entity.Property(e => e.ShipmentNo).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTransitConfirmed>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo, e.ReceiveSeq, e.TransitSeq }).HasName("PK_tbt_TransitConfirmed_1");

            entity.ToTable("tbt_TransitConfirmed");

            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.IsExportReceivedResult).HasDefaultValue(0);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LocationId)
                .HasComment("Refer Location Master")
                .HasColumnName("LocationID");
            entity.Property(e => e.StockActualQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TransitQty).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TbtTransitInstruction>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment }).HasName("PK_tbt_StoringInstruction");

            entity.ToTable("tbt_TransitInstruction");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("Slip no.");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dcid)
                .HasComment("Id of Warehouse")
                .HasColumnName("DCID");
            entity.Property(e => e.StoringInstructionDraftDate)
                .HasComment("Storing Instruction Draf Date")
                .HasColumnType("datetime");
            entity.Property(e => e.StoringInstructionDraftNo)
                .HasMaxLength(5)
                .HasComment("Storing Instruction Draf No");
            entity.Property(e => e.SupplierId)
                .HasComment("ID of Supplier")
                .HasColumnName("SupplierID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<TbtTransitInstructionItem>(entity =>
        {
            entity.HasKey(e => new { e.ReceivingNo, e.Installment, e.LineNo });

            entity.ToTable("tbt_TransitInstructionItems");

            entity.Property(e => e.ReceivingNo)
                .HasMaxLength(22)
                .HasComment("Slip no.");
            entity.Property(e => e.Installment).HasComment("Installment");
            entity.Property(e => e.LineNo).HasComment("Line Sequence No.");
            entity.Property(e => e.ConfirmTransitDraftNo)
                .HasMaxLength(25)
                .HasComment("Confirm Storing Draft No");
            entity.Property(e => e.ConfirmTransitDraftTime)
                .HasComment("Confirm Storing Draft Time")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasComment("ID of Client")
                .HasColumnName("CustomerID");
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductConditionId)
                .HasComment("Id of condition of product")
                .HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId)
                .HasComment("ID of Model")
                .HasColumnName("ProductID");
            entity.Property(e => e.TransitInstructQty)
                .HasComment("Storing Instruct Quantity")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);

            entity.HasOne(d => d.TbtTransitInstruction).WithMany(p => p.TbtTransitInstructionItems)
                .HasForeignKey(d => new { d.ReceivingNo, d.Installment })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbt_TransitInstructionItems_tbt_TransitInstruction");
        });

        modelBuilder.Entity<TmpFinal1>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tmp_final1");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Finaladdress)
                .HasMaxLength(200)
                .HasColumnName("finaladdress");
            entity.Property(e => e.Finalcode)
                .HasMaxLength(50)
                .HasColumnName("finalcode");
            entity.Property(e => e.Finalname)
                .HasMaxLength(100)
                .HasColumnName("finalname");
        });

        modelBuilder.Entity<TmpFinal2>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tmp_final2");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Finaladdress)
                .HasMaxLength(200)
                .HasColumnName("finaladdress");
            entity.Property(e => e.Finaladdressredata)
                .HasMaxLength(200)
                .HasColumnName("finaladdressredata");
            entity.Property(e => e.Finalcode)
                .HasMaxLength(50)
                .HasColumnName("finalcode");
            entity.Property(e => e.FinaldesfromF1)
                .HasMaxLength(100)
                .HasColumnName("finaldesfrom_f1");
            entity.Property(e => e.Finalname)
                .HasMaxLength(100)
                .HasColumnName("finalname");
            entity.Property(e => e.Thactflag).HasColumnName("thactflag");
            entity.Property(e => e.Wmsfinaladdress)
                .HasMaxLength(200)
                .HasColumnName("wmsfinaladdress");
            entity.Property(e => e.Wmsfinalname)
                .HasMaxLength(100)
                .HasColumnName("wmsfinalname");
            entity.Property(e => e.Wmsflag).HasColumnName("wmsflag");
        });

        modelBuilder.Entity<TmpFinal3>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tmp_final3");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Finaladdress)
                .HasMaxLength(200)
                .HasColumnName("finaladdress");
            entity.Property(e => e.Finaladdressredata)
                .HasMaxLength(200)
                .HasColumnName("finaladdressredata");
            entity.Property(e => e.Finalcode)
                .HasMaxLength(50)
                .HasColumnName("finalcode");
            entity.Property(e => e.FinaldesfromF1)
                .HasMaxLength(100)
                .HasColumnName("finaldesfrom_f1");
            entity.Property(e => e.Finalname)
                .HasMaxLength(100)
                .HasColumnName("finalname");
            entity.Property(e => e.Thactflag).HasColumnName("thactflag");
            entity.Property(e => e.Wmsfinaladdress)
                .HasMaxLength(200)
                .HasColumnName("wmsfinaladdress");
            entity.Property(e => e.Wmsfinalname)
                .HasMaxLength(100)
                .HasColumnName("wmsfinalname");
            entity.Property(e => e.Wmsflag).HasColumnName("wmsflag");
        });

        modelBuilder.Entity<TmpFinaltransaction>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tmp_finaltransaction");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Finaladdress)
                .HasMaxLength(200)
                .HasColumnName("finaladdress");
            entity.Property(e => e.Finalcode)
                .HasMaxLength(100)
                .HasColumnName("finalcode");
            entity.Property(e => e.Finalname)
                .HasMaxLength(100)
                .HasColumnName("finalname");
            entity.Property(e => e.Finaltype)
                .HasMaxLength(100)
                .HasColumnName("finaltype");
        });

        modelBuilder.Entity<TmpInitialInvenW3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_Initial_Inven_W3");

            entity.Property(e => e.ArrivalDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ConditionofItem)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ExpiredDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LocationCode)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Mfgdate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MFGDate");
            entity.Property(e => e.PalletNo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PoitemLine).HasColumnName("POItemLine");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("PONo");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Supplier)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UnitCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Warehouse)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TmpLangMapSpaceUtilization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_LangMAP_SpaceUtilization");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LangId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LANG_ID");
            entity.Property(e => e.LangWord)
                .HasMaxLength(500)
                .HasColumnName("LANG_WORD");
            entity.Property(e => e.MapId).HasColumnName("MAP_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
        });

        modelBuilder.Entity<TmpScreenLangSpaceUtilization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ScreenLang_SpaceUtilization");

            entity.Property(e => e.CtrlId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CTRL_ID");
            entity.Property(e => e.CtrlType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTRL_TYPE");
            entity.Property(e => e.FormId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_ID");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.MapId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MAP_ID");
            entity.Property(e => e.Origin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGIN");
        });

        modelBuilder.Entity<TmpShipmentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ShipmentDetails");

            entity.Property(e => e.CoilNo).HasMaxLength(50);
            entity.Property(e => e.Eta)
                .HasMaxLength(50)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(50)
                .HasColumnName("ETD");
            entity.Property(e => e.GrossWeight).HasMaxLength(50);
            entity.Property(e => e.Gwnet)
                .HasMaxLength(50)
                .HasColumnName("GWNet");
            entity.Property(e => e.ItemName).HasMaxLength(50);
            entity.Property(e => e.LoadingPlace).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.NetWeight).HasMaxLength(50);
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.PackingQuantity).HasMaxLength(50);
            entity.Property(e => e.Shipto).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Transportation).HasMaxLength(50);
            entity.Property(e => e.Truck).HasMaxLength(50);
            entity.Property(e => e.TruckType).HasMaxLength(50);
            entity.Property(e => e.WorkOrder).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpShipmentDetailsTruckBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ShipmentDetails_TruckBooking");

            entity.Property(e => e.CoilNo).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.CutTime).HasMaxLength(50);
            entity.Property(e => e.Eta)
                .HasMaxLength(50)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(50)
                .HasColumnName("ETD");
            entity.Property(e => e.GrossWeight).HasMaxLength(50);
            entity.Property(e => e.Gwnet)
                .HasMaxLength(50)
                .HasColumnName("GWNet");
            entity.Property(e => e.ItemName).HasMaxLength(50);
            entity.Property(e => e.LoadingPlace).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.NetWeight).HasMaxLength(50);
            entity.Property(e => e.PackingNo).HasMaxLength(50);
            entity.Property(e => e.PackingQuantity).HasMaxLength(50);
            entity.Property(e => e.Shipto).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Transportation).HasMaxLength(50);
            entity.Property(e => e.Truck).HasMaxLength(50);
            entity.Property(e => e.TruckType).HasMaxLength(50);
            entity.Property(e => e.WorkOrder).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpWhgraph>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("Tmp_WHGraph");

            entity.Property(e => e.SpaceAvialable).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.SpaceCapacity).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.SpaceUsage).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.TransactionBalance).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionIn).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.TransactionOut).HasColumnType("numeric(11, 2)");
            entity.Property(e => e.WhCode).HasMaxLength(50);
            entity.Property(e => e.WhName).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpWhtable>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("tmp_WHTable");

            entity.Property(e => e.DomesticBalanceQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Domestic_BalanceQty");
            entity.Property(e => e.DomesticInQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Domestic_InQty");
            entity.Property(e => e.DomesticOutQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Domestic_OutQty");
            entity.Property(e => e.ExportBalanceQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Export_BalanceQty");
            entity.Property(e => e.ExportInQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Export_InQty");
            entity.Property(e => e.ExportOutQty)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("Export_OutQty");
            entity.Property(e => e.ProductVariety).HasMaxLength(50);
        });

        modelBuilder.Entity<VInterfaceEventName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Interface_EventName");

            entity.Property(e => e.EventName).HasMaxLength(40);
            entity.Property(e => e.InterfaceTypeId).HasColumnName("InterfaceTypeID");
        });

        modelBuilder.Entity<VMultilang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MULTILANG");

            entity.Property(e => e.CtrlId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CTRL_ID");
            entity.Property(e => e.CtrlType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTRL_TYPE");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FormId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_ID");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.LangId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LANG_ID");
            entity.Property(e => e.LangWord)
                .HasMaxLength(500)
                .HasColumnName("LANG_WORD");
            entity.Property(e => e.MapId).HasColumnName("MAP_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Origin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGIN");
        });

        modelBuilder.Entity<VReceiveReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RECEIVE_REPORT");

            entity.Property(e => e.ChargeItem).HasColumnType("numeric(37, 5)");
            entity.Property(e => e.ChargeUnit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.ProductBarCode).HasMaxLength(100);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductLongName).HasMaxLength(320);
            entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReceivingNo).HasMaxLength(22);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StockDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfGoodsCode).HasMaxLength(50);
            entity.Property(e => e.UnitCode).HasMaxLength(50);
            entity.Property(e => e.UnitName).HasMaxLength(100);
        });

        modelBuilder.Entity<VStockbylocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_STOCKBYLOCATION");

            entity.Property(e => e.LocationCode).HasMaxLength(17);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductLongName).HasMaxLength(320);
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StorageLocation).HasMaxLength(4);
            entity.Property(e => e.ZoneCode).HasMaxLength(3);
            entity.Property(e => e.ZoneName).HasMaxLength(50);
        });

        modelBuilder.Entity<VThact660Export>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_THACT_660_Export");

            entity.Property(e => e.LineText).HasMaxLength(495);
        });

        modelBuilder.Entity<VThact670Export>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_THACT_670_Export");

            entity.Property(e => e.LineText).HasMaxLength(325);
        });

        modelBuilder.Entity<VThact690Export>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_THACT_690_Export");

            entity.Property(e => e.LineText).HasMaxLength(378);
        });

        modelBuilder.Entity<VThactInterfaceExportAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_THACT_Interface_Export_All");

            entity.Property(e => e.LineText).HasMaxLength(495);
        });

        modelBuilder.Entity<VwCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Customer");

            entity.Property(e => e.BusinessType).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactName1).HasMaxLength(100);
            entity.Property(e => e.ContactName2).HasMaxLength(100);
            entity.Property(e => e.ContactName3).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.CustomerAddress).HasMaxLength(200);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DefaultReceivingDate)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.Extension).HasMaxLength(10);
            entity.Property(e => e.FaxNo).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.OwnerCode).HasMaxLength(50);
            entity.Property(e => e.OwnerName).HasMaxLength(100);
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateOrProvince).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFinalDestination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FinalDestination");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.DisplayMember).HasMaxLength(352);
            entity.Property(e => e.FinalDestinationAddress).HasMaxLength(500);
            entity.Property(e => e.FinalDestinationCode).HasMaxLength(100);
            entity.Property(e => e.FinalDestinationId).HasColumnName("FinalDestinationID");
            entity.Property(e => e.FinalDestinationLongName).HasMaxLength(250);
            entity.Property(e => e.ShippingCustomerId).HasColumnName("ShippingCustomerID");
        });

        modelBuilder.Entity<VwProductControlVoid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProductControlVoid");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<VwProductControlVoidName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProductControlVoidName");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<VwProductControlVoidNameShort>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProductControlVoidNameShort");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<VwReportItemStatusGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ReportItemStatusGroup");

            entity.Property(e => e.ItemStatusId).HasColumnName("ItemStatusID");
            entity.Property(e => e.ItemStatusName).HasMaxLength(20);
            entity.Property(e => e.ReportItemStatusGroupCode)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ReportItemStatusGroupId).HasColumnName("ReportItemStatusGroupID");
            entity.Property(e => e.ReportItemStatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<VwReportItemStatusGroupMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ReportItemStatusGroupMapping");

            entity.Property(e => e.ClassificationCode).HasMaxLength(60);
            entity.Property(e => e.ClassificationName).HasMaxLength(100);
            entity.Property(e => e.ItemStatusId).HasColumnName("ItemStatusID");
            entity.Property(e => e.ItemStatusName).HasMaxLength(20);
            entity.Property(e => e.ReportItemStatusGroupCode)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ReportItemStatusGroupId).HasColumnName("ReportItemStatusGroupID");
            entity.Property(e => e.ReportItemStatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<VwShippingInfoSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShippingInfoSummary");

            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Eta).HasColumnName("ETA");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwStockActual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StockActual");

            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("dcid");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.PalletNo).HasMaxLength(20);
            entity.Property(e => e.ProductConditionId).HasColumnName("ProductConditionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.StockActual).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VwTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_test");

            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Eta).HasColumnName("ETA");
            entity.Property(e => e.ShipmentNo).HasMaxLength(22);
            entity.Property(e => e.ShipmentNoGroup).HasMaxLength(22);
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
        });
        modelBuilder.HasSequence("Seq_LoadingNo");
        modelBuilder.HasSequence("SeqShippingInstructionNo");
        modelBuilder.HasSequence("Seq_ShippingNoteNo");
        modelBuilder.HasSequence("Seq_StickerRunningNo");
        modelBuilder.HasSequence<decimal>("Seq_TruckBooking")
            .HasMin(1L)
            .HasMax(999999999L);

        OnModelCreatingPartial(modelBuilder);
    }


}
