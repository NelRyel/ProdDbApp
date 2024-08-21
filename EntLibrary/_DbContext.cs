using EntLibrary.EntModels.GenresModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntLibrary
{
    public class _DbContext: DbContext {

        public DbSet<GeneralGenre> Genres { get; set; } = null!;
        public DbSet<GameGenre> GamesGenres { get; set; } = null!;
        public DbSet<Movie_Series_Anime_Genre> MoviesGenres { get; set; } = null!;

        public _DbContext() {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=wpfappdb.db");
        }





    }
}
