using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Models
{
    public class MovieContext : DbContext 
    {
        //a constructor, when you are calling this constructor I have to recieve from you a DbContextOptions type that is MovieContext. "options" is the variable name its recieving
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId=1,
                    Category="Romance/Fantasy",
                    Title="About Time",
                    Year= 2013,
                    Director="Richard Curtis",
                    Rating="R",
                    Edited=true,
                    Notes="Live your life"
                },
                new MovieResponse
                {
                    MovieId=2,
                    Category = "Adventure",
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = true,
                    Notes = "Start Living"
                },
                new MovieResponse
                {
                    MovieId=3,
                    Category = "Comedy/Romance",
                    Title = "Love, Rosie",
                    Year = 2014,
                    Director = "Christian Ditter",
                    Rating = "R",
                    Edited = false,
                    Notes = "Fight for Love"
                }
            );
        }
    }
}
