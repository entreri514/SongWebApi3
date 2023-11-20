using Microsoft.EntityFrameworkCore;
using SongWebApi.Models;

namespace SongWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
     //   {
     //       base.OnModelCreating(modelBuilder);

     //       Microsoft.EntityFrameworkCore.Metadata.Builders.DataBuilder<Song> dataBuilder = modelBuilder.Entity<Song>().HasData(
     //           new Song
     //           {
                    
     //               Title = "Enter Sandman",
     //               Artist = "Metallica",
     //               Album = "Black Album",
     //               ReleaseDate = new DateTime (1991, 8, 12),
     //               Genre = "Rock"
     //           },

     //           new Song
     //           {
                    
     //               Title = "Sad But True",
     //               Artist = "Metallica",
     //               Album = "Black Album",
     //               ReleaseDate = new DateTime(1991, 8, 12),
     //               Genre = "rock"
     //           },
     //           new Song
     //           {
                    
     //               Title="Holier Than Thou",
     //               Artist="Metallica",
     //               Album="Black Album",
     //               ReleaseDate=new DateTime(1991,8,12),
     //               Genre="Rock"

     //           },
     //           new Song
     //           {
     //               Title="The Unforgiven",
     //               Artist="Metallica",
     //               Album="Black Album",
     //               ReleaseDate=new DateTime(1991,8,12),
     //               Genre="Rock"

     //           },
     //           new Song
     //           {
     //               Title="Wherever I May Roam",
     //               Artist="Metallica",
     //               Album="Black Album",
     //               ReleaseDate=new DateTime(1991,8,12),
     //               Genre="Rock"

     //           },
     //           new Song
     //           {
     //               Title="Don't Tread On Me",
     //               Artist="Metallica",
     //               Album="Black Album",
     //               ReleaseDate=new DateTime(1991,8,12),
     //               Genre="Rock"
     //           });

 //       }


    }
}
