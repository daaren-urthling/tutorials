using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Angular_NETCore_EFCore.Models
{
    public partial class DatiMagoContext : DbContext
    {
        public DatiMagoContext()
        {
        }

        public DatiMagoContext(DbContextOptions<DatiMagoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MaBillOfMaterials> MaBillOfMaterials { get; set; }
        public virtual DbSet<MaBillOfMaterialsComp> MaBillOfMaterialsComps { get; set; }
        public virtual DbSet<MaBillOfMaterialsRouting> MaBillOfMaterialsRoutings { get; set; }
        public virtual DbSet<MaItemsFiscalYearData> MaItemsFiscalYearData { get; set; }
        public virtual DbSet<MaOperation> MaOperations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=DatiMago;User Id=sa;Password=Microarea.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaBillOfMaterials>(entity =>
            {
                entity.HasKey(e => e.Bom)
                    .HasName("PK_BillOfMaterials")
                    .IsClustered(false);

                entity.ToTable("MA_BillOfMaterials");

                entity.HasIndex(e => new { e.Bom, e.Sf }, "MA_BillOfMaterials2");

                entity.HasIndex(e => e.Description, "MA_BillOfMaterials4");

                entity.Property(e => e.Bom)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("BOM");

                entity.Property(e => e.CodeType).HasDefaultValueSql("((7798784))");

                entity.Property(e => e.Configurable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.InProduction)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.LastModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.LastSubId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesDocOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Sf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SF")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Tbcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("TBCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbcreatedId).HasColumnName("TBCreatedID");

                entity.Property(e => e.Tbguid)
                    .HasColumnName("TBGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tbmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("TBModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbmodifiedId).HasColumnName("TBModifiedID");

                entity.Property(e => e.UoM)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsePercQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MaBillOfMaterialsComp>(entity =>
            {
                entity.HasKey(e => new { e.Bom, e.Line })
                    .HasName("PK_BillOfMaterialsComp")
                    .IsClustered(false);

                entity.ToTable("MA_BillOfMaterialsComp");

                entity.HasIndex(e => new { e.Bom, e.Component, e.ComponentType }, "MA_BillOfMaterialsComp2");

                entity.HasIndex(e => new { e.Bom, e.SubId }, "MA_BillOfMaterialsComp3");

                entity.HasIndex(e => e.Bom, "MA_BillOfMaterialsComp4");

                entity.Property(e => e.Bom)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("BOM");

                entity.Property(e => e.Component)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComponentType).HasDefaultValueSql("((7798784))");

                entity.Property(e => e.Configurable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DnrtgStep)
                    .HasColumnName("DNRtgStep")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Drawing)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndUseRtgStep).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExternalLineReference).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedComponent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.FixedQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.IsKanban)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NotPostable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Notes)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperationSubId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PercQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickingSpecificator)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickingSpecificatorType).HasDefaultValueSql("((6750211))");

                entity.Property(e => e.PickingStorage)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuestionNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScrapPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrapQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrapUm)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ScrapUM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SetFixedQtyOnMo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SetFixedQtyOnMO")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.StructureCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tbcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("TBCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbcreatedId).HasColumnName("TBCreatedID");

                entity.Property(e => e.Tbmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("TBModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbmodifiedId).HasColumnName("TBModifiedID");

                entity.Property(e => e.TechnicalData)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToExplode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true);

                entity.Property(e => e.UoM)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidityEndingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.ValidityStartingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.Valorize)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true);

                entity.Property(e => e.Variant)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Waste)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WastePerc).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BomNavigation)
                    .WithMany(p => p.MaBillOfMaterialsComps)
                    .HasForeignKey(d => d.Bom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMate_BillOfMate_00");
            });

            modelBuilder.Entity<MaBillOfMaterialsRouting>(entity =>
            {
                entity.HasKey(e => new { e.Bom, e.RtgStep, e.Alternate, e.AltRtgStep })
                    .HasName("PK_BillOfMaterialsRouting")
                    .IsClustered(false);

                entity.ToTable("MA_BillOfMaterialsRouting");

                entity.Property(e => e.Bom)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("BOM");

                entity.Property(e => e.Alternate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IsWc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IsWC")
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true);

                entity.Property(e => e.LineTypeInDn)
                    .HasColumnName("LineTypeInDN")
                    .HasDefaultValueSql("((24576000))");

                entity.Property(e => e.NoOfProcessingWorkers).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfSetupWorkers).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Operation)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessingAttendancePerc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessingWorkingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.QueueTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupAttendancePerc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupWorkingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tbcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("TBCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbcreatedId).HasColumnName("TBCreatedID");

                entity.Property(e => e.Tbmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("TBModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbmodifiedId).HasColumnName("TBModifiedID");

                entity.Property(e => e.TotalTime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Wc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("WC")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BomNavigation)
                    .WithMany(p => p.MaBillOfMaterialsRoutings)
                    .HasForeignKey(d => d.Bom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMate_BillOfMate_01");
            });

            modelBuilder.Entity<MaItemsFiscalYearData>(entity =>
            {
                entity.HasKey(e => new { e.FiscalYear, e.Item })
                    .HasName("PK_ItemsFiscalYearData")
                    .IsClustered(false);

                entity.ToTable("MA_ItemsFiscalYearData");

                entity.HasIndex(e => e.ValuationType, "IX_MA_ItemsFiscalYearData");

                entity.Property(e => e.Item)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluateByLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.InventoryValuationCriteria).HasDefaultValueSql("((4259840))");

                entity.Property(e => e.LastLotNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoAbcvaluation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NoABCValuation")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.StandardCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tbcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("TBCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbcreatedId).HasColumnName("TBCreatedID");

                entity.Property(e => e.Tbmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("TBModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbmodifiedId).HasColumnName("TBModifiedID");

                entity.Property(e => e.ValuationType).HasDefaultValueSql("((11272194))");
            });

            modelBuilder.Entity<MaOperation>(entity =>
            {
                entity.HasKey(e => e.Operation)
                    .HasName("PK_Operations")
                    .IsClustered(false);

                entity.ToTable("MA_Operations");

                entity.Property(e => e.Operation)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostsOnQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.Description)
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HourlyCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IsWC")
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true);

                entity.Property(e => e.Item)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('17991231')");

                entity.Property(e => e.NoOfProcessingWorkers).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfSetupWorkers).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperationDescriptionFile)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessingAttendancePerc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessingTeam)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessingWorkingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.QueueTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupAttendancePerc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupTeam)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SetupTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetupWorkingTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tbcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("TBCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbcreatedId).HasColumnName("TBCreatedID");

                entity.Property(e => e.Tbguid)
                    .HasColumnName("TBGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tbmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("TBModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TbmodifiedId).HasColumnName("TBModifiedID");

                entity.Property(e => e.TotalTime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Wc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("WC")
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
