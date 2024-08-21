using EntLibrary.EntModels.Companies;
using EntLibrary.EntModels.GenresModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntLibrary.EntModels.Products
{
    public class Game : Product
    {
        public int? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }

        public int? DeveloperId { get; set; }
        public Developer? Developer { get; set; }

        public List<GameGenre> Genres { get; set; }

    }
}
