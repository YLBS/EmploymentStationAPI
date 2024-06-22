using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Base
{
    public class BaseDbContext: DbContext
    {

        public BaseDbContext()
        {

        }
        public BaseDbContext(DbContextOptions<BaseDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Entity.Base.MemPosition> MemPositions { get; set; } = null!;
        public virtual DbSet<MemInfo> MemInfos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity.Base.MemPosition>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("Mem_Position");

                entity.Property(e => e.PosId)
                    .ValueGeneratedNever()
                    .HasColumnName("PosID");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.BeginHiresDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExamAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamNotice)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Geyn).HasColumnName("GEYN");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(1800)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TagLib)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Welfa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });
            modelBuilder.Entity<Entity.Base.MemInfo>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Info");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AddressT)
                    .HasColumnName("Address_T")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyIntroduction)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FoundDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenceNumber)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoUpdatedate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldContactTel)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qqflag).HasColumnName("QQFlag");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });
        }
    }
}
