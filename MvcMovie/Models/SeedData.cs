using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
   public static class SeedData
   {
      public static void Initialize(IServiceProvider serviceProvider)
      {
         using (var context = new MvcMovieContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<MvcMovieContext>>()))
         {
            // Look for any movies.
            if (context.Movie.Any())
            {
               return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                   Title = "The Other Side of Heaven",
                   ReleaseDate = DateTime.Parse("2001-12-14"),
                   Genre = "Adventure",
                   Rating = "PG",
                   Price = 7.99M,
                   ImagePath = "/images/heavenpic.jpg"
                },
                new Movie
                {
                   Title = "God's Army",
                   ReleaseDate = DateTime.Parse("2000-03-10"),
                   Genre = "Drama",
                   Rating = "PG",
                   Price = 8.99M,
                   ImagePath = ""
                },

                new Movie
                {
                   Title = "The Best Two Years",
                   ReleaseDate = DateTime.Parse("2004-02-20"),
                   Genre = "Comedy-Drama",
                   Rating = "PG",
                   Price = 9.99M
                },

                new Movie
                {
                   Title = "The R.M.",
                   ReleaseDate = DateTime.Parse("2003-01-31"),
                   Genre = "Religious Comedy",
                   Rating = "PG",
                   Price = 3.99M
                }
            );
            context.SaveChanges();
         }
      }
   }
}