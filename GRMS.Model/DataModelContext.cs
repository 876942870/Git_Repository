using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMS.Model
{
    public class DataModelContext:DbContext
    {
        public DataModelContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataModelContext>(null);
            //modelBuilder.Entity<Base_Article>()
            //    .Property(e => e.UrlTitle)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Base_Article>()
            //    .HasMany(e => e.Exts)
            //    .WithRequired(e => e.Article)
            //    .HasForeignKey(e => e.ArticleId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Base_Catalog>()
            //    .Property(e => e.Language)
            //    .IsUnicode(false);
            base.OnModelCreating(modelBuilder);
        }
    }
}
