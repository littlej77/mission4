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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryType = "Romance/Fantasy" },
                new Category { CategoryID = 2, CategoryType = "Comedy/Adventure" },
                new Category { CategoryID = 3, CategoryType = "Rom-com" },
                new Category { CategoryID = 4, CategoryType = "Horror" },
                new Category { CategoryID = 5, CategoryType = "Action" },
                new Category { CategoryID = 6, CategoryType = "Mystery" },
                new Category { CategoryID = 7, CategoryType = "Drama" }
            );




            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId=1,
                    CategoryID =1,
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
                    CategoryID = 2,
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
                    CategoryID = 3,
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
