using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class TrackContext : DbContext
    {
        public TrackContext()
            : base("name=TrackContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Track> Authors { get; set; }
        //public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<Tag> Tags { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TrackConfiguration());
        }*/
    }
}
