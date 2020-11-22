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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
