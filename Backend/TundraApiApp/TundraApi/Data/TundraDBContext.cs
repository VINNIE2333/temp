using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TundraApi.Models;

namespace TundraApi.Data
{
    public partial class TundraDBContext : DbContext
    {
        public TundraDBContext()
        {
        }

        public TundraDBContext(DbContextOptions<TundraDBContext> options)
            : base(options)
        {
        }

        //Approve, Condition,FailureCode, PDMHistory, PMOffSeason,
        //UserWorkLists, wrworelation

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AlternatePart> AlternatePart { get; set; }
        public virtual DbSet<Approve> Approve { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<BudgetType> BudgetType { get; set; }
        public virtual DbSet<CloseRemark> CloseRemarks { get; set; }
        public virtual DbSet<Code> Codes { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<CostAccount> CostAccounts { get; set; }
        public virtual DbSet<Craft> Craft { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<Eqhistory> EQHistory { get; set; }
        public virtual DbSet<Eqtype> EQType { get; set; }
        public virtual DbSet<EquipComp> EquipComp { get; set; }
        public virtual DbSet<EquipCompHistory> EquipCompHistory { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentHistory> EquipmentHistory { get; set; }
        public virtual DbSet<FailureCode> FailureCode { get; set; }
        public virtual DbSet<InfTable> InfTable { get; set; }
        public virtual DbSet<InvCount> InvCount { get; set; }
        public virtual DbSet<InvCountDetail> InvCountDetail { get; set; }
        public virtual DbSet<InvLot> InvLot { get; set; }
        public virtual DbSet<InvMain> InvMain { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryTran> InventoryTrans { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemRequest> ItemRequest { get; set; }
        public virtual DbSet<ItemRequestKey> ItemRequestKeys { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<ItemVendor> ItemVendor { get; set; }
        public virtual DbSet<ItemsHistory> ItemsHistory { get; set; }
        public virtual DbSet<LaborType> LaborType { get; set; }
        public virtual DbSet<LabourTimeStamp> LabourTimeStamp { get; set; }
        public virtual DbSet<Link> Link { get; set; }
        public virtual DbSet<LocHistory> LocHistory { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationHistory> LocationHistory { get; set; }
        public virtual DbSet<LotMaster> LotMaster { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ManufacturerItem> ManufacturerItem { get; set; }
        public virtual DbSet<MaterialTransfer> MaterialTransfer { get; set; }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<MeasurementReading> MeasurementReading { get; set; }
        public virtual DbSet<Meter> Meter { get; set; }
        public virtual DbSet<MeterReading> MeterReading { get; set; }
        public virtual DbSet<Mileage> Mileage { get; set; }
        public virtual DbSet<NestedProc> NestedProc { get; set; }
        public virtual DbSet<Pdm> PDM { get; set; }
        public virtual DbSet<Pdmhistory> PDMHistory { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<Pm> PM { get; set; }
        public virtual DbSet<PmoffSeason> PMOffSeason { get; set; }
        public virtual DbSet<Po> PO { get; set; }
        public virtual DbSet<Pohistory> POHistory { get; set; }
        public virtual DbSet<Poline> POLine { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<RequestLine> RequestLine { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<RouteDetail> RouteDetail { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<SpecificationHistory> SpecificationHistory { get; set; }
        public virtual DbSet<StoreRoom> StoreRoom { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<TransBatch> TransBatch { get; set; }
        public virtual DbSet<UpdateScreenFieldAttr> UpdateScreenFieldAttrs { get; set; }
        public virtual DbSet<UserWorkList> UserWorkList { get; set; }
        public virtual DbSet<VActiveInventoryUsage> VActiveInventoryUsages { get; set; }
        public virtual DbSet<VAddrequesttopo> VAddrequesttopos { get; set; }
        public virtual DbSet<VAllMaxReading> VAllMaxReadings { get; set; }
        public virtual DbSet<VAllTransBatch> VAllTransBatches { get; set; }
        public virtual DbSet<VAvailableAttribute> VAvailableAttributes { get; set; }
        public virtual DbSet<VCheckRequestedItem> VCheckRequestedItems { get; set; }
        public virtual DbSet<VCompEquipmentList> VCompEquipmentLists { get; set; }
        public virtual DbSet<VCopyFieldsMapDetail> VCopyFieldsMapDetails { get; set; }
        public virtual DbSet<VCostAccount> VCostAccounts { get; set; }
        public virtual DbSet<VCostrecoveryApjournal> VCostrecoveryApjournals { get; set; }
        public virtual DbSet<VCsuciCostRecovery> VCsuciCostRecoveries { get; set; }
        public virtual DbSet<VCurrchangerate> VCurrchangerates { get; set; }
        public virtual DbSet<VCustomerRecentList> VCustomerRecentLists { get; set; }
        public virtual DbSet<VEmployee> VEmployees { get; set; }
        public virtual DbSet<VEmployeeRecentlist> VEmployeeRecentlists { get; set; }
        public virtual DbSet<VEmployeeUserRight> VEmployeeUserRights { get; set; }
        public virtual DbSet<VEmployeeVendor> VEmployeeVendors { get; set; }
        public virtual DbSet<VEqLastMeasurementReading> VEqLastMeasurementReadings { get; set; }
        public virtual DbSet<VEqLastMeterReading> VEqLastMeterReadings { get; set; }
        public virtual DbSet<VEquipmentDetail> VEquipmentDetails { get; set; }
        public virtual DbSet<VEquipmentPrint> VEquipmentPrints { get; set; }
        public virtual DbSet<VEquipmentRecentlist> VEquipmentRecentlists { get; set; }
        public virtual DbSet<VEquipmentUserWlist> VEquipmentUserWlists { get; set; }
        public virtual DbSet<VEquipmentdowntime1> VEquipmentdowntime1s { get; set; }
        public virtual DbSet<VEstMaterial> VEstMaterials { get; set; }
        public virtual DbSet<VEstService> VEstServices { get; set; }
        public virtual DbSet<VEstwolabour> VEstwolabours { get; set; }
        public virtual DbSet<VFundrecovery> VFundrecoveries { get; set; }
        public virtual DbSet<VGeneratepo> VGeneratepos { get; set; }
        public virtual DbSet<VHistorylog> VHistorylogs { get; set; }
        public virtual DbSet<VInfPo> VInfPos { get; set; }
        public virtual DbSet<VInfPoline> VInfPolines { get; set; }
        public virtual DbSet<VInfTableDetailed> VInfTableDetaileds { get; set; }
        public virtual DbSet<VInterfaceRecentList> VInterfaceRecentLists { get; set; }
        public virtual DbSet<VInvCountBatch> VInvCountBatches { get; set; }
        public virtual DbSet<VInvCountLine> VInvCountLines { get; set; }
        public virtual DbSet<VInvItem> VInvItems { get; set; }
        public virtual DbSet<VInventory> VInventories { get; set; }
        public virtual DbSet<VInventoryIssue> VInventoryIssues { get; set; }
        public virtual DbSet<VInventoryLot> VInventoryLots { get; set; }
        public virtual DbSet<VInventoryPosition> VInventoryPositions { get; set; }
        public virtual DbSet<VInventoryStoreroom> VInventoryStorerooms { get; set; }
        public virtual DbSet<VInventoryTransBatch> VInventoryTransBatches { get; set; }
        public virtual DbSet<VInventoryTransDetail> VInventoryTransDetails { get; set; }
        public virtual DbSet<VInventoryWithNonStockItem> VInventoryWithNonStockItems { get; set; }
        public virtual DbSet<VInventorymain> VInventorymains { get; set; }
        public virtual DbSet<VItemRecentlist> VItemRecentlists { get; set; }
        public virtual DbSet<VItemvendorlist> VItemvendorlists { get; set; }
        public virtual DbSet<VLabour> VLabours { get; set; }
        public virtual DbSet<VLastMeasurementReading> VLastMeasurementReadings { get; set; }
        public virtual DbSet<VLastMeasurementReadingDetail> VLastMeasurementReadingDetails { get; set; }
        public virtual DbSet<VLocation> VLocations { get; set; }
        public virtual DbSet<VLocationRecentlist> VLocationRecentlists { get; set; }
        public virtual DbSet<VMaxInterval> VMaxIntervals { get; set; }
        public virtual DbSet<VMaxMeterReading> VMaxMeterReadings { get; set; }
        public virtual DbSet<VMaxReading> VMaxReadings { get; set; }
        public virtual DbSet<VMaxReadingDate> VMaxReadingDates { get; set; }
        public virtual DbSet<VMaxReadingDateBack> VMaxReadingDateBacks { get; set; }
        public virtual DbSet<VMinInterval> VMinIntervals { get; set; }
        public virtual DbSet<VMtinventoryTransDetail> VMtinventoryTransDetails { get; set; }
        public virtual DbSet<VMttransactionDetail> VMttransactionDetails { get; set; }
        public virtual DbSet<VNestedProcedureDue> VNestedProcedureDues { get; set; }
        public virtual DbSet<VPdm> VPdms { get; set; }
        public virtual DbSet<VPdmemailnotification> VPdmemailnotifications { get; set; }
        public virtual DbSet<VPdmrecentlist> VPdmrecentlists { get; set; }
        public virtual DbSet<VPhasebalance> VPhasebalances { get; set; }
        public virtual DbSet<VPmPrint> VPmPrints { get; set; }
        public virtual DbSet<VPmdetail> VPmdetails { get; set; }
        public virtual DbSet<VPmequipment> VPmequipments { get; set; }
        public virtual DbSet<VPmrecentlist> VPmrecentlists { get; set; }
        public virtual DbSet<VPoPrint> VPoPrints { get; set; }
        public virtual DbSet<VPoh> VPohs { get; set; }
        public virtual DbSet<VPoinvoice> VPoinvoices { get; set; }
        public virtual DbSet<VPoinvoiceHeader> VPoinvoiceHeaders { get; set; }
        public virtual DbSet<VPorecentlist> VPorecentlists { get; set; }
        public virtual DbSet<VPrintFormObject> VPrintFormObjects { get; set; }
        public virtual DbSet<VProcPrint> VProcPrints { get; set; }
        public virtual DbSet<VProcRecentlist> VProcRecentlists { get; set; }
        public virtual DbSet<VProcedure> VProcedures { get; set; }
        public virtual DbSet<VProceduresDetail> VProceduresDetails { get; set; }
        public virtual DbSet<VProjectRecentList> VProjectRecentLists { get; set; }
        public virtual DbSet<VProjectReport> VProjectReports { get; set; }
        public virtual DbSet<VProjectcost> VProjectcosts { get; set; }
        public virtual DbSet<VReadyToPost> VReadyToPosts { get; set; }
        public virtual DbSet<VReceivingPoline> VReceivingPolines { get; set; }
        public virtual DbSet<VReportWithFieldAlias> VReportWithFieldAliases { get; set; }
        public virtual DbSet<VReqrecentList> VReqrecentLists { get; set; }
        public virtual DbSet<VRequestLine> VRequestLines { get; set; }
        public virtual DbSet<VRequisition> VRequisitions { get; set; }
        public virtual DbSet<VReservedItem> VReservedItems { get; set; }
        public virtual DbSet<VReturn> VReturns { get; set; }
        public virtual DbSet<VReturnDetail> VReturnDetails { get; set; }
        public virtual DbSet<VReturnvendorfrom> VReturnvendorfroms { get; set; }
        public virtual DbSet<VReturnvendorfromBack> VReturnvendorfromBacks { get; set; }
        public virtual DbSet<VRoutePrint> VRoutePrints { get; set; }
        public virtual DbSet<VRouteReading> VRouteReadings { get; set; }
        public virtual DbSet<VRouteRecentList> VRouteRecentLists { get; set; }
        public virtual DbSet<VScreenAttr> VScreenAttrs { get; set; }
        public virtual DbSet<VServiceTransBatch> VServiceTransBatches { get; set; }
        public virtual DbSet<VServiceTransDetail> VServiceTransDetails { get; set; }
        public virtual DbSet<VSpecification> VSpecifications { get; set; }
        public virtual DbSet<VStagingIssue> VStagingIssues { get; set; }
        public virtual DbSet<VStatusCodeWithDesc> VStatusCodeWithDescs { get; set; }
        public virtual DbSet<VStoreRoomRecentList> VStoreRoomRecentLists { get; set; }
        public virtual DbSet<VSubfolderList> VSubfolderLists { get; set; }
        public virtual DbSet<VTableList> VTableLists { get; set; }
        public virtual DbSet<VTeroLabelWithForeignKey> VTeroLabelWithForeignKeys { get; set; }
        public virtual DbSet<VTimeCardsRecentlist> VTimeCardsRecentlists { get; set; }
        public virtual DbSet<VUserGroup> VUserGroups { get; set; }
        public virtual DbSet<VVariablestest> VVariablestests { get; set; }
        public virtual DbSet<VVendor> VVendors { get; set; }
        public virtual DbSet<VVendorRecentlist> VVendorRecentlists { get; set; }
        public virtual DbSet<VViewlist> VViewlists { get; set; }
        public virtual DbSet<VWoCostAccount> VWoCostAccounts { get; set; }
        public virtual DbSet<VWoEstActTotalCost> VWoEstActTotalCosts { get; set; }
        public virtual DbSet<VWoandequip> VWoandequips { get; set; }
        public virtual DbSet<VWohistory> VWohistories { get; set; }
        public virtual DbSet<VWohistoryWo> VWohistoryWos { get; set; }
        public virtual DbSet<VWolabourDetail> VWolabourDetails { get; set; }
        public virtual DbSet<VWolabourSchedule> VWolabourSchedules { get; set; }
        public virtual DbSet<VWomat> VWomats { get; set; }
        public virtual DbSet<VWorecentlist> VWorecentlists { get; set; }
        public virtual DbSet<VWoreport> VWoreports { get; set; }
        public virtual DbSet<VWorkOrderDetail> VWorkOrderDetails { get; set; }
        public virtual DbSet<VWorkRequestRecentlist> VWorkRequestRecentlists { get; set; }
        public virtual DbSet<VWorkbytype> VWorkbytypes { get; set; }
        public virtual DbSet<VWorkorder> VWorkorders { get; set; }
        public virtual DbSet<VWorkrequest> VWorkrequests { get; set; }
        public virtual DbSet<VWostoreroom> VWostorerooms { get; set; }
        public virtual DbSet<VWropenwocount> VWropenwocounts { get; set; }
        public virtual DbSet<Vcontact> VContact { get; set; }
        public virtual DbSet<Vcostrecovery> Vcostrecoveries { get; set; }
        public virtual DbSet<Vcostrecoveryaccr> Vcostrecoveryaccrs { get; set; }
        public virtual DbSet<Vcostrecoverycombined> Vcostrecoverycombineds { get; set; }
        public virtual DbSet<Vcostrecoverydetail> Vcostrecoverydetails { get; set; }
        public virtual DbSet<Vcostrecoverydetailaccr> Vcostrecoverydetailaccrs { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorHistory> VendorHistory { get; set; }
        public virtual DbSet<VendorService> VendorService { get; set; }
        public virtual DbSet<Vwohistory1> Vwohistories1 { get; set; }
        public virtual DbSet<Vwohistoryaccr> Vwohistoryaccrs { get; set; }
        public virtual DbSet<Wohistory> WOHistory { get; set; }
        public virtual DbSet<Wolabour> WOLabour { get; set; }
        public virtual DbSet<Womaterial> WOMaterial { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkRequest> WorkRequest { get; set; }
        public virtual DbSet<WorkType> WorkType { get; set; }
        public virtual DbSet<Woservice> WOService { get; set; }
        public virtual DbSet<Wotask> WOTasks { get; set; }
        public virtual DbSet<Wotool> WOTools { get; set; }
        public virtual DbSet<Wrhistory> WRHistory { get; set; }
        public virtual DbSet<Wrworelation> WRWORelation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Account1)
                    .HasName("PK_Accounts_Account");

                entity.HasIndex(e => e.Inactive, "IX_Accounts_Inactive");

                entity.Property(e => e.Account1)
                    .HasMaxLength(60)
                    .HasColumnName("Account");

                entity.Property(e => e.Acct1).HasMaxLength(50);

                entity.Property(e => e.Acct2).HasMaxLength(50);

                entity.Property(e => e.Acct3).HasMaxLength(50);

                entity.Property(e => e.Acct4).HasMaxLength(50);

                entity.Property(e => e.Acct5).HasMaxLength(50);

                entity.Property(e => e.Acct6).HasMaxLength(50);

                entity.Property(e => e.Acct7).HasMaxLength(50);

                entity.Property(e => e.Acct8).HasMaxLength(50);

                entity.Property(e => e.Acct9).HasMaxLength(50);

                entity.Property(e => e.AcctId)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("AcctID");

                entity.Property(e => e.AcctNote).HasMaxLength(255);

                entity.Property(e => e.BudgetAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BudgetType).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentBalance).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(60);
            });

            modelBuilder.Entity<AlternatePart>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("AlternatePart");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlternateItemNum).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Approve>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Approve");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApproveCode).HasMaxLength(60);

                entity.Property(e => e.ApproveInOrder).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.OnePersonApprove).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RequiredNumber).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Budget_Counter");

                entity.ToTable("Budget");

                entity.Property(e => e.BudgetAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BudgetType).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.FiscalEndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalStartDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYear).HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<BudgetType>(entity =>
            {
                entity.HasKey(e => e.BudgetType1)
                    .HasName("PK_BudgetType_BudgetType");

                entity.ToTable("BudgetType");

                entity.Property(e => e.BudgetType1).HasColumnName("BudgetType");

                entity.Property(e => e.BudgetDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<CloseRemark>(entity =>
            {
                entity.HasKey(e => e.CloseRemCode)
                    .HasName("PK_CloseRemarks_CloseRemCode");

                entity.Property(e => e.CloseRemCode).HasMaxLength(60);

                entity.Property(e => e.CloseRemShortText).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RemarkType).HasMaxLength(10);
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.HasKey(e => new { e.Tfield, e.Tcode })
                    .HasName("PK_Codes_tfield");

                entity.Property(e => e.Tfield)
                    .HasMaxLength(20)
                    .HasColumnName("tfield");

                entity.Property(e => e.Tcode)
                    .HasMaxLength(60)
                    .HasColumnName("tcode");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tcode1)
                    .HasMaxLength(60)
                    .HasColumnName("tcode1");

                entity.Property(e => e.Tcode2)
                    .HasMaxLength(60)
                    .HasColumnName("tcode2");

                entity.Property(e => e.Tdesc)
                    .HasMaxLength(255)
                    .HasColumnName("tdesc");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Condition");

                entity.Property(e => e.ConditionCode).HasMaxLength(60);

                entity.Property(e => e.ConditionDescription).HasMaxLength(200);

                entity.Property(e => e.ConditionValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CostAccount>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_CostAccounts_Counter")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.LinkType, e.LinkId }, "IX_CostAccounts_LinkId")
                    .IsClustered();

                entity.Property(e => e.Account).HasMaxLength(60);

                entity.Property(e => e.CostAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostPercent).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Keeppercent)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("keeppercent");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Craft>(entity =>
            {
                entity.HasKey(e => e.Craft1)
                    .HasName("PK_Craft_Craft");

                entity.ToTable("Craft");

                entity.Property(e => e.Craft1)
                    .HasMaxLength(60)
                    .HasColumnName("Craft");

                entity.Property(e => e.CraftDesc).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_Employee_Empid");

                entity.ToTable("Employee");

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Accepted).HasMaxLength(10);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpGroup).HasMaxLength(60);

                entity.Property(e => e.EmpTitle).HasMaxLength(60);

                entity.Property(e => e.Employee1)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Employee")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Emppword).HasMaxLength(40);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Lab1)
                    .HasMaxLength(60)
                    .HasColumnName("lab1");

                entity.Property(e => e.Lab2)
                    .HasMaxLength(60)
                    .HasColumnName("lab2");

                entity.Property(e => e.Lab3)
                    .HasMaxLength(60)
                    .HasColumnName("lab3");

                entity.Property(e => e.Lab4)
                    .HasMaxLength(60)
                    .HasColumnName("lab4");

                entity.Property(e => e.Lab5).HasMaxLength(60);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcid)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("LCID");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StandardRate).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Userflags)
                    .HasMaxLength(10)
                    .HasColumnName("userflags");

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_EmployeeHistory_Empid");

                entity.ToTable("EmployeeHistory");

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Accepted).HasMaxLength(10);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpGroup).HasMaxLength(60);

                entity.Property(e => e.EmpTitle).HasMaxLength(60);

                entity.Property(e => e.Employee).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Emppword).HasMaxLength(40);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Lab1)
                    .HasMaxLength(60)
                    .HasColumnName("lab1");

                entity.Property(e => e.Lab2)
                    .HasMaxLength(60)
                    .HasColumnName("lab2");

                entity.Property(e => e.Lab3)
                    .HasMaxLength(60)
                    .HasColumnName("lab3");

                entity.Property(e => e.Lab4)
                    .HasMaxLength(60)
                    .HasColumnName("lab4");

                entity.Property(e => e.Lab5)
                    .HasMaxLength(60)
                    .HasColumnName("lab5");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcid)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("LCID");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StandardRate).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Userflags)
                    .HasMaxLength(10)
                    .HasColumnName("userflags");

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<Eqhistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_EQHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("EQHistory");

                entity.HasIndex(e => e.Equipment, "IX_EQHistory_Equipment")
                    .IsClustered();

                entity.Property(e => e.AccountNew).HasMaxLength(60);

                entity.Property(e => e.AccountOld).HasMaxLength(60);

                entity.Property(e => e.DivisionNew).HasMaxLength(60);

                entity.Property(e => e.DivisionOld).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.LocationNew).HasMaxLength(60);

                entity.Property(e => e.LocationOld).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OperatorNew).HasMaxLength(60);

                entity.Property(e => e.OperatorOld).HasMaxLength(60);

                entity.Property(e => e.ParentNew).HasMaxLength(60);

                entity.Property(e => e.ParentOld).HasMaxLength(60);

                entity.Property(e => e.StatusNew).HasMaxLength(60);

