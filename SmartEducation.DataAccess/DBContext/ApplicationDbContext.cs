using Microsoft.EntityFrameworkCore;
using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Country { get; set; }

        #region ViewModel_Data_Retrive
        //public DbSet<VmStudent> VmStudent { get; set; } = null;
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Parent>().HasKey(t => t.Id);
            //modelBuilder.Entity<Parent>().HasMany(t => t.Student).WithOne(t => t.Parent);

            //modelBuilder.Entity<Country>().HasKey(t => t.Id);
            //modelBuilder.Entity<Country>().HasMany(t => t.Student).WithOne(t => t.Country);

            //modelBuilder.Entity<Student>().HasKey(t => t.Id);

            //modelBuilder.Entity<VmStudent>().HasNoKey().ToView("view_name_that_doesnt_exist");
            //modelBuilder.Entity<VmStudent>().HasNoKey();

            #region SEED_DATA
            //modelBuilder.Entity<Student>().HasData(new List<Student>
            //{
            //    new Student // 1
            //    {
            //        Name = "Rahim"
            //    },
            //    new Student // 2
            //    {
            //        Name = "Karim",
            //    },
            //    new Student // 3
            //    {
            //        Name = "Jamal",
            //    }
            //});
            #endregion


            //modelBuilder.Entity<VmStudent>(builder =>
            //{
            //    builder.HasNoKey();
            //});



        }
    }
}
