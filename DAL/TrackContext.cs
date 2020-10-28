using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL.EntityConfiguration;



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
        public virtual DbSet<User> Courses { get; set; }
        public virtual DbSet<PartsOfTrack> Tags { get; set; }

      //  protected override void OnModelCreating(DbModelBuilder modelBuilder)
       // {
          //  modelBuilder.Configurations.Add(new TrackConfiguration());
       // }
    }
}