                entity.Property(e => e.StatusOld).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Eqtype>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("EQType");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eqcode)
                    .HasMaxLength(60)
                    .HasColumnName("EQCode");

                entity.Property(e => e.Eqlevel)
                    .HasMaxLength(2)
                    .HasColumnName("EQLevel");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentCode).HasMaxLength(60);
            });

            modelBuilder.Entity<EquipComp>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("EquipComp");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<EquipCompHistory>(entity =>
            {
                entity.HasKey(e => new { e.Equipment, e.ItemNum })
                    .HasName("PK_EquipCompHistory_ItemNum");

                entity.ToTable("EquipCompHistory");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.Equipment1)
                    .HasName("PK_Equipment_Equipment");

                entity.HasIndex(e => e.Division, "IX_Equipment_Division");

                entity.HasIndex(e => e.Hazardous, "IX_Equipment_Haz");

                entity.HasIndex(e => e.Inactive, "IX_Equipment_Inactive");

                entity.HasIndex(e => e.Location, "IX_Equipment_Location");

                entity.HasIndex(e => e.Equipment1, "_dta_index_Equipment_5_1504060444__K1_2");

                entity.Property(e => e.Equipment1)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EquipmentHistory>(entity =>
            {
                entity.HasKey(e => e.Equipment)
                    .HasName("PK_EquipmentHistory_Equipment");

                entity.ToTable("EquipmentHistory");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FailureCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FailureCode");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.FailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("FailureCode");

                entity.Property(e => e.FailureLevel).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ParentCode).HasMaxLength(60);
            });

            modelBuilder.Entity<InfTable>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("InfTable");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ExportPrimaryKey).HasMaxLength(60);

                entity.Property(e => e.Exportrestriction)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exportrestriction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importtype)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("importtype");

                entity.Property(e => e.InterfaceModule).HasMaxLength(60);

                entity.Property(e => e.InterfaceName)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InterfaceType).HasMaxLength(60);

                entity.Property(e => e.KeyFieldToTrigger).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Parenttable)
                    .HasMaxLength(50)
                    .HasColumnName("parenttable");

                entity.Property(e => e.Parenttablekeyfield)
                    .HasMaxLength(50)
                    .HasColumnName("parenttablekeyfield");

                entity.Property(e => e.SourceTable).HasMaxLength(60);

                entity.Property(e => e.Tablefkfield)
                    .HasMaxLength(50)
                    .HasColumnName("tablefkfield");

                entity.Property(e => e.TagName).HasMaxLength(60);
            });

            modelBuilder.Entity<InvCount>(entity =>
            {
                entity.HasKey(e => e.BatchNum);

                entity.ToTable("InvCount");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Createdby).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QueryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("QueryID");

                entity.Property(e => e.RequiredMatches).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('NEW')");

                entity.Property(e => e.Storeroom).HasMaxLength(60);
            });

            modelBuilder.Entity<InvCountDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("InvCountDetail");

                entity.HasIndex(e => e.BatchNum, "IX_InvCountDetail_BatchNum");

                entity.HasIndex(e => e.CountTime, "IX_InvCountDetail_CountTime");

                entity.HasIndex(e => e.LotCounter, "IX_InvCountDetail_LotCounter");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Count)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CountTime).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Posted).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<InvLot>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("InvLot");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastLotNum).HasMaxLength(60);

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("position")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);
            });

            modelBuilder.Entity<InvMain>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("InvMain");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Defmanufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("defmanufacturer");

                entity.Property(e => e.Defposition)
                    .HasMaxLength(60)
                    .HasColumnName("defposition")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.Defvendor)
                    .HasMaxLength(60)
                    .HasColumnName("defvendor");

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.StoreRoom).HasMaxLength(60);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => new { e.ItemNum, e.StoreRoom });

                entity.ToTable("Inventory");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Account).HasMaxLength(60);

                entity.Property(e => e.Aisle).HasMaxLength(30);

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BackOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BinNum).HasMaxLength(30);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvRowNum).HasMaxLength(30);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.LotPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);
            });

            modelBuilder.Entity<InventoryTran>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.HasIndex(e => e.Counter, "IX_InventoryTrans");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Condition)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConditionCode).HasMaxLength(60);

                entity.Property(e => e.Conversion)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("numeric(18, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueTo).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Mtnum)
                    .HasMaxLength(60)
                    .HasColumnName("MTNum");

                entity.Property(e => e.OtherLotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OtherLotNum).HasMaxLength(60);

                entity.Property(e => e.OtherPosition).HasMaxLength(60);

                entity.Property(e => e.OtherStoreRoom).HasMaxLength(60);

                entity.Property(e => e.OtherTransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.Position).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RepairShop).HasMaxLength(60);

                entity.Property(e => e.ReturnVendor).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.StoreroomQty).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("InvoiceDetail");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(60);

                entity.Property(e => e.InvoiceQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<InvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo)
                    .HasName("PK_InvoiceHeader_1");

                entity.ToTable("InvoiceHeader");

                entity.Property(e => e.InvoiceNo).HasMaxLength(60);

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("numeric(18, 10)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(60)
                    .HasColumnName("PONumber");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorInvoiceNo).HasMaxLength(60);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ItemNum)
                    .HasName("PK_Items_ItemNum");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuePrice)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ManufPartNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.PurchasePrice)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ShortDesc).HasMaxLength(255);

                entity.Property(e => e.Stocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SubType0).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.Tax1Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax1Exempt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax2Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax2Exempt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.Warranty).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<ItemRequest>(entity =>
            {
                entity.HasKey(e => e.ReqNum)
                    .HasName("PK_ItemRequest_ReqNum");

                entity.ToTable("ItemRequest");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ActualCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AuthorizationDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationId).HasMaxLength(60);

                entity.Property(e => e.AuthorizationSignature).HasMaxLength(100);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CredentialStatus).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeptApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.DeptApprovalId).HasMaxLength(60);

                entity.Property(e => e.DeptSignature).HasMaxLength(100);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DivisionApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionApprovalId).HasMaxLength(60);

                entity.Property(e => e.DivisionSignature).HasMaxLength(100);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FacultyUse).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsKeyRequest).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.RecipientEndAccess).HasColumnType("datetime");

                entity.Property(e => e.RecipientFirstName).HasMaxLength(60);

                entity.Property(e => e.RecipientId).HasMaxLength(60);

                entity.Property(e => e.RecipientLastName).HasMaxLength(60);

                entity.Property(e => e.RecipientLocation).HasMaxLength(255);

                entity.Property(e => e.RecipientStartAccess).HasColumnType("datetime");

                entity.Property(e => e.RecipientSupervisor).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.Rq1)
                    .HasMaxLength(60)
                    .HasColumnName("rq1");

                entity.Property(e => e.Rq10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq10");

                entity.Property(e => e.Rq2)
                    .HasMaxLength(60)
                    .HasColumnName("rq2");

                entity.Property(e => e.Rq3)
                    .HasMaxLength(60)
                    .HasColumnName("rq3");

                entity.Property(e => e.Rq4)
                    .HasMaxLength(60)
                    .HasColumnName("rq4");

                entity.Property(e => e.Rq5)
                    .HasMaxLength(60)
                    .HasColumnName("rq5");

                entity.Property(e => e.Rq6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq6");

                entity.Property(e => e.Rq7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq7");

                entity.Property(e => e.Rq8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq8");

                entity.Property(e => e.Rq9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq9");

                entity.Property(e => e.Rtsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("RTSDate");

                entity.Property(e => e.ShipAddress1).HasMaxLength(100);

                entity.Property(e => e.ShipAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipAddress3).HasMaxLength(100);

                entity.Property(e => e.ShipPhone).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.StatusFlags).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);
            });

            modelBuilder.Entity<ItemRequestKey>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_ItemRequestKeys_Counter")
                    .IsClustered(false);

                entity.HasIndex(e => e.ReqNum, "IX_ItemRequestKeys_ReqNum")
                    .IsClustered();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExteriaDoor).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InteriaDoor).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReqNum).HasMaxLength(60);
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("ItemType");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemCode).HasMaxLength(60);

                entity.Property(e => e.ItemLevel).HasMaxLength(1);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ParentCode).HasMaxLength(60);
            });

            modelBuilder.Entity<ItemVendor>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("ItemVendor");

                entity.HasIndex(e => e.Vendor, "IX_ItemVendor_Vendor");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.Conversion)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationDate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.Discount).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.IsDefault)
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifyDate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<ItemsHistory>(entity =>
            {
                entity.HasKey(e => e.ItemNum)
                    .HasName("PK_ItemsHistory_ItemNum");

                entity.ToTable("ItemsHistory");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Fixprice)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("FIXPRICE");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'FIFO')");

                entity.Property(e => e.IssuePrice)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'AVGPRICE')");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ManufPartNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Purchaseprice)
                    .HasMaxLength(60)
                    .HasColumnName("PURCHASEPRICE")
                    .HasDefaultValueSql("(N'QUOTEDPRICE')");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ShortDesc).HasMaxLength(255);

                entity.Property(e => e.Stocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SubType0).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.Tax1Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax1Exempt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax2Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax2Exempt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.Warranty).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LaborType>(entity =>
            {
                entity.HasKey(e => e.LabType)
                    .HasName("PK_LaborType_LabType");

                entity.ToTable("LaborType");

                entity.Property(e => e.LabType).HasMaxLength(60);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Scale)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<LabourTimeStamp>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("LabourTimeStamp");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Batchnum).HasColumnName("batchnum");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Empid)
                    .HasMaxLength(60)
                    .HasColumnName("empid");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("endtime");

                entity.Property(e => e.Labtype)
                    .HasMaxLength(20)
                    .HasColumnName("labtype");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("starttime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("wonum");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Links_Counter")
                    .IsClustered(false);

                entity.HasIndex(e => e.DocId, "IX_Links_DocID");

                entity.HasIndex(e => e.Wwmodule, "IX_Links_wwmodule");

                entity.HasIndex(e => e.Wwrecord, "IX_Links_wwrecord");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DocId)
                    .HasMaxLength(20)
                    .HasColumnName("DocID");

                entity.Property(e => e.LinkTitle).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(255)
                    .HasColumnName("LinkURL");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Subfolder).HasMaxLength(100);

                entity.Property(e => e.Wwmodule)
                    .HasMaxLength(30)
                    .HasColumnName("wwmodule");

                entity.Property(e => e.Wwrecord)
                    .HasMaxLength(60)
                    .HasColumnName("wwrecord");
            });

            modelBuilder.Entity<LocHistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_LocHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("LocHistory");

                entity.HasIndex(e => e.Location, "IX_LocHistory_Location")
                    .IsClustered();

                entity.Property(e => e.DivisionNew).HasMaxLength(60);

                entity.Property(e => e.DivisionOld).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ParentNew).HasMaxLength(60);

                entity.Property(e => e.ParentOld).HasMaxLength(60);

                entity.Property(e => e.StatusNew).HasMaxLength(60);

                entity.Property(e => e.StatusOld).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.Location1)
                    .HasName("PK_Location_Location");

                entity.ToTable("Location");

                entity.Property(e => e.Location1)
                    .HasMaxLength(60)
                    .HasColumnName("Location");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Afe)
                    .HasMaxLength(60)
                    .HasColumnName("AFE");

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(60)
                    .HasColumnName("contact1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(60)
                    .HasColumnName("contact2");

                entity.Property(e => e.Contact3)
                    .HasMaxLength(60)
                    .HasColumnName("contact3");

                entity.Property(e => e.Contact4)
                    .HasMaxLength(60)
                    .HasColumnName("contact4");

                entity.Property(e => e.Contact5)
                    .HasMaxLength(60)
                    .HasColumnName("contact5");

                entity.Property(e => e.Contact6)
                    .HasMaxLength(60)
                    .HasColumnName("contact6");

                entity.Property(e => e.ContactName).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.District1).HasMaxLength(60);

                entity.Property(e => e.District2).HasMaxLength(60);

                entity.Property(e => e.District3).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Loc1)
                    .HasMaxLength(60)
                    .HasColumnName("loc1");

                entity.Property(e => e.Loc2)
                    .HasMaxLength(60)
                    .HasColumnName("loc2");

                entity.Property(e => e.Loc3)
                    .HasMaxLength(60)
                    .HasColumnName("loc3");

                entity.Property(e => e.Loc4)
                    .HasMaxLength(60)
                    .HasColumnName("loc4");

                entity.Property(e => e.LocType).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifyDate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Note1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note10).HasMaxLength(100);

                entity.Property(e => e.Note2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note4).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note5).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9).HasMaxLength(100);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.Tax1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax1");

                entity.Property(e => e.Tax2)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax2");

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LocationHistory>(entity =>
            {
                entity.HasKey(e => e.Location)
                    .HasName("PK_LocationHistory_Location");

                entity.ToTable("LocationHistory");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(60)
                    .HasColumnName("contact1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(60)
                    .HasColumnName("contact2");

                entity.Property(e => e.Contact3)
                    .HasMaxLength(60)
                    .HasColumnName("contact3");

                entity.Property(e => e.Contact4)
                    .HasMaxLength(60)
                    .HasColumnName("contact4");

                entity.Property(e => e.Contact5)
                    .HasMaxLength(60)
                    .HasColumnName("contact5");

                entity.Property(e => e.Contact6)
                    .HasMaxLength(60)
                    .HasColumnName("contact6");

                entity.Property(e => e.ContactName).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.District1).HasMaxLength(60);

                entity.Property(e => e.District2).HasMaxLength(60);

                entity.Property(e => e.District3).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Loc1)
                    .HasMaxLength(60)
                    .HasColumnName("loc1");

                entity.Property(e => e.Loc2)
                    .HasMaxLength(60)
                    .HasColumnName("loc2");

                entity.Property(e => e.Loc3)
                    .HasMaxLength(60)
                    .HasColumnName("loc3");

                entity.Property(e => e.Loc4)
                    .HasMaxLength(60)
                    .HasColumnName("loc4");

                entity.Property(e => e.LocType).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifyDate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Note1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note10).HasMaxLength(100);

                entity.Property(e => e.Note2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note4).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note5).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9).HasMaxLength(100);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.Tax1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax1");

                entity.Property(e => e.Tax2)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax2");

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LotMaster>(entity =>
            {
                entity.HasKey(e => e.LotNum);

                entity.ToTable("LotMaster");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LotType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'ADJUSTMENT')");

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorLot).HasMaxLength(60);

                entity.Property(e => e.VirtualQuantity).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK_Manufacturer_CompanyCode");

                entity.ToTable("Manufacturer");

                entity.Property(e => e.CompanyCode).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MName)
                    .HasMaxLength(100)
                    .HasColumnName("mName");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<ManufacturerItem>(entity =>
            {
                entity.HasKey(e => new { e.Manufacturer, e.ItemNum })
                    .HasName("PK_ManufacturerItem_ItemNum");

                entity.ToTable("ManufacturerItem");

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.ManufPartNum).HasMaxLength(60);
            });

            modelBuilder.Entity<MaterialTransfer>(entity =>
            {
                entity.HasKey(e => e.Mtnum);

                entity.ToTable("MaterialTransfer");

                entity.Property(e => e.Mtnum)
                    .HasMaxLength(60)
                    .HasColumnName("MTNum");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationCoding).HasMaxLength(60);

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromLocation).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.MtslipNum)
                    .HasMaxLength(60)
                    .HasColumnName("MTSlipNum");

                entity.Property(e => e.ProdPeriod).HasMaxLength(10);

                entity.Property(e => e.SourceCoding).HasMaxLength(60);

                entity.Property(e => e.ToLocation).HasMaxLength(60);
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Measurement_Counter")
                    .IsClustered(false);

                entity.ToTable("Measurement");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.MeasUnit).HasMaxLength(60);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ValueType).HasMaxLength(60);
            });

            modelBuilder.Entity<MeasurementReading>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_SpecReading_Counter")
                    .IsClustered(false);

                entity.ToTable("MeasurementReading");

                entity.HasIndex(e => new { e.LinkType, e.LinkId }, "IX_SpecReading")
                    .IsClustered();

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("dirtylog")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpId).HasMaxLength(60);

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);

                entity.Property(e => e.MeasureDate).HasColumnType("datetime");

                entity.Property(e => e.MeasureReading).HasMaxLength(50);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Meter>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Meter_Counter")
                    .IsClustered(false);

                entity.ToTable("Meter");

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Cumulative).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.FudgeFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterType).HasMaxLength(60);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PrimaryMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ResetMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rollover).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Template).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);
            });

            modelBuilder.Entity<MeterReading>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_MeterRead_Counter")
                    .IsClustered(false);

                entity.ToTable("MeterReading");

                entity.HasIndex(e => e.Equipment, "IX_MeterRead_Equipment")
                    .IsClustered();

                entity.HasIndex(e => e.WoNum, "IX_MeterRead_WoNum");

                entity.HasIndex(e => e.Equipment, "_dta_index_MeterReading_5_1453964256__K2_3_4_7");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.MIncrement)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("M_Increment");

                entity.Property(e => e.MeterDate).HasColumnType("datetime");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterOffset).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterReading1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("MeterReading");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Mileage>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Mileage");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Distance).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FromAddress).HasMaxLength(255);

                entity.Property(e => e.FromLocation).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LabourCounter).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType).HasMaxLength(60);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RoundTrip).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ToAddress).HasMaxLength(255);

                entity.Property(e => e.ToLocation).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<NestedProc>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_NestedProc_Counter")
                    .IsClustered(false);

                entity.ToTable("NestedProc");

                entity.HasIndex(e => e.PmNum, "IX_NestedProc_PmNum")
                    .IsClustered();

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.IntervalDue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.Pmsequence)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PMSequence");

                entity.Property(e => e.ProcNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Pdm>(entity =>
            {
                entity.HasKey(e => e.Pdmnum)
                    .HasName("PK_PDM_PDMNum");

                entity.ToTable("PDM");

                entity.Property(e => e.Pdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDMNum");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.HighLimit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HighLimitEmail).HasMaxLength(60);

                entity.Property(e => e.HighLimitProc).HasMaxLength(60);

                entity.Property(e => e.HighWarning).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HighWarningEmail).HasMaxLength(60);

                entity.Property(e => e.HighWarningProc).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.LowLimit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LowLimitEmail).HasMaxLength(60);

                entity.Property(e => e.LowLimitProc).HasMaxLength(60);

                entity.Property(e => e.LowWarning).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LowWarningEmail).HasMaxLength(60);

                entity.Property(e => e.LowWarningProc).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pdm1)
                    .HasMaxLength(60)
                    .HasColumnName("PDM1");

                entity.Property(e => e.Pdm10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM10");

                entity.Property(e => e.Pdm2)
                    .HasMaxLength(60)
                    .HasColumnName("PDM2");

                entity.Property(e => e.Pdm3)
                    .HasMaxLength(60)
                    .HasColumnName("PDM3");

                entity.Property(e => e.Pdm4)
                    .HasMaxLength(60)
                    .HasColumnName("PDM4");

                entity.Property(e => e.Pdm5)
                    .HasMaxLength(60)
                    .HasColumnName("PDM5");

                entity.Property(e => e.Pdm6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM6");

                entity.Property(e => e.Pdm7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM7");

                entity.Property(e => e.Pdm8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM8");

                entity.Property(e => e.Pdm9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM9");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");
            });

            modelBuilder.Entity<Pdmhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDMHistory");

                entity.Property(e => e.ActionTriggered).HasMaxLength(20);

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeasurementReading).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Pdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDMNum");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Phase_Counter")
                    .IsClustered(false);

                entity.ToTable("Phase");

                entity.HasIndex(e => new { e.ProjectId, e.Phase1 }, "IX_Phase_Phase")
                    .IsClustered();

                entity.Property(e => e.Budget).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Phase1)
                    .HasMaxLength(60)
                    .HasColumnName("Phase");

                entity.Property(e => e.PhaseOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pm>(entity =>
            {
                entity.HasKey(e => e.PmNum)
                    .HasName("PK_PM_PmNum");

                entity.ToTable("PM");

                entity.HasIndex(e => e.Equipment, "IX_PM_Equipment");

                entity.HasIndex(e => e.Location, "IX_PM_Location");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.AvgUsage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IntervalUnit).HasMaxLength(60);

                entity.Property(e => e.IsLocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPMDate");

                entity.Property(e => e.LastPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading");

                entity.Property(e => e.LastPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading2");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MeterInterval).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterInterval2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterName2).HasMaxLength(60);

                entity.Property(e => e.MeterRange).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterRange2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NestedPm)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("NestedPM");

                entity.Property(e => e.NextDueDate).HasColumnType("datetime");

                entity.Property(e => e.NextPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading");

                entity.Property(e => e.NextPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading2");

                entity.Property(e => e.OnDue).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OverrideDate).HasColumnType("datetime");

                entity.Property(e => e.Pm1)
                    .HasMaxLength(60)
                    .HasColumnName("pm1");

                entity.Property(e => e.Pm2)
                    .HasMaxLength(60)
                    .HasColumnName("pm2");

                entity.Property(e => e.Pm3).HasColumnName("pm3");

                entity.Property(e => e.Pm4).HasColumnName("pm4");

                entity.Property(e => e.PmgenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMGenDate");

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Seasonal).HasComputedColumnSql("([dbo].[DetermineSeasonal]([PMnum]))", false);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<PmoffSeason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMOffSeason");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.EndDate).HasMaxLength(5);

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Pmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PMNum");

                entity.Property(e => e.StartDate).HasMaxLength(5);
            });

            modelBuilder.Entity<Po>(entity =>
            {
                entity.HasKey(e => e.PoNum)
                    .HasName("PK_PO_PoNum");

                entity.ToTable("PO");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BillAddress1).HasMaxLength(100);

                entity.Property(e => e.BillAddress2).HasMaxLength(100);

                entity.Property(e => e.BillAddress3).HasMaxLength(100);

                entity.Property(e => e.BillAddress4).HasMaxLength(100);

                entity.Property(e => e.BillAddress5).HasMaxLength(100);

                entity.Property(e => e.BillPhone).HasMaxLength(30);

                entity.Property(e => e.BillTo).HasMaxLength(60);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("numeric(18, 10)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Freight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OpenPo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenPO");

                entity.Property(e => e.Po1)
                    .HasMaxLength(60)
                    .HasColumnName("PO1");

                entity.Property(e => e.Po10)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po10");

                entity.Property(e => e.Po2)
                    .HasMaxLength(60)
                    .HasColumnName("PO2");

                entity.Property(e => e.Po3)
                    .HasMaxLength(60)
                    .HasColumnName("PO3");

                entity.Property(e => e.Po4)
                    .HasMaxLength(60)
                    .HasColumnName("PO4");

                entity.Property(e => e.Po9)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po9");

                entity.Property(e => e.PoTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Potype)
                    .HasMaxLength(60)
                    .HasColumnName("POType");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1).HasMaxLength(100);

                entity.Property(e => e.ShipAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipAddress3).HasMaxLength(100);

                entity.Property(e => e.ShipAddress4).HasMaxLength(100);

                entity.Property(e => e.ShipAddress5).HasMaxLength(100);

                entity.Property(e => e.ShipPhone).HasMaxLength(30);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TermsCode).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);
            });

            modelBuilder.Entity<Pohistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_POHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("POHistory");

                entity.HasIndex(e => e.PoNum, "IX_POHistory_PoNum");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Statuscode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("statuscode");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Poline>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_POLine_Counter")
                    .IsClustered(false);

                entity.ToTable("POLine");

                entity.HasIndex(e => e.PoNum, "IX_POLine_PoNum")
                    .IsClustered();

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("numeric(18, 10)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NewEquip).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenFlag)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OrderQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized)
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.HasKey(e => e.ProcNum)
                    .HasName("PK_Procedures_ProcNum");

                entity.HasIndex(e => e.Equipment, "IX_Procedures_Equipment");

                entity.HasIndex(e => e.Location, "IX_Procedures_Location");

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pr1)
                    .HasMaxLength(60)
                    .HasColumnName("pr1");

                entity.Property(e => e.Pr2)
                    .HasMaxLength(60)
                    .HasColumnName("pr2");

                entity.Property(e => e.Pr3)
                    .HasMaxLength(60)
                    .HasColumnName("pr3");

                entity.Property(e => e.Pr4)
                    .HasMaxLength(60)
                    .HasColumnName("pr4");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<RequestLine>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_RequestLine_Counter")
                    .IsClustered(false);

                entity.ToTable("RequestLine");

                entity.HasIndex(e => e.ReqNum, "IX_RequestLine_ReqNum")
                    .IsClustered();

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ipa)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("IPA");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsKeyRequest).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.RequestQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReturnedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusFlags).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);
            });

            modelBuilder.Entity<Models.Route>(entity =>
            {
                entity.HasKey(e => e.RouteName)
                    .HasName("PK_Templates_RouteName");

                entity.ToTable("Route");

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.ChangeRemark).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RouteDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<RouteDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("RouteDetail");

                entity.HasIndex(e => e.Counter, "IX_RouteDetail");

                entity.HasIndex(e => e.RouteName, "IX_RouteDetail_RouteName");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdOrder).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('equipment')");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ReadingType).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.SpecTag).HasMaxLength(60);

                entity.Property(e => e.TagOrder).HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Schedule_Counter")
                    .IsClustered(false);

                entity.ToTable("Schedule");

                entity.HasIndex(e => e.TransDate, "IX_Schedule_TransDate");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityId)
                    .HasMaxLength(50)
                    .HasColumnName("ActivityID");

                entity.Property(e => e.ActivityType).HasMaxLength(60);

                entity.Property(e => e.ChangeRemark).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceRule).HasMaxLength(255);

                entity.Property(e => e.ResourceId)
                    .HasMaxLength(50)
                    .HasColumnName("ResourceID");

                entity.Property(e => e.ResourceType).HasMaxLength(60);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Specification_Counter")
                    .IsClustered(false);

                entity.ToTable("Specification");

                entity.HasIndex(e => new { e.LinkType, e.LinkId }, "IX_Specification_LinkId")
                    .IsClustered();

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddToLongDescription).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddToShortDescription).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IsTemplate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.MeasUnit).HasMaxLength(60);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderBy).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SpecTag).HasMaxLength(60);

                entity.Property(e => e.SpecValue).HasMaxLength(255);
            });

            modelBuilder.Entity<SpecificationHistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_SpecificationHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("SpecificationHistory");

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cumulative).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FudgeFactor).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.IdOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.IsTemplate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.MeasUnit).HasMaxLength(60);

                entity.Property(e => e.MeterType).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rollover).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SpecTag).HasMaxLength(60);

                entity.Property(e => e.SpecValue).HasMaxLength(255);

                entity.Property(e => e.TagOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Template).HasMaxLength(60);
            });

            modelBuilder.Entity<StoreRoom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StoreRoom");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(60)
                    .HasColumnName("contact1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(60)
                    .HasColumnName("contact2");

                entity.Property(e => e.Contact3)
                    .HasMaxLength(60)
                    .HasColumnName("contact3");

                entity.Property(e => e.Contact4)
                    .HasMaxLength(60)
                    .HasColumnName("contact4");

                entity.Property(e => e.Contact5)
                    .HasMaxLength(60)
                    .HasColumnName("contact5");

                entity.Property(e => e.Contact6)
                    .HasMaxLength(60)
                    .HasColumnName("contact6");

                entity.Property(e => e.ContactName).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.District1).HasMaxLength(60);

                entity.Property(e => e.District2).HasMaxLength(60);

                entity.Property(e => e.District3).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Loc1)
                    .HasMaxLength(60)
                    .HasColumnName("loc1");

                entity.Property(e => e.Loc2)
                    .HasMaxLength(60)
                    .HasColumnName("loc2");

                entity.Property(e => e.Loc3)
                    .HasMaxLength(60)
                    .HasColumnName("loc3");

                entity.Property(e => e.Loc4)
                    .HasMaxLength(60)
                    .HasColumnName("loc4");

                entity.Property(e => e.LocType).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifyDate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Note1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note10).HasMaxLength(100);

                entity.Property(e => e.Note2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note4).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note5).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9).HasMaxLength(100);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StoreRoom1)
                    .HasMaxLength(60)
                    .HasColumnName("StoreRoom");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.Tax1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax1");

                entity.Property(e => e.Tax2)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax2");

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.CodeType })
                    .HasName("PK_Terms_Code");

                entity.Property(e => e.Code).HasMaxLength(60);

                entity.Property(e => e.CodeType).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultCode).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransBatch>(entity =>
            {
                entity.HasKey(e => e.BatchNum);

                entity.ToTable("TransBatch");

                entity.HasIndex(e => e.Wonum, "IX_Transbatch_Wonum");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvCountBatchNum).HasMaxLength(60);

                entity.Property(e => e.Invoiced).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.Itemnum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReceiptLotNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<UpdateScreenFieldAttr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("update ScreenFieldAttr ");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserWorkList>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_UserWorkList_Counter")
                    .IsClustered(false);

                entity.ToTable("UserWorkList");

                entity.HasIndex(e => e.UserId, "IX_UserWorkList");

                entity.HasIndex(e => e.TransDate, "IX_UserWorkList_Transdate");

                entity.HasIndex(e => new { e.UserId, e.LinkModule, e.LinkType }, "IX_UserWorkList_multi");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkModule).HasMaxLength(20);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(60);
            });

            modelBuilder.Entity<VActiveInventoryUsage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ActiveInventoryUsage");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reserved).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Store).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VAddrequesttopo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_addrequesttopo");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");

                entity.Property(e => e.Wotype)
                    .HasMaxLength(60)
                    .HasColumnName("WOType");
            });

            modelBuilder.Entity<VAllMaxReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AllMaxReading");

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cumulative).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CurrentReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.FudgeFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxOffset).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxReading).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MeterDate).HasColumnType("datetime");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterType).HasMaxLength(60);

                entity.Property(e => e.PrimaryMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ResetMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rollover).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Unit).HasMaxLength(60);
            });

            modelBuilder.Entity<VAllTransBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AllTransBatch");

                entity.Property(e => e.AddCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvCountBatchNum).HasMaxLength(60);

                entity.Property(e => e.Invoiced).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.Itemnum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReceiptLotNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VAvailableAttribute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AvailableAttributes");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Attribute).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ReadingType).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Type).HasMaxLength(60);

                entity.Property(e => e.Unit)
                    .HasMaxLength(60)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<VCheckRequestedItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CheckRequestedItem");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");

                entity.Property(e => e.Wotype)
                    .HasMaxLength(60)
                    .HasColumnName("WOType");
            });

            modelBuilder.Entity<VCompEquipmentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CompEquipmentList");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PartItemNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VCopyFieldsMapDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CopyFieldsMapDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DecimalPlaces).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.EmailFlag).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.ExportFlag).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryTag).HasMaxLength(5);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.IsMapped).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MapType).HasMaxLength(60);

                entity.Property(e => e.MaxLength).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Module).HasMaxLength(60);

                entity.Property(e => e.WwfieldDesc)
                    .HasMaxLength(100)
                    .HasColumnName("WWFieldDesc");

                entity.Property(e => e.WwfieldLabel)
                    .HasMaxLength(100)
                    .HasColumnName("WWFieldLabel");

                entity.Property(e => e.WwfieldName)
                    .HasMaxLength(60)
                    .HasColumnName("WWFieldName");

                entity.Property(e => e.WwfieldOrder)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("WWFieldOrder");

                entity.Property(e => e.WwfieldType)
                    .HasMaxLength(10)
                    .HasColumnName("WWFieldType");

                entity.Property(e => e.WwselectList)
                    .HasMaxLength(255)
                    .HasColumnName("WWSelectList");

                entity.Property(e => e.WwtableName)
                    .HasMaxLength(60)
                    .HasColumnName("WWTableName");
            });

            modelBuilder.Entity<VCostAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CostAccounts");

                entity.Property(e => e.Account).HasMaxLength(60);

                entity.Property(e => e.CostAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostAmountInBaseTable).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostPercent).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.CostPercentInBaseTable).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Keeppercent)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("keeppercent");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(21, 4)");
            });

            modelBuilder.Entity<VCostrecoveryApjournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_COSTRECOVERY_APJOURNAL");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.Compdate)
                    .HasColumnType("datetime")
                    .HasColumnName("compdate");

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.Draccount)
                    .HasMaxLength(60)
                    .HasColumnName("draccount");

                entity.Property(e => e.FullWoNum).HasMaxLength(63);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);
            });

            modelBuilder.Entity<VCsuciCostRecovery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CSUCI_COST_RECOVERY");

                entity.Property(e => e.Draccount)
                    .HasMaxLength(60)
                    .HasColumnName("draccount");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VCurrchangerate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_currchangerate");

                entity.Property(e => e.Currency)
                    .HasMaxLength(60)
                    .HasColumnName("currency");

                entity.Property(e => e.Exchangedate)
                    .HasColumnType("datetime")
                    .HasColumnName("exchangedate");

                entity.Property(e => e.Exchangerate)
                    .HasColumnType("numeric(18, 10)")
                    .HasColumnName("exchangerate");
            });

            modelBuilder.Entity<VCustomerRecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CustomerRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Address1).HasMaxLength(225);

                entity.Property(e => e.Address2).HasMaxLength(225);

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.CompanyType).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(60);

                entity.Property(e => e.Fax).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(11, 0)");

                entity.Property(e => e.LastContact).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Mail).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NextContact).HasColumnType("datetime");

                entity.Property(e => e.Owner).HasMaxLength(60);

                entity.Property(e => e.Recno).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Region).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Telephone).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WebPage).HasMaxLength(60);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(20)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<VEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Employee");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmpName).HasMaxLength(306);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SelType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VEmployeeRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EmployeeRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpGroup).HasMaxLength(60);

                entity.Property(e => e.EmpTitle).HasMaxLength(30);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Employee).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Emppword).HasMaxLength(40);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Lab1)
                    .HasMaxLength(60)
                    .HasColumnName("lab1");

                entity.Property(e => e.Lab2)
                    .HasMaxLength(60)
                    .HasColumnName("lab2");

                entity.Property(e => e.Lab3)
                    .HasMaxLength(60)
                    .HasColumnName("lab3");

                entity.Property(e => e.Lab4)
                    .HasMaxLength(60)
                    .HasColumnName("lab4");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcid)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("LCID");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Userflags)
                    .HasMaxLength(10)
                    .HasColumnName("userflags");

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VEmployeeUserRight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EmployeeUserRight");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.EmpGroup).HasMaxLength(60);

                entity.Property(e => e.EmpName).HasMaxLength(101);

                entity.Property(e => e.EmpTitle).HasMaxLength(30);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);
            });

            modelBuilder.Entity<VEmployeeVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EmployeeVendor");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SelType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VEqLastMeasurementReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EQ_LAST_MEASUREMENT_READINGS");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);

                entity.Property(e => e.MeasUnit).HasMaxLength(60);

                entity.Property(e => e.MeasureDate).HasColumnType("datetime");

                entity.Property(e => e.MeasureReading).HasMaxLength(50);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);
            });

            modelBuilder.Entity<VEqLastMeterReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EQ_LAST_METER_READINGS");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.MeterDate).HasColumnType("datetime");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Unit).HasMaxLength(60);
            });

            modelBuilder.Entity<VEquipmentDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EquipmentDetail");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VEquipmentPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EQUIPMENT_PRINT");

                entity.Property(e => e.CurrentValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EquipmentAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Equipment_Address1");

                entity.Property(e => e.EquipmentAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Equipment_Address2");

                entity.Property(e => e.EquipmentAssetTag)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_AssetTag");

                entity.Property(e => e.EquipmentCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_CBCode");

                entity.Property(e => e.EquipmentClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ClientCode");

                entity.Property(e => e.EquipmentCostToDate)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_CostToDate");

                entity.Property(e => e.EquipmentCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_CrAccount");

                entity.Property(e => e.EquipmentCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Customer");

                entity.Property(e => e.EquipmentDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Department");

                entity.Property(e => e.EquipmentDeprecFactor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DeprecFactor");

                entity.Property(e => e.EquipmentDeprecMethod)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Equipment_DeprecMethod");

                entity.Property(e => e.EquipmentDirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Equipment_Dirtylog");

                entity.Property(e => e.EquipmentDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Division");

                entity.Property(e => e.EquipmentDownTime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DownTime");

                entity.Property(e => e.EquipmentDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_DrAccount");

                entity.Property(e => e.EquipmentEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Equipment");

                entity.Property(e => e.EquipmentEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_EquipmentDesc");

                entity.Property(e => e.EquipmentHazardous)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_Hazardous");

                entity.Property(e => e.EquipmentInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_Inactive");

                entity.Property(e => e.EquipmentInstructions).HasColumnName("Equipment_Instructions");

                entity.Property(e => e.EquipmentItemNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ItemNum");

                entity.Property(e => e.EquipmentLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Location");

                entity.Property(e => e.EquipmentLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_LocationDesc");

                entity.Property(e => e.EquipmentManufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Manufacturer");

                entity.Property(e => e.EquipmentMasterRec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_MasterRec");

                entity.Property(e => e.EquipmentMeterReading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_MeterReading");

                entity.Property(e => e.EquipmentModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_ModifyDate");

                entity.Property(e => e.EquipmentMrtype)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_MRType");

                entity.Property(e => e.EquipmentNote1)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note1");

                entity.Property(e => e.EquipmentNote10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note10");

                entity.Property(e => e.EquipmentNote2)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note2");

                entity.Property(e => e.EquipmentNote3)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note3");

                entity.Property(e => e.EquipmentNote4)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note4");

                entity.Property(e => e.EquipmentNote5)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note5");

                entity.Property(e => e.EquipmentNote6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note6");

                entity.Property(e => e.EquipmentNote7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note7");

                entity.Property(e => e.EquipmentNote8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note8");

                entity.Property(e => e.EquipmentNote9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note9");

                entity.Property(e => e.EquipmentOperator)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Operator");

                entity.Property(e => e.EquipmentParentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_ParentDesc");

                entity.Property(e => e.EquipmentParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ParentId");

                entity.Property(e => e.EquipmentPriority)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Priority");

                entity.Property(e => e.EquipmentPurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_PurchaseDate");

                entity.Property(e => e.EquipmentPurchasePrice)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_PurchasePrice");

                entity.Property(e => e.EquipmentRate)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Rate");

                entity.Property(e => e.EquipmentRoom)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Room");

                entity.Property(e => e.EquipmentSalvageValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_SalvageValue");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.EquipmentStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Status");

                entity.Property(e => e.EquipmentSubType1)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType1");

                entity.Property(e => e.EquipmentSubType2)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType2");

                entity.Property(e => e.EquipmentSubType3)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType3");

                entity.Property(e => e.EquipmentSubType4)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType4");

                entity.Property(e => e.EquipmentSubType5)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType5");

                entity.Property(e => e.EquipmentUsefulLife)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_UsefulLife");

                entity.Property(e => e.EquipmentVendor)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Vendor");

                entity.Property(e => e.EquipmentWarrantyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_WarrantyDate");

                entity.Property(e => e.LocationDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHLSD");

                entity.Property(e => e.LocationDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHRange");

                entity.Property(e => e.LocationDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHSect");

                entity.Property(e => e.LocationDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHTownShip");

                entity.Property(e => e.LocationSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfLSD");

                entity.Property(e => e.LocationSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfRange");

                entity.Property(e => e.LocationSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfSect");

                entity.Property(e => e.LocationSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfTownShip");

                entity.Property(e => e.ManufacturerMName)
                    .HasMaxLength(100)
                    .HasColumnName("Manufacturer_mName");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.VendorVendName)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_VendName");
            });

            modelBuilder.Entity<VEquipmentRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EquipmentRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VEquipmentUserWlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EquipmentUserWList");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CostToDate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeprecFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DeprecMethod).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Hazardous).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkModule).HasMaxLength(20);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MobileEquipment).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mrtype)
                    .HasMaxLength(60)
                    .HasColumnName("MRType");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SalvageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.SubType5).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.UsefulLife).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VEquipmentdowntime1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EQUIPMENTDOWNTIME1");

                entity.Property(e => e.CalField).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.EquipmentDownTime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DownTime");

                entity.Property(e => e.EquipmentDownTime0)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DownTime0");

                entity.Property(e => e.EquipmentEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Equipment");

                entity.Property(e => e.EquipmentEquipment0)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Equipment0");

                entity.Property(e => e.EquipmentEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_EquipmentDesc");

                entity.Property(e => e.EquipmentEquipmentDesc0)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_EquipmentDesc0");

                entity.Property(e => e.WorkOrderActHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours");

                entity.Property(e => e.WorkOrderActHours0)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours0");

                entity.Property(e => e.WorkOrderActLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActLabor");

                entity.Property(e => e.WorkOrderActMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMaterial");

                entity.Property(e => e.WorkOrderActService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActService");

                entity.Property(e => e.WorkOrderDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_DrAccount");

                entity.Property(e => e.WorkOrderLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location");

                entity.Property(e => e.WorkOrderLocation0)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location0");

                entity.Property(e => e.WorkOrderLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc");

                entity.Property(e => e.WorkOrderLocationDesc0)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc0");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderRequest0).HasColumnName("WorkOrder_Request0");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");

                entity.Property(e => e.WorkOrderWoType0)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType0");
            });

            modelBuilder.Entity<VEstMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EstMaterial");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Issuedqty)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("issuedqty");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType).HasMaxLength(60);

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Qtyonorder)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("qtyonorder");

                entity.Property(e => e.Qtyreserved)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("qtyreserved");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reserved).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Store).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VEstService>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EstService");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Issuedqty)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("issuedqty");

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.Qtyonorder)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("qtyonorder");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reserved).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ServiceCode).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VEstwolabour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ESTWOLABOUR");

                entity.Property(e => e.WolabourDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("WOLabour_Description");

                entity.Property(e => e.WolabourEmpid)
                    .HasMaxLength(60)
                    .HasColumnName("WOLabour_Empid");

                entity.Property(e => e.WolabourEstimate)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOLabour_Estimate");

                entity.Property(e => e.WolabourHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOLabour_Hours");

                entity.Property(e => e.WolabourOrderType)
                    .HasMaxLength(60)
                    .HasColumnName("WOLabour_OrderType");

                entity.Property(e => e.WorkOrderActHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours");

                entity.Property(e => e.WorkOrderActLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActLabor");

                entity.Property(e => e.WorkOrderActMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMaterial");

                entity.Property(e => e.WorkOrderActService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActService");

                entity.Property(e => e.WorkOrderActTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActTools");

                entity.Property(e => e.WorkOrderAssignedHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_AssignedHours");

                entity.Property(e => e.WorkOrderChargeback)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Chargeback");

                entity.Property(e => e.WorkOrderClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ClientCode");

                entity.Property(e => e.WorkOrderCompCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CompCode");

                entity.Property(e => e.WorkOrderCompDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CompDate");

                entity.Property(e => e.WorkOrderCompRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkOrder_CompRemark");

                entity.Property(e => e.WorkOrderContact)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Contact");

                entity.Property(e => e.WorkOrderContactPhone)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ContactPhone");

                entity.Property(e => e.WorkOrderCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CrAccount");

                entity.Property(e => e.WorkOrderCraft)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Craft");

                entity.Property(e => e.WorkOrderCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CreatedBy");

                entity.Property(e => e.WorkOrderCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CreationDate");

                entity.Property(e => e.WorkOrderCrew)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Crew");

                entity.Property(e => e.WorkOrderDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Department");

                entity.Property(e => e.WorkOrderDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_DirtyLog");

                entity.Property(e => e.WorkOrderDivision)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Division");

                entity.Property(e => e.WorkOrderDowntime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Downtime");

                entity.Property(e => e.WorkOrderDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_DrAccount");

                entity.Property(e => e.WorkOrderDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Duration");

                entity.Property(e => e.WorkOrderEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Employee");

                entity.Property(e => e.WorkOrderEqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress1");

                entity.Property(e => e.WorkOrderEqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress2");

                entity.Property(e => e.WorkOrderEqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_EQOperator");

                entity.Property(e => e.WorkOrderEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Equipment");

                entity.Property(e => e.WorkOrderEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EquipmentDesc");

                entity.Property(e => e.WorkOrderEstCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstCost");

                entity.Property(e => e.WorkOrderEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstHours");

                entity.Property(e => e.WorkOrderEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstLabor");

                entity.Property(e => e.WorkOrderEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstMaterial");

                entity.Property(e => e.WorkOrderEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstService");

                entity.Property(e => e.WorkOrderEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstTools");

                entity.Property(e => e.WorkOrderFailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode1");

                entity.Property(e => e.WorkOrderFailureCode2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode2");

                entity.Property(e => e.WorkOrderFailureCode3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode3");

                entity.Property(e => e.WorkOrderLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location");

                entity.Property(e => e.WorkOrderLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc");

                entity.Property(e => e.WorkOrderManager)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Manager");

                entity.Property(e => e.WorkOrderModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ModifyBy");

                entity.Property(e => e.WorkOrderModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_ModifyDate");

                entity.Property(e => e.WorkOrderNote1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note1");

                entity.Property(e => e.WorkOrderNote2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note2");

                entity.Property(e => e.WorkOrderNote3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note3");

                entity.Property(e => e.WorkOrderNote4)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note4");

                entity.Property(e => e.WorkOrderNote5)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note5");

                entity.Property(e => e.WorkOrderNote6)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note6");

                entity.Property(e => e.WorkOrderNote7)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note7");

                entity.Property(e => e.WorkOrderNote8)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note8");

                entity.Property(e => e.WorkOrderOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_OpenDate");

                entity.Property(e => e.WorkOrderPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PDMNum");

                entity.Property(e => e.WorkOrderPhase)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Phase");

                entity.Property(e => e.WorkOrderPmNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PmNum");

                entity.Property(e => e.WorkOrderPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_PostDate");

                entity.Property(e => e.WorkOrderPriority)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Priority");

                entity.Property(e => e.WorkOrderProcNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProcNum");

                entity.Property(e => e.WorkOrderProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProjectId");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Requester");

                entity.Property(e => e.WorkOrderRoom)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Room");

                entity.Property(e => e.WorkOrderRouteName)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_RouteName");

                entity.Property(e => e.WorkOrderStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status");

                entity.Property(e => e.WorkOrderStatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_StatusCode");

                entity.Property(e => e.WorkOrderTargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetDate");

                entity.Property(e => e.WorkOrderTargetEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetEndDate");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");
            });

            modelBuilder.Entity<VFundrecovery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FUNDRECOVERY");

                entity.Property(e => e.ActualType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Totalcost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VGeneratepo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_generatepo");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Color).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Defmanufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("defmanufacturer");

                entity.Property(e => e.Defposition)
                    .HasMaxLength(60)
                    .HasColumnName("defposition");

                entity.Property(e => e.Defvendor)
                    .HasMaxLength(60)
                    .HasColumnName("defvendor");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Polist)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("polist");

                entity.Property(e => e.QtyOnApprovedPo)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("QtyOnApprovedPO");

                entity.Property(e => e.QtyOnHand).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(21, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VHistorylog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HISTORYLOG");

                entity.Property(e => e.HistoryLogAction)
                    .HasMaxLength(100)
                    .HasColumnName("HistoryLog_Action");

                entity.Property(e => e.HistoryLogBatchNum)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("HistoryLog_BatchNum");

                entity.Property(e => e.HistoryLogCounter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HistoryLog_Counter");

                entity.Property(e => e.HistoryLogDbUser)
                    .HasMaxLength(100)
                    .HasColumnName("HistoryLog_DbUser");

                entity.Property(e => e.HistoryLogFieldName)
                    .HasMaxLength(60)
                    .HasColumnName("HistoryLog_FieldName");

                entity.Property(e => e.HistoryLogFieldValue)
                    .HasMaxLength(2000)
                    .HasColumnName("HistoryLog_FieldValue");

                entity.Property(e => e.HistoryLogLinkId)
                    .HasMaxLength(60)
                    .HasColumnName("HistoryLog_LinkID");

                entity.Property(e => e.HistoryLogLinkTable)
                    .HasMaxLength(60)
                    .HasColumnName("HistoryLog_LinkTable");

                entity.Property(e => e.HistoryLogModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("HistoryLog_ModifyBy");

                entity.Property(e => e.HistoryLogModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HistoryLog_ModifyDate");

                entity.Property(e => e.HistoryLogNewFieldValue)
                    .HasMaxLength(2000)
                    .HasColumnName("HistoryLog_NewFieldValue");

                entity.Property(e => e.HistoryLogRemark).HasColumnName("HistoryLog_Remark");
            });

            modelBuilder.Entity<VInfPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Inf_PO");

                entity.Property(e => e.AcctContact).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.BillAddress1).HasMaxLength(100);

                entity.Property(e => e.BillAddress2).HasMaxLength(100);

                entity.Property(e => e.BillAddress3).HasMaxLength(100);

                entity.Property(e => e.BillAddress4).HasMaxLength(100);

                entity.Property(e => e.BillAddress5).HasMaxLength(100);

                entity.Property(e => e.BillPhone).HasMaxLength(30);

                entity.Property(e => e.BillTo).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContractNum).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.Expr3).HasMaxLength(30);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Freight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Hispostatus)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("hispostatus");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsWtappr).HasColumnName("isWTAPPR");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OpenPo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenPO");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Po1)
                    .HasMaxLength(60)
                    .HasColumnName("PO1");

                entity.Property(e => e.Po10)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po10");

                entity.Property(e => e.Po2)
                    .HasMaxLength(60)
                    .HasColumnName("PO2");

                entity.Property(e => e.Po3)
                    .HasMaxLength(60)
                    .HasColumnName("PO3");

                entity.Property(e => e.Po4)
                    .HasMaxLength(60)
                    .HasColumnName("PO4");

                entity.Property(e => e.Po9)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po9");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PoTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Potype)
                    .HasMaxLength(60)
                    .HasColumnName("POType");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1).HasMaxLength(100);

                entity.Property(e => e.ShipAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipAddress3).HasMaxLength(100);

                entity.Property(e => e.ShipAddress4).HasMaxLength(100);

                entity.Property(e => e.ShipAddress5).HasMaxLength(100);

                entity.Property(e => e.ShipPhone).HasMaxLength(30);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Taxid1).HasMaxLength(60);

                entity.Property(e => e.Taxid2).HasMaxLength(60);

                entity.Property(e => e.TermsCode).HasMaxLength(60);

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.VendCategory).HasMaxLength(60);

                entity.Property(e => e.VendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("VendCustID");

                entity.Property(e => e.VendName).HasMaxLength(255);

                entity.Property(e => e.VendTerms).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VInfPoline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Inf_POLine");

                entity.Property(e => e.Acct1).HasMaxLength(50);

                entity.Property(e => e.Acct2).HasMaxLength(101);

                entity.Property(e => e.Acct3).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BudgetType).HasMaxLength(50);

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NewEquip).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenFlag).HasMaxLength(1);

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OrderQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");
            });

            modelBuilder.Entity<VInfTableDetailed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InfTableDetailed");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ExportPrimaryKey).HasMaxLength(60);

                entity.Property(e => e.Exportrestriction)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exportrestriction");

                entity.Property(e => e.Importtype)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("importtype");

                entity.Property(e => e.InterfaceModule).HasMaxLength(60);

                entity.Property(e => e.InterfaceName).HasMaxLength(60);

                entity.Property(e => e.InterfaceType).HasMaxLength(60);

                entity.Property(e => e.IsUsed)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.KeyFieldToTrigger).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Parenttable)
                    .HasMaxLength(50)
                    .HasColumnName("parenttable");

                entity.Property(e => e.Parenttablekeyfield)
                    .HasMaxLength(50)
                    .HasColumnName("parenttablekeyfield");

                entity.Property(e => e.SourceTable).HasMaxLength(60);

                entity.Property(e => e.Tablefkfield)
                    .HasMaxLength(50)
                    .HasColumnName("tablefkfield");

                entity.Property(e => e.TagName).HasMaxLength(60);
            });

            modelBuilder.Entity<VInterfaceRecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InterfaceRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ActionTable).HasMaxLength(60);

                entity.Property(e => e.AppendData).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dbaction)
                    .HasMaxLength(20)
                    .HasColumnName("DBAction");

                entity.Property(e => e.Delimiter).HasMaxLength(20);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ExcludePosted).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FileLocation).HasMaxLength(100);

                entity.Property(e => e.FileType).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InterfaceName).HasMaxLength(60);

                entity.Property(e => e.InterfaceType).HasMaxLength(60);

                entity.Property(e => e.LastRun).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RemotePassword).HasMaxLength(60);

                entity.Property(e => e.RemoteUsername).HasMaxLength(60);

                entity.Property(e => e.RunInterval).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ServiceUrl).HasColumnName("ServiceURL");

                entity.Property(e => e.TriggerField).HasMaxLength(60);

                entity.Property(e => e.TriggerMode).HasMaxLength(60);

                entity.Property(e => e.UpdateData).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.UpdatePosted).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.UserModule).HasMaxLength(30);
            });

            modelBuilder.Entity<VInvCountBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvCountBatch");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Createdby).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QueryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("QueryID");

                entity.Property(e => e.Queryname)
                    .HasMaxLength(60)
                    .HasColumnName("queryname");

                entity.Property(e => e.RequiredMatches).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Storeroom).HasMaxLength(60);
            });

            modelBuilder.Entity<VInvCountLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvCountLines");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Counted)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("counted");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Defmanufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("defmanufacturer");

                entity.Property(e => e.Defposition)
                    .HasMaxLength(60)
                    .HasColumnName("defposition");

                entity.Property(e => e.Defvendor)
                    .HasMaxLength(60)
                    .HasColumnName("defvendor");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.ManufPartNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("position");

                entity.Property(e => e.Posted)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("posted");

                entity.Property(e => e.PurchasePrice).HasMaxLength(60);

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.SubType0).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.Warranty).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VInvItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_INV_ITEM");

                entity.Property(e => e.InactiveItem)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ItemsCategory)
                    .HasMaxLength(60)
                    .HasColumnName("Items_Category");

                entity.Property(e => e.ItemsChangeRemark).HasColumnName("Items_ChangeRemark");

                entity.Property(e => e.ItemsCreatedby)
                    .HasMaxLength(60)
                    .HasColumnName("Items_createdby");

                entity.Property(e => e.ItemsCreationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Items_creationdate");

                entity.Property(e => e.ItemsDirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Items_DirtyLog");

                entity.Property(e => e.ItemsDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Items_Division");

                entity.Property(e => e.ItemsFixPrice)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Items_FixPrice");

                entity.Property(e => e.ItemsInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Items_Inactive");

                entity.Property(e => e.ItemsIssueMethod)
                    .HasMaxLength(60)
                    .HasColumnName("Items_IssueMethod");

                entity.Property(e => e.ItemsIssuePrice)
                    .HasMaxLength(60)
                    .HasColumnName("Items_IssuePrice");

                entity.Property(e => e.ItemsIssueUnit)
                    .HasMaxLength(60)
                    .HasColumnName("Items_IssueUnit");

                entity.Property(e => e.ItemsItemDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Items_ItemDesc");

                entity.Property(e => e.ItemsItemNum)
                    .HasMaxLength(60)
                    .HasColumnName("Items_ItemNum");

                entity.Property(e => e.ItemsManufPartNum)
                    .HasMaxLength(60)
                    .HasColumnName("Items_ManufPartNum");

                entity.Property(e => e.ItemsManufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("Items_Manufacturer");

                entity.Property(e => e.ItemsMarkup)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("Items_Markup");

                entity.Property(e => e.ItemsModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Items_ModifyDate");

                entity.Property(e => e.ItemsModifyby)
                    .HasMaxLength(60)
                    .HasColumnName("Items_modifyby");

                entity.Property(e => e.ItemsPurchasePrice)
                    .HasMaxLength(60)
                    .HasColumnName("Items_PurchasePrice");

                entity.Property(e => e.ItemsSerialized)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Items_Serialized");

                entity.Property(e => e.ItemsShortDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Items_ShortDesc");

                entity.Property(e => e.ItemsStocked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Items_Stocked");

                entity.Property(e => e.ItemsSubType0)
                    .HasMaxLength(60)
                    .HasColumnName("Items_SubType0");

                entity.Property(e => e.ItemsSubType1)
                    .HasMaxLength(60)
                    .HasColumnName("Items_SubType1");

                entity.Property(e => e.ItemsSubType2)
                    .HasMaxLength(60)
                    .HasColumnName("Items_SubType2");

                entity.Property(e => e.ItemsSubType3)
                    .HasMaxLength(60)
                    .HasColumnName("Items_SubType3");

                entity.Property(e => e.ItemsSubType4)
                    .HasMaxLength(60)
                    .HasColumnName("Items_SubType4");

                entity.Property(e => e.ItemsVendor)
                    .HasMaxLength(60)
                    .HasColumnName("Items_Vendor");

                entity.Property(e => e.ItemsVendorPart)
                    .HasMaxLength(60)
                    .HasColumnName("Items_VendorPart");

                entity.Property(e => e.ItemsWarranty)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Items_Warranty");

                entity.Property(e => e.ManufacturerMName)
                    .HasMaxLength(100)
                    .HasColumnName("Manufacturer_mName");

                entity.Property(e => e.Printdate1)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("printdate1");

                entity.Property(e => e.Printdate2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate2");

                entity.Property(e => e.SerializedItem)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StockedItem)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VendorVendName)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_VendName");
            });

            modelBuilder.Entity<VInventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_inventory");

                entity.Property(e => e.Division)
                    .HasMaxLength(60)
                    .HasColumnName("division");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(255)
                    .HasColumnName("itemdesc");

                entity.Property(e => e.Itemnum)
                    .HasMaxLength(60)
                    .HasColumnName("itemnum");

                entity.Property(e => e.Stocklevel)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("stocklevel");

                entity.Property(e => e.Storeroom)
                    .HasMaxLength(60)
                    .HasColumnName("storeroom");
            });

            modelBuilder.Entity<VInventoryIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryIssue");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalQuantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("position");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Totalcost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorLot).HasMaxLength(60);
            });

            modelBuilder.Entity<VInventoryLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryLot");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("position");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(38, 20)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorLot).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VInventoryPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryPosition");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("position");

                entity.Property(e => e.QtyOnHand).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.Warranty).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VInventoryStoreroom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryStoreroom");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Defmanufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("defmanufacturer");

                entity.Property(e => e.Defposition)
                    .HasMaxLength(60)
                    .HasColumnName("defposition");

                entity.Property(e => e.Defvendor)
                    .HasMaxLength(60)
                    .HasColumnName("defvendor");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LookUpCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QtyOnHand).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VInventoryTransBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryTransBatch");

                entity.Property(e => e.AddCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvCountBatchNum).HasMaxLength(60);

                entity.Property(e => e.Invoiced).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.Itemnum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReceiptLotNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VInventoryTransDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryTransDetail");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.BatchTransType).HasMaxLength(20);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Condition).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ConditionCode).HasMaxLength(60);

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvCountBatchNum).HasMaxLength(60);

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueTo).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Mtnum)
                    .HasMaxLength(60)
                    .HasColumnName("MTNum");

                entity.Property(e => e.OtherLotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OtherLotNum).HasMaxLength(60);

                entity.Property(e => e.OtherPosition).HasMaxLength(60);

                entity.Property(e => e.OtherStoreRoom).HasMaxLength(60);

                entity.Property(e => e.OtherTransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.Position).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.RepairShop).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnVendor).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.StoreroomQty).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VInventoryWithNonStockItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InventoryWithNonStockItems");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Defmanufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("defmanufacturer");

                entity.Property(e => e.Defposition)
                    .HasMaxLength(60)
                    .HasColumnName("defposition");

                entity.Property(e => e.Defvendor)
                    .HasMaxLength(60)
                    .HasColumnName("defvendor");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.MaxStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QtyOnHand).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyOnOrder).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReorderMethod).HasMaxLength(20);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VInventorymain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_INVENTORYMAIN");

                entity.Property(e => e.InvLotCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("InvLot_Counter");

                entity.Property(e => e.VInventoryStoreroomMaxStock)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("v_InventoryStoreroom_MaxStock");

                entity.Property(e => e.VInventoryStoreroomQtyOnHand)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("v_InventoryStoreroom_QtyOnHand");
            });

            modelBuilder.Entity<VItemRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ItemRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.ManufPartNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.PurchasePrice).HasMaxLength(60);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ShortDesc).HasMaxLength(255);

                entity.Property(e => e.Stocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SubType0).HasMaxLength(60);

                entity.Property(e => e.SubType1).HasMaxLength(60);

                entity.Property(e => e.SubType2).HasMaxLength(60);

                entity.Property(e => e.SubType3).HasMaxLength(60);

                entity.Property(e => e.SubType4).HasMaxLength(60);

                entity.Property(e => e.Tax1Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax1Exempt");

                entity.Property(e => e.Tax2Exempt)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tax2Exempt");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.Warranty).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VItemvendorlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_itemvendorlist");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("counter");

                entity.Property(e => e.IsDefault).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LookupCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PurchasePrice).HasMaxLength(60);

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VLabour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LABOUR");

                entity.Property(e => e.CityAndState).HasMaxLength(122);

                entity.Property(e => e.EmployeeAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Employee_Address1");

                entity.Property(e => e.EmployeeAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Employee_Address2");

                entity.Property(e => e.EmployeeCity)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_City");

                entity.Property(e => e.EmployeeContact)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Contact");

                entity.Property(e => e.EmployeeCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Employee_Country");

                entity.Property(e => e.EmployeeCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_CrAccount");

                entity.Property(e => e.EmployeeCraft)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Craft");

                entity.Property(e => e.EmployeeDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Department");

                entity.Property(e => e.EmployeeDirtylog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("Employee_Dirtylog");

                entity.Property(e => e.EmployeeDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Division");

                entity.Property(e => e.EmployeeDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_DrAccount");

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Employee_Email");

                entity.Property(e => e.EmployeeEmailNotify)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Employee_EmailNotify");

                entity.Property(e => e.EmployeeEmpTitle)
                    .HasMaxLength(30)
                    .HasColumnName("Employee_EmpTitle");

                entity.Property(e => e.EmployeeEmpgroup)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_empgroup");

                entity.Property(e => e.EmployeeEmpid)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Empid");

                entity.Property(e => e.EmployeeEmployee)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Employee_Employee");

                entity.Property(e => e.EmployeeEmppword)
                    .HasMaxLength(40)
                    .HasColumnName("Employee_Emppword");

                entity.Property(e => e.EmployeeFax)
                    .HasMaxLength(30)
                    .HasColumnName("Employee_Fax");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("Employee_FirstName");

                entity.Property(e => e.EmployeeHireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Employee_HireDate");

                entity.Property(e => e.EmployeeInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Employee_Inactive");

                entity.Property(e => e.EmployeeLab1)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_lab1");

                entity.Property(e => e.EmployeeLab2)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_lab2");

                entity.Property(e => e.EmployeeLab3)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_lab3");

                entity.Property(e => e.EmployeeLab4)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_lab4");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(50)
                    .HasColumnName("Employee_LastName");

                entity.Property(e => e.EmployeeLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Location");

                entity.Property(e => e.EmployeeManager)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_Manager");

                entity.Property(e => e.EmployeePhone)
                    .HasMaxLength(30)
                    .HasColumnName("Employee_Phone");

                entity.Property(e => e.EmployeeRate)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Employee_Rate");

                entity.Property(e => e.EmployeeState)
                    .HasMaxLength(60)
                    .HasColumnName("Employee_State");

                entity.Property(e => e.EmployeeSystem)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Employee_System");

                entity.Property(e => e.EmployeeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Employee_URL");

                entity.Property(e => e.EmployeeUserFlags)
                    .HasMaxLength(10)
                    .HasColumnName("Employee_UserFlags");

                entity.Property(e => e.EmployeeYesNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeZip)
                    .HasMaxLength(20)
                    .HasColumnName("Employee_Zip");

                entity.Property(e => e.FullName).HasMaxLength(101);

                entity.Property(e => e.InactiveYesNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");
            });

            modelBuilder.Entity<VLastMeasurementReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LastMeasurementReading");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.EmpId).HasMaxLength(60);

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);

                entity.Property(e => e.MeasureDate).HasColumnType("datetime");

                entity.Property(e => e.MeasureReading).HasMaxLength(50);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VLastMeasurementReadingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LastMeasurementReadingDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.MeasUnit).HasMaxLength(60);

                entity.Property(e => e.MeasureReading).HasMaxLength(50);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ValueType).HasMaxLength(60);
            });

            modelBuilder.Entity<VLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LOCATION");

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.LocationAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Location_Address1");

                entity.Property(e => e.LocationAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Location_Address2");

                entity.Property(e => e.LocationContact)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Contact");

                entity.Property(e => e.LocationContact1)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact1");

                entity.Property(e => e.LocationContact2)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact2");

                entity.Property(e => e.LocationContact3)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact3");

                entity.Property(e => e.LocationContact4)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact4");

                entity.Property(e => e.LocationContact5)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact5");

                entity.Property(e => e.LocationContact6)
                    .HasMaxLength(60)
                    .HasColumnName("Location_contact6");

                entity.Property(e => e.LocationContactName)
                    .HasMaxLength(60)
                    .HasColumnName("Location_ContactName");

                entity.Property(e => e.LocationCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Location_CrAccount");

                entity.Property(e => e.LocationCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Customer");

                entity.Property(e => e.LocationDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Department");

                entity.Property(e => e.LocationDistrict1)
                    .HasMaxLength(60)
                    .HasColumnName("Location_District1");

                entity.Property(e => e.LocationDistrict2)
                    .HasMaxLength(60)
                    .HasColumnName("Location_District2");

                entity.Property(e => e.LocationDistrict3)
                    .HasMaxLength(60)
                    .HasColumnName("Location_District3");

                entity.Property(e => e.LocationDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Division");

                entity.Property(e => e.LocationDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Location_DrAccount");

                entity.Property(e => e.LocationLoc1)
                    .HasMaxLength(60)
                    .HasColumnName("Location_loc1");

                entity.Property(e => e.LocationLoc2)
                    .HasMaxLength(60)
                    .HasColumnName("Location_loc2");

                entity.Property(e => e.LocationLoc3)
                    .HasMaxLength(60)
                    .HasColumnName("Location_loc3");

                entity.Property(e => e.LocationLoc4)
                    .HasMaxLength(60)
                    .HasColumnName("Location_loc4");

                entity.Property(e => e.LocationLocType)
                    .HasMaxLength(60)
                    .HasColumnName("Location_locType");

                entity.Property(e => e.LocationLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Location");

                entity.Property(e => e.LocationLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Location_LocationDesc");

                entity.Property(e => e.LocationMasterRec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Location_MasterRec");

                entity.Property(e => e.LocationNote1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Location_Note1");

                entity.Property(e => e.LocationNote10)
                    .HasMaxLength(100)
                    .HasColumnName("Location_Note10");

                entity.Property(e => e.LocationNote2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Location_Note2");

                entity.Property(e => e.LocationNote3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Location_Note3");

                entity.Property(e => e.LocationNote4)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Location_Note4");

                entity.Property(e => e.LocationNote5)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Location_Note5");

                entity.Property(e => e.LocationNote6)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Note6");

                entity.Property(e => e.LocationNote7)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Note7");

                entity.Property(e => e.LocationNote8)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Note8");

                entity.Property(e => e.LocationNote9)
                    .HasMaxLength(100)
                    .HasColumnName("Location_Note9");

                entity.Property(e => e.LocationParentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Location_ParentDesc");

                entity.Property(e => e.LocationParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Location_ParentID");

                entity.Property(e => e.LocationPriority)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Priority");

                entity.Property(e => e.LocationStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Location_Status");

                entity.Property(e => e.LocationWarrantyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Location_WarrantyDate");

                entity.Property(e => e.Printform)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printform");

                entity.Property(e => e.Printform2)
                    .HasColumnType("datetime")
                    .HasColumnName("printform2");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);
            });

            modelBuilder.Entity<VLocationRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocationRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(60)
                    .HasColumnName("contact1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(60)
                    .HasColumnName("contact2");

                entity.Property(e => e.Contact3)
                    .HasMaxLength(60)
                    .HasColumnName("contact3");

                entity.Property(e => e.Contact4)
                    .HasMaxLength(60)
                    .HasColumnName("contact4");

                entity.Property(e => e.Contact5)
                    .HasMaxLength(60)
                    .HasColumnName("contact5");

                entity.Property(e => e.Contact6)
                    .HasMaxLength(60)
                    .HasColumnName("contact6");

                entity.Property(e => e.ContactName).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.District1).HasMaxLength(60);

                entity.Property(e => e.District2).HasMaxLength(60);

                entity.Property(e => e.District3).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Loc1)
                    .HasMaxLength(60)
                    .HasColumnName("loc1");

                entity.Property(e => e.Loc2)
                    .HasMaxLength(60)
                    .HasColumnName("loc2");

                entity.Property(e => e.Loc3)
                    .HasMaxLength(60)
                    .HasColumnName("loc3");

                entity.Property(e => e.Loc4)
                    .HasMaxLength(60)
                    .HasColumnName("loc4");

                entity.Property(e => e.LocType).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifyDate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Note1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note10).HasMaxLength(100);

                entity.Property(e => e.Note2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note4).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note5).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9).HasMaxLength(100);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.Tax1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax1");

                entity.Property(e => e.Tax2)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("tax2");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VMaxInterval>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MaxInterval");

                entity.Property(e => e.MaxOfPminterval)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("MaxOfPMInterval");

                entity.Property(e => e.PmNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VMaxMeterReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MaxMeterReading");

                entity.Property(e => e.AvgInterval).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Cumulative).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.FudgeFactor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxOffset).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxReading).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterType).HasMaxLength(60);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PrimaryMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ResetMeter).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rollover).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Template).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);
            });

            modelBuilder.Entity<VMaxReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MaxReading");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.MaxOffset).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxReading).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MeterName).HasMaxLength(60);
            });

            modelBuilder.Entity<VMaxReadingDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MaxReadingDate");

                entity.Property(e => e.CurrentReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.MaxOffSet).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxReading).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MeterDate).HasColumnType("datetime");

                entity.Property(e => e.MeterName).HasMaxLength(60);
            });

            modelBuilder.Entity<VMaxReadingDateBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MaxReadingDate_back");

                entity.Property(e => e.CurrentReading).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.MaxOffset).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MaxReading).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MeterDate).HasColumnType("datetime");

                entity.Property(e => e.MeterName).HasMaxLength(60);
            });

            modelBuilder.Entity<VMinInterval>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MinInterval");

                entity.Property(e => e.MinOfIntervalDue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PmNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VMtinventoryTransDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MTInventoryTransDetail");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.BatchTransType).HasMaxLength(20);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Condition).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ConditionCode).HasMaxLength(60);

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DestinationProvince).HasMaxLength(50);

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvCountBatchNum).HasMaxLength(60);

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueTo).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Mtnum)
                    .HasMaxLength(60)
                    .HasColumnName("MTNum");

                entity.Property(e => e.OtherLotCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OtherLotNum).HasMaxLength(60);

                entity.Property(e => e.OtherPosition).HasMaxLength(60);

                entity.Property(e => e.OtherStoreRoom).HasMaxLength(60);

                entity.Property(e => e.OtherTransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.Position).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.RepairShop).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnVendor).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.SourceProvince).HasMaxLength(50);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.StoreroomQty).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VMttransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MTTransactionDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationCoding).HasMaxLength(60);

                entity.Property(e => e.DestinationProvince).HasMaxLength(50);

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromLocation).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Mtnum)
                    .HasMaxLength(60)
                    .HasColumnName("MTNum");

                entity.Property(e => e.MtslipNum)
                    .HasMaxLength(60)
                    .HasColumnName("MTSlipNum");

                entity.Property(e => e.ProdPeriod).HasMaxLength(10);

                entity.Property(e => e.SourceCoding).HasMaxLength(60);

                entity.Property(e => e.SourceProvince).HasMaxLength(50);

                entity.Property(e => e.ToLocation).HasMaxLength(60);
            });

            modelBuilder.Entity<VNestedProcedureDue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_NestedProcedureDue");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.ProcNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VPdm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PDM");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.MeasurementMeasUnit)
                    .HasMaxLength(60)
                    .HasColumnName("Measurement_MeasUnit");

                entity.Property(e => e.PdmCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_CBCode");

                entity.Property(e => e.PdmChangeRemark).HasColumnName("PDM_ChangeRemark");

                entity.Property(e => e.PdmClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_ClientCode");

                entity.Property(e => e.PdmContact)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Contact");

                entity.Property(e => e.PdmContactPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PDM_ContactPhone");

                entity.Property(e => e.PdmCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_CrAccount");

                entity.Property(e => e.PdmCraft)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Craft");

                entity.Property(e => e.PdmCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_CreatedBy");

                entity.Property(e => e.PdmCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDM_CreationDate");

                entity.Property(e => e.PdmCrew)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Crew");

                entity.Property(e => e.PdmCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Customer");

                entity.Property(e => e.PdmDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Department");

                entity.Property(e => e.PdmDirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PDM_DirtyLog");

                entity.Property(e => e.PdmDivision)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Division");

                entity.Property(e => e.PdmDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_DrAccount");

                entity.Property(e => e.PdmDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_Duration");

                entity.Property(e => e.PdmEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Employee");

                entity.Property(e => e.PdmEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Equipment");

                entity.Property(e => e.PdmEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PDM_EquipmentDesc");

                entity.Property(e => e.PdmHighLimit)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_HighLimit");

                entity.Property(e => e.PdmHighLimitProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighLimitProc");

                entity.Property(e => e.PdmHighWarning)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_HighWarning");

                entity.Property(e => e.PdmHighWarningProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighWarningProc");

                entity.Property(e => e.PdmInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_Inactive");

                entity.Property(e => e.PdmLastWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LastWoNum");

                entity.Property(e => e.PdmLocation)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Location");

                entity.Property(e => e.PdmLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PDM_LocationDesc");

                entity.Property(e => e.PdmLowLimit)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_LowLimit");

                entity.Property(e => e.PdmLowLimitProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowLimitProc");

                entity.Property(e => e.PdmLowWarning)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_LowWarning");

                entity.Property(e => e.PdmLowWarningProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowWarningProc");

                entity.Property(e => e.PdmManager)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Manager");

                entity.Property(e => e.PdmMeasurementName)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_MeasurementName");

                entity.Property(e => e.PdmModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_ModifyBy");

                entity.Property(e => e.PdmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDM_ModifyDate");

                entity.Property(e => e.PdmOpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_OpenWO");

                entity.Property(e => e.PdmOperator)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Operator");

                entity.Property(e => e.PdmPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDMNum");

                entity.Property(e => e.PdmPriority)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Priority");

                entity.Property(e => e.PdmRequest).HasColumnName("PDM_Request");

                entity.Property(e => e.PdmRoom)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Room");

                entity.Property(e => e.PdmWoType)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_WoType");

                entity.Property(e => e.PdmWostatus)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_WOStatus");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");
            });

            modelBuilder.Entity<VPdmemailnotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PDMEMAILNOTIFICATION");

                entity.Property(e => e.EquipmentAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Equipment_Address1");

                entity.Property(e => e.EquipmentAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Equipment_Address2");

                entity.Property(e => e.EquipmentAssetTag)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_AssetTag");

                entity.Property(e => e.EquipmentCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_CBCode");

                entity.Property(e => e.EquipmentClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ClientCode");

                entity.Property(e => e.EquipmentCostToDate)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_CostToDate");

                entity.Property(e => e.EquipmentCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_CrAccount");

                entity.Property(e => e.EquipmentDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Department");

                entity.Property(e => e.EquipmentDeprecFactor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DeprecFactor");

                entity.Property(e => e.EquipmentDeprecMethod)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Equipment_DeprecMethod");

                entity.Property(e => e.EquipmentDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Division");

                entity.Property(e => e.EquipmentDownTime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_DownTime");

                entity.Property(e => e.EquipmentDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_DrAccount");

                entity.Property(e => e.EquipmentEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Equipment");

                entity.Property(e => e.EquipmentEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_EquipmentDesc");

                entity.Property(e => e.EquipmentHazardous)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_Hazardous");

                entity.Property(e => e.EquipmentInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_Inactive");

                entity.Property(e => e.EquipmentInstructions).HasColumnName("Equipment_Instructions");

                entity.Property(e => e.EquipmentItemNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ItemNum");

                entity.Property(e => e.EquipmentLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Location");

                entity.Property(e => e.EquipmentLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_LocationDesc");

                entity.Property(e => e.EquipmentManufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Manufacturer");

                entity.Property(e => e.EquipmentMasterRec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_MasterRec");

                entity.Property(e => e.EquipmentMeterReading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_MeterReading");

                entity.Property(e => e.EquipmentMrtype)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_MRType");

                entity.Property(e => e.EquipmentNote1)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note1");

                entity.Property(e => e.EquipmentNote10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note10");

                entity.Property(e => e.EquipmentNote2)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note2");

                entity.Property(e => e.EquipmentNote3)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note3");

                entity.Property(e => e.EquipmentNote4)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note4");

                entity.Property(e => e.EquipmentNote5)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Note5");

                entity.Property(e => e.EquipmentNote6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note6");

                entity.Property(e => e.EquipmentNote7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note7");

                entity.Property(e => e.EquipmentNote8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note8");

                entity.Property(e => e.EquipmentNote9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Note9");

                entity.Property(e => e.EquipmentOperator)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Operator");

                entity.Property(e => e.EquipmentParentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Equipment_ParentDesc");

                entity.Property(e => e.EquipmentParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_ParentId");

                entity.Property(e => e.EquipmentPriority)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Priority");

                entity.Property(e => e.EquipmentPurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_PurchaseDate");

                entity.Property(e => e.EquipmentPurchasePrice)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_PurchasePrice");

                entity.Property(e => e.EquipmentRate)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_Rate");

                entity.Property(e => e.EquipmentRoom)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Room");

                entity.Property(e => e.EquipmentSalvageValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_SalvageValue");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.EquipmentStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Status");

                entity.Property(e => e.EquipmentSubType1)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType1");

                entity.Property(e => e.EquipmentSubType2)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType2");

                entity.Property(e => e.EquipmentSubType3)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType3");

                entity.Property(e => e.EquipmentSubType4)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType4");

                entity.Property(e => e.EquipmentSubType5)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SubType5");

                entity.Property(e => e.EquipmentUsefulLife)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Equipment_UsefulLife");

                entity.Property(e => e.EquipmentVendor)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Vendor");

                entity.Property(e => e.EquipmentWarrantyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_WarrantyDate");

                entity.Property(e => e.MeasurementLinkType)
                    .HasMaxLength(20)
                    .HasColumnName("Measurement_LinkType");

                entity.Property(e => e.MeasurementMeasUnit)
                    .HasMaxLength(60)
                    .HasColumnName("Measurement_MeasUnit");

                entity.Property(e => e.PdmCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_CBCode");

                entity.Property(e => e.PdmChangeRemark).HasColumnName("PDM_ChangeRemark");

                entity.Property(e => e.PdmClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_ClientCode");

                entity.Property(e => e.PdmContact)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Contact");

                entity.Property(e => e.PdmContactPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PDM_ContactPhone");

                entity.Property(e => e.PdmCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_CrAccount");

                entity.Property(e => e.PdmCraft)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Craft");

                entity.Property(e => e.PdmCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_CreatedBy");

                entity.Property(e => e.PdmCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDM_CreationDate");

                entity.Property(e => e.PdmCrew)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Crew");

                entity.Property(e => e.PdmDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Department");

                entity.Property(e => e.PdmDirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PDM_DirtyLog");

                entity.Property(e => e.PdmDivision)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Division");

                entity.Property(e => e.PdmDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_DrAccount");

                entity.Property(e => e.PdmDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_Duration");

                entity.Property(e => e.PdmEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Employee");

                entity.Property(e => e.PdmEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Equipment");

                entity.Property(e => e.PdmEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PDM_EquipmentDesc");

                entity.Property(e => e.PdmHighLimit)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_HighLimit");

                entity.Property(e => e.PdmHighLimitEmail)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighLimitEmail");

                entity.Property(e => e.PdmHighLimitProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighLimitProc");

                entity.Property(e => e.PdmHighWarning)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_HighWarning");

                entity.Property(e => e.PdmHighWarningEmail)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighWarningEmail");

                entity.Property(e => e.PdmHighWarningProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_HighWarningProc");

                entity.Property(e => e.PdmInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_Inactive");

                entity.Property(e => e.PdmLastWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LastWoNum");

                entity.Property(e => e.PdmLocation)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Location");

                entity.Property(e => e.PdmLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PDM_LocationDesc");

                entity.Property(e => e.PdmLowLimit)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_LowLimit");

                entity.Property(e => e.PdmLowLimitEmail)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowLimitEmail");

                entity.Property(e => e.PdmLowLimitProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowLimitProc");

                entity.Property(e => e.PdmLowWarning)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_LowWarning");

                entity.Property(e => e.PdmLowWarningEmail)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowWarningEmail");

                entity.Property(e => e.PdmLowWarningProc)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_LowWarningProc");

                entity.Property(e => e.PdmManager)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Manager");

                entity.Property(e => e.PdmMeasurementName)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_MeasurementName");

                entity.Property(e => e.PdmModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_ModifyBy");

                entity.Property(e => e.PdmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDM_ModifyDate");

                entity.Property(e => e.PdmOpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PDM_OpenWO");

                entity.Property(e => e.PdmOperator)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Operator");

                entity.Property(e => e.PdmPdm1)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDM1");

                entity.Property(e => e.PdmPdm10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_PDM10");

                entity.Property(e => e.PdmPdm2)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDM2");

                entity.Property(e => e.PdmPdm3)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDM3");

                entity.Property(e => e.PdmPdm4)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDM4");

                entity.Property(e => e.PdmPdm5)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDM5");

                entity.Property(e => e.PdmPdm6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_PDM6");

                entity.Property(e => e.PdmPdm7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_PDM7");

                entity.Property(e => e.PdmPdm8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_PDM8");

                entity.Property(e => e.PdmPdm9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM_PDM9");

                entity.Property(e => e.PdmPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_PDMNum");

                entity.Property(e => e.PdmPriority)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Priority");

                entity.Property(e => e.PdmRequest).HasColumnName("PDM_Request");

                entity.Property(e => e.PdmRoom)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_Room");

                entity.Property(e => e.PdmWoType)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_WoType");

                entity.Property(e => e.PdmWostatus)
                    .HasMaxLength(60)
                    .HasColumnName("PDM_WOStatus");

                entity.Property(e => e.PdmhistoryActionTriggered)
                    .HasMaxLength(20)
                    .HasColumnName("PDMHistory_ActionTriggered");

                entity.Property(e => e.PdmhistoryCounter)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("PDMHistory_Counter");

                entity.Property(e => e.PdmhistoryCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDMHistory_CreationDate");

                entity.Property(e => e.PdmhistoryMeasurementReading)
                    .HasMaxLength(60)
                    .HasColumnName("PDMHistory_MeasurementReading");

                entity.Property(e => e.PdmhistoryPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDMHistory_PDMNum");

                entity.Property(e => e.PdmhistoryTransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PDMHistory_TransDate");

                entity.Property(e => e.PdmhistoryWonum)
                    .HasMaxLength(60)
                    .HasColumnName("PDMHistory_WONum");
            });

            modelBuilder.Entity<VPdmrecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PDMRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.HighLimit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HighLimitEmail).HasMaxLength(60);

                entity.Property(e => e.HighLimitProc).HasMaxLength(60);

                entity.Property(e => e.HighWarning).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HighWarningEmail).HasMaxLength(60);

                entity.Property(e => e.HighWarningProc).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.LowLimit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LowLimitEmail).HasMaxLength(60);

                entity.Property(e => e.LowLimitProc).HasMaxLength(60);

                entity.Property(e => e.LowWarning).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LowWarningEmail).HasMaxLength(60);

                entity.Property(e => e.LowWarningProc).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MeasurementName).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pdm1)
                    .HasMaxLength(60)
                    .HasColumnName("PDM1");

                entity.Property(e => e.Pdm10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM10");

                entity.Property(e => e.Pdm2)
                    .HasMaxLength(60)
                    .HasColumnName("PDM2");

                entity.Property(e => e.Pdm3)
                    .HasMaxLength(60)
                    .HasColumnName("PDM3");

                entity.Property(e => e.Pdm4)
                    .HasMaxLength(60)
                    .HasColumnName("PDM4");

                entity.Property(e => e.Pdm5)
                    .HasMaxLength(60)
                    .HasColumnName("PDM5");

                entity.Property(e => e.Pdm6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM6");

                entity.Property(e => e.Pdm7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM7");

                entity.Property(e => e.Pdm8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM8");

                entity.Property(e => e.Pdm9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PDM9");

                entity.Property(e => e.Pdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("PDMNum");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");
            });

            modelBuilder.Entity<VPhasebalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PHASEBALANCE");

                entity.Property(e => e.Budget)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("budget");

                entity.Property(e => e.Id)
                    .HasMaxLength(120)
                    .HasColumnName("ID");

                entity.Property(e => e.Manager)
                    .HasMaxLength(60)
                    .HasColumnName("manager");

                entity.Property(e => e.Phase)
                    .HasMaxLength(60)
                    .HasColumnName("phase");

                entity.Property(e => e.PhaseBalance).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Prjtype)
                    .HasMaxLength(60)
                    .HasColumnName("prjtype");

                entity.Property(e => e.Projectid)
                    .HasMaxLength(60)
                    .HasColumnName("projectid");
            });

            modelBuilder.Entity<VPmPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PM_PRINT");

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.LocationDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHLSD");

                entity.Property(e => e.LocationDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHRange");

                entity.Property(e => e.LocationDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHSect");

                entity.Property(e => e.LocationDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHTownShip");

                entity.Property(e => e.LocationSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfLSD");

                entity.Property(e => e.LocationSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfRange");

                entity.Property(e => e.LocationSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfSect");

                entity.Property(e => e.LocationSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfTownShip");

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.PmAvgUsage)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_AvgUsage");

                entity.Property(e => e.PmCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PM_CBCode");

                entity.Property(e => e.PmClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("PM_ClientCode");

                entity.Property(e => e.PmContact)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Contact");

                entity.Property(e => e.PmContactPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PM_ContactPhone");

                entity.Property(e => e.PmCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PM_CrAccount");

                entity.Property(e => e.PmCraft)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Craft");

                entity.Property(e => e.PmCrew)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Crew");

                entity.Property(e => e.PmCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Customer");

                entity.Property(e => e.PmDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Department");

                entity.Property(e => e.PmDivision)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Division");

                entity.Property(e => e.PmDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PM_DrAccount");

                entity.Property(e => e.PmDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_Duration");

                entity.Property(e => e.PmEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Employee");

                entity.Property(e => e.PmEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Equipment");

                entity.Property(e => e.PmEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PM_EquipmentDesc");

                entity.Property(e => e.PmEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstHours");

                entity.Property(e => e.PmEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstLabor");

                entity.Property(e => e.PmEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstMaterial");

                entity.Property(e => e.PmEstMileage)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstMileage");

                entity.Property(e => e.PmEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstService");

                entity.Property(e => e.PmEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_EstTools");

                entity.Property(e => e.PmInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PM_Inactive");

                entity.Property(e => e.PmIntervalUnit)
                    .HasMaxLength(60)
                    .HasColumnName("PM_IntervalUnit");

                entity.Property(e => e.PmIsLocked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PM_IsLocked");

                entity.Property(e => e.PmLastIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PM_LastIssueDate");

                entity.Property(e => e.PmLastPmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PM_LastPMDate");

                entity.Property(e => e.PmLastPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_LastPMReading");

                entity.Property(e => e.PmLastPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_LastPMReading2");

                entity.Property(e => e.PmLocation)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Location");

                entity.Property(e => e.PmLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("PM_LocationDesc");

                entity.Property(e => e.PmManager)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Manager");

                entity.Property(e => e.PmMeterInterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PM_MeterInterval");

                entity.Property(e => e.PmMeterInterval2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PM_MeterInterval2");

                entity.Property(e => e.PmMeterName)
                    .HasMaxLength(60)
                    .HasColumnName("PM_MeterName");

                entity.Property(e => e.PmMeterName2)
                    .HasMaxLength(60)
                    .HasColumnName("PM_MeterName2");

                entity.Property(e => e.PmMeterRange)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_MeterRange");

                entity.Property(e => e.PmMeterRange2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_MeterRange2");

                entity.Property(e => e.PmNestedPm)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PM_NestedPM");

                entity.Property(e => e.PmNextDueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PM_NextDueDate");

                entity.Property(e => e.PmNextPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_NextPMReading");

                entity.Property(e => e.PmNextPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PM_NextPMReading2");

                entity.Property(e => e.PmOverrideDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PM_OverrideDate");

                entity.Property(e => e.PmPmNum)
                    .HasMaxLength(60)
                    .HasColumnName("PM_PmNum");

                entity.Property(e => e.PmPmgenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PM_PMGenDate");

                entity.Property(e => e.PmPminterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PM_PMInterval");

                entity.Property(e => e.PmPriority)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Priority");

                entity.Property(e => e.PmProcnum)
                    .HasMaxLength(60)
                    .HasColumnName("PM_procnum");

                entity.Property(e => e.PmRequest).HasColumnName("PM_Request");

                entity.Property(e => e.PmRoom)
                    .HasMaxLength(60)
                    .HasColumnName("PM_Room");

                entity.Property(e => e.PmRouteName)
                    .HasMaxLength(60)
                    .HasColumnName("PM_RouteName");

                entity.Property(e => e.PmWoType)
                    .HasMaxLength(60)
                    .HasColumnName("PM_WoType");

                entity.Property(e => e.PmWostatus)
                    .HasMaxLength(60)
                    .HasColumnName("PM_WOStatus");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");
            });

            modelBuilder.Entity<VPmdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PMDetail");

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgUsage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IntervalUnit).HasMaxLength(60);

                entity.Property(e => e.IsLocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPMDate");

                entity.Property(e => e.LastPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading");

                entity.Property(e => e.LastPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading2");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MeterInterval).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterInterval2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterName2).HasMaxLength(60);

                entity.Property(e => e.MeterRange).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterRange2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NestedPm)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("NestedPM");

                entity.Property(e => e.NextDueDate).HasColumnType("datetime");

                entity.Property(e => e.NextPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading");

                entity.Property(e => e.NextPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading2");

                entity.Property(e => e.OnDue).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OverrideDate).HasColumnType("datetime");

                entity.Property(e => e.Pm1)
                    .HasMaxLength(60)
                    .HasColumnName("pm1");

                entity.Property(e => e.Pm2)
                    .HasMaxLength(60)
                    .HasColumnName("pm2");

                entity.Property(e => e.Pm3).HasColumnName("pm3");

                entity.Property(e => e.Pm4).HasColumnName("pm4");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PmgenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMGenDate");

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VPmequipment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PMEquipment");

                entity.Property(e => e.AvgUsage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqinactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("EQInactive");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IntervalUnit).HasMaxLength(60);

                entity.Property(e => e.IsLocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPMDate");

                entity.Property(e => e.LastPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading");

                entity.Property(e => e.LastPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading2");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MeterInterval).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterInterval2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterName2).HasMaxLength(60);

                entity.Property(e => e.MeterRange).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterRange2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NestedPm)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("NestedPM");

                entity.Property(e => e.NextDueDate).HasColumnType("datetime");

                entity.Property(e => e.NextPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading");

                entity.Property(e => e.NextPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading2");

                entity.Property(e => e.OnDue).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OverrideDate).HasColumnType("datetime");

                entity.Property(e => e.Pm1)
                    .HasMaxLength(60)
                    .HasColumnName("pm1");

                entity.Property(e => e.Pm2)
                    .HasMaxLength(60)
                    .HasColumnName("pm2");

                entity.Property(e => e.Pm3).HasColumnName("pm3");

                entity.Property(e => e.Pm4).HasColumnName("pm4");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PmgenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMGenDate");

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VPmrecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PMRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AvgUsage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IntervalUnit).HasMaxLength(60);

                entity.Property(e => e.IsLocked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPMDate");

                entity.Property(e => e.LastPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading");

                entity.Property(e => e.LastPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LastPMReading2");

                entity.Property(e => e.LastWoNum).HasMaxLength(60);

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.MeterInterval).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterInterval2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterName).HasMaxLength(60);

                entity.Property(e => e.MeterName2).HasMaxLength(60);

                entity.Property(e => e.MeterRange).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MeterRange2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NestedPm)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("NestedPM");

                entity.Property(e => e.NextDueDate).HasColumnType("datetime");

                entity.Property(e => e.NextPmreading)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading");

                entity.Property(e => e.NextPmreading2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("NextPMReading2");

                entity.Property(e => e.OnDue).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenWo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenWO");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OverrideDate).HasColumnType("datetime");

                entity.Property(e => e.Pm1)
                    .HasMaxLength(60)
                    .HasColumnName("pm1");

                entity.Property(e => e.Pm2)
                    .HasMaxLength(60)
                    .HasColumnName("pm2");

                entity.Property(e => e.Pm3).HasColumnName("pm3");

                entity.Property(e => e.Pm4).HasColumnName("pm4");

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PmgenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PMGenDate");

                entity.Property(e => e.Pminterval)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PMInterval");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VPoPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PO_PRINT");

                entity.Property(e => e.CityPlusState).HasMaxLength(122);

                entity.Property(e => e.CountryPlusZip).HasMaxLength(122);

                entity.Property(e => e.PoBaseCurrencyTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_BaseCurrencyTotal");

                entity.Property(e => e.PoBillAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress1");

                entity.Property(e => e.PoBillAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress2");

                entity.Property(e => e.PoBillAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress3");

                entity.Property(e => e.PoBillAddress4)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress4");

                entity.Property(e => e.PoBillAddress5)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress5");

                entity.Property(e => e.PoBillPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PO_BillPhone");

                entity.Property(e => e.PoBillTo)
                    .HasMaxLength(60)
                    .HasColumnName("PO_BillTo");

                entity.Property(e => e.PoCloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_CloseDate");

                entity.Property(e => e.PoCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_CrAccount");

                entity.Property(e => e.PoCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Customer");

                entity.Property(e => e.PoDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Department");

                entity.Property(e => e.PoDivision)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Division");

                entity.Property(e => e.PoDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_DrAccount");

                entity.Property(e => e.PoEmpid)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Empid");

                entity.Property(e => e.PoExchangeAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_ExchangeAccount");

                entity.Property(e => e.PoExchangeRate)
                    .HasColumnType("numeric(18, 10)")
                    .HasColumnName("PO_ExchangeRate");

                entity.Property(e => e.PoFreight)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_Freight");

                entity.Property(e => e.PoManager)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Manager");

                entity.Property(e => e.PoOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_OpenDate");

                entity.Property(e => e.PoPo1)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PO1");

                entity.Property(e => e.PoPo10)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PO_po10");

                entity.Property(e => e.PoPo2)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PO2");

                entity.Property(e => e.PoPo3)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PO3");

                entity.Property(e => e.PoPo4)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PO4");

                entity.Property(e => e.PoPo9)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("PO_po9");

                entity.Property(e => e.PoPoDesc).HasColumnName("PO_PoDesc");

                entity.Property(e => e.PoPoNum)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PoNum");

                entity.Property(e => e.PoPoTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_PoTotal");

                entity.Property(e => e.PoPotype)
                    .HasMaxLength(60)
                    .HasColumnName("PO_POType");

                entity.Property(e => e.PoPriority)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Priority");

                entity.Property(e => e.PoPromisedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_PromisedDate");

                entity.Property(e => e.PoRequiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_RequiredDate");

                entity.Property(e => e.PoShipAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PO_ShipAddress1");

                entity.Property(e => e.PoShipAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PO_ShipAddress2");

                entity.Property(e => e.PoShipAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PO_ShipAddress3");

                entity.Property(e => e.PoShipAddress4)
                    .HasMaxLength(100)
                    .HasColumnName("PO_ShipAddress4");

                entity.Property(e => e.PoShipAddress5)
                    .HasMaxLength(100)
                    .HasColumnName("PO_ShipAddress5");

                entity.Property(e => e.PoShipPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PO_ShipPhone");

                entity.Property(e => e.PoShipTo)
                    .HasMaxLength(60)
                    .HasColumnName("PO_ShipTo");

                entity.Property(e => e.PoStatus)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Status");

                entity.Property(e => e.PoStatuscode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("PO_statuscode");

                entity.Property(e => e.PoSubTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_SubTotal");

                entity.Property(e => e.PoTax1Total)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_Tax1Total");

                entity.Property(e => e.PoTax2Total)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_Tax2Total");

                entity.Property(e => e.PoTerms).HasColumnName("PO_Terms");

                entity.Property(e => e.PoTermsCode)
                    .HasMaxLength(60)
                    .HasColumnName("PO_TermsCode");

                entity.Property(e => e.PoTotalWithFreight).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.PoVendor)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Vendor");

                entity.Property(e => e.PoVendorCurrency)
                    .HasMaxLength(60)
                    .HasColumnName("PO_VendorCurrency");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.VendorAcctContact)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_AcctContact");

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Address1");

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Address2");

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_City");

                entity.Property(e => e.VendorCompanyCode)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_CompanyCode");

                entity.Property(e => e.VendorContact)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Contact");

                entity.Property(e => e.VendorContractNum)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_ContractNum");

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Country");

                entity.Property(e => e.VendorDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Division");

                entity.Property(e => e.VendorEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_Email");

                entity.Property(e => e.VendorFax)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Fax");

                entity.Property(e => e.VendorParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_ParentID");

                entity.Property(e => e.VendorPhone)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Phone");

                entity.Property(e => e.VendorState)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_State");

                entity.Property(e => e.VendorTax1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("Vendor_Tax1");

                entity.Property(e => e.VendorTax2)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("Vendor_Tax2");

                entity.Property(e => e.VendorTaxid1)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Taxid1");

                entity.Property(e => e.VendorTaxid2)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Taxid2");

                entity.Property(e => e.VendorUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_URL");

                entity.Property(e => e.VendorVendCategory)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendCategory");

                entity.Property(e => e.VendorVendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendCustID");

                entity.Property(e => e.VendorVendName)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_VendName");

                entity.Property(e => e.VendorVendTerms)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendTerms");

                entity.Property(e => e.VendorVendorCurrency)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_VendorCurrency");

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(20)
                    .HasColumnName("Vendor_Zip");
            });

            modelBuilder.Entity<VPoh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_POH");

                entity.Property(e => e.PoBaseCurrencyTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_BaseCurrencyTotal");

                entity.Property(e => e.PoBillAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress1");

                entity.Property(e => e.PoBillAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress2");

                entity.Property(e => e.PoBillAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress3");

                entity.Property(e => e.PoBillAddress4)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress4");

                entity.Property(e => e.PoBillAddress5)
                    .HasMaxLength(100)
                    .HasColumnName("PO_BillAddress5");

                entity.Property(e => e.PoBillPhone)
                    .HasMaxLength(30)
                    .HasColumnName("PO_BillPhone");

                entity.Property(e => e.PoBillTo)
                    .HasMaxLength(60)
                    .HasColumnName("PO_BillTo");

                entity.Property(e => e.PoChangeRemark).HasColumnName("PO_ChangeRemark");

                entity.Property(e => e.PoCloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_CloseDate");

                entity.Property(e => e.PoCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_CrAccount");

                entity.Property(e => e.PoCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("PO_CreatedBy");

                entity.Property(e => e.PoCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_CreationDate");

                entity.Property(e => e.PoCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Customer");

                entity.Property(e => e.PoDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Department");

                entity.Property(e => e.PoDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("PO_DirtyLog");

                entity.Property(e => e.PoDivision)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Division");

                entity.Property(e => e.PoDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_DrAccount");

                entity.Property(e => e.PoEmpid)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Empid");

                entity.Property(e => e.PoExchangeAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PO_ExchangeAccount");

                entity.Property(e => e.PoExchangeRate)
                    .HasColumnType("numeric(18, 10)")
                    .HasColumnName("PO_ExchangeRate");

                entity.Property(e => e.PoFreight)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_Freight");

                entity.Property(e => e.PoManager)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Manager");

                entity.Property(e => e.PoModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("PO_ModifyBy");

                entity.Property(e => e.PoPoDesc).HasColumnName("PO_PoDesc");

                entity.Property(e => e.PoPoNum)
                    .HasMaxLength(60)
                    .HasColumnName("PO_PoNum");

                entity.Property(e => e.PoPoTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_PoTotal");

                entity.Property(e => e.PoPotype)
                    .HasMaxLength(60)
                    .HasColumnName("PO_POType");

                entity.Property(e => e.PoPriority)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Priority");

                entity.Property(e => e.PoShipTo)
                    .HasMaxLength(60)
                    .HasColumnName("PO_ShipTo");

                entity.Property(e => e.PoStatus)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Status");

                entity.Property(e => e.PoSubTotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("PO_SubTotal");

                entity.Property(e => e.PoVendor)
                    .HasMaxLength(60)
                    .HasColumnName("PO_Vendor");

                entity.Property(e => e.PoVendorCurrency)
                    .HasMaxLength(60)
                    .HasColumnName("PO_VendorCurrency");

                entity.Property(e => e.PohistoryCounter).HasColumnName("POHistory_Counter");

                entity.Property(e => e.PohistoryCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("POHistory_CreatedBy");

                entity.Property(e => e.PohistoryCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POHistory_CreationDate");

                entity.Property(e => e.PohistoryModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("POHistory_ModifyBy");

                entity.Property(e => e.PohistoryModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POHistory_ModifyDate");

                entity.Property(e => e.PohistoryOperator)
                    .HasMaxLength(60)
                    .HasColumnName("POHistory_Operator");

                entity.Property(e => e.PohistoryPoNum)
                    .HasMaxLength(60)
                    .HasColumnName("POHistory_PoNum");

                entity.Property(e => e.PohistoryRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("POHistory_Remark");
            });

            modelBuilder.Entity<VPoinvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_POInvoice");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(60);

                entity.Property(e => e.InvoicePrice).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.InvoiceQty).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.InvoiceSubTotal).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.InvoiceTax1).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.InvoiceTax2).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineAmount).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.LineNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NewEquip).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenFlag).HasMaxLength(1);

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OrderQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.SubTotalWithTax2).HasColumnType("numeric(22, 4)");

                entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");
            });

            modelBuilder.Entity<VPoinvoiceHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_POInvoiceHeader");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(60)
                    .HasColumnName("PONumber");

                entity.Property(e => e.Tax1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorInvoiceNo).HasMaxLength(60);
            });

            modelBuilder.Entity<VPorecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PORecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BillAddress1).HasMaxLength(100);

                entity.Property(e => e.BillAddress2).HasMaxLength(100);

                entity.Property(e => e.BillAddress3).HasMaxLength(100);

                entity.Property(e => e.BillPhone).HasMaxLength(30);

                entity.Property(e => e.BillTo).HasMaxLength(60);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.Freight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OpenPo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("OpenPO");

                entity.Property(e => e.Po1)
                    .HasMaxLength(60)
                    .HasColumnName("PO1");

                entity.Property(e => e.Po10)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po10");

                entity.Property(e => e.Po2)
                    .HasMaxLength(60)
                    .HasColumnName("PO2");

                entity.Property(e => e.Po3)
                    .HasMaxLength(60)
                    .HasColumnName("PO3");

                entity.Property(e => e.Po4)
                    .HasMaxLength(60)
                    .HasColumnName("PO4");

                entity.Property(e => e.Po9)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("po9");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PoTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Potype)
                    .HasMaxLength(60)
                    .HasColumnName("POType");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1).HasMaxLength(100);

                entity.Property(e => e.ShipAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipAddress3).HasMaxLength(100);

                entity.Property(e => e.ShipPhone).HasMaxLength(30);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Total).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TermsCode).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);
            });

            modelBuilder.Entity<VPrintFormObject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PrintFormObject");

                entity.Property(e => e.ControlId)
                    .HasMaxLength(60)
                    .HasColumnName("ControlID");

                entity.Property(e => e.ControlName).HasMaxLength(63);

                entity.Property(e => e.ControlType).HasMaxLength(30);

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DbField).HasMaxLength(60);

                entity.Property(e => e.DbTable).HasMaxLength(60);

                entity.Property(e => e.Mastercounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mastercounter");

                entity.Property(e => e.SubType).HasMaxLength(20);
            });

            modelBuilder.Entity<VProcPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PROC_PRINT");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.LocationDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHLSD");

                entity.Property(e => e.LocationDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHRange");

                entity.Property(e => e.LocationDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHSect");

                entity.Property(e => e.LocationDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_DHTownShip");

                entity.Property(e => e.LocationSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfLSD");

                entity.Property(e => e.LocationSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfRange");

                entity.Property(e => e.LocationSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfSect");

                entity.Property(e => e.LocationSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Location_SurfTownShip");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.ProceduresCbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Procedures_CBCode");

                entity.Property(e => e.ProceduresClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_ClientCode");

                entity.Property(e => e.ProceduresContact)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Contact");

                entity.Property(e => e.ProceduresContactPhone)
                    .HasMaxLength(30)
                    .HasColumnName("Procedures_ContactPhone");

                entity.Property(e => e.ProceduresCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_CrAccount");

                entity.Property(e => e.ProceduresCraft)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Craft");

                entity.Property(e => e.ProceduresCrew)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Crew");

                entity.Property(e => e.ProceduresDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Department");

                entity.Property(e => e.ProceduresDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Division");

                entity.Property(e => e.ProceduresDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_DrAccount");

                entity.Property(e => e.ProceduresDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_Duration");

                entity.Property(e => e.ProceduresEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Employee");

                entity.Property(e => e.ProceduresEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Equipment");

                entity.Property(e => e.ProceduresEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Procedures_EquipmentDesc");

                entity.Property(e => e.ProceduresEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_EstHours");

                entity.Property(e => e.ProceduresEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_EstLabor");

                entity.Property(e => e.ProceduresEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_EstMaterial");

                entity.Property(e => e.ProceduresEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_EstService");

                entity.Property(e => e.ProceduresEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Procedures_EstTools");

                entity.Property(e => e.ProceduresLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Location");

                entity.Property(e => e.ProceduresLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Procedures_LocationDesc");

                entity.Property(e => e.ProceduresManager)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Manager");

                entity.Property(e => e.ProceduresMasterRec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Procedures_MasterRec");

                entity.Property(e => e.ProceduresPriority)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Priority");

                entity.Property(e => e.ProceduresProcnum)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_procnum");

                entity.Property(e => e.ProceduresRequest).HasColumnName("Procedures_Request");

                entity.Property(e => e.ProceduresRequester)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Requester");

                entity.Property(e => e.ProceduresRoom)
                    .HasMaxLength(60)
                    .HasColumnName("Procedures_Room");
            });

            modelBuilder.Entity<VProcRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProcRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pr1)
                    .HasMaxLength(60)
                    .HasColumnName("pr1");

                entity.Property(e => e.Pr2)
                    .HasMaxLength(60)
                    .HasColumnName("pr2");

                entity.Property(e => e.Pr3)
                    .HasMaxLength(60)
                    .HasColumnName("pr3");

                entity.Property(e => e.Pr4)
                    .HasMaxLength(60)
                    .HasColumnName("pr4");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Procedures");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pr1)
                    .HasMaxLength(60)
                    .HasColumnName("pr1");

                entity.Property(e => e.Pr2)
                    .HasMaxLength(60)
                    .HasColumnName("pr2");

                entity.Property(e => e.Pr3)
                    .HasMaxLength(60)
                    .HasColumnName("pr3");

                entity.Property(e => e.Pr4)
                    .HasMaxLength(60)
                    .HasColumnName("pr4");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VProceduresDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProceduresDetail");

                entity.Property(e => e.Cbcode)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("CBCode");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Pr1)
                    .HasMaxLength(60)
                    .HasColumnName("pr1");

                entity.Property(e => e.Pr2)
                    .HasMaxLength(60)
                    .HasColumnName("pr2");

                entity.Property(e => e.Pr3)
                    .HasMaxLength(60)
                    .HasColumnName("pr3");

                entity.Property(e => e.Pr4)
                    .HasMaxLength(60)
                    .HasColumnName("pr4");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VProjectRecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Prj1)
                    .HasMaxLength(60)
                    .HasColumnName("prj1");

                entity.Property(e => e.Prj10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Prj2)
                    .HasMaxLength(60)
                    .HasColumnName("prj2");

                entity.Property(e => e.Prj3)
                    .HasMaxLength(60)
                    .HasColumnName("prj3");

                entity.Property(e => e.Prj4)
                    .HasMaxLength(60)
                    .HasColumnName("prj4");

                entity.Property(e => e.Prj5)
                    .HasMaxLength(60)
                    .HasColumnName("prj5");

                entity.Property(e => e.Prj6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("prj6");

                entity.Property(e => e.Prj7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("prj7");

                entity.Property(e => e.Prj8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("prj8");

                entity.Property(e => e.Prj9).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PrjType).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.UserId).HasMaxLength(60);
            });

            modelBuilder.Entity<VProjectReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PROJECT_REPORT");

                entity.Property(e => e.PhaseBudget)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Phase_Budget");

                entity.Property(e => e.PhaseDescription).HasColumnName("Phase_Description");

                entity.Property(e => e.PhaseEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Phase_EndDate");

                entity.Property(e => e.PhasePercentage)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Phase_Percentage");

                entity.Property(e => e.PhasePhase)
                    .HasMaxLength(60)
                    .HasColumnName("Phase_Phase");

                entity.Property(e => e.PhasePhaseOrder)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Phase_PhaseOrder");

                entity.Property(e => e.PhaseStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Phase_StartDate");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.ProjectsCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_Customer");

                entity.Property(e => e.ProjectsDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_Department");

                entity.Property(e => e.ProjectsDescription).HasColumnName("Projects_Description");

                entity.Property(e => e.ProjectsDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_Division");

                entity.Property(e => e.ProjectsEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Projects_EndDate");

                entity.Property(e => e.ProjectsManager)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_Manager");

                entity.Property(e => e.ProjectsModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Projects_ModifyDate");

                entity.Property(e => e.ProjectsOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Projects_OpenDate");

                entity.Property(e => e.ProjectsPrjType)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_PrjType");

                entity.Property(e => e.ProjectsProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_ProjectId");

                entity.Property(e => e.ProjectsStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Projects_StartDate");

                entity.Property(e => e.ProjectsStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Projects_Status");
            });

            modelBuilder.Entity<VProjectcost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PROJECTCOSTS");

                entity.Property(e => e.Costs)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("costs");

                entity.Property(e => e.Costs2)
                    .HasColumnType("numeric(24, 4)")
                    .HasColumnName("costs2");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id)
                    .HasMaxLength(120)
                    .HasColumnName("ID");

                entity.Property(e => e.Idnum)
                    .HasMaxLength(60)
                    .HasColumnName("idnum");

                entity.Property(e => e.Manager)
                    .HasMaxLength(60)
                    .HasColumnName("manager");

                entity.Property(e => e.ManagerName).HasMaxLength(101);

                entity.Property(e => e.Phase)
                    .HasMaxLength(60)
                    .HasColumnName("phase");

                entity.Property(e => e.Prjtype)
                    .HasMaxLength(60)
                    .HasColumnName("prjtype");

                entity.Property(e => e.Projectid)
                    .HasMaxLength(60)
                    .HasColumnName("projectid");

                entity.Property(e => e.Seq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("seq");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Title2)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("title2");
            });

            modelBuilder.Entity<VReadyToPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReadyToPost");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpGroup).HasMaxLength(60);

                entity.Property(e => e.EmpTitle).HasMaxLength(30);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Employee).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Emppword).HasMaxLength(40);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Lab1)
                    .HasMaxLength(60)
                    .HasColumnName("lab1");

                entity.Property(e => e.Lab2)
                    .HasMaxLength(60)
                    .HasColumnName("lab2");

                entity.Property(e => e.Lab3)
                    .HasMaxLength(60)
                    .HasColumnName("lab3");

                entity.Property(e => e.Lab4)
                    .HasMaxLength(60)
                    .HasColumnName("lab4");

                entity.Property(e => e.Lab5).HasMaxLength(60);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcid)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("LCID");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StandardRate).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Userflags)
                    .HasMaxLength(10)
                    .HasColumnName("userflags");

                entity.Property(e => e.Wlcounter)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("wlcounter");

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VReceivingPoline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReceivingPOLine");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BillPhone).HasMaxLength(30);

                entity.Property(e => e.BillTo).HasMaxLength(60);

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeAccount).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.NewEquip).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OpenFlag).HasMaxLength(1);

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OrderQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PoNum).HasMaxLength(60);

                entity.Property(e => e.PocrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("POCrAccount");

                entity.Property(e => e.PodrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("PODrAccount");

                entity.Property(e => e.Potype)
                    .HasMaxLength(60)
                    .HasColumnName("POType");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseAgent).HasMaxLength(60);

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.ReceiveQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ShipPhone).HasMaxLength(30);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");
            });

            modelBuilder.Entity<VReportWithFieldAlias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportWithFieldAlias");

                entity.Property(e => e.Aliaslist).HasColumnName("aliaslist");

                entity.Property(e => e.Availableto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("availableto");

                entity.Property(e => e.Charttype)
                    .HasMaxLength(60)
                    .HasColumnName("charttype");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DefaultListReport).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DirectSql)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("DirectSQL");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.Division)
                    .HasMaxLength(60)
                    .HasColumnName("division");

                entity.Property(e => e.Divisiontype)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("divisiontype");

                entity.Property(e => e.IsSystem)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("isSystem");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Printowner)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("printowner");

                entity.Property(e => e.Printsql)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("printsql");

                entity.Property(e => e.Reportdesc)
                    .HasMaxLength(255)
                    .HasColumnName("reportdesc");

                entity.Property(e => e.Reportmodule)
                    .HasMaxLength(30)
                    .HasColumnName("reportmodule");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(60)
                    .HasColumnName("reportname");

                entity.Property(e => e.Reportowner)
                    .HasMaxLength(60)
                    .HasColumnName("reportowner");

                entity.Property(e => e.Sqltext).HasColumnName("SQLTEXT");

                entity.Property(e => e.Tablelist).HasColumnName("tablelist");
            });

            modelBuilder.Entity<VReqrecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_REQRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ActualCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AuthorizationDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationId).HasMaxLength(60);

                entity.Property(e => e.AuthorizationSignature).HasMaxLength(100);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CredentialStatus).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DeptApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.DeptApprovalId).HasMaxLength(60);

                entity.Property(e => e.DeptSignature).HasMaxLength(100);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DivisionApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionApprovalId).HasMaxLength(60);

                entity.Property(e => e.DivisionSignature).HasMaxLength(100);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FacultyUse).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsKeyRequest).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.RecipientEndAccess).HasColumnType("datetime");

                entity.Property(e => e.RecipientFirstName).HasMaxLength(60);

                entity.Property(e => e.RecipientId).HasMaxLength(60);

                entity.Property(e => e.RecipientLastName).HasMaxLength(60);

                entity.Property(e => e.RecipientLocation).HasMaxLength(255);

                entity.Property(e => e.RecipientStartAccess).HasColumnType("datetime");

                entity.Property(e => e.RecipientSupervisor).HasMaxLength(60);

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.Rq1)
                    .HasMaxLength(60)
                    .HasColumnName("rq1");

                entity.Property(e => e.Rq10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq10");

                entity.Property(e => e.Rq2)
                    .HasMaxLength(60)
                    .HasColumnName("rq2");

                entity.Property(e => e.Rq3)
                    .HasMaxLength(60)
                    .HasColumnName("rq3");

                entity.Property(e => e.Rq4)
                    .HasMaxLength(60)
                    .HasColumnName("rq4");

                entity.Property(e => e.Rq5)
                    .HasMaxLength(60)
                    .HasColumnName("rq5");

                entity.Property(e => e.Rq6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq6");

                entity.Property(e => e.Rq7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq7");

                entity.Property(e => e.Rq8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq8");

                entity.Property(e => e.Rq9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("rq9");

                entity.Property(e => e.Rtsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("RTSDate");

                entity.Property(e => e.ShipAddress1).HasMaxLength(100);

                entity.Property(e => e.ShipAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipAddress3).HasMaxLength(100);

                entity.Property(e => e.ShipPhone).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.StatusFlags).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);
            });

            modelBuilder.Entity<VRequestLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RequestLine");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ipa)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("IPA");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.Issuedqty)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("issuedqty");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(60);

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Qtyonorder)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("qtyonorder");

                entity.Property(e => e.Qtyreserved)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("qtyreserved");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.RequestQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusFlags).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VRequisition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_REQUISITION");

                entity.Property(e => e.InactiveIr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("inactiveIR");

                entity.Property(e => e.ItemRequestActualCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_ActualCost");

                entity.Property(e => e.ItemRequestCloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemRequest_CloseDate");

                entity.Property(e => e.ItemRequestCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_CrAccount");

                entity.Property(e => e.ItemRequestCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Customer");

                entity.Property(e => e.ItemRequestDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Department");

                entity.Property(e => e.ItemRequestDescription).HasColumnName("ItemRequest_Description");

                entity.Property(e => e.ItemRequestDirtyLog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ItemRequest_DirtyLog");

                entity.Property(e => e.ItemRequestDivision)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Division");

                entity.Property(e => e.ItemRequestDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_DrAccount");

                entity.Property(e => e.ItemRequestInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ItemRequest_Inactive");

                entity.Property(e => e.ItemRequestModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemRequest_ModifyDate");

                entity.Property(e => e.ItemRequestOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemRequest_OpenDate");

                entity.Property(e => e.ItemRequestOperator)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Operator");

                entity.Property(e => e.ItemRequestPhone)
                    .HasMaxLength(30)
                    .HasColumnName("ItemRequest_Phone");

                entity.Property(e => e.ItemRequestPriority)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Priority");

                entity.Property(e => e.ItemRequestReqNum)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_ReqNum");

                entity.Property(e => e.ItemRequestRequester)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Requester");

                entity.Property(e => e.ItemRequestRequiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemRequest_RequiredDate");

                entity.Property(e => e.ItemRequestRq1)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_rq1");

                entity.Property(e => e.ItemRequestRq10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_rq10");

                entity.Property(e => e.ItemRequestRq2)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_rq2");

                entity.Property(e => e.ItemRequestRq3)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_rq3");

                entity.Property(e => e.ItemRequestRq4)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_rq4");

                entity.Property(e => e.ItemRequestRq5)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_rq5");

                entity.Property(e => e.ItemRequestRq6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_rq6");

                entity.Property(e => e.ItemRequestRq7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_rq7");

                entity.Property(e => e.ItemRequestRq8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_rq8");

                entity.Property(e => e.ItemRequestRq9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_rq9");

                entity.Property(e => e.ItemRequestShipAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("ItemRequest_ShipAddress1");

                entity.Property(e => e.ItemRequestShipAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("ItemRequest_ShipAddress2");

                entity.Property(e => e.ItemRequestShipAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("ItemRequest_ShipAddress3");

                entity.Property(e => e.ItemRequestShipPhone)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_ShipPhone");

                entity.Property(e => e.ItemRequestShipTo)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_ShipTo");

                entity.Property(e => e.ItemRequestStatus)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Status");

                entity.Property(e => e.ItemRequestStatusFlags)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("ItemRequest_StatusFlags");

                entity.Property(e => e.ItemRequestTotalCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("ItemRequest_TotalCost");

                entity.Property(e => e.ItemRequestVendor)
                    .HasMaxLength(60)
                    .HasColumnName("ItemRequest_Vendor");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");
            });

            modelBuilder.Entity<VReservedItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReservedItems");

                entity.Property(e => e.ChargeTo).HasMaxLength(60);

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QtyOnHand).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.QtyReserved).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);
            });

            modelBuilder.Entity<VReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Return");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssueType)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Number).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ReturnPosition).HasMaxLength(255);

                entity.Property(e => e.ReturnStoreRoom).HasMaxLength(255);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);
            });

            modelBuilder.Entity<VReturnDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReturnDetail");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Category).HasMaxLength(60);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FixPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueMethod).HasMaxLength(60);

                entity.Property(e => e.IssuePrice).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LastCount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LotNum).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Markup).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Position).HasMaxLength(60);

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(38, 20)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnPosition).HasMaxLength(255);

                entity.Property(e => e.ReturnQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReturnStoreRoom).HasMaxLength(255);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Serialized).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StockLevel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorLot).HasMaxLength(60);

                entity.Property(e => e.VendorPart).HasMaxLength(60);
            });

            modelBuilder.Entity<VReturnvendorfrom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_returnvendorfrom");

                entity.Property(e => e.Batchnum)
                    .HasMaxLength(60)
                    .HasColumnName("batchnum");

                entity.Property(e => e.Division)
                    .HasMaxLength(60)
                    .HasColumnName("division");

                entity.Property(e => e.Equipserial)
                    .HasMaxLength(60)
                    .HasColumnName("equipserial");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Issuedqty)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("issuedqty");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lotcounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("lotcounter");

                entity.Property(e => e.Lotnum)
                    .HasMaxLength(60)
                    .HasColumnName("lotnum");

                entity.Property(e => e.Receiptbatchnum)
                    .HasMaxLength(60)
                    .HasColumnName("receiptbatchnum");

                entity.Property(e => e.ReturnFrom).HasMaxLength(60);

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Serialnum)
                    .HasMaxLength(60)
                    .HasColumnName("serialnum");

                entity.Property(e => e.TransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Vendorlot)
                    .HasMaxLength(60)
                    .HasColumnName("vendorlot");
            });

            modelBuilder.Entity<VReturnvendorfromBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_returnvendorfrom_back");

                entity.Property(e => e.Batchnum)
                    .HasMaxLength(60)
                    .HasColumnName("batchnum");

                entity.Property(e => e.Division)
                    .HasMaxLength(60)
                    .HasColumnName("division");

                entity.Property(e => e.Equipserial)
                    .HasMaxLength(60)
                    .HasColumnName("equipserial");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Issuedqty)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("issuedqty");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.LineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lotcounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("lotcounter");

                entity.Property(e => e.Lotnum)
                    .HasMaxLength(60)
                    .HasColumnName("lotnum");

                entity.Property(e => e.Receiptbatchnum)
                    .HasMaxLength(60)
                    .HasColumnName("receiptbatchnum");

                entity.Property(e => e.ReturnFrom).HasMaxLength(60);

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Serialnum)
                    .HasMaxLength(60)
                    .HasColumnName("serialnum");

                entity.Property(e => e.TransCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Vendorlot)
                    .HasMaxLength(60)
                    .HasColumnName("vendorlot");
            });

            modelBuilder.Entity<VRoutePrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ROUTE_PRINT");

                entity.Property(e => e.ChangeRemark).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Printdate)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate");

                entity.Property(e => e.RouteDesc).HasMaxLength(255);

                entity.Property(e => e.RouteName).HasMaxLength(60);
            });

            modelBuilder.Entity<VRouteReading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RouteReading");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CurrentReading).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Idorder)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("idorder");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastOffSet).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LastReading).HasMaxLength(50);

                entity.Property(e => e.LastReadingDate).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(20);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.MasterRec).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.NewDate).HasColumnType("datetime");

                entity.Property(e => e.NewReading).HasMaxLength(50);

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(60);

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.Readingtype)
                    .HasMaxLength(60)
                    .HasColumnName("readingtype");

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Spectag)
                    .HasMaxLength(60)
                    .HasColumnName("spectag");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Tagorder)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("tagorder");

                entity.Property(e => e.Type).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.Valuetype)
                    .HasMaxLength(60)
                    .HasColumnName("valuetype");

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VRouteRecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RouteRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeRemark).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RouteDesc).HasMaxLength(255);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);
            });

            modelBuilder.Entity<VScreenAttr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ScreenAttr");

                entity.Property(e => e.AddNewField).HasMaxLength(60);

                entity.Property(e => e.AutoCompleteList).HasMaxLength(255);

                entity.Property(e => e.ClassName).HasMaxLength(60);

                entity.Property(e => e.Colspan).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ColumnPosition).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ControlId)
                    .HasMaxLength(81)
                    .HasColumnName("ControlID");

                entity.Property(e => e.DbField).HasMaxLength(60);

                entity.Property(e => e.DbTable).HasMaxLength(60);

                entity.Property(e => e.Dcounter).HasColumnName("DCounter");

                entity.Property(e => e.DefaultLabel).HasMaxLength(300);

                entity.Property(e => e.DesignTimeFilter).HasMaxLength(255);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.FileName).HasMaxLength(60);

                entity.Property(e => e.Fontsize).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Groupid).HasMaxLength(60);

                entity.Property(e => e.Labeldisplay)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("labeldisplay");

                entity.Property(e => e.LeftPos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LookupLink).HasMaxLength(255);

                entity.Property(e => e.LookupPrimaryKey).HasMaxLength(60);

                entity.Property(e => e.LookupTableName).HasMaxLength(60);

                entity.Property(e => e.Mandatory).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OldControlId)
                    .HasMaxLength(60)
                    .HasColumnName("oldControlID");

                entity.Property(e => e.OnchangeFilter).HasMaxLength(60);

                entity.Property(e => e.Placeholder).HasMaxLength(255);

                entity.Property(e => e.ReportLink).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RowPosition).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Rowspan).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.RunTimeFilter).HasMaxLength(255);

                entity.Property(e => e.Sheight)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("SHeight");

                entity.Property(e => e.Smcounter).HasColumnName("SMCounter");

                entity.Property(e => e.Subtype).HasMaxLength(20);

                entity.Property(e => e.Swidth)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("SWidth");

                entity.Property(e => e.Systemlookup)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("systemlookup");

                entity.Property(e => e.Systemmandatory)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("systemmandatory");

                entity.Property(e => e.TabIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TopPos).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VServiceTransBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ServiceTransBatch");

                entity.Property(e => e.AddCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Invoiced).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.Itemnum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VServiceTransDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ServiceTransDetail");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseCurrencyTotal).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.BatchTransType).HasMaxLength(20);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueTo).HasMaxLength(60);

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.ReturnVendor).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VSpecification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Specification");

                entity.Property(e => e.SpecTag).HasMaxLength(60);
            });

            modelBuilder.Entity<VStagingIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_StagingIssue");

                entity.Property(e => e.AddCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.BatchNum).HasMaxLength(60);

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Conversion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DocNumber).HasMaxLength(60);

                entity.Property(e => e.DocType).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Invoiced).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsInventory).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsService).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IssueUnit).HasMaxLength(60);

                entity.Property(e => e.IssuedQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.Itemnum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POLineCounter");

                entity.Property(e => e.Ponum)
                    .HasMaxLength(60)
                    .HasColumnName("PONum");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(60);

                entity.Property(e => e.QtyInIssueUnit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.QtyToIssue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.ReceiptBatchNum).HasMaxLength(60);

                entity.Property(e => e.ReqLineCounter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqNum).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ShipTo).HasMaxLength(60);

                entity.Property(e => e.Staging).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Storeroom).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WolineCounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOLineCounter");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<VStatusCodeWithDesc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_StatusCodeWithDesc");

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tcode)
                    .HasMaxLength(60)
                    .HasColumnName("tcode");

                entity.Property(e => e.Tcode1)
                    .HasMaxLength(60)
                    .HasColumnName("tcode1");

                entity.Property(e => e.Tcode1desc)
                    .HasMaxLength(255)
                    .HasColumnName("tcode1desc");

                entity.Property(e => e.Tcode2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tcode2");

                entity.Property(e => e.Tdesc)
                    .HasMaxLength(255)
                    .HasColumnName("tdesc");

                entity.Property(e => e.Tfield)
                    .HasMaxLength(20)
                    .HasColumnName("tfield");
            });

            modelBuilder.Entity<VStoreRoomRecentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_StoreRoomRecentList");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);
            });

            modelBuilder.Entity<VSubfolderList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SubfolderList");

                entity.Property(e => e.Subfolder).HasMaxLength(100);
            });

            modelBuilder.Entity<VTableList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TableList");

                entity.Property(e => e.IsView).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.WwtableName)
                    .HasMaxLength(128)
                    .HasColumnName("WWTableName");
            });

            modelBuilder.Entity<VTeroLabelWithForeignKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TeroLabelWithForeignKeys");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DecimalPlaces).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.EmailFlag).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ExportFlag).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extrafilter)
                    .HasMaxLength(255)
                    .HasColumnName("extrafilter");

                entity.Property(e => e.Fieldlist)
                    .HasMaxLength(100)
                    .HasColumnName("fieldlist");

                entity.Property(e => e.HistoryTag).HasMaxLength(5);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Lookuplink)
                    .HasMaxLength(255)
                    .HasColumnName("lookuplink");

                entity.Property(e => e.Lookuptable)
                    .HasMaxLength(100)
                    .HasColumnName("lookuptable");

                entity.Property(e => e.MaxLength).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.WwfieldDesc)
                    .HasMaxLength(100)
                    .HasColumnName("WWFieldDesc");

                entity.Property(e => e.WwfieldLabel)
                    .HasMaxLength(100)
                    .HasColumnName("WWFieldLabel");

                entity.Property(e => e.WwfieldName)
                    .HasMaxLength(60)
                    .HasColumnName("WWFieldName");

                entity.Property(e => e.WwfieldOrder)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("WWFieldOrder");

                entity.Property(e => e.WwfieldType)
                    .HasMaxLength(10)
                    .HasColumnName("WWFieldType");

                entity.Property(e => e.WwselectList)
                    .HasMaxLength(255)
                    .HasColumnName("WWSelectList");

                entity.Property(e => e.WwtableName)
                    .HasMaxLength(60)
                    .HasColumnName("WWTableName");
            });

            modelBuilder.Entity<VTimeCardsRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TimeCardsRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Hours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LaborType).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Scale).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VUserGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UserGroups");

                entity.Property(e => e.GroupId).HasMaxLength(60);
            });

            modelBuilder.Entity<VVariablestest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VARIABLESTEST");

                entity.Property(e => e.EmpName).HasMaxLength(101);

                entity.Property(e => e.Empid)
                    .HasMaxLength(60)
                    .HasColumnName("empid");

                entity.Property(e => e.Period)
                    .HasMaxLength(35)
                    .HasColumnName("period");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");
            });

            modelBuilder.Entity<VVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VENDOR");

                entity.Property(e => e.Cityplusstate)
                    .HasMaxLength(122)
                    .HasColumnName("cityplusstate");

                entity.Property(e => e.Countrypluszip)
                    .HasMaxLength(122)
                    .HasColumnName("countrypluszip");

                entity.Property(e => e.InactiveVendor)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.VendorAcctContact)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_AcctContact");

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Address1");

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Address2");

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_City");

                entity.Property(e => e.VendorCompanyCode)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_CompanyCode");

                entity.Property(e => e.VendorContact)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Contact");

                entity.Property(e => e.VendorContractNum)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_ContractNum");

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Vendor_Country");

                entity.Property(e => e.VendorDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Division");

                entity.Property(e => e.VendorEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_Email");

                entity.Property(e => e.VendorFax)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Fax");

                entity.Property(e => e.VendorInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Vendor_Inactive");

                entity.Property(e => e.VendorParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_ParentID");

                entity.Property(e => e.VendorPhone)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Phone");

                entity.Property(e => e.VendorState)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_State");

                entity.Property(e => e.VendorTax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Vendor_Tax1");

                entity.Property(e => e.VendorTax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Vendor_Tax2");

                entity.Property(e => e.VendorTaxid1)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Taxid1");

                entity.Property(e => e.VendorTaxid2)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_Taxid2");

                entity.Property(e => e.VendorUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_URL");

                entity.Property(e => e.VendorVendCategory)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendCategory");

                entity.Property(e => e.VendorVendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendCustID");

                entity.Property(e => e.VendorVendName)
                    .HasMaxLength(255)
                    .HasColumnName("Vendor_VendName");

                entity.Property(e => e.VendorVendTerms)
                    .HasMaxLength(60)
                    .HasColumnName("Vendor_VendTerms");

                entity.Property(e => e.VendorVendorCurrency)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_VendorCurrency");

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(20)
                    .HasColumnName("Vendor_Zip");
            });

            modelBuilder.Entity<VVendorRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_VendorRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AcctContact).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.CompanyCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContractNum).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(60)
                    .HasColumnName("EmpID");

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Taxid1).HasMaxLength(60);

                entity.Property(e => e.Taxid2).HasMaxLength(60);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.VendCategory).HasMaxLength(60);

                entity.Property(e => e.VendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("VendCustID");

                entity.Property(e => e.VendName).HasMaxLength(255);

                entity.Property(e => e.VendTerms).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(30);

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VViewlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Viewlist");

                entity.Property(e => e.Aliaslist).HasColumnName("aliaslist");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DirectSql)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("DirectSQL");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.IsSystem)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("isSystem");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Publishdate)
                    .HasColumnType("datetime")
                    .HasColumnName("publishdate");

                entity.Property(e => e.Published)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("published");

                entity.Property(e => e.Publishedby)
                    .HasMaxLength(60)
                    .HasColumnName("publishedby");

                entity.Property(e => e.Querydesc)
                    .HasMaxLength(255)
                    .HasColumnName("querydesc");

                entity.Property(e => e.Querymodule)
                    .HasMaxLength(30)
                    .HasColumnName("querymodule");

                entity.Property(e => e.Queryname)
                    .HasMaxLength(60)
                    .HasColumnName("queryname");

                entity.Property(e => e.Queryowner)
                    .HasMaxLength(60)
                    .HasColumnName("queryowner");

                entity.Property(e => e.Sqltext).HasColumnName("SQLTEXT");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.Tablelist).HasColumnName("tablelist");

                entity.Property(e => e.ViewName)
                    .HasMaxLength(128)
                    .HasColumnName("VIEW_NAME");
            });

            modelBuilder.Entity<VWoCostAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WoCostAccounts");

                entity.Property(e => e.Account).HasMaxLength(60);

                entity.Property(e => e.AccountCost).HasColumnType("numeric(27, 8)");

                entity.Property(e => e.CostAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostPercent).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Keeppercent)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("keeppercent");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);
            });

            modelBuilder.Entity<VWoEstActTotalCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WoEstActTotalCost");

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTotalCost).HasColumnType("numeric(21, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTotalCost).HasColumnType("numeric(21, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VWoandequip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOANDEQUIP");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("COST");

                entity.Property(e => e.EquipmentEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Equipment");

                entity.Property(e => e.EquipmentLocation)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Location");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.EquipmentStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_Status");

                entity.Property(e => e.WorkOrderEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Equipment");

                entity.Property(e => e.WorkOrderEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EquipmentDesc");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");
            });

            modelBuilder.Entity<VWohistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOHISTORY");

                entity.Property(e => e.WohistoryCounter)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WOHistory_Counter");

                entity.Property(e => e.WohistoryCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WOHistory_CreatedBy");

                entity.Property(e => e.WohistoryCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOHistory_CreationDate");

                entity.Property(e => e.WohistoryRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WOHistory_Remark");

                entity.Property(e => e.WorkOrderStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoSubType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoSubType");
            });

            modelBuilder.Entity<VWohistoryWo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOHistoryWO");

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AlertType).HasMaxLength(60);

                entity.Property(e => e.AssignedHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CompCode).HasMaxLength(60);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.CompRemark).HasMaxLength(2000);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.Counter).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Downtime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Locked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note10");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note9");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("ParentWO");

                entity.Property(e => e.PdmNum).HasMaxLength(60);

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Wo1)
                    .HasMaxLength(30)
                    .HasColumnName("wo1");

                entity.Property(e => e.Wo2)
                    .HasMaxLength(30)
                    .HasColumnName("wo2");

                entity.Property(e => e.Wo3)
                    .HasMaxLength(30)
                    .HasColumnName("wo3");

                entity.Property(e => e.Wo4)
                    .HasMaxLength(30)
                    .HasColumnName("wo4");

                entity.Property(e => e.Wo5)
                    .HasMaxLength(30)
                    .HasColumnName("wo5");

                entity.Property(e => e.Wo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo6");

                entity.Property(e => e.Wo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo7");

                entity.Property(e => e.Wo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo8");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VWolabourDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WOLabourDetail");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Counter).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Hours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LaborType).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype");

                entity.Property(e => e.PostBy).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReadyToPost).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Scale).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.Worate)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("WORate");

                entity.Property(e => e.Wostatus)
                    .HasMaxLength(60)
                    .HasColumnName("WOStatus");

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VWolabourSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WOLabourSchedule");

                entity.Property(e => e.ActivityId)
                    .HasMaxLength(50)
                    .HasColumnName("ActivityID");

                entity.Property(e => e.ActivityType).HasMaxLength(60);

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Hours).HasColumnType("numeric(21, 7)");

                entity.Property(e => e.RecurrenceRule).HasMaxLength(255);

                entity.Property(e => e.ResourceId)
                    .HasMaxLength(50)
                    .HasColumnName("ResourceID");

                entity.Property(e => e.ResourceType).HasMaxLength(60);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<VWomat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOMAT");

                entity.Property(e => e.WomaterialActual)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_Actual");

                entity.Property(e => e.WomaterialAddCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_AddCost");

                entity.Property(e => e.WomaterialCbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_CBTax1");

                entity.Property(e => e.WomaterialCbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_CBTax2");

                entity.Property(e => e.WomaterialChangeRemark).HasColumnName("WOMaterial_ChangeRemark");

                entity.Property(e => e.WomaterialChargeBack)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_ChargeBack");

                entity.Property(e => e.WomaterialChargeBackAmount)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_ChargeBackAmount");

                entity.Property(e => e.WomaterialCounter).HasColumnName("WOMaterial_Counter");

                entity.Property(e => e.WomaterialCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_CrAccount");

                entity.Property(e => e.WomaterialCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_CreatedBy");

                entity.Property(e => e.WomaterialCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOMaterial_CreationDate");

                entity.Property(e => e.WomaterialDescription)
                    .HasMaxLength(255)
                    .HasColumnName("WOMaterial_Description");

                entity.Property(e => e.WomaterialDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WOMaterial_DirtyLog");

                entity.Property(e => e.WomaterialDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_DrAccount");

                entity.Property(e => e.WomaterialEquipSerial)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_EquipSerial");

                entity.Property(e => e.WomaterialEstimate)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_Estimate");

                entity.Property(e => e.WomaterialExtension)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_Extension");

                entity.Property(e => e.WomaterialInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_Inactive");

                entity.Property(e => e.WomaterialItemNum)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_ItemNum");

                entity.Property(e => e.WomaterialMarkupAmount)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_MarkupAmount");

                entity.Property(e => e.WomaterialModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_ModifyBy");

                entity.Property(e => e.WomaterialModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOMaterial_ModifyDate");

                entity.Property(e => e.WomaterialOrderType)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_OrderType");

                entity.Property(e => e.WomaterialPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOMaterial_PostDate");

                entity.Property(e => e.WomaterialPrintDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOMaterial_PrintDate");

                entity.Property(e => e.WomaterialPrintPerson)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_PrintPerson");

                entity.Property(e => e.WomaterialPublicNote)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_PublicNote");

                entity.Property(e => e.WomaterialQuantity)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_Quantity");

                entity.Property(e => e.WomaterialRefNum)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WOMaterial_RefNum");

                entity.Property(e => e.WomaterialReserved)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WOMaterial_Reserved");

                entity.Property(e => e.WomaterialSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_SerialNum");

                entity.Property(e => e.WomaterialStore)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_Store");

                entity.Property(e => e.WomaterialTaskNum)
                    .HasMaxLength(30)
                    .HasColumnName("WOMaterial_TaskNum");

                entity.Property(e => e.WomaterialTax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_Tax1");

                entity.Property(e => e.WomaterialTax1Account)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_Tax1Account");

                entity.Property(e => e.WomaterialTax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_Tax2");

                entity.Property(e => e.WomaterialTax2Account)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_Tax2Account");

                entity.Property(e => e.WomaterialTransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOMaterial_TransDate");

                entity.Property(e => e.WomaterialUnit)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_Unit");

                entity.Property(e => e.WomaterialUnitPrice)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WOMaterial_UnitPrice");

                entity.Property(e => e.WomaterialVendor)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_Vendor");

                entity.Property(e => e.WomaterialWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WOMaterial_WoNum");

                entity.Property(e => e.WorkOrderActHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours");

                entity.Property(e => e.WorkOrderActLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActLabor");

                entity.Property(e => e.WorkOrderActMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMaterial");

                entity.Property(e => e.WorkOrderActMileage)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMileage");

                entity.Property(e => e.WorkOrderActService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActService");

                entity.Property(e => e.WorkOrderActTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActTools");

                entity.Property(e => e.WorkOrderAlertType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_AlertType");

                entity.Property(e => e.WorkOrderAssignedHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_AssignedHours");

                entity.Property(e => e.WorkOrderChangeRemark).HasColumnName("WorkOrder_ChangeRemark");

                entity.Property(e => e.WorkOrderChargeback)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Chargeback");

                entity.Property(e => e.WorkOrderClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ClientCode");

                entity.Property(e => e.WorkOrderCompCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CompCode");

                entity.Property(e => e.WorkOrderCompDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CompDate");

                entity.Property(e => e.WorkOrderCompRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkOrder_CompRemark");

                entity.Property(e => e.WorkOrderCompShortDesc).HasColumnName("WorkOrder_CompShortDesc");

                entity.Property(e => e.WorkOrderContact)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Contact");

                entity.Property(e => e.WorkOrderContactPhone)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ContactPhone");

                entity.Property(e => e.WorkOrderCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CrAccount");

                entity.Property(e => e.WorkOrderCraft)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Craft");

                entity.Property(e => e.WorkOrderCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CreatedBy");

                entity.Property(e => e.WorkOrderCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CreationDate");

                entity.Property(e => e.WorkOrderCrew)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Crew");

                entity.Property(e => e.WorkOrderCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Customer");

                entity.Property(e => e.WorkOrderDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Department");

                entity.Property(e => e.WorkOrderDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHLSD");

                entity.Property(e => e.WorkOrderDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHRange");

                entity.Property(e => e.WorkOrderDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHSect");

                entity.Property(e => e.WorkOrderDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHTownShip");

                entity.Property(e => e.WorkOrderDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_DirtyLog");

                entity.Property(e => e.WorkOrderDivision)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Division");

                entity.Property(e => e.WorkOrderDowntime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Downtime");

                entity.Property(e => e.WorkOrderDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_DrAccount");

                entity.Property(e => e.WorkOrderDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Duration");

                entity.Property(e => e.WorkOrderEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Employee");

                entity.Property(e => e.WorkOrderEqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress1");

                entity.Property(e => e.WorkOrderEqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress2");

                entity.Property(e => e.WorkOrderEqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_EQOperator");

                entity.Property(e => e.WorkOrderEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Equipment");

                entity.Property(e => e.WorkOrderEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EquipmentDesc");

                entity.Property(e => e.WorkOrderEstCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstCost");

                entity.Property(e => e.WorkOrderEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstHours");

                entity.Property(e => e.WorkOrderEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstLabor");

                entity.Property(e => e.WorkOrderEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstMaterial");

                entity.Property(e => e.WorkOrderEstMileage)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstMileage");

                entity.Property(e => e.WorkOrderEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstService");

                entity.Property(e => e.WorkOrderEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstTools");

                entity.Property(e => e.WorkOrderFailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode1");

                entity.Property(e => e.WorkOrderFailureCode2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode2");

                entity.Property(e => e.WorkOrderFailureCode3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode3");

                entity.Property(e => e.WorkOrderFifthRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FifthRequester");

                entity.Property(e => e.WorkOrderFourthRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FourthRequester");

                entity.Property(e => e.WorkOrderInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Inactive");

                entity.Property(e => e.WorkOrderLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location");

                entity.Property(e => e.WorkOrderLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc");

                entity.Property(e => e.WorkOrderLocked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Locked");

                entity.Property(e => e.WorkOrderManager)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Manager");

                entity.Property(e => e.WorkOrderModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ModifyBy");

                entity.Property(e => e.WorkOrderModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_ModifyDate");

                entity.Property(e => e.WorkOrderNote1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note1");

                entity.Property(e => e.WorkOrderNote10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_note10");

                entity.Property(e => e.WorkOrderNote2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note2");

                entity.Property(e => e.WorkOrderNote3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note3");

                entity.Property(e => e.WorkOrderNote4)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note4");

                entity.Property(e => e.WorkOrderNote5)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note5");

                entity.Property(e => e.WorkOrderNote6)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note6");

                entity.Property(e => e.WorkOrderNote7)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note7");

                entity.Property(e => e.WorkOrderNote8)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note8");

                entity.Property(e => e.WorkOrderNote9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_note9");

                entity.Property(e => e.WorkOrderOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_OpenDate");

                entity.Property(e => e.WorkOrderParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ParentWO");

                entity.Property(e => e.WorkOrderPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PDMNum");

                entity.Property(e => e.WorkOrderPhase)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Phase");

                entity.Property(e => e.WorkOrderPmNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PmNum");

                entity.Property(e => e.WorkOrderPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_PostDate");

                entity.Property(e => e.WorkOrderPriority)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Priority");

                entity.Property(e => e.WorkOrderProcNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProcNum");

                entity.Property(e => e.WorkOrderProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProjectId");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Requester");

                entity.Property(e => e.WorkOrderRoom)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Room");

                entity.Property(e => e.WorkOrderRouteName)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_RouteName");

                entity.Property(e => e.WorkOrderStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status");

                entity.Property(e => e.WorkOrderStatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_StatusCode");

                entity.Property(e => e.WorkOrderSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfLSD");

                entity.Property(e => e.WorkOrderSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfRange");

                entity.Property(e => e.WorkOrderSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfSect");

                entity.Property(e => e.WorkOrderSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfTownShip");

                entity.Property(e => e.WorkOrderTargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetDate");

                entity.Property(e => e.WorkOrderTargetEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetEndDate");

                entity.Property(e => e.WorkOrderThirdRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ThirdRequester");

                entity.Property(e => e.WorkOrderWo1)
                    .HasMaxLength(30)
                    .HasColumnName("WorkOrder_wo1");

                entity.Property(e => e.WorkOrderWo2)
                    .HasMaxLength(30)
                    .HasColumnName("WorkOrder_wo2");

                entity.Property(e => e.WorkOrderWo3)
                    .HasMaxLength(30)
                    .HasColumnName("WorkOrder_wo3");

                entity.Property(e => e.WorkOrderWo4)
                    .HasMaxLength(30)
                    .HasColumnName("WorkOrder_wo4");

                entity.Property(e => e.WorkOrderWo5)
                    .HasMaxLength(30)
                    .HasColumnName("WorkOrder_wo5");

                entity.Property(e => e.WorkOrderWo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_wo6");

                entity.Property(e => e.WorkOrderWo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_wo7");

                entity.Property(e => e.WorkOrderWo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_wo8");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoSubType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoSubType");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");
            });

            modelBuilder.Entity<VWorecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WORecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AssignedHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CompCode).HasMaxLength(60);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.CompRemark).HasMaxLength(2000);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Downtime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Locked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note10");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note9");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("ParentWO");

                entity.Property(e => e.PdmNum).HasMaxLength(60);

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.Wo1)
                    .HasMaxLength(30)
                    .HasColumnName("wo1");

                entity.Property(e => e.Wo2)
                    .HasMaxLength(30)
                    .HasColumnName("wo2");

                entity.Property(e => e.Wo3)
                    .HasMaxLength(30)
                    .HasColumnName("wo3");

                entity.Property(e => e.Wo4)
                    .HasMaxLength(30)
                    .HasColumnName("wo4");

                entity.Property(e => e.Wo5)
                    .HasMaxLength(30)
                    .HasColumnName("wo5");

                entity.Property(e => e.Wo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo6");

                entity.Property(e => e.Wo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo7");

                entity.Property(e => e.Wo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo8");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VWoreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOREPORT");

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.CodesTcode)
                    .HasMaxLength(60)
                    .HasColumnName("Codes_tcode");

                entity.Property(e => e.CodesTdesc).HasColumnName("Codes_tdesc");

                entity.Property(e => e.CompBy).HasMaxLength(60);

                entity.Property(e => e.CompHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CompTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Completed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName).HasMaxLength(101);

                entity.Property(e => e.EmpName).HasMaxLength(101);

                entity.Property(e => e.EquipmentHazardous)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Equipment_Hazardous");

                entity.Property(e => e.EquipmentInstructions).HasColumnName("Equipment_Instructions");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.HazMat)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLicenseNum)
                    .HasMaxLength(60)
                    .HasColumnName("Location_LicenseNum");

                entity.Property(e => e.LocationParentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Location_ParentDesc");

                entity.Property(e => e.LocationParentLoc)
                    .HasMaxLength(60)
                    .HasColumnName("Location_ParentLoc");

                entity.Property(e => e.LocationUwi)
                    .HasMaxLength(60)
                    .HasColumnName("Location_UWI");

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.ReqName).HasMaxLength(101);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.WoactualsTotal)
                    .HasColumnType("numeric(21, 4)")
                    .HasColumnName("WOActualsTotal");

                entity.Property(e => e.WoestimatesTotal)
                    .HasColumnType("numeric(21, 4)")
                    .HasColumnName("WOEstimatesTotal");

                entity.Property(e => e.WorkOrderActHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours");

                entity.Property(e => e.WorkOrderActHours0)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours0");

                entity.Property(e => e.WorkOrderActLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActLabor");

                entity.Property(e => e.WorkOrderActMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMaterial");

                entity.Property(e => e.WorkOrderActService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActService");

                entity.Property(e => e.WorkOrderActTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActTools");

                entity.Property(e => e.WorkOrderAlerttype)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Alerttype");

                entity.Property(e => e.WorkOrderAssignedHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_AssignedHours");

                entity.Property(e => e.WorkOrderChargeback)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Chargeback");

                entity.Property(e => e.WorkOrderClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ClientCode");

                entity.Property(e => e.WorkOrderCompCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CompCode");

                entity.Property(e => e.WorkOrderCompDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CompDate");

                entity.Property(e => e.WorkOrderCompDate0)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CompDate0");

                entity.Property(e => e.WorkOrderCompRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkOrder_CompRemark");

                entity.Property(e => e.WorkOrderContact)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Contact");

                entity.Property(e => e.WorkOrderContactPhone)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ContactPhone");

                entity.Property(e => e.WorkOrderCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CrAccount");

                entity.Property(e => e.WorkOrderCraft)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Craft");

                entity.Property(e => e.WorkOrderCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CreatedBy");

                entity.Property(e => e.WorkOrderCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CreationDate");

                entity.Property(e => e.WorkOrderCrew)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Crew");

                entity.Property(e => e.WorkOrderDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Department");

                entity.Property(e => e.WorkOrderDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHLSD");

                entity.Property(e => e.WorkOrderDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHRange");

                entity.Property(e => e.WorkOrderDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHSect");

                entity.Property(e => e.WorkOrderDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHTownShip");

                entity.Property(e => e.WorkOrderDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_DirtyLog");

                entity.Property(e => e.WorkOrderDivision)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Division");

                entity.Property(e => e.WorkOrderDowntime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Downtime");

                entity.Property(e => e.WorkOrderDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_DrAccount");

                entity.Property(e => e.WorkOrderDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Duration");

                entity.Property(e => e.WorkOrderEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Employee");

                entity.Property(e => e.WorkOrderEqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress1");

                entity.Property(e => e.WorkOrderEqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress2");

                entity.Property(e => e.WorkOrderEqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_EQOperator");

                entity.Property(e => e.WorkOrderEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Equipment");

                entity.Property(e => e.WorkOrderEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EquipmentDesc");

                entity.Property(e => e.WorkOrderEstCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstCost");

                entity.Property(e => e.WorkOrderEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstHours");

                entity.Property(e => e.WorkOrderEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstLabor");

                entity.Property(e => e.WorkOrderEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstMaterial");

                entity.Property(e => e.WorkOrderEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstService");

                entity.Property(e => e.WorkOrderEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstTools");

                entity.Property(e => e.WorkOrderFailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode1");

                entity.Property(e => e.WorkOrderFailureCode2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode2");

                entity.Property(e => e.WorkOrderFailureCode3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode3");

                entity.Property(e => e.WorkOrderInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Inactive");

                entity.Property(e => e.WorkOrderLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location");

                entity.Property(e => e.WorkOrderLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc");

                entity.Property(e => e.WorkOrderLocked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Locked");

                entity.Property(e => e.WorkOrderManager)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Manager");

                entity.Property(e => e.WorkOrderModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ModifyBy");

                entity.Property(e => e.WorkOrderModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_ModifyDate");

                entity.Property(e => e.WorkOrderNote1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note1");

                entity.Property(e => e.WorkOrderNote2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note2");

                entity.Property(e => e.WorkOrderNote3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note3");

                entity.Property(e => e.WorkOrderNote4)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note4");

                entity.Property(e => e.WorkOrderNote5)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note5");

                entity.Property(e => e.WorkOrderNote6)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note6");

                entity.Property(e => e.WorkOrderNote7)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note7");

                entity.Property(e => e.WorkOrderNote8)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Note8");

                entity.Property(e => e.WorkOrderOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_OpenDate");

                entity.Property(e => e.WorkOrderPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PDMNum");

                entity.Property(e => e.WorkOrderPhase)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Phase");

                entity.Property(e => e.WorkOrderPmNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PmNum");

                entity.Property(e => e.WorkOrderPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_PostDate");

                entity.Property(e => e.WorkOrderPriority)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Priority");

                entity.Property(e => e.WorkOrderProcNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProcNum");

                entity.Property(e => e.WorkOrderProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProjectId");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Requester");

                entity.Property(e => e.WorkOrderRoom)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Room");

                entity.Property(e => e.WorkOrderStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status");

                entity.Property(e => e.WorkOrderStatus0)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status0");

                entity.Property(e => e.WorkOrderStatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_StatusCode");

                entity.Property(e => e.WorkOrderSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfLSD");

                entity.Property(e => e.WorkOrderSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfRange");

                entity.Property(e => e.WorkOrderSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfSect");

                entity.Property(e => e.WorkOrderSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfTownShip");

                entity.Property(e => e.WorkOrderTargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetDate");

                entity.Property(e => e.WorkOrderTargetEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetEndDate");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoSubType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoSubType");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");

                entity.Property(e => e.Wotypeandnum)
                    .HasMaxLength(121)
                    .HasColumnName("wotypeandnum");
            });

            modelBuilder.Entity<VWorkOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WorkOrderDetail");

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AlertType).HasMaxLength(60);

                entity.Property(e => e.AssetTag).HasMaxLength(60);

                entity.Property(e => e.AssignedHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CompCode).HasMaxLength(60);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.CompRemark).HasMaxLength(2000);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Downtime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LicenseNum).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Locked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.Manufacturer).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note10");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note9");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentDesc).HasMaxLength(255);

                entity.Property(e => e.ParentLoc).HasMaxLength(60);

                entity.Property(e => e.ParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("ParentWO");

                entity.Property(e => e.PdmNum).HasMaxLength(60);

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.Uwi)
                    .HasMaxLength(60)
                    .HasColumnName("UWI");

                entity.Property(e => e.Wo1)
                    .HasMaxLength(30)
                    .HasColumnName("wo1");

                entity.Property(e => e.Wo2)
                    .HasMaxLength(30)
                    .HasColumnName("wo2");

                entity.Property(e => e.Wo3)
                    .HasMaxLength(30)
                    .HasColumnName("wo3");

                entity.Property(e => e.Wo4)
                    .HasMaxLength(30)
                    .HasColumnName("wo4");

                entity.Property(e => e.Wo5)
                    .HasMaxLength(30)
                    .HasColumnName("wo5");

                entity.Property(e => e.Wo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo6");

                entity.Property(e => e.Wo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo7");

                entity.Property(e => e.Wo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo8");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VWorkRequestRecentlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WorkRequestRecentlist");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Pending).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Request).HasMaxLength(2000);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");

                entity.Property(e => e.Wrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WRNum");
            });

            modelBuilder.Entity<VWorkbytype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WORKBYTYPE");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");
            });

            modelBuilder.Entity<VWorkorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WORKORDER");

                entity.Property(e => e.Account)
                    .HasMaxLength(128)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Counter).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Fund)
                    .HasMaxLength(128)
                    .HasColumnName("FUND");

                entity.Property(e => e.Org)
                    .HasMaxLength(128)
                    .HasColumnName("ORG");

                entity.Property(e => e.Program)
                    .HasMaxLength(128)
                    .HasColumnName("PROGRAM");

                entity.Property(e => e.Test).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.WorkOrderActHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActHours");

                entity.Property(e => e.WorkOrderActLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActLabor");

                entity.Property(e => e.WorkOrderActMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActMaterial");

                entity.Property(e => e.WorkOrderActService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActService");

                entity.Property(e => e.WorkOrderActTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_ActTools");

                entity.Property(e => e.WorkOrderAssignedHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_AssignedHours");

                entity.Property(e => e.WorkOrderChargeback)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Chargeback");

                entity.Property(e => e.WorkOrderClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ClientCode");

                entity.Property(e => e.WorkOrderCompCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CompCode");

                entity.Property(e => e.WorkOrderCompDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CompDate");

                entity.Property(e => e.WorkOrderCompRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkOrder_CompRemark");

                entity.Property(e => e.WorkOrderContact)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Contact");

                entity.Property(e => e.WorkOrderContactPhone)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ContactPhone");

                entity.Property(e => e.WorkOrderCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CrAccount");

                entity.Property(e => e.WorkOrderCraft)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Craft");

                entity.Property(e => e.WorkOrderCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_CreatedBy");

                entity.Property(e => e.WorkOrderCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_CreationDate");

                entity.Property(e => e.WorkOrderCrew)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Crew");

                entity.Property(e => e.WorkOrderDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Department");

                entity.Property(e => e.WorkOrderDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHLSD");

                entity.Property(e => e.WorkOrderDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHRange");

                entity.Property(e => e.WorkOrderDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHSect");

                entity.Property(e => e.WorkOrderDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_DHTownShip");

                entity.Property(e => e.WorkOrderDivision)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Division");

                entity.Property(e => e.WorkOrderDowntime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Downtime");

                entity.Property(e => e.WorkOrderDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_DrAccount");

                entity.Property(e => e.WorkOrderDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_Duration");

                entity.Property(e => e.WorkOrderEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Employee");

                entity.Property(e => e.WorkOrderEqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress1");

                entity.Property(e => e.WorkOrderEqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EQAddress2");

                entity.Property(e => e.WorkOrderEqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_EQOperator");

                entity.Property(e => e.WorkOrderEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Equipment");

                entity.Property(e => e.WorkOrderEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_EquipmentDesc");

                entity.Property(e => e.WorkOrderEstCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstCost");

                entity.Property(e => e.WorkOrderEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstHours");

                entity.Property(e => e.WorkOrderEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstLabor");

                entity.Property(e => e.WorkOrderEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstMaterial");

                entity.Property(e => e.WorkOrderEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstService");

                entity.Property(e => e.WorkOrderEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkOrder_EstTools");

                entity.Property(e => e.WorkOrderFailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode1");

                entity.Property(e => e.WorkOrderFailureCode2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode2");

                entity.Property(e => e.WorkOrderFailureCode3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_FailureCode3");

                entity.Property(e => e.WorkOrderInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Inactive");

                entity.Property(e => e.WorkOrderLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Location");

                entity.Property(e => e.WorkOrderLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_LocationDesc");

                entity.Property(e => e.WorkOrderLocked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkOrder_Locked");

                entity.Property(e => e.WorkOrderManager)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Manager");

                entity.Property(e => e.WorkOrderModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ModifyBy");

                entity.Property(e => e.WorkOrderModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_ModifyDate");

                entity.Property(e => e.WorkOrderOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_OpenDate");

                entity.Property(e => e.WorkOrderParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ParentWO");

                entity.Property(e => e.WorkOrderPdmnum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PDMNum");

                entity.Property(e => e.WorkOrderPhase)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Phase");

                entity.Property(e => e.WorkOrderPmNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_PmNum");

                entity.Property(e => e.WorkOrderPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_PostDate");

                entity.Property(e => e.WorkOrderPriority)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Priority");

                entity.Property(e => e.WorkOrderProcNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProcNum");

                entity.Property(e => e.WorkOrderProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_ProjectId");

                entity.Property(e => e.WorkOrderRequest).HasColumnName("WorkOrder_Request");

                entity.Property(e => e.WorkOrderRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Requester");

                entity.Property(e => e.WorkOrderRoom)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Room");

                entity.Property(e => e.WorkOrderStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_Status");

                entity.Property(e => e.WorkOrderStatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkOrder_StatusCode");

                entity.Property(e => e.WorkOrderSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfLSD");

                entity.Property(e => e.WorkOrderSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfRange");

                entity.Property(e => e.WorkOrderSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfSect");

                entity.Property(e => e.WorkOrderSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkOrder_SurfTownShip");

                entity.Property(e => e.WorkOrderTargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetDate");

                entity.Property(e => e.WorkOrderTargetEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkOrder_TargetEndDate");

                entity.Property(e => e.WorkOrderWoNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoNum");

                entity.Property(e => e.WorkOrderWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkOrder_WoType");
            });

            modelBuilder.Entity<VWorkrequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WORKREQUEST");

                entity.Property(e => e.EquipmentSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("Equipment_SerialNum");

                entity.Property(e => e.Printdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("printdate");

                entity.Property(e => e.Printdate2)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate2");

                entity.Property(e => e.WorkRequestAlarmIncluded)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_AlarmIncluded");

                entity.Property(e => e.WorkRequestAlertType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_AlertType");

                entity.Property(e => e.WorkRequestAssignDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_AssignDate");

                entity.Property(e => e.WorkRequestChangeRemark).HasColumnName("WorkRequest_ChangeRemark");

                entity.Property(e => e.WorkRequestChargeback)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_Chargeback");

                entity.Property(e => e.WorkRequestClientCode)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ClientCode");

                entity.Property(e => e.WorkRequestContact)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Contact");

                entity.Property(e => e.WorkRequestContactPhone)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ContactPhone");

                entity.Property(e => e.WorkRequestCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_CrAccount");

                entity.Property(e => e.WorkRequestCraft)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Craft");

                entity.Property(e => e.WorkRequestCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_CreatedBy");

                entity.Property(e => e.WorkRequestCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_CreationDate");

                entity.Property(e => e.WorkRequestCrew)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Crew");

                entity.Property(e => e.WorkRequestCustomer)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Customer");

                entity.Property(e => e.WorkRequestDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Department");

                entity.Property(e => e.WorkRequestDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_DHLSD");

                entity.Property(e => e.WorkRequestDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_DHRange");

                entity.Property(e => e.WorkRequestDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_DHSect");

                entity.Property(e => e.WorkRequestDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_DHTownShip");

                entity.Property(e => e.WorkRequestDirtyLog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkRequest_DirtyLog");

                entity.Property(e => e.WorkRequestDivision)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Division");

                entity.Property(e => e.WorkRequestDownholeLsdlocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_DownholeLSDLocation");

                entity.Property(e => e.WorkRequestDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_DrAccount");

                entity.Property(e => e.WorkRequestDuration)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_Duration");

                entity.Property(e => e.WorkRequestElectricPropaneMotor)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ElectricPropaneMotor");

                entity.Property(e => e.WorkRequestEmailCc1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EmailCC1");

                entity.Property(e => e.WorkRequestEmailCc2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EmailCC2");

                entity.Property(e => e.WorkRequestEmailCc3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EmailCC3");

                entity.Property(e => e.WorkRequestEmailCc4)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EmailCC4");

                entity.Property(e => e.WorkRequestEmailCc5)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EmailCC5");

                entity.Property(e => e.WorkRequestEmployee)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Employee");

                entity.Property(e => e.WorkRequestEqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("WorkRequest_EQAddress1");

                entity.Property(e => e.WorkRequestEqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("WorkRequest_EQAddress2");

                entity.Property(e => e.WorkRequestEqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EQOperator");

                entity.Property(e => e.WorkRequestEquipment)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Equipment");

                entity.Property(e => e.WorkRequestEquipmentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkRequest_EquipmentDesc");

                entity.Property(e => e.WorkRequestEquipmentManufacturer)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_EquipmentManufacturer");

                entity.Property(e => e.WorkRequestEstCost)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstCost");

                entity.Property(e => e.WorkRequestEstHours)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstHours");

                entity.Property(e => e.WorkRequestEstLabor)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstLabor");

                entity.Property(e => e.WorkRequestEstMaterial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstMaterial");

                entity.Property(e => e.WorkRequestEstService)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstService");

                entity.Property(e => e.WorkRequestEstTools)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("WorkRequest_EstTools");

                entity.Property(e => e.WorkRequestFailureCode1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_FailureCode1");

                entity.Property(e => e.WorkRequestFailureCode2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_FailureCode2");

                entity.Property(e => e.WorkRequestFailureCode3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_FailureCode3");

                entity.Property(e => e.WorkRequestFieldArea)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_FieldArea");

                entity.Property(e => e.WorkRequestFifthRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_FifthRequester");

                entity.Property(e => e.WorkRequestForthRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ForthRequester");

                entity.Property(e => e.WorkRequestHistoryProblemDescription)
                    .HasMaxLength(200)
                    .HasColumnName("WorkRequest_HistoryProblemDescription");

                entity.Property(e => e.WorkRequestInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_Inactive");

                entity.Property(e => e.WorkRequestIsHazardIdrequired)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_IsHazardIDRequired");

                entity.Property(e => e.WorkRequestIsPumpJackWithVfdtimelock)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_IsPumpJackWithVFDTimelock");

                entity.Property(e => e.WorkRequestIsShutDown)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_IsShutDown");

                entity.Property(e => e.WorkRequestLeaseRoadCondition)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_LeaseRoadCondition");

                entity.Property(e => e.WorkRequestLocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Location");

                entity.Property(e => e.WorkRequestLocationDesc)
                    .HasMaxLength(255)
                    .HasColumnName("WorkRequest_LocationDesc");

                entity.Property(e => e.WorkRequestLossEstimate)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_LossEstimate");

                entity.Property(e => e.WorkRequestMaintenanceIssue)
                    .HasMaxLength(200)
                    .HasColumnName("WorkRequest_MaintenanceIssue");

                entity.Property(e => e.WorkRequestManager)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Manager");

                entity.Property(e => e.WorkRequestModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ModifyBy");

                entity.Property(e => e.WorkRequestModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_ModifyDate");

                entity.Property(e => e.WorkRequestMotorVoltage)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_MotorVoltage");

                entity.Property(e => e.WorkRequestNewSheaveSizeRequest)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_NewSheaveSizeRequest");

                entity.Property(e => e.WorkRequestNewSpmrequest)
                    .HasMaxLength(200)
                    .HasColumnName("WorkRequest_NewSPMRequest");

                entity.Property(e => e.WorkRequestNote1)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note1");

                entity.Property(e => e.WorkRequestNote2)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note2");

                entity.Property(e => e.WorkRequestNote3)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note3");

                entity.Property(e => e.WorkRequestNote4)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note4");

                entity.Property(e => e.WorkRequestNote5)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note5");

                entity.Property(e => e.WorkRequestNote6)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note6");

                entity.Property(e => e.WorkRequestNote7)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note7");

                entity.Property(e => e.WorkRequestNote8)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Note8");

                entity.Property(e => e.WorkRequestOilPerDay)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_OilPerDay");

                entity.Property(e => e.WorkRequestOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_OpenDate");

                entity.Property(e => e.WorkRequestPhase)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Phase");

                entity.Property(e => e.WorkRequestPostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_PostDate");

                entity.Property(e => e.WorkRequestPriority)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Priority");

                entity.Property(e => e.WorkRequestProcNum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ProcNum");

                entity.Property(e => e.WorkRequestProdEngineering)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ProdEngineering");

                entity.Property(e => e.WorkRequestProjectId)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ProjectId");

                entity.Property(e => e.WorkRequestPumpJackCheck)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("WorkRequest_PumpJackCheck");

                entity.Property(e => e.WorkRequestPumpJackFrequence)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_PumpJackFrequence");

                entity.Property(e => e.WorkRequestPumpJackInfo)
                    .HasMaxLength(200)
                    .HasColumnName("WorkRequest_PumpJackInfo");

                entity.Property(e => e.WorkRequestRemark)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkRequest_Remark");

                entity.Property(e => e.WorkRequestRequest)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkRequest_Request");

                entity.Property(e => e.WorkRequestRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Requester");

                entity.Property(e => e.WorkRequestRoom)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Room");

                entity.Property(e => e.WorkRequestSheaveSize)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_SheaveSize");

                entity.Property(e => e.WorkRequestStatus)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_Status");

                entity.Property(e => e.WorkRequestStatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("WorkRequest_StatusCode");

                entity.Property(e => e.WorkRequestSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_SurfLSD");

                entity.Property(e => e.WorkRequestSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_SurfRange");

                entity.Property(e => e.WorkRequestSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_SurfSect");

                entity.Property(e => e.WorkRequestSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("WorkRequest_SurfTownShip");

                entity.Property(e => e.WorkRequestSurfaceLsdlocation)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_SurfaceLSDLocation");

                entity.Property(e => e.WorkRequestTargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_TargetDate");

                entity.Property(e => e.WorkRequestTargetEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WorkRequest_TargetEndDate");

                entity.Property(e => e.WorkRequestThirdRequester)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_ThirdRequester");

                entity.Property(e => e.WorkRequestUnitSize)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_UnitSize");

                entity.Property(e => e.WorkRequestWaterPerDay)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_WaterPerDay");

                entity.Property(e => e.WorkRequestWoType)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_WoType");

                entity.Property(e => e.WorkRequestWrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WorkRequest_WRNum");
            });

            modelBuilder.Entity<VWostoreroom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WOStoreroom");

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AssignedHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CompCode).HasMaxLength(60);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.CompRemark).HasMaxLength(2000);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Downtime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Locked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note10");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note9");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("ParentWO");

                entity.Property(e => e.PdmNum).HasMaxLength(60);

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.StoreRoom).HasMaxLength(60);

                entity.Property(e => e.StoreroomAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Storeroom_Address1");

                entity.Property(e => e.StoreroomAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Storeroom_Address2");

                entity.Property(e => e.StoreroomChangeRemark).HasColumnName("Storeroom_ChangeRemark");

                entity.Property(e => e.StoreroomContact)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact");

                entity.Property(e => e.StoreroomContact1)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact1");

                entity.Property(e => e.StoreroomContact2)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact2");

                entity.Property(e => e.StoreroomContact3)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact3");

                entity.Property(e => e.StoreroomContact4)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact4");

                entity.Property(e => e.StoreroomContact5)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact5");

                entity.Property(e => e.StoreroomContact6)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Contact6");

                entity.Property(e => e.StoreroomContactName)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_ContactName");

                entity.Property(e => e.StoreroomCrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_CrAccount");

                entity.Property(e => e.StoreroomCreatedBy)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_CreatedBy");

                entity.Property(e => e.StoreroomCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Storeroom_CreationDate");

                entity.Property(e => e.StoreroomDepartment)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Department");

                entity.Property(e => e.StoreroomDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Storeroom_Description");

                entity.Property(e => e.StoreroomDhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_DHLSD");

                entity.Property(e => e.StoreroomDhrange)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_DHRange");

                entity.Property(e => e.StoreroomDhsect)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_DHSect");

                entity.Property(e => e.StoreroomDhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_DHTownShip");

                entity.Property(e => e.StoreroomDistrict1)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_District1");

                entity.Property(e => e.StoreroomDistrict2)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_District2");

                entity.Property(e => e.StoreroomDistrict3)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_District3");

                entity.Property(e => e.StoreroomDivision)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Division");

                entity.Property(e => e.StoreroomDrAccount)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_DrAccount");

                entity.Property(e => e.StoreroomInactive)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Storeroom_Inactive");

                entity.Property(e => e.StoreroomLoc1)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Loc1");

                entity.Property(e => e.StoreroomLoc2)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Loc2");

                entity.Property(e => e.StoreroomLoc3)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Loc3");

                entity.Property(e => e.StoreroomLoc4)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Loc4");

                entity.Property(e => e.StoreroomLocType)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_LocType");

                entity.Property(e => e.StoreroomMasterRec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("Storeroom_MasterRec");

                entity.Property(e => e.StoreroomModifyBy)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_ModifyBy");

                entity.Property(e => e.StoreroomModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Storeroom_ModifyDate");

                entity.Property(e => e.StoreroomNote1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Storeroom_Note1");

                entity.Property(e => e.StoreroomNote10)
                    .HasMaxLength(100)
                    .HasColumnName("Storeroom_Note10");

                entity.Property(e => e.StoreroomNote2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Storeroom_Note2");

                entity.Property(e => e.StoreroomNote3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Storeroom_Note3");

                entity.Property(e => e.StoreroomNote4)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Storeroom_Note4");

                entity.Property(e => e.StoreroomNote5)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Storeroom_Note5");

                entity.Property(e => e.StoreroomNote6)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Note6");

                entity.Property(e => e.StoreroomNote7)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Note7");

                entity.Property(e => e.StoreroomNote8)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Note8");

                entity.Property(e => e.StoreroomNote9)
                    .HasMaxLength(100)
                    .HasColumnName("Storeroom_Note9");

                entity.Property(e => e.StoreroomParentDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Storeroom_ParentDesc");

                entity.Property(e => e.StoreroomParentId)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_ParentId");

                entity.Property(e => e.StoreroomPriority)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Priority");

                entity.Property(e => e.StoreroomStatus)
                    .HasMaxLength(60)
                    .HasColumnName("Storeroom_Status");

                entity.Property(e => e.StoreroomSurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_SurfLSD");

                entity.Property(e => e.StoreroomSurfRange)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_SurfRange");

                entity.Property(e => e.StoreroomSurfSect)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_SurfSect");

                entity.Property(e => e.StoreroomSurfTownShip)
                    .HasMaxLength(50)
                    .HasColumnName("Storeroom_SurfTownShip");

                entity.Property(e => e.StoreroomWarrantyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Storeroom_WarrantyDate");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.Wo1)
                    .HasMaxLength(30)
                    .HasColumnName("wo1");

                entity.Property(e => e.Wo2)
                    .HasMaxLength(30)
                    .HasColumnName("wo2");

                entity.Property(e => e.Wo3)
                    .HasMaxLength(30)
                    .HasColumnName("wo3");

                entity.Property(e => e.Wo4)
                    .HasMaxLength(30)
                    .HasColumnName("wo4");

                entity.Property(e => e.Wo5)
                    .HasMaxLength(30)
                    .HasColumnName("wo5");

                entity.Property(e => e.Wo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo6");

                entity.Property(e => e.Wo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo7");

                entity.Property(e => e.Wo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo8");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<VWropenwocount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_wropenwocount");

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedBy).HasMaxLength(60);

                entity.Property(e => e.Counter).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Wocount).HasColumnName("wocount");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");

                entity.Property(e => e.Wrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WRNum");
            });

            modelBuilder.Entity<Vcontact>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_Vcontact_Counter")
                    .IsClustered(false);

                entity.ToTable("Vcontact");

                entity.HasIndex(e => new { e.LinkType, e.LinkId }, "IX_Vcontact_LinkId")
                    .IsClustered();

                entity.Property(e => e.Address1).HasMaxLength(225);

                entity.Property(e => e.Address2).HasMaxLength(225);

                entity.Property(e => e.Cel).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CtEmail).HasMaxLength(255);

                entity.Property(e => e.CtFax).HasMaxLength(30);

                entity.Property(e => e.CtName).HasMaxLength(60);

                entity.Property(e => e.CtPhone).HasMaxLength(30);

                entity.Property(e => e.CtTitle).HasMaxLength(60);

                entity.Property(e => e.Ctype)
                    .HasMaxLength(60)
                    .HasColumnName("CType");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Extension).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastContact).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasMaxLength(60);

                entity.Property(e => e.LinkType).HasMaxLength(10);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.Mail).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.MrMs).HasMaxLength(60);

                entity.Property(e => e.Name1).HasMaxLength(60);

                entity.Property(e => e.Name2).HasMaxLength(60);

                entity.Property(e => e.NextContact).HasColumnType("datetime");

                entity.Property(e => e.Owner).HasMaxLength(60);

                entity.Property(e => e.Region).HasMaxLength(60);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.Surname).HasMaxLength(60);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(60)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<Vcostrecovery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCOSTRECOVERY");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.ActualType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.Compdate)
                    .HasColumnType("datetime")
                    .HasColumnName("compdate");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.Draccount)
                    .HasMaxLength(60)
                    .HasColumnName("draccount");

                entity.Property(e => e.FullWoNum).HasMaxLength(63);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);
            });

            modelBuilder.Entity<Vcostrecoveryaccr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCOSTRECOVERYACCR");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FullWoNum).HasMaxLength(67);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.Wotype)
                    .HasMaxLength(60)
                    .HasColumnName("wotype");
            });

            modelBuilder.Entity<Vcostrecoverycombined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCOSTRECOVERYCOMBINED");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.Actual)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActualType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.Compdate)
                    .HasColumnType("datetime")
                    .HasColumnName("compdate");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.Draccount)
                    .HasMaxLength(60)
                    .HasColumnName("draccount");

                entity.Property(e => e.FullWoNum).HasMaxLength(63);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);
            });

            modelBuilder.Entity<Vcostrecoverydetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCOSTRECOVERYDETAIL");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.ActualType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.Compdate)
                    .HasColumnType("datetime")
                    .HasColumnName("compdate");

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.Draccount)
                    .HasMaxLength(60)
                    .HasColumnName("draccount");

                entity.Property(e => e.FullWoNum)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Request)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("request");

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);
            });

            modelBuilder.Entity<Vcostrecoverydetailaccr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCOSTRECOVERYDETAILACCR");

                entity.Property(e => e.AcctNum).HasMaxLength(6);

                entity.Property(e => e.Class).HasMaxLength(5);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(3);

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.FullWoNum)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Fund).HasMaxLength(5);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Program).HasMaxLength(5);

                entity.Property(e => e.Project).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.Wotype)
                    .HasMaxLength(60)
                    .HasColumnName("wotype");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK_Vendor_CompanyCode");

                entity.ToTable("Vendor");

                entity.HasIndex(e => e.ParentId, "IX_Vendor_ParentID");

                entity.Property(e => e.CompanyCode).HasMaxLength(60);

                entity.Property(e => e.AcctContact).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContractNum).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(60)
                    .HasColumnName("EmpID");

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Taxid1).HasMaxLength(60);

                entity.Property(e => e.Taxid2).HasMaxLength(60);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.VendCategory).HasMaxLength(60);

                entity.Property(e => e.VendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("VendCustID");

                entity.Property(e => e.VendName).HasMaxLength(255);

                entity.Property(e => e.VendTerms).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(30);

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VendorHistory>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK_VendorHistory_CompanyCode");

                entity.ToTable("VendorHistory");

                entity.Property(e => e.CompanyCode).HasMaxLength(60);

                entity.Property(e => e.AcctContact).HasMaxLength(60);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContractNum).HasMaxLength(60);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailNotify).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(60)
                    .HasColumnName("EmpID");

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(60)
                    .HasColumnName("ParentID");

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Taxid1).HasMaxLength(60);

                entity.Property(e => e.Taxid2).HasMaxLength(60);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.VendCategory).HasMaxLength(60);

                entity.Property(e => e.VendCustId)
                    .HasMaxLength(60)
                    .HasColumnName("VendCustID");

                entity.Property(e => e.VendName).HasMaxLength(255);

                entity.Property(e => e.VendTerms).HasMaxLength(60);

                entity.Property(e => e.VendorCurrency).HasMaxLength(30);

                entity.Property(e => e.Zip).HasMaxLength(20);
            });

            modelBuilder.Entity<VendorService>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_VendorService_ID")
                    .IsClustered(false);

                entity.ToTable("VendorService");

                entity.HasIndex(e => e.Vendor, "IX_VendorService_Vendor")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.QuotedPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ServiceCode).HasMaxLength(60);

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.VendorPartNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Vwohistory1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWOHISTORY");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WocloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOCloseDate");
            });

            modelBuilder.Entity<Vwohistoryaccr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWOHISTORYACCR");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.WocloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WOCloseDate");
            });

            modelBuilder.Entity<Wohistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("WOHistory");

                entity.HasIndex(e => e.WoNum, "IX_WOHistory_WoNum")
                    .IsClustered();

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Wolabour>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOLabour_Counter")
                    .IsClustered(false);

                entity.ToTable("WOLabour");

                entity.HasIndex(e => e.Empid, "IX_WOLabour_Empid");

                entity.HasIndex(e => e.Ordertype, "IX_WOLabour_Estimate");

                entity.HasIndex(e => e.Inactive, "IX_WOLabour_Inactive");

                entity.HasIndex(e => e.Ordertype, "IX_WOLabour_OrderType");

                entity.HasIndex(e => e.WoNum, "IX_WOLabour_WoNum")
                    .IsClustered();

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Empid).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Hours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LaborType).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype")
                    .HasDefaultValueSql("('workorder')");

                entity.Property(e => e.PostBy).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReadyToPost).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Scale)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ScheduledHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TaskNum).HasMaxLength(60);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.Worate)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("WORate");
            });

            modelBuilder.Entity<Womaterial>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOMaterial_Counter")
                    .IsClustered(false);

                entity.ToTable("WOMaterial");

                entity.HasIndex(e => e.OrderType, "IX_WOMaterial_Estimate");

                entity.HasIndex(e => e.OrderType, "IX_WOMaterial_OrderType");

                entity.HasIndex(e => e.WoNum, "IX_WOMaterial_WoNum")
                    .IsClustered();

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Craccount)
                    .HasMaxLength(60)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.EquipSerial).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('workorder')");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reserved).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Store).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasKey(e => e.WoNum)
                    .HasName("PK_WorkOrder_WoNum");

                entity.ToTable("WorkOrder");

                entity.HasIndex(e => e.Division, "IX_WorkOrder_Division");

                entity.HasIndex(e => e.Inactive, "IX_WorkOrder_Inactive");

                entity.Property(e => e.WoNum).HasMaxLength(60);

                entity.Property(e => e.ActHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ActTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AlertType).HasMaxLength(60);

                entity.Property(e => e.AssignedHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.CompCode).HasMaxLength(60);

                entity.Property(e => e.CompDate).HasColumnType("datetime");

                entity.Property(e => e.CompRemark).HasMaxLength(2000);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.Downtime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.Locked).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note10");

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.Note9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("note9");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentWo)
                    .HasMaxLength(60)
                    .HasColumnName("ParentWO");

                entity.Property(e => e.PdmNum).HasMaxLength(60);

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PmNum).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.RouteName).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.Wo1)
                    .HasMaxLength(30)
                    .HasColumnName("wo1");

                entity.Property(e => e.Wo2)
                    .HasMaxLength(30)
                    .HasColumnName("wo2");

                entity.Property(e => e.Wo3)
                    .HasMaxLength(30)
                    .HasColumnName("wo3");

                entity.Property(e => e.Wo4)
                    .HasMaxLength(30)
                    .HasColumnName("wo4");

                entity.Property(e => e.Wo5)
                    .HasMaxLength(30)
                    .HasColumnName("wo5");

                entity.Property(e => e.Wo6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo6");

                entity.Property(e => e.Wo7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo7");

                entity.Property(e => e.Wo8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("wo8");

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<WorkRequest>(entity =>
            {
                entity.HasKey(e => e.Wrnum)
                    .HasName("PK_WorkRequest_WoReqNum");

                entity.ToTable("WorkRequest");

                entity.Property(e => e.Wrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WRNum");

                entity.Property(e => e.AlarmIncluded).HasMaxLength(60);

                entity.Property(e => e.AlertType).HasMaxLength(60);

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.Chargeback).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ClientCode).HasMaxLength(60);

                entity.Property(e => e.Contact).HasMaxLength(60);

                entity.Property(e => e.ContactPhone).HasMaxLength(60);

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Craft).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Crew).HasMaxLength(60);

                entity.Property(e => e.Customer).HasMaxLength(60);

                entity.Property(e => e.Department).HasMaxLength(60);

                entity.Property(e => e.Dhlsd)
                    .HasMaxLength(50)
                    .HasColumnName("DHLSD");

                entity.Property(e => e.Dhrange)
                    .HasMaxLength(50)
                    .HasColumnName("DHRange");

                entity.Property(e => e.Dhsect)
                    .HasMaxLength(50)
                    .HasColumnName("DHSect");

                entity.Property(e => e.DhtownShip)
                    .HasMaxLength(50)
                    .HasColumnName("DHTownShip");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.Division).HasMaxLength(60);

                entity.Property(e => e.DownholeLsdlocation)
                    .HasMaxLength(60)
                    .HasColumnName("DownholeLSDLocation");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Duration).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ElectricPropaneMotor).HasMaxLength(60);

                entity.Property(e => e.EmailCc1)
                    .HasMaxLength(60)
                    .HasColumnName("EmailCC1");

                entity.Property(e => e.EmailCc2)
                    .HasMaxLength(60)
                    .HasColumnName("EmailCC2");

                entity.Property(e => e.EmailCc3)
                    .HasMaxLength(60)
                    .HasColumnName("EmailCC3");

                entity.Property(e => e.EmailCc4)
                    .HasMaxLength(60)
                    .HasColumnName("EmailCC4");

                entity.Property(e => e.EmailCc5)
                    .HasMaxLength(60)
                    .HasColumnName("EmailCC5");

                entity.Property(e => e.Employee).HasMaxLength(60);

                entity.Property(e => e.Eqaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress1");

                entity.Property(e => e.Eqaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("EQAddress2");

                entity.Property(e => e.Eqoperator)
                    .HasMaxLength(60)
                    .HasColumnName("EQOperator");

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.EquipmentManufacturer).HasMaxLength(60);

                entity.Property(e => e.EstCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstLabor).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMaterial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstMileage).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstService).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.EstTools).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FailureCode1).HasMaxLength(60);

                entity.Property(e => e.FailureCode2).HasMaxLength(60);

                entity.Property(e => e.FailureCode3).HasMaxLength(60);

                entity.Property(e => e.FieldArea).HasMaxLength(60);

                entity.Property(e => e.FifthRequester).HasMaxLength(60);

                entity.Property(e => e.FourthRequester).HasMaxLength(60);

                entity.Property(e => e.HistoryProblemDescription).HasMaxLength(200);

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsHazardIdrequired)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("IsHazardIDRequired");

                entity.Property(e => e.IsPumpJackWithVfdtimelock)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("IsPumpJackWithVFDTimelock");

                entity.Property(e => e.IsShutDown).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LeaseRoadCondition).HasMaxLength(60);

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.LossEstimate).HasMaxLength(60);

                entity.Property(e => e.MaintenanceIssue).HasMaxLength(200);

                entity.Property(e => e.Manager).HasMaxLength(60);

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotorVoltage).HasMaxLength(60);

                entity.Property(e => e.NewSheaveSizeRequest).HasMaxLength(60);

                entity.Property(e => e.NewSpmrequest)
                    .HasMaxLength(200)
                    .HasColumnName("NewSPMRequest");

                entity.Property(e => e.Note1).HasMaxLength(60);

                entity.Property(e => e.Note2).HasMaxLength(60);

                entity.Property(e => e.Note3).HasMaxLength(60);

                entity.Property(e => e.Note4).HasMaxLength(60);

                entity.Property(e => e.Note5).HasMaxLength(60);

                entity.Property(e => e.Note6).HasMaxLength(60);

                entity.Property(e => e.Note7).HasMaxLength(60);

                entity.Property(e => e.Note8).HasMaxLength(60);

                entity.Property(e => e.OilPerDay).HasMaxLength(60);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Pending).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Phase).HasMaxLength(60);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Priority).HasMaxLength(60);

                entity.Property(e => e.ProcNum).HasMaxLength(60);

                entity.Property(e => e.ProdEngineering).HasMaxLength(60);

                entity.Property(e => e.ProjectId).HasMaxLength(60);

                entity.Property(e => e.PumpJackCheck).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PumpJackFrequence).HasMaxLength(60);

                entity.Property(e => e.PumpJackInfo).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Request).HasMaxLength(2000);

                entity.Property(e => e.Requester).HasMaxLength(60);

                entity.Property(e => e.Room).HasMaxLength(60);

                entity.Property(e => e.SheaveSize).HasMaxLength(60);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.SurfLsd)
                    .HasMaxLength(50)
                    .HasColumnName("SurfLSD");

                entity.Property(e => e.SurfRange).HasMaxLength(50);

                entity.Property(e => e.SurfSect).HasMaxLength(50);

                entity.Property(e => e.SurfTownShip).HasMaxLength(50);

                entity.Property(e => e.SurfaceLsdlocation)
                    .HasMaxLength(60)
                    .HasColumnName("SurfaceLSDLocation");

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdRequester).HasMaxLength(60);

                entity.Property(e => e.UnitSize).HasMaxLength(60);

                entity.Property(e => e.WaterPerDay).HasMaxLength(60);

                entity.Property(e => e.WoType).HasMaxLength(60);

                entity.Property(e => e.WosubType)
                    .HasMaxLength(60)
                    .HasColumnName("WOSubType");
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.HasKey(e => e.Wotype);

                entity.ToTable("WorkType");

                entity.Property(e => e.Wotype)
                    .HasMaxLength(60)
                    .HasColumnName("WOType");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.System).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<Woservice>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOService_Counter")
                    .IsClustered(false);

                entity.ToTable("WOService");

                entity.HasIndex(e => e.Estimate, "IX_WOService_Estimate");

                entity.HasIndex(e => e.Ordertype, "IX_WOService_OrderType");

                entity.HasIndex(e => e.WoNum, "IX_WOService_WoNum")
                    .IsClustered();

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype")
                    .HasDefaultValueSql("('workorder')");

                entity.Property(e => e.Pocounter)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POCounter");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reserved).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ServiceCode).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Vendor).HasMaxLength(60);

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Wotask>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOTasks_Counter")
                    .IsClustered(false);

                entity.ToTable("WOTasks");

                entity.HasIndex(e => e.Estimate, "IX_WOTasks_Estimate");

                entity.HasIndex(e => e.Ordertype, "IX_WOTasks_OrderType");

                entity.HasIndex(e => e.WoNum, "IX_WOTasks_WoNum")
                    .IsClustered();

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(60)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(60)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype")
                    .HasDefaultValueSql("('workorder')");

                entity.Property(e => e.PublicNote).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TaskHours).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.WoNum).HasMaxLength(60);
            });

            modelBuilder.Entity<Wotool>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WOTools_Counter")
                    .IsClustered(false);

                entity.ToTable("WOTools");

                entity.HasIndex(e => e.Ordertype, "IX_WOTools_Estimate");

                entity.HasIndex(e => e.Wonum, "IX_WOTools_KeyNum")
                    .IsClustered();

                entity.HasIndex(e => e.Ordertype, "IX_WOTools_OrderType");

                entity.Property(e => e.Actual).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AddCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cbtax1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax1");

                entity.Property(e => e.Cbtax2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("CBTax2");

                entity.Property(e => e.ChargeBack).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ChargeBackAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CrAccount).HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.DrAccount).HasMaxLength(60);

                entity.Property(e => e.Equipment).HasMaxLength(60);

                entity.Property(e => e.EquipmentDesc).HasMaxLength(255);

                entity.Property(e => e.Estimate).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Extension).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Inactive).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemNum).HasMaxLength(60);

                entity.Property(e => e.MarkupAmount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(60)
                    .HasColumnName("ordertype")
                    .HasDefaultValueSql("('workorder')");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintPerson).HasMaxLength(60);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RefNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SerialNum).HasMaxLength(60);

                entity.Property(e => e.Store).HasMaxLength(60);

                entity.Property(e => e.TaskNum).HasMaxLength(30);

                entity.Property(e => e.Tax1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax1Account).HasMaxLength(60);

                entity.Property(e => e.Tax2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Tax2Account).HasMaxLength(60);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(60);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");
            });

            modelBuilder.Entity<Wrhistory>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WRHistory_Counter")
                    .IsClustered(false);

                entity.ToTable("WRHistory");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(14, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirtyLog).HasColumnType("numeric(14, 0)");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Status).HasMaxLength(60);

                entity.Property(e => e.StatusCode)
                    .HasColumnType("numeric(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Wrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WRNum");
            });

            modelBuilder.Entity<Wrworelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WRWORelation");

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedBy).HasMaxLength(60);

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(60);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dirtylog)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dirtylog");

                entity.Property(e => e.ModifyBy).HasMaxLength(60);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Wonum)
                    .HasMaxLength(60)
                    .HasColumnName("WONum");

                entity.Property(e => e.Wrnum)
                    .HasMaxLength(60)
                    .HasColumnName("WRNum");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
