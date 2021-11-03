using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRIS.Models
{
    public class SrisContext : DbContext
    {
        public SrisContext()
         : base("SrisContext")
        {
            Database.SetInitializer<SrisContext>(new SrisDbInitializer());

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SrisContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<OfficeDeparment> OfficeDeparments { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<TechnicianService> TechnicianServices { get; set; }
        public DbSet<InspectionInfo> InspectionInfos { get; set; }
        public DbSet<FindingParticular> FindingParticulars { get; set; }
        public DbSet<ProcedureTest> ProcedureTests { get; set; }
        public DbSet<UnitSpecification> UnitSpecifications { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Inspected> Inspecteds { get; set; }
        public DbSet<ItemReplacement> ItemReplacements { get; set; }
        public DbSet<Item> Items { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                        .HasKey(k => k.User_id)
                        .Property(p => p.User_id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ServiceRequest>()
                        .HasKey(k => k.Sr_id)
                        .Property(p => p.Sr_id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<OfficeDeparment>()
                        .HasKey(k => k.Od_id)
                        .Property(p => p.Od_id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Technician>()
                        .HasKey(k => k.Tech_id)
                        .Property(p => p.Tech_id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TechnicianService>()
                       .HasKey(k => k.Ts_id)
                       .Property(p => p.Ts_id)
                       .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ItemReplacement>()
                       .HasKey(k => k.Ir_id)
                       .Property(p => p.Ir_id)
                       .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Item>()
                       .HasKey(k => k.I_id)
                       .Property(p => p.I_id)
                       .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



            // 1 ServiceInfo to many TechnicianServices
            modelBuilder.Entity<TechnicianService>()
                        .HasOptional<ServiceRequest>(k => k.ServiceRequest)
                        .WithMany(p => p.TechnicianService)
                        .HasForeignKey<int?>(k => k.Sr_id);

            modelBuilder.Entity<TechnicianService>()
                        .HasOptional<ItemReplacement>(k => k.ItemReplacement)
                        .WithMany(p => p.TechnicianService)
                        .HasForeignKey<int?>(k => k.Ir_id);

            // 1 Technician to many TechnicianServices
            modelBuilder.Entity<TechnicianService>()
                        .HasRequired<Technician>(k => k.Technician)
                        .WithMany(p => p.TechnicianService)
                        .HasForeignKey<int>(k => k.Tech_id);



            //inspection db

            modelBuilder.Entity<InspectionInfo>()
                     .HasKey(k => k.Ii_id)
                     .Property(p => p.Ii_id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<FindingParticular>()
                      .HasKey(k => k.Fp_id)
                      .Property(p => p.Fp_id)
                      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ProcedureTest>()
                      .HasKey(k => k.Pt_id)
                      .Property(p => p.Pt_id)
                      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UnitSpecification>()
                      .HasKey(k => k.Us_id)
                      .Property(p => p.Us_id)
                      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Recommendation>()
           .HasKey(k => k.R_id)
           .Property(p => p.R_id)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Inspected>()
                      .HasKey(k => k.I_id)
                      .Property(p => p.I_id)
                      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            //1 inspection report to many Finding particulars
            modelBuilder.Entity<FindingParticular>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.FindingParticular)
         .HasForeignKey<int?>(k => k.II_ID);

            //1 inspection report to many ProcedureTest
            modelBuilder.Entity<ProcedureTest>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.ProcedureTest)
         .HasForeignKey<int?>(k => k.II_ID);

            //1 inspection report to many UnitSpecification
            modelBuilder.Entity<UnitSpecification>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.UnitSpecification)
         .HasForeignKey<int?>(k => k.II_ID);

            //1 inspection report to many Recommendations
            modelBuilder.Entity<Recommendation>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.Recommendation)
         .HasForeignKey<int?>(k => k.II_ID);

            //1 inspection report to many Inspected
            modelBuilder.Entity<Inspected>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.Inspected)
         .HasForeignKey<int?>(k => k.II_ID);

            //1 itemReplacement report to many Item
            modelBuilder.Entity<Item>()
         .HasOptional<ItemReplacement>(k => k.ItemReplacement)
         .WithMany(p => p.Item)
         .HasForeignKey<int?>(k => k.Ir_id);
        }
    }
}
