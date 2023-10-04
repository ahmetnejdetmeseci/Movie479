using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class Db : DbContext
{

    public DbSet<Director> Directors {get; set;}

    public DbSet<Movie> Movies { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<Record> Records { get; set; }

    public DbSet<MovieGenre> MovieGenres { get; set; }

    public Db(DbContextOptions options) : base(options)
    {
        //constructor dependency injection
    }


    //because we have 2 primary keys we need to say
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        //we specify that the RECORD Table has 2 primary keys
        modelBuilder.Entity<Record>().HasKey(e => new {e.Id, e.GuId});
        
        //I do not want MovieGenre to have keys
        modelBuilder.Entity<MovieGenre>().HasNoKey();

    }

}
