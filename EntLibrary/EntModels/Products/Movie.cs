using EntLibrary.EntModels.Companies;
using EntLibrary.EntModels.GenresModel;
using EntLibrary.EntModels.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntLibrary.EntModels.Products
{
    public class Movie:Product
    {
        public List<Director>? Directors { get; set; }
        public List<Producer>? Producers { get; set; }
        public List<Actor>? Actors { get; set; }
        public List<Production>? Productions { get; set; }
        public List<Distributer>? Distributors { get; set; }
        public List<Movie_Series_Anime_Genre>? Genres { get; set; }
        public int? RunnigTime { get; set; }

   
    }
}
