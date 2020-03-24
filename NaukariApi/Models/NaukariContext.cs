using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Naukari.Models
{
    public partial class NaukariContext : DbContext
    {
        public NaukariContext()
        {
        }

        public NaukariContext(DbContextOptions<NaukariContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Educations> Educations { get; set; }
        public virtual DbSet<Employments> Employments { get; set; }
        public virtual DbSet<OtherEducations> OtherEducations { get; set; }
        public virtual DbSet<OtherEmployments> OtherEmployments { get; set; }
        public virtual DbSet<UserObject> UserObject { get; set; }
        public virtual DbSet<UserObjectType> UserObjectType { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Naukari;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Educations>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("educations");

                entity.Property(e => e.EducationId).HasColumnName("educationId");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasColumnName("course")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseType)
                    .IsRequired()
                    .HasColumnName("courseType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HighestQualification)
                    .IsRequired()
                    .HasColumnName("highestQualification")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassingYear)
                    .IsRequired()
                    .HasColumnName("passingYear")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skill)
                    .IsRequired()
                    .HasColumnName("skill")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .IsRequired()
                    .HasColumnName("specialization")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasColumnName("university")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Educations)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_educations_users");
            });

            modelBuilder.Entity<Employments>(entity =>
            {
                entity.HasKey(e => e.EmploymentId);

                entity.ToTable("employments");

                entity.Property(e => e.EmploymentId).HasColumnName("employmentId");

                entity.Property(e => e.AnnualSalary)
                    .IsRequired()
                    .HasColumnName("annualSalary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("cityName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contry)
                    .HasColumnName("contry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCompany)
                    .IsRequired()
                    .HasColumnName("currentCompany")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDesignation)
                    .IsRequired()
                    .HasColumnName("currentDesignation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentLocation)
                    .IsRequired()
                    .HasColumnName("currentLocation")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalArea)
                    .HasColumnName("functionalArea")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoticePeriod)
                    .HasColumnName("noticePeriod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skill)
                    .IsRequired()
                    .HasColumnName("skill")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WorkEnd)
                    .HasColumnName("workEnd")
                    .HasColumnType("date");

                entity.Property(e => e.WorkStart)
                    .HasColumnName("workStart")
                    .HasColumnType("date");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Employments)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_employments_users");
            });

            modelBuilder.Entity<OtherEducations>(entity =>
            {
                entity.HasKey(e => e.OtherEducationId);

                entity.ToTable("otherEducations");

                entity.Property(e => e.OtherEducationId).HasColumnName("otherEducationId");

                entity.Property(e => e.Course)
                    .HasColumnName("course")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationId).HasColumnName("educationId");

                entity.Property(e => e.PassingYear)
                    .HasColumnName("passingYear")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasColumnName("qualification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .HasColumnName("specialization")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasColumnName("university")
                    .HasMaxLength(10);

                //entity.HasOne(d => d.Education)
                //    .WithMany(p => p.OtherEducations)
                //    .HasForeignKey(d => d.EducationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_otherEducations_educations");
            });

            modelBuilder.Entity<OtherEmployments>(entity =>
            {
                entity.HasKey(e => e.OtherEmploymentId);

                entity.ToTable("otherEmployments");

                entity.Property(e => e.OtherEmploymentId).HasColumnName("otherEmploymentId");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentId).HasColumnName("employmentId");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("date");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("date");

                //entity.HasOne(d => d.Employment)
                //    .WithMany(p => p.OtherEmployments)
                //    .HasForeignKey(d => d.EmploymentId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_otherEmployments_employments");
            });

            modelBuilder.Entity<UserObject>(entity =>
            {
                entity.ToTable("userObject");

                entity.Property(e => e.UserObjectId).HasColumnName("userObjectId");

                entity.Property(e => e.UserObjectName)
                    .IsRequired()
                    .HasColumnName("userObjectName")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserObjectTypeId).HasColumnName("userObjectTypeId");

                entity.HasOne(d => d.UserObjectType)
                    .WithMany(p => p.UserObject)
                    .HasForeignKey(d => d.UserObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userObject_userObjectType");
            });

            modelBuilder.Entity<UserObjectType>(entity =>
            {
                entity.ToTable("userObjectType");

                entity.Property(e => e.UserObjectTypeId).HasColumnName("userObjectTypeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserObjectType)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userObjectType_users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasColumnName("cityName")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentLocation)
                    .IsRequired()
                    .HasColumnName("currentLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("emailId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasColumnName("mobileNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);
                    
                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resume)
                    .HasColumnName("resume")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
